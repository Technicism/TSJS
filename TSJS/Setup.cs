using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TSJS {
  public partial class Setup : Form {

    public Setup() {
      InitializeComponent();
      textBoxDecrypter.Text = Properties.Settings.Default.DecrypterPath;
    }

    private void buttonSelectDecrypter_Click(object sender, EventArgs e) {
      if (openFileDialog.ShowDialog() == DialogResult.OK) {
        Properties.Settings.Default.DecrypterPath = textBoxDecrypter.Text = openFileDialog.FileName;
      }
    }

    private void buttonOk_Click(object sender, EventArgs e) {
      Properties.Settings.Default.Save();
      Close();
    }

    private void Setup_Load(object sender, EventArgs e) {
      
    }
  }
}
