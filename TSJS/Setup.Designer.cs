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
      this.comboBoxDistanceUnit = new System.Windows.Forms.ComboBox();
      this.buttonCancel = new System.Windows.Forms.Button();
      this.textBoxExtractor = new System.Windows.Forms.TextBox();
      this.label2 = new System.Windows.Forms.Label();
      this.buttonSelectExtractor = new System.Windows.Forms.Button();
      this.button1 = new System.Windows.Forms.Button();
      this.label3 = new System.Windows.Forms.Label();
      this.textBox1 = new System.Windows.Forms.TextBox();
      this.button2 = new System.Windows.Forms.Button();
      this.label4 = new System.Windows.Forms.Label();
      this.textBox2 = new System.Windows.Forms.TextBox();
      this.labelDistanceUnit = new System.Windows.Forms.Label();
      this.SuspendLayout();
      // 
      // textBoxDecrypter
      // 
      this.textBoxDecrypter.Location = new System.Drawing.Point(147, 5);
      this.textBoxDecrypter.Name = "textBoxDecrypter";
      this.textBoxDecrypter.Size = new System.Drawing.Size(344, 20);
      this.textBoxDecrypter.TabIndex = 0;
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(41, 8);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(100, 13);
      this.label1.TabIndex = 1;
      this.label1.Text = "Decrypter Location:";
      // 
      // buttonSelectDecrypter
      // 
      this.buttonSelectDecrypter.Location = new System.Drawing.Point(497, 4);
      this.buttonSelectDecrypter.Name = "buttonSelectDecrypter";
      this.buttonSelectDecrypter.Size = new System.Drawing.Size(75, 22);
      this.buttonSelectDecrypter.TabIndex = 2;
      this.buttonSelectDecrypter.Text = "Select";
      this.buttonSelectDecrypter.UseVisualStyleBackColor = true;
      this.buttonSelectDecrypter.Click += new System.EventHandler(this.buttonSelectDecrypter_Click);
      // 
      // buttonOk
      // 
      this.buttonOk.Location = new System.Drawing.Point(154, 160);
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
      this.checkBoxUnvisitedCities.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
      this.checkBoxUnvisitedCities.Location = new System.Drawing.Point(11, 137);
      this.checkBoxUnvisitedCities.Name = "checkBoxUnvisitedCities";
      this.checkBoxUnvisitedCities.Size = new System.Drawing.Size(148, 17);
      this.checkBoxUnvisitedCities.TabIndex = 13;
      this.checkBoxUnvisitedCities.Text = "Unvisited Sources Visible:";
      this.checkBoxUnvisitedCities.UseVisualStyleBackColor = true;
      // 
      // comboBoxDistanceUnit
      // 
      this.comboBoxDistanceUnit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.comboBoxDistanceUnit.FormattingEnabled = true;
      this.comboBoxDistanceUnit.Items.AddRange(new object[] {
            "Kilometres",
            "Miles"});
      this.comboBoxDistanceUnit.Location = new System.Drawing.Point(147, 110);
      this.comboBoxDistanceUnit.Name = "comboBoxDistanceUnit";
      this.comboBoxDistanceUnit.Size = new System.Drawing.Size(72, 21);
      this.comboBoxDistanceUnit.TabIndex = 12;
      // 
      // buttonCancel
      // 
      this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
      this.buttonCancel.Location = new System.Drawing.Point(235, 160);
      this.buttonCancel.Name = "buttonCancel";
      this.buttonCancel.Size = new System.Drawing.Size(75, 23);
      this.buttonCancel.TabIndex = 14;
      this.buttonCancel.Text = "Cancel";
      this.buttonCancel.UseVisualStyleBackColor = true;
      // 
      // textBoxExtractor
      // 
      this.textBoxExtractor.Location = new System.Drawing.Point(147, 32);
      this.textBoxExtractor.Name = "textBoxExtractor";
      this.textBoxExtractor.Size = new System.Drawing.Size(344, 20);
      this.textBoxExtractor.TabIndex = 15;
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(45, 35);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(96, 13);
      this.label2.TabIndex = 16;
      this.label2.Text = "Extractor Location:";
      // 
      // buttonSelectExtractor
      // 
      this.buttonSelectExtractor.Location = new System.Drawing.Point(497, 31);
      this.buttonSelectExtractor.Name = "buttonSelectExtractor";
      this.buttonSelectExtractor.Size = new System.Drawing.Size(75, 22);
      this.buttonSelectExtractor.TabIndex = 17;
      this.buttonSelectExtractor.Text = "Select";
      this.buttonSelectExtractor.UseVisualStyleBackColor = true;
      this.buttonSelectExtractor.Click += new System.EventHandler(this.buttonSelectExtractor_Click);
      // 
      // button1
      // 
      this.button1.Location = new System.Drawing.Point(497, 57);
      this.button1.Name = "button1";
      this.button1.Size = new System.Drawing.Size(75, 22);
      this.button1.TabIndex = 20;
      this.button1.Text = "Select";
      this.button1.UseVisualStyleBackColor = true;
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Location = new System.Drawing.Point(60, 61);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(81, 13);
      this.label3.TabIndex = 19;
      this.label3.Text = "ETS2 Location:";
      // 
      // textBox1
      // 
      this.textBox1.Location = new System.Drawing.Point(147, 58);
      this.textBox1.Name = "textBox1";
      this.textBox1.Size = new System.Drawing.Size(344, 20);
      this.textBox1.TabIndex = 18;
      // 
      // button2
      // 
      this.button2.Location = new System.Drawing.Point(497, 83);
      this.button2.Name = "button2";
      this.button2.Size = new System.Drawing.Size(75, 22);
      this.button2.TabIndex = 23;
      this.button2.Text = "Select";
      this.button2.UseVisualStyleBackColor = true;
      // 
      // label4
      // 
      this.label4.AutoSize = true;
      this.label4.Location = new System.Drawing.Point(66, 87);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(75, 13);
      this.label4.TabIndex = 22;
      this.label4.Text = "ATS Location:";
      // 
      // textBox2
      // 
      this.textBox2.Location = new System.Drawing.Point(147, 84);
      this.textBox2.Name = "textBox2";
      this.textBox2.Size = new System.Drawing.Size(344, 20);
      this.textBox2.TabIndex = 21;
      // 
      // labelDistanceUnit
      // 
      this.labelDistanceUnit.AutoSize = true;
      this.labelDistanceUnit.Location = new System.Drawing.Point(67, 113);
      this.labelDistanceUnit.Name = "labelDistanceUnit";
      this.labelDistanceUnit.RightToLeft = System.Windows.Forms.RightToLeft.No;
      this.labelDistanceUnit.Size = new System.Drawing.Size(74, 13);
      this.labelDistanceUnit.TabIndex = 11;
      this.labelDistanceUnit.Text = "Distance Unit:";
      // 
      // Setup
      // 
      this.AcceptButton = this.buttonOk;
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.CancelButton = this.buttonCancel;
      this.ClientSize = new System.Drawing.Size(584, 188);
      this.Controls.Add(this.button2);
      this.Controls.Add(this.label4);
      this.Controls.Add(this.textBox2);
      this.Controls.Add(this.button1);
      this.Controls.Add(this.label3);
      this.Controls.Add(this.textBox1);
      this.Controls.Add(this.buttonSelectExtractor);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.textBoxExtractor);
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
      this.ShowInTaskbar = false;
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
    private System.Windows.Forms.ComboBox comboBoxDistanceUnit;
    private System.Windows.Forms.Button buttonCancel;
    private System.Windows.Forms.TextBox textBoxExtractor;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Button buttonSelectExtractor;
    private System.Windows.Forms.Button button1;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.TextBox textBox1;
    private System.Windows.Forms.Button button2;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.TextBox textBox2;
    private System.Windows.Forms.Label labelDistanceUnit;
  }
}