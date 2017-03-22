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
    public string decrypterPath;
    private Main main;

    public Setup(Main main, string decrypterPath) {
      InitializeComponent();
      this.main = main;
      this.decrypterPath = textBoxDecrypter.Text = decrypterPath;
    }

    private void buttonSelectDecrypter_Click(object sender, EventArgs e) {
      if (openFileDialog.ShowDialog() == DialogResult.OK) {
        decrypterPath = textBoxDecrypter.Text = openFileDialog.FileName;
      }
    }

    private void buttonOk_Click(object sender, EventArgs e) {
      main.decrypterPath = decrypterPath;
      Close();
    }
  }
}
