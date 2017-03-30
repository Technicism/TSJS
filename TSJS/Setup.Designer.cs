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
      this.buttonDecrypter = new System.Windows.Forms.Button();
      this.buttonOk = new System.Windows.Forms.Button();
      this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
      this.checkBoxUnvisited = new System.Windows.Forms.CheckBox();
      this.comboBoxDistanceUnit = new System.Windows.Forms.ComboBox();
      this.buttonCancel = new System.Windows.Forms.Button();
      this.textBoxExtractor = new System.Windows.Forms.TextBox();
      this.label2 = new System.Windows.Forms.Label();
      this.buttonExtractor = new System.Windows.Forms.Button();
      this.buttonETS2 = new System.Windows.Forms.Button();
      this.label3 = new System.Windows.Forms.Label();
      this.textBoxETS2 = new System.Windows.Forms.TextBox();
      this.buttonATS = new System.Windows.Forms.Button();
      this.label4 = new System.Windows.Forms.Label();
      this.textBoxATS = new System.Windows.Forms.TextBox();
      this.labelDistanceUnit = new System.Windows.Forms.Label();
      this.folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
      this.buttonExplore = new System.Windows.Forms.Button();
      this.label5 = new System.Windows.Forms.Label();
      this.comboBoxCurrencyETS2 = new System.Windows.Forms.ComboBox();
      this.label6 = new System.Windows.Forms.Label();
      this.comboBoxCurrencyATS = new System.Windows.Forms.ComboBox();
      this.SuspendLayout();
      // 
      // textBoxDecrypter
      // 
      this.textBoxDecrypter.Location = new System.Drawing.Point(143, 5);
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
      // buttonDecrypter
      // 
      this.buttonDecrypter.Location = new System.Drawing.Point(493, 4);
      this.buttonDecrypter.Name = "buttonDecrypter";
      this.buttonDecrypter.Size = new System.Drawing.Size(75, 22);
      this.buttonDecrypter.TabIndex = 2;
      this.buttonDecrypter.Text = "Select";
      this.buttonDecrypter.UseVisualStyleBackColor = true;
      this.buttonDecrypter.Click += new System.EventHandler(this.buttonSelectDecrypter_Click);
      // 
      // buttonOk
      // 
      this.buttonOk.Location = new System.Drawing.Point(174, 214);
      this.buttonOk.Name = "buttonOk";
      this.buttonOk.Size = new System.Drawing.Size(75, 23);
      this.buttonOk.TabIndex = 3;
      this.buttonOk.Text = "OK";
      this.buttonOk.UseVisualStyleBackColor = true;
      this.buttonOk.Click += new System.EventHandler(this.buttonOk_Click);
      // 
      // checkBoxUnvisited
      // 
      this.checkBoxUnvisited.AutoSize = true;
      this.checkBoxUnvisited.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
      this.checkBoxUnvisited.Location = new System.Drawing.Point(9, 191);
      this.checkBoxUnvisited.Name = "checkBoxUnvisited";
      this.checkBoxUnvisited.Size = new System.Drawing.Size(148, 17);
      this.checkBoxUnvisited.TabIndex = 13;
      this.checkBoxUnvisited.Text = "Unvisited Sources Visible:";
      this.checkBoxUnvisited.UseVisualStyleBackColor = true;
      // 
      // comboBoxDistanceUnit
      // 
      this.comboBoxDistanceUnit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.comboBoxDistanceUnit.FormattingEnabled = true;
      this.comboBoxDistanceUnit.Items.AddRange(new object[] {
            "Kilometres",
            "Miles"});
      this.comboBoxDistanceUnit.Location = new System.Drawing.Point(143, 110);
      this.comboBoxDistanceUnit.Name = "comboBoxDistanceUnit";
      this.comboBoxDistanceUnit.Size = new System.Drawing.Size(72, 21);
      this.comboBoxDistanceUnit.TabIndex = 12;
      // 
      // buttonCancel
      // 
      this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
      this.buttonCancel.Location = new System.Drawing.Point(255, 214);
      this.buttonCancel.Name = "buttonCancel";
      this.buttonCancel.Size = new System.Drawing.Size(75, 23);
      this.buttonCancel.TabIndex = 14;
      this.buttonCancel.Text = "Cancel";
      this.buttonCancel.UseVisualStyleBackColor = true;
      // 
      // textBoxExtractor
      // 
      this.textBoxExtractor.Location = new System.Drawing.Point(143, 32);
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
      // buttonExtractor
      // 
      this.buttonExtractor.Location = new System.Drawing.Point(493, 31);
      this.buttonExtractor.Name = "buttonExtractor";
      this.buttonExtractor.Size = new System.Drawing.Size(75, 22);
      this.buttonExtractor.TabIndex = 17;
      this.buttonExtractor.Text = "Select";
      this.buttonExtractor.UseVisualStyleBackColor = true;
      this.buttonExtractor.Click += new System.EventHandler(this.buttonSelectExtractor_Click);
      // 
      // buttonETS2
      // 
      this.buttonETS2.Location = new System.Drawing.Point(493, 57);
      this.buttonETS2.Name = "buttonETS2";
      this.buttonETS2.Size = new System.Drawing.Size(75, 22);
      this.buttonETS2.TabIndex = 20;
      this.buttonETS2.Text = "Select";
      this.buttonETS2.UseVisualStyleBackColor = true;
      this.buttonETS2.Click += new System.EventHandler(this.buttonCurrencyETS2_Click);
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
      // textBoxETS2
      // 
      this.textBoxETS2.Location = new System.Drawing.Point(143, 58);
      this.textBoxETS2.Name = "textBoxETS2";
      this.textBoxETS2.Size = new System.Drawing.Size(344, 20);
      this.textBoxETS2.TabIndex = 18;
      // 
      // buttonATS
      // 
      this.buttonATS.Location = new System.Drawing.Point(493, 83);
      this.buttonATS.Name = "buttonATS";
      this.buttonATS.Size = new System.Drawing.Size(75, 22);
      this.buttonATS.TabIndex = 23;
      this.buttonATS.Text = "Select";
      this.buttonATS.UseVisualStyleBackColor = true;
      this.buttonATS.Click += new System.EventHandler(this.buttonCurrencyATS_Click);
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
      // textBoxATS
      // 
      this.textBoxATS.Location = new System.Drawing.Point(143, 84);
      this.textBoxATS.Name = "textBoxATS";
      this.textBoxATS.Size = new System.Drawing.Size(344, 20);
      this.textBoxATS.TabIndex = 21;
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
      // buttonExplore
      // 
      this.buttonExplore.Location = new System.Drawing.Point(336, 214);
      this.buttonExplore.Name = "buttonExplore";
      this.buttonExplore.Size = new System.Drawing.Size(75, 23);
      this.buttonExplore.TabIndex = 24;
      this.buttonExplore.Text = "Explore";
      this.buttonExplore.UseVisualStyleBackColor = true;
      this.buttonExplore.Click += new System.EventHandler(this.buttonExplore_Click);
      // 
      // label5
      // 
      this.label5.AutoSize = true;
      this.label5.Location = new System.Drawing.Point(59, 140);
      this.label5.Name = "label5";
      this.label5.RightToLeft = System.Windows.Forms.RightToLeft.No;
      this.label5.Size = new System.Drawing.Size(82, 13);
      this.label5.TabIndex = 25;
      this.label5.Text = "ETS2 Currency:";
      // 
      // comboBoxCurrencyETS2
      // 
      this.comboBoxCurrencyETS2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.comboBoxCurrencyETS2.FormattingEnabled = true;
      this.comboBoxCurrencyETS2.Items.AddRange(new object[] {
            "EUR",
            "CHF",
            "CZK",
            "GBP",
            "PLN",
            "HUF",
            "DKK",
            "SEK",
            "NOK"});
      this.comboBoxCurrencyETS2.Location = new System.Drawing.Point(143, 137);
      this.comboBoxCurrencyETS2.Name = "comboBoxCurrencyETS2";
      this.comboBoxCurrencyETS2.Size = new System.Drawing.Size(72, 21);
      this.comboBoxCurrencyETS2.TabIndex = 26;
      // 
      // label6
      // 
      this.label6.AutoSize = true;
      this.label6.Location = new System.Drawing.Point(63, 167);
      this.label6.Name = "label6";
      this.label6.RightToLeft = System.Windows.Forms.RightToLeft.No;
      this.label6.Size = new System.Drawing.Size(76, 13);
      this.label6.TabIndex = 27;
      this.label6.Text = "ATS Currency:";
      // 
      // comboBoxCurrencyATS
      // 
      this.comboBoxCurrencyATS.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.comboBoxCurrencyATS.FormattingEnabled = true;
      this.comboBoxCurrencyATS.Items.AddRange(new object[] {
            "USD",
            "EUR"});
      this.comboBoxCurrencyATS.Location = new System.Drawing.Point(143, 164);
      this.comboBoxCurrencyATS.Name = "comboBoxCurrencyATS";
      this.comboBoxCurrencyATS.Size = new System.Drawing.Size(72, 21);
      this.comboBoxCurrencyATS.TabIndex = 28;
      // 
      // Setup
      // 
      this.AcceptButton = this.buttonOk;
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.CancelButton = this.buttonCancel;
      this.ClientSize = new System.Drawing.Size(580, 243);
      this.Controls.Add(this.label6);
      this.Controls.Add(this.comboBoxCurrencyATS);
      this.Controls.Add(this.label5);
      this.Controls.Add(this.comboBoxCurrencyETS2);
      this.Controls.Add(this.buttonExplore);
      this.Controls.Add(this.buttonATS);
      this.Controls.Add(this.label4);
      this.Controls.Add(this.textBoxATS);
      this.Controls.Add(this.buttonETS2);
      this.Controls.Add(this.label3);
      this.Controls.Add(this.textBoxETS2);
      this.Controls.Add(this.buttonExtractor);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.textBoxExtractor);
      this.Controls.Add(this.buttonCancel);
      this.Controls.Add(this.checkBoxUnvisited);
      this.Controls.Add(this.labelDistanceUnit);
      this.Controls.Add(this.comboBoxDistanceUnit);
      this.Controls.Add(this.buttonOk);
      this.Controls.Add(this.buttonDecrypter);
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
    private System.Windows.Forms.Button buttonDecrypter;
    private System.Windows.Forms.Button buttonOk;
    private System.Windows.Forms.OpenFileDialog openFileDialog;
    private System.Windows.Forms.CheckBox checkBoxUnvisited;
    private System.Windows.Forms.ComboBox comboBoxDistanceUnit;
    private System.Windows.Forms.Button buttonCancel;
    private System.Windows.Forms.TextBox textBoxExtractor;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Button buttonExtractor;
    private System.Windows.Forms.Button buttonETS2;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.TextBox textBoxETS2;
    private System.Windows.Forms.Button buttonATS;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.TextBox textBoxATS;
    private System.Windows.Forms.Label labelDistanceUnit;
    private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog;
    private System.Windows.Forms.Button buttonExplore;
    private System.Windows.Forms.Label label5;
    private System.Windows.Forms.ComboBox comboBoxCurrencyETS2;
    private System.Windows.Forms.Label label6;
    private System.Windows.Forms.ComboBox comboBoxCurrencyATS;
  }
}