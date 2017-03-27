using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;

namespace TSJS {
  public partial class Main : Form {

    // Unencrypted plain text of the save game.
    private string contents;

    // Use Dictionary data structure because they are built once per save game and then searched a lot.
    private Dictionary<string, Job> offeredJobs = new Dictionary<string, Job>();
    private Dictionary<string, Company> companies = new Dictionary<string, Company>();
    private Dictionary<string, string> offers = new Dictionary<string, string>();
    private Dictionary<string, Job> completedJobs = new Dictionary<string, Job>();
    private Dictionary<string, bool> visitedCities = new Dictionary<string, bool>();
    
    // Can choose between different distance units.
    private const int KILOMETRES = 0;
    private const int MILES = 1;

    /// <summary>
    /// Get the string between two substrings exclusively.
    /// </summary>
    /// <param name="str"></param>
    /// <param name="strStart"></param>
    /// <param name="strStop"></param>
    /// <returns></returns>
    public static string BetweenExclusive(string str, string strStart, string strStop) {
      int start = str.IndexOf(strStart) + strStart.Length;
      int stop = str.IndexOf(strStop, start);
      return str.Substring(start, stop - start);
    }

    /// <summary>
    /// Add a job to a grid to be displayed.
    /// </summary>
    /// <param name="dataGridView"></param>
    /// <param name="job"></param>
    private void AddJobRow(DataGridView dataGridView, Job job) {
      int distance = job.distanceKilometres;
      if (Properties.Settings.Default.DistanceUnit == MILES) {
        distance = job.distanceMiles;
      }
      dataGridView.Rows.Add(job.id, job.sourceCity, job.sourceCompany, job.destinationCity, job.destinationCompany, job.cargo, distance, job.profit);
    }

    /// <summary>
    /// Change the distance metric displayed in a grid.
    /// </summary>
    /// <param name="jobs"></param>
    /// <param name="dataGridView"></param>
    private void ChangeMetric(Dictionary<string, Job> jobs, DataGridView dataGridView) {
      string nameDistance = dataGridView.Name + "Distance";
      string nameId = dataGridView.Name + "Id";
      for (int i = 0; i < dataGridView.Rows.Count; i++) {
        DataGridViewCellCollection cells = dataGridView.Rows[i].Cells;
        if (Properties.Settings.Default.DistanceUnit == KILOMETRES) {
          cells[nameDistance].Value = jobs[cells[nameId].Value.ToString()].distanceKilometres;
        } else if (Properties.Settings.Default.DistanceUnit == MILES) {
          cells[nameDistance].Value = jobs[cells[nameId].Value.ToString()].distanceMiles;
        }
      }
    }

    /// <summary>
    /// Search all the jobs and make sure to maintain any sorting applied.
    /// </summary>
    /// <param name="query">Supports keywords separated by spaces.</param>
    private void Search(Dictionary<string, Job> jobs, DataGridView dataGridView, Dictionary<string, bool> visited, string query) {

      // Remember current sorting.
      DataGridViewColumn column = dataGridView.SortedColumn;
      ListSortDirection direction;
      if (dataGridView.SortOrder == SortOrder.Ascending) {
        direction = ListSortDirection.Ascending;
      } else {
        direction = ListSortDirection.Descending;
      }

      // Clear.
      dataGridView.Rows.Clear();
      List<string> found = new List<string>();
      int count = 0;

      // Search keywords.
      string[] keywords = query.Split(' ');
      foreach (Job job in jobs.Values) {
        foreach (string keyword in keywords) {
          if ((job.ToString().Contains(keyword) || keyword.Length == 0 && !found.Contains(job.id)) && (visited.Count == 0 || visited.ContainsKey(job.sourceCity))) {
            AddJobRow(dataGridView, job);
            found.Add(job.id);
            count++;
          }
        }
      }

      // Apply sorting again.
      if (column != null) {
        dataGridView.Sort(column, direction);
      }

      // Show a count of all the jobs found.
      if ((tabControl.SelectedIndex == 0 && dataGridView == dataGridViewOfferedJobs) || (tabControl.SelectedIndex == 1 && dataGridView == dataGridViewCompletedJobs)) {
        labelCountValue.Text = count.ToString();
      }
    }

    /// <summary>
    /// Perform a user inputted search across all grids. 
    /// </summary>
    public void ApplySearch() {
      Cursor.Current = Cursors.WaitCursor;
      Dictionary<string, bool> visited = new Dictionary<string, bool>();
      if (!Properties.Settings.Default.UnvisitedCities) {
        visited = visitedCities;
      }
      Search(offeredJobs, dataGridViewOfferedJobs, visited, textBoxSearch.Text);
      Search(completedJobs, dataGridViewCompletedJobs, visited, textBoxSearch.Text);
      Cursor.Current = Cursors.Default;
    }

    public Main() {
      InitializeComponent();
    }

