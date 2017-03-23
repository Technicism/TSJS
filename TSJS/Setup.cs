using System;
using System.Windows.Forms;

namespace TSJS {
  public partial class Setup : Form {

    public Setup() {
      InitializeComponent();
      textBoxDecrypter.Text = Properties.Settings.Default.DecrypterPath;
      comboBoxDistanceUnit.SelectedIndex = Properties.Settings.Default.DistanceUnit;
      checkBoxUnvisitedCities.Checked = Properties.Settings.Default.UnvisitedCities;
    }

    private void buttonSelectDecrypter_Click(object sender, EventArgs e) {
      if (openFileDialog.ShowDialog() == DialogResult.OK) {
        textBoxDecrypter.Text = openFileDialog.FileName;
      }
    }

    private void buttonOk_Click(object sender, EventArgs e) {
      Properties.Settings.Default.DecrypterPath = textBoxDecrypter.Text;
      Properties.Settings.Default.DistanceUnit = comboBoxDistanceUnit.SelectedIndex;
      Properties.Settings.Default.UnvisitedCities = checkBoxUnvisitedCities.Checked;
      Properties.Settings.Default.Save();
      Close();
    }
  }
}
