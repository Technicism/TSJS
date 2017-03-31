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
      this.labelDecrypterLoction = new System.Windows.Forms.Label();
      this.buttonDecrypter = new System.Windows.Forms.Button();
      this.buttonOk = new System.Windows.Forms.Button();
      this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
      this.checkBoxUnvisited = new System.Windows.Forms.CheckBox();
      this.comboBoxDistanceUnit = new System.Windows.Forms.ComboBox();
      this.buttonCancel = new System.Windows.Forms.Button();
      this.textBoxExtractor = new System.Windows.Forms.TextBox();
      this.labelExtractorLocation = new System.Windows.Forms.Label();
      this.buttonExtractor = new System.Windows.Forms.Button();
      this.buttonPathETS2 = new System.Windows.Forms.Button();
      this.labelPathETS2 = new System.Windows.Forms.Label();
      this.textBoxPathETS2 = new System.Windows.Forms.TextBox();
      this.buttonPathATS = new System.Windows.Forms.Button();
      this.labelPathATS = new System.Windows.Forms.Label();
      this.textBoxPathATS = new System.Windows.Forms.TextBox();
      this.labelDistanceUnit = new System.Windows.Forms.Label();
      this.folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
      this.buttonExplore = new System.Windows.Forms.Button();
      this.labelCurrencyETS2 = new System.Windows.Forms.Label();
      this.comboBoxCurrencyETS2 = new System.Windows.Forms.ComboBox();
      this.labelCurrencyATS = new System.Windows.Forms.Label();
      this.comboBoxCurrencyATS = new System.Windows.Forms.ComboBox();
      this.SuspendLayout();
      // 
      // textBoxDecrypter
      // 
      this.textBoxDecrypter.Location = new System.Drawing.Point(143, 5);
      this.textBoxDecrypter.Name = "textBoxDecrypter";
      this.textBoxDecrypter.Size = new System.Drawing.Size(344, 20);
      this.textBoxDecrypter.TabIndex = 1;
      // 
      // labelDecrypterLoction
      // 
      this.labelDecrypterLoction.AutoSize = true;
      this.labelDecrypterLoction.Location = new System.Drawing.Point(41, 8);
      this.labelDecrypterLoction.Name = "labelDecrypterLoction";
      this.labelDecrypterLoction.Size = new System.Drawing.Size(100, 13);
      this.labelDecrypterLoction.TabIndex = 0;
      this.labelDecrypterLoction.Text = "Decrypter Location:";
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
      this.buttonOk.TabIndex = 19;
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
      this.checkBoxUnvisited.TabIndex = 18;
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
      this.comboBoxDistanceUnit.TabIndex = 13;
      // 
      // buttonCancel
      // 
      this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
      this.buttonCancel.Location = new System.Drawing.Point(255, 214);
      this.buttonCancel.Name = "buttonCancel";
      this.buttonCancel.Size = new System.Drawing.Size(75, 23);
      this.buttonCancel.TabIndex = 20;
      this.buttonCancel.Text = "Cancel";
      this.buttonCancel.UseVisualStyleBackColor = true;
      // 
      // textBoxExtractor
      // 
      this.textBoxExtractor.Location = new System.Drawing.Point(143, 32);
      this.textBoxExtractor.Name = "textBoxExtractor";
      this.textBoxExtractor.Size = new System.Drawing.Size(344, 20);
      this.textBoxExtractor.TabIndex = 4;
      // 
      // labelExtractorLocation
      // 
      this.labelExtractorLocation.AutoSize = true;
      this.labelExtractorLocation.Location = new System.Drawing.Point(45, 35);
      this.labelExtractorLocation.Name = "labelExtractorLocation";
      this.labelExtractorLocation.Size = new System.Drawing.Size(96, 13);
      this.labelExtractorLocation.TabIndex = 3;
      this.labelExtractorLocation.Text = "Extractor Location:";
      // 
      // buttonExtractor
      // 
      this.buttonExtractor.Location = new System.Drawing.Point(493, 31);
      this.buttonExtractor.Name = "buttonExtractor";
      this.buttonExtractor.Size = new System.Drawing.Size(75, 22);
      this.buttonExtractor.TabIndex = 5;
      this.buttonExtractor.Text = "Select";
      this.buttonExtractor.UseVisualStyleBackColor = true;
      this.buttonExtractor.Click += new System.EventHandler(this.buttonSelectExtractor_Click);
      // 
      // buttonPathETS2
      // 
      this.buttonPathETS2.Location = new System.Drawing.Point(493, 57);
      this.buttonPathETS2.Name = "buttonPathETS2";
      this.buttonPathETS2.Size = new System.Drawing.Size(75, 22);
      this.buttonPathETS2.TabIndex = 8;
      this.buttonPathETS2.Text = "Select";
      this.buttonPathETS2.UseVisualStyleBackColor = true;
      this.buttonPathETS2.Click += new System.EventHandler(this.buttonCurrencyETS2_Click);
      // 
      // labelPathETS2
      // 
      this.labelPathETS2.AutoSize = true;
      this.labelPathETS2.Location = new System.Drawing.Point(60, 61);
      this.labelPathETS2.Name = "labelPathETS2";
      this.labelPathETS2.Size = new System.Drawing.Size(81, 13);
      this.labelPathETS2.TabIndex = 6;
      this.labelPathETS2.Text = "ETS2 Location:";
      // 
      // textBoxPathETS2
      // 
      this.textBoxPathETS2.Location = new System.Drawing.Point(143, 58);
      this.textBoxPathETS2.Name = "textBoxPathETS2";
      this.textBoxPathETS2.Size = new System.Drawing.Size(344, 20);
      this.textBoxPathETS2.TabIndex = 7;
      // 
      // buttonPathATS
      // 
      this.buttonPathATS.Location = new System.Drawing.Point(493, 83);
      this.buttonPathATS.Name = "buttonPathATS";
      this.buttonPathATS.Size = new System.Drawing.Size(75, 22);
      this.buttonPathATS.TabIndex = 11;
      this.buttonPathATS.Text = "Select";
      this.buttonPathATS.UseVisualStyleBackColor = true;
      this.buttonPathATS.Click += new System.EventHandler(this.buttonCurrencyATS_Click);
      // 
      // labelPathATS
      // 
      this.labelPathATS.AutoSize = true;
      this.labelPathATS.Location = new System.Drawing.Point(66, 87);
      this.labelPathATS.Name = "labelPathATS";
      this.labelPathATS.Size = new System.Drawing.Size(75, 13);
      this.labelPathATS.TabIndex = 9;
      this.labelPathATS.Text = "ATS Location:";
      // 
      // textBoxPathATS
      // 
      this.textBoxPathATS.Location = new System.Drawing.Point(143, 84);
      this.textBoxPathATS.Name = "textBoxPathATS";
      this.textBoxPathATS.Size = new System.Drawing.Size(344, 20);
      this.textBoxPathATS.TabIndex = 10;
      // 
      // labelDistanceUnit
      // 
      this.labelDistanceUnit.AutoSize = true;
      this.labelDistanceUnit.Location = new System.Drawing.Point(67, 113);
      this.labelDistanceUnit.Name = "labelDistanceUnit";
      this.labelDistanceUnit.RightToLeft = System.Windows.Forms.RightToLeft.No;
      this.labelDistanceUnit.Size = new System.Drawing.Size(74, 13);
      this.labelDistanceUnit.TabIndex = 12;
      this.labelDistanceUnit.Text = "Distance Unit:";
      // 
      // buttonExplore
      // 
      this.buttonExplore.Location = new System.Drawing.Point(336, 214);
      this.buttonExplore.Name = "buttonExplore";
      this.buttonExplore.Size = new System.Drawing.Size(75, 23);
      this.buttonExplore.TabIndex = 21;
      this.buttonExplore.Text = "Explore";
      this.buttonExplore.UseVisualStyleBackColor = true;
      this.buttonExplore.Click += new System.EventHandler(this.buttonExplore_Click);
      // 
      // labelCurrencyETS2
      // 
      this.labelCurrencyETS2.AutoSize = true;
      this.labelCurrencyETS2.Location = new System.Drawing.Point(59, 140);
      this.labelCurrencyETS2.Name = "labelCurrencyETS2";
      this.labelCurrencyETS2.RightToLeft = System.Windows.Forms.RightToLeft.No;
      this.labelCurrencyETS2.Size = new System.Drawing.Size(82, 13);
      this.labelCurrencyETS2.TabIndex = 14;
      this.labelCurrencyETS2.Text = "ETS2 Currency:";
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
      this.comboBoxCurrencyETS2.TabIndex = 15;
      // 
      // labelCurrencyATS
      // 
      this.labelCurrencyATS.AutoSize = true;
      this.labelCurrencyATS.Location = new System.Drawing.Point(63, 167);
      this.labelCurrencyATS.Name = "labelCurrencyATS";
      this.labelCurrencyATS.RightToLeft = System.Windows.Forms.RightToLeft.No;
      this.labelCurrencyATS.Size = new System.Drawing.Size(76, 13);
      this.labelCurrencyATS.TabIndex = 16;
      this.labelCurrencyATS.Text = "ATS Currency:";
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
      this.comboBoxCurrencyATS.TabIndex = 17;
      // 
      // Setup
      // 
      this.AcceptButton = this.buttonOk;
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.CancelButton = this.buttonCancel;
      this.ClientSize = new System.Drawing.Size(580, 243);
      this.Controls.Add(this.labelCurrencyATS);
      this.Controls.Add(this.comboBoxCurrencyATS);
      this.Controls.Add(this.labelCurrencyETS2);
      this.Controls.Add(this.comboBoxCurrencyETS2);
      this.Controls.Add(this.buttonExplore);
      this.Controls.Add(this.buttonPathATS);
      this.Controls.Add(this.labelPathATS);
      this.Controls.Add(this.textBoxPathATS);
      this.Controls.Add(this.buttonPathETS2);
      this.Controls.Add(this.labelPathETS2);
      this.Controls.Add(this.textBoxPathETS2);
      this.Controls.Add(this.buttonExtractor);
      this.Controls.Add(this.labelExtractorLocation);
      this.Controls.Add(this.textBoxExtractor);
      this.Controls.Add(this.buttonCancel);
      this.Controls.Add(this.checkBoxUnvisited);
      this.Controls.Add(this.labelDistanceUnit);
      this.Controls.Add(this.comboBoxDistanceUnit);
      this.Controls.Add(this.buttonOk);
      this.Controls.Add(this.buttonDecrypter);
      this.Controls.Add(this.labelDecrypterLoction);
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
    private System.Windows.Forms.Label labelDecrypterLoction;
    private System.Windows.Forms.Button buttonDecrypter;
    private System.Windows.Forms.Button buttonOk;
    private System.Windows.Forms.OpenFileDialog openFileDialog;
    private System.Windows.Forms.CheckBox checkBoxUnvisited;
    private System.Windows.Forms.ComboBox comboBoxDistanceUnit;
    private System.Windows.Forms.Button buttonCancel;
    private System.Windows.Forms.TextBox textBoxExtractor;
    private System.Windows.Forms.Label labelExtractorLocation;
    private System.Windows.Forms.Button buttonExtractor;
    private System.Windows.Forms.Button buttonPathETS2;
    private System.Windows.Forms.Label labelPathETS2;
    private System.Windows.Forms.TextBox textBoxPathETS2;
    private System.Windows.Forms.Button buttonPathATS;
    private System.Windows.Forms.Label labelPathATS;
    private System.Windows.Forms.TextBox textBoxPathATS;
    private System.Windows.Forms.Label labelDistanceUnit;
    private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog;
    private System.Windows.Forms.Button buttonExplore;
    private System.Windows.Forms.Label labelCurrencyETS2;
    private System.Windows.Forms.ComboBox comboBoxCurrencyETS2;
    private System.Windows.Forms.Label labelCurrencyATS;
    private System.Windows.Forms.ComboBox comboBoxCurrencyATS;
  }
}