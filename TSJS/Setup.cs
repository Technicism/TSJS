using System;
using System.Configuration;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;

namespace TSJS {
  public partial class Setup : Form {

    public Setup() {
      InitializeComponent();
      textBoxDecrypter.Text = Properties.Settings.Default.Decrypter;
      textBoxExtractor.Text = Properties.Settings.Default.Extractor;
      textBoxPathETS2.Text = Properties.Settings.Default.PathETS2;
      textBoxPathATS.Text = Properties.Settings.Default.PathATS;
      comboBoxDistanceUnit.SelectedIndex = Properties.Settings.Default.DistanceUnit;
      comboBoxCurrencyATS.SelectedIndex = Properties.Settings.Default.CurrencyATS;
      comboBoxCurrencyETS2.SelectedIndex = Properties.Settings.Default.CurrencyETS2;
      checkBoxUnvisited.Checked = Properties.Settings.Default.UnvisitedCities;
    }

    private void buttonSelectDecrypter_Click(object sender, EventArgs e) {
      if (openFileDialog.ShowDialog() == DialogResult.OK) {
        textBoxDecrypter.Text = openFileDialog.FileName;
      }
    }

    private void buttonSelectExtractor_Click(object sender, EventArgs e) {
      if (openFileDialog.ShowDialog() == DialogResult.OK) {
        textBoxExtractor.Text = openFileDialog.FileName;
      }
    }

    private void buttonOk_Click(object sender, EventArgs e) {
      Properties.Settings.Default.Decrypter = textBoxDecrypter.Text;
      Properties.Settings.Default.Extractor = textBoxExtractor.Text;
      Properties.Settings.Default.PathETS2 = textBoxPathETS2.Text;
      Properties.Settings.Default.PathATS = textBoxPathATS.Text;
      Properties.Settings.Default.DistanceUnit = comboBoxDistanceUnit.SelectedIndex;
      Properties.Settings.Default.CurrencyATS = comboBoxCurrencyATS.SelectedIndex;
      Properties.Settings.Default.CurrencyETS2 = comboBoxCurrencyETS2.SelectedIndex;
      Properties.Settings.Default.UnvisitedCities = checkBoxUnvisited.Checked;
      Properties.Settings.Default.Save();
      Close();
    }

    private void buttonCurrencyETS2_Click(object sender, EventArgs e) {
      if (folderBrowserDialog.ShowDialog() == DialogResult.OK) {
        textBoxPathETS2.Text = folderBrowserDialog.SelectedPath;
      }
    }

    private void buttonCurrencyATS_Click(object sender, EventArgs e) {
      if (folderBrowserDialog.ShowDialog() == DialogResult.OK) {
        textBoxPathATS.Text = folderBrowserDialog.SelectedPath;
      }
    }

    private void buttonExplore_Click(object sender, EventArgs e) {
      string configPath = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.PerUserRoamingAndLocal).FilePath;
      Process.Start(new FileInfo(configPath).DirectoryName);
    }
  }
}
