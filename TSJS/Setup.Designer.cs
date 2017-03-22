namespace TSJS {
  partial class Setup {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing) {
      if (disposing && (components != null)) {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent() {
      this.textBoxDecrypter = new System.Windows.Forms.TextBox();
      this.label1 = new System.Windows.Forms.Label();
      this.buttonSelectDecrypter = new System.Windows.Forms.Button();
      this.buttonOk = new System.Windows.Forms.Button();
      this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
      this.SuspendLayout();
      // 
      // textBoxDecrypter
      // 
      this.textBoxDecrypter.Location = new System.Drawing.Point(70, 5);
      this.textBoxDecrypter.Name = "textBoxDecrypter";
      this.textBoxDecrypter.Size = new System.Drawing.Size(301, 20);
      this.textBoxDecrypter.TabIndex = 0;
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(8, 8);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(56, 13);
      this.label1.TabIndex = 1;
      this.label1.Text = "Decrypter:";
      // 
      // buttonSelectDecrypter
      // 
      this.buttonSelectDecrypter.Location = new System.Drawing.Point(377, 3);
      this.buttonSelectDecrypter.Name = "buttonSelectDecrypter";
      this.buttonSelectDecrypter.Size = new System.Drawing.Size(75, 23);
      this.buttonSelectDecrypter.TabIndex = 2;
      this.buttonSelectDecrypter.Text = "Select";
      this.buttonSelectDecrypter.UseVisualStyleBackColor = true;
      this.buttonSelectDecrypter.Click += new System.EventHandler(this.buttonSelectDecrypter_Click);
      // 
      // buttonOk
      // 
      this.buttonOk.Location = new System.Drawing.Point(11, 166);
      this.buttonOk.Name = "buttonOk";
      this.buttonOk.Size = new System.Drawing.Size(75, 23);
      this.buttonOk.TabIndex = 3;
      this.buttonOk.Text = "OK";
      this.buttonOk.UseVisualStyleBackColor = true;
      this.buttonOk.Click += new System.EventHandler(this.buttonOk_Click);
      // 
      // openFileDialog
      // 
      this.openFileDialog.FileName = "openFileDialog";
      // 
      // Setup
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(464, 201);
      this.Controls.Add(this.buttonOk);
      this.Controls.Add(this.buttonSelectDecrypter);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.textBoxDecrypter);
      this.Name = "Setup";
      this.Text = "Setup";
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.TextBox textBoxDecrypter;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Button buttonSelectDecrypter;
    private System.Windows.Forms.Button buttonOk;
    private System.Windows.Forms.OpenFileDialog openFileDialog;
  }
}