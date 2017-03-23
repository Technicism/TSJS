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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Setup));
      this.textBoxDecrypter = new System.Windows.Forms.TextBox();
      this.label1 = new System.Windows.Forms.Label();
      this.buttonSelectDecrypter = new System.Windows.Forms.Button();
      this.buttonOk = new System.Windows.Forms.Button();
      this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
      this.checkBoxUnvisitedCities = new System.Windows.Forms.CheckBox();
      this.labelDistanceUnit = new System.Windows.Forms.Label();
      this.comboBoxDistanceUnit = new System.Windows.Forms.ComboBox();
      this.buttonCancel = new System.Windows.Forms.Button();
      this.SuspendLayout();
      // 
      // textBoxDecrypter
      // 
      this.textBoxDecrypter.Location = new System.Drawing.Point(114, 5);
      this.textBoxDecrypter.Name = "textBoxDecrypter";
      this.textBoxDecrypter.Size = new System.Drawing.Size(257, 20);
      this.textBoxDecrypter.TabIndex = 0;
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(8, 8);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(100, 13);
      this.label1.TabIndex = 1;
      this.label1.Text = "Decrypter Location:";
      // 
      // buttonSelectDecrypter
      // 
      this.buttonSelectDecrypter.Location = new System.Drawing.Point(377, 4);
      this.buttonSelectDecrypter.Name = "buttonSelectDecrypter";
      this.buttonSelectDecrypter.Size = new System.Drawing.Size(75, 22);
      this.buttonSelectDecrypter.TabIndex = 2;
      this.buttonSelectDecrypter.Text = "Select";
      this.buttonSelectDecrypter.UseVisualStyleBackColor = true;
      this.buttonSelectDecrypter.Click += new System.EventHandler(this.buttonSelectDecrypter_Click);
      // 
      // buttonOk
      // 
      this.buttonOk.Location = new System.Drawing.Point(154, 81);
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
      // checkBoxUnvisitedCities
      // 
      this.checkBoxUnvisitedCities.AutoSize = true;
      this.checkBoxUnvisitedCities.Location = new System.Drawing.Point(12, 58);
      this.checkBoxUnvisitedCities.Name = "checkBoxUnvisitedCities";
      this.checkBoxUnvisitedCities.Size = new System.Drawing.Size(160, 17);
      this.checkBoxUnvisitedCities.TabIndex = 13;
      this.checkBoxUnvisitedCities.Text = "Show unvisited source cities";
      this.checkBoxUnvisitedCities.UseVisualStyleBackColor = true;
      // 
      // labelDistanceUnit
      // 
      this.labelDistanceUnit.AutoSize = true;
      this.labelDistanceUnit.Location = new System.Drawing.Point(8, 34);
      this.labelDistanceUnit.Name = "labelDistanceUnit";
      this.labelDistanceUnit.RightToLeft = System.Windows.Forms.RightToLeft.No;
      this.labelDistanceUnit.Size = new System.Drawing.Size(74, 13);
      this.labelDistanceUnit.TabIndex = 11;
      this.labelDistanceUnit.Text = "Distance Unit:";
      // 
      // comboBoxDistanceUnit
      // 
      this.comboBoxDistanceUnit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.comboBoxDistanceUnit.FormattingEnabled = true;
      this.comboBoxDistanceUnit.Items.AddRange(new object[] {
            "Kilometres",
            "Miles"});
      this.comboBoxDistanceUnit.Location = new System.Drawing.Point(114, 31);
      this.comboBoxDistanceUnit.Name = "comboBoxDistanceUnit";
      this.comboBoxDistanceUnit.Size = new System.Drawing.Size(72, 21);
      this.comboBoxDistanceUnit.TabIndex = 12;
      // 
      // buttonCancel
      // 
      this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
      this.buttonCancel.Location = new System.Drawing.Point(235, 81);
      this.buttonCancel.Name = "buttonCancel";
      this.buttonCancel.Size = new System.Drawing.Size(75, 23);
      this.buttonCancel.TabIndex = 14;
      this.buttonCancel.Text = "Cancel";
      this.buttonCancel.UseVisualStyleBackColor = true;
      // 
      // Setup
      // 
      this.AcceptButton = this.buttonOk;
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.CancelButton = this.buttonCancel;
      this.ClientSize = new System.Drawing.Size(464, 111);
      this.Controls.Add(this.buttonCancel);
      this.Controls.Add(this.checkBoxUnvisitedCities);
      this.Controls.Add(this.labelDistanceUnit);
      this.Controls.Add(this.comboBoxDistanceUnit);
      this.Controls.Add(this.buttonOk);
      this.Controls.Add(this.buttonSelectDecrypter);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.textBoxDecrypter);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
      this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = "Setup";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
      this.Text = "TSJS - Truck Simulator Job Searcher - Setup";
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.TextBox textBoxDecrypter;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Button buttonSelectDecrypter;
    private System.Windows.Forms.Button buttonOk;
    private System.Windows.Forms.OpenFileDialog openFileDialog;
    private System.Windows.Forms.CheckBox checkBoxUnvisitedCities;
    private System.Windows.Forms.Label labelDistanceUnit;
    private System.Windows.Forms.ComboBox comboBoxDistanceUnit;
    private System.Windows.Forms.Button buttonCancel;
  }
}