    private void buttonOpen_Click(object sender, EventArgs e) {
      if (openFileDialog.ShowDialog() != DialogResult.OK) {
        return;
      }
      Cursor.Current = Cursors.WaitCursor;

      contents = File.ReadAllText(openFileDialog.FileName);
      if (contents.Substring(0, 4) == "ScsC") {         // Encrypted.
        string tempFile = Path.GetTempFileName();
        Process process = new Process();
        process.StartInfo = new ProcessStartInfo(Properties.Settings.Default.Decrypter, openFileDialog.FileName + " " + tempFile);
        process.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
        process.Start();
        process.WaitForExit();
        contents = File.ReadAllText(tempFile);
        File.Delete(tempFile);
      } else if (contents.Substring(0, 4) != "SiiN") {  // Decrypted.
        Cursor.Current = Cursors.Default;
        MessageBox.Show("Cannot open file, make sure this file was created with the game config.cfg file using:\r\nuset g_save_format \"2\"", "Cannot Open File", MessageBoxButtons.OK, MessageBoxIcon.Error);
        return;
      }

      Text = "TSJS - Truck Simulator Job Searcher - " + openFileDialog.FileName;

      // Clear previous file (if any).
      int offset = 0;
      dataGridViewOfferedJobs.Rows.Clear();
      dataGridViewCompletedJobs.Rows.Clear();
      offeredJobs.Clear();
      completedJobs.Clear();
      companies.Clear();
      visitedCities.Clear();
      offers.Clear();

      try {

        // Get all of the companies.
        while (true) {
          string companyStart = "company : ";
          string companyStop = "}";
          int start = this.contents.IndexOf(companyStart, offset);
          if (start == -1) {
            break;  // No more companies.
          }
          int stop = this.contents.IndexOf(companyStop, start) + companyStop.Length;
          Company company = new Company(this.contents.Substring(start, stop - start));
          companies.Add(company.id, company);

          // Storing all of the offers and their corresponding source company once, saves from searching through all companies to find the offers each time.
          foreach (string offer in company.offers) {
            offers.Add(offer, company.id);
          }
          offset = stop;
        }

        // Get all of the job offers.
        offset = 0;
        while (true) {
          string offerStart = "job_offer_data : ";
          string offerStop = "}";
          int start = this.contents.IndexOf(offerStart, offset);
          if (start == -1) {
            break;  // No more job offers.
          }
          int stop = this.contents.IndexOf(offerStop, start) + offerStop.Length;
          Job job = new Job(this.contents.Substring(start, stop - start));
          job.AddSource(offers[job.id]);
          if (job.IsValid()) {
            AddJobRow(dataGridViewOfferedJobs, job);
            offeredJobs.Add(job.id, job);
          }
          offset = stop;
        }

        // Get all of the completed jobs.
        offset = 0;
        while (true) {
          string offerStart = "delivery_log_entry : ";
          string offerStop = "}";
          int start = this.contents.IndexOf(offerStart, offset);
          if (start == -1) {
            break;  // No more job offers.
          }
          int stop = this.contents.IndexOf(offerStop, start) + offerStop.Length;
          Job job = new Job(this.contents.Substring(start, stop - start));
          if (job.IsValid()) {
            AddJobRow(dataGridViewCompletedJobs, job);
            completedJobs.Add(job.id, job);
          }
          offset = stop;
        }

        // Get all of the visited cities.
        int vistedCitiesCount = int.Parse(BetweenExclusive(this.contents, "visited_cities: ", "\r\n"));
        for (int i = 0; i < vistedCitiesCount; i++) {
          visitedCities.Add(BetweenExclusive(this.contents, "visited_cities[" + i + "]: ", "\r\n"), true);
        }

        // Apply search.
        ApplySearch();
      } catch (Exception exception) {
        MessageBox.Show("Unable to read this file, the following exception occurred:\r\n" + exception.ToString(), "Error Reading File", MessageBoxButtons.OK, MessageBoxIcon.Error);
      }
      textBoxSearch.Focus();
      Cursor.Current = Cursors.Default;
    }

    private void tabControl_SelectedIndexChanged(object sender, EventArgs e) {
      if (tabControl.SelectedIndex == 0) {
        labelCountValue.Text = dataGridViewOfferedJobs.Rows.Count.ToString();
      } else if (tabControl.SelectedIndex == 1) {
        labelCountValue.Text = dataGridViewCompletedJobs.Rows.Count.ToString();
      }
    }

    private void textBoxSearch_TextChanged(object sender, EventArgs e) {
      ApplySearch();
    }

    private void linkLabelGitHub_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
      Process.Start("https://github.com/Technicism/TSJS"); // Open up URL in default web browser.
    }

    private void buttonSetup_Click(object sender, EventArgs e) {
      Setup setup = new Setup();
      setup.ShowDialog();
      ApplySearch();
    }
  }
}
