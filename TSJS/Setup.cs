using System;
using System.Windows.Forms;

namespace TSJS {
  public partial class Setup : Form {

    public Setup() {
      InitializeComponent();
      textBoxDecrypter.Text = Properties.Settings.Default.Decrypter;
      textBoxExtractor.Text = Properties.Settings.Default.Extractor;
      textBoxETS2.Text = Properties.Settings.Default.ETS2;
      textBoxATS.Text = Properties.Settings.Default.ATS;
      comboBoxDistanceUnit.SelectedIndex = Properties.Settings.Default.DistanceUnit;
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
      Properties.Settings.Default.ETS2 = textBoxETS2.Text;
      Properties.Settings.Default.ATS = textBoxATS.Text;
      Properties.Settings.Default.DistanceUnit = comboBoxDistanceUnit.SelectedIndex;
      Properties.Settings.Default.UnvisitedCities = checkBoxUnvisited.Checked;
      Properties.Settings.Default.Save();
      Close();
    }

    private void buttonETS2_Click(object sender, EventArgs e) {
      if (folderBrowserDialog.ShowDialog() == DialogResult.OK) {
        textBoxETS2.Text = folderBrowserDialog.SelectedPath;
      }
    }

    private void buttonATS_Click(object sender, EventArgs e) {
      if (folderBrowserDialog.ShowDialog() == DialogResult.OK) {
        textBoxATS.Text = folderBrowserDialog.SelectedPath;
      }
    }
  }
}
