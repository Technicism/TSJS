﻿namespace TSJS {
  partial class Main {
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
      this.dataGridViewOfferedJobs = new System.Windows.Forms.DataGridView();
      this.dataGridViewOfferedJobsId = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.dataGridViewOfferedJobsSourceCity = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.dataGridViewOfferedJobsSourceCompany = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.dataGridViewOfferedJobsDestinationCity = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.dataGridViewOfferedJobsDestinationCompany = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.dataGridViewOfferedJobsCargo = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.dataGridViewOfferedJobsDistance = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.dataGridViewOfferedProfit = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.buttonOpen = new System.Windows.Forms.Button();
      this.textBoxSearch = new System.Windows.Forms.TextBox();
      this.tabControl = new System.Windows.Forms.TabControl();
      this.tabPageOfferedJobs = new System.Windows.Forms.TabPage();
      this.tabPageCompletedJobs = new System.Windows.Forms.TabPage();
      this.dataGridViewCompletedJobs = new System.Windows.Forms.DataGridView();
      this.dataGridViewCompletedJobsId = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.dataGridViewCompletedJobsSourceCity = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.dataGridViewCompletedJobsSourceCompany = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.dataGridViewCompletedJobsDestinationCity = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.dataGridViewCompletedJobsDestinationCompany = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.dataGridViewCompletedJobsCargo = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.dataGridViewCompletedJobsDistance = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.dataGridViewCompletedProfit = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
      this.labelSearch = new System.Windows.Forms.Label();
      this.labelCount = new System.Windows.Forms.Label();
      this.labelCountValue = new System.Windows.Forms.Label();
      this.linkLabelGitHub = new System.Windows.Forms.LinkLabel();
      this.labelVersion = new System.Windows.Forms.Label();
      this.buttonSetup = new System.Windows.Forms.Button();
      ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOfferedJobs)).BeginInit();
      this.tabControl.SuspendLayout();
      this.tabPageOfferedJobs.SuspendLayout();
      this.tabPageCompletedJobs.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCompletedJobs)).BeginInit();
      this.SuspendLayout();
      // 
      // dataGridViewOfferedJobs
      // 
      this.dataGridViewOfferedJobs.AllowUserToAddRows = false;
      this.dataGridViewOfferedJobs.AllowUserToDeleteRows = false;
      this.dataGridViewOfferedJobs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dataGridViewOfferedJobs.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewOfferedJobsId,
            this.dataGridViewOfferedJobsSourceCity,
            this.dataGridViewOfferedJobsSourceCompany,
            this.dataGridViewOfferedJobsDestinationCity,
            this.dataGridViewOfferedJobsDestinationCompany,
            this.dataGridViewOfferedJobsCargo,
            this.dataGridViewOfferedJobsDistance,
            this.dataGridViewOfferedProfit});
      this.dataGridViewOfferedJobs.Dock = System.Windows.Forms.DockStyle.Fill;
      this.dataGridViewOfferedJobs.Location = new System.Drawing.Point(3, 3);
      this.dataGridViewOfferedJobs.Name = "dataGridViewOfferedJobs";
      this.dataGridViewOfferedJobs.ReadOnly = true;
      this.dataGridViewOfferedJobs.Size = new System.Drawing.Size(660, 330);
      this.dataGridViewOfferedJobs.TabIndex = 5;
      // 
      // dataGridViewOfferedJobsId
      // 
      this.dataGridViewOfferedJobsId.HeaderText = "ID";
      this.dataGridViewOfferedJobsId.Name = "dataGridViewOfferedJobsId";
      this.dataGridViewOfferedJobsId.ReadOnly = true;
      this.dataGridViewOfferedJobsId.Visible = false;
      // 
      // dataGridViewOfferedJobsSourceCity
      // 
      this.dataGridViewOfferedJobsSourceCity.HeaderText = "Source City";
      this.dataGridViewOfferedJobsSourceCity.Name = "dataGridViewOfferedJobsSourceCity";
      this.dataGridViewOfferedJobsSourceCity.ReadOnly = true;
      // 
      // dataGridViewOfferedJobsSourceCompany
      // 
      this.dataGridViewOfferedJobsSourceCompany.HeaderText = "Source Company";
      this.dataGridViewOfferedJobsSourceCompany.Name = "dataGridViewOfferedJobsSourceCompany";
      this.dataGridViewOfferedJobsSourceCompany.ReadOnly = true;
      // 
      // dataGridViewOfferedJobsDestinationCity
      // 
      this.dataGridViewOfferedJobsDestinationCity.HeaderText = "Destination City";
      this.dataGridViewOfferedJobsDestinationCity.Name = "dataGridViewOfferedJobsDestinationCity";
      this.dataGridViewOfferedJobsDestinationCity.ReadOnly = true;
      // 
      // dataGridViewOfferedJobsDestinationCompany
      // 
      this.dataGridViewOfferedJobsDestinationCompany.HeaderText = "Destination Company";
      this.dataGridViewOfferedJobsDestinationCompany.Name = "dataGridViewOfferedJobsDestinationCompany";
      this.dataGridViewOfferedJobsDestinationCompany.ReadOnly = true;
      // 
      // dataGridViewOfferedJobsCargo
      // 
      this.dataGridViewOfferedJobsCargo.HeaderText = "Cargo";
      this.dataGridViewOfferedJobsCargo.Name = "dataGridViewOfferedJobsCargo";
      this.dataGridViewOfferedJobsCargo.ReadOnly = true;
      // 
      // dataGridViewOfferedJobsDistance
      // 
      this.dataGridViewOfferedJobsDistance.HeaderText = "Distance";
      this.dataGridViewOfferedJobsDistance.Name = "dataGridViewOfferedJobsDistance";
      this.dataGridViewOfferedJobsDistance.ReadOnly = true;
      // 
      // dataGridViewOfferedProfit
      // 
      this.dataGridViewOfferedProfit.HeaderText = "Profit";
      this.dataGridViewOfferedProfit.Name = "dataGridViewOfferedProfit";
      this.dataGridViewOfferedProfit.ReadOnly = true;
      // 
      // buttonOpen
      // 
      this.buttonOpen.Location = new System.Drawing.Point(12, 12);
      this.buttonOpen.Name = "buttonOpen";
      this.buttonOpen.Size = new System.Drawing.Size(64, 22);
      this.buttonOpen.TabIndex = 1;
      this.buttonOpen.Text = "Open";
      this.buttonOpen.UseVisualStyleBackColor = true;
      this.buttonOpen.Click += new System.EventHandler(this.buttonOpen_Click);
      // 
      // textBoxSearch
      // 
      this.textBoxSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.textBoxSearch.Location = new System.Drawing.Point(132, 13);
      this.textBoxSearch.Name = "textBoxSearch";
      this.textBoxSearch.Size = new System.Drawing.Size(484, 20);
      this.textBoxSearch.TabIndex = 3;
      this.textBoxSearch.TextChanged += new System.EventHandler(this.textBoxSearch_TextChanged);
      // 
      // tabControl
      // 
      this.tabControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.tabControl.Controls.Add(this.tabPageOfferedJobs);
      this.tabControl.Controls.Add(this.tabPageCompletedJobs);
      this.tabControl.Location = new System.Drawing.Point(12, 40);
      this.tabControl.Name = "tabControl";
      this.tabControl.SelectedIndex = 0;
      this.tabControl.Size = new System.Drawing.Size(674, 362);
      this.tabControl.TabIndex = 6;
      this.tabControl.SelectedIndexChanged += new System.EventHandler(this.tabControl_SelectedIndexChanged);
      // 
      // tabPageOfferedJobs
      // 
      this.tabPageOfferedJobs.Controls.Add(this.dataGridViewOfferedJobs);
      this.tabPageOfferedJobs.Location = new System.Drawing.Point(4, 22);
      this.tabPageOfferedJobs.Name = "tabPageOfferedJobs";
      this.tabPageOfferedJobs.Padding = new System.Windows.Forms.Padding(3);
      this.tabPageOfferedJobs.Size = new System.Drawing.Size(666, 336);
      this.tabPageOfferedJobs.TabIndex = 0;
      this.tabPageOfferedJobs.Text = "Offered Jobs";
      this.tabPageOfferedJobs.UseVisualStyleBackColor = true;
      // 
      // tabPageCompletedJobs
      // 
      this.tabPageCompletedJobs.Controls.Add(this.dataGridViewCompletedJobs);
      this.tabPageCompletedJobs.Location = new System.Drawing.Point(4, 22);
      this.tabPageCompletedJobs.Name = "tabPageCompletedJobs";
      this.tabPageCompletedJobs.Padding = new System.Windows.Forms.Padding(3);
      this.tabPageCompletedJobs.Size = new System.Drawing.Size(666, 336);
      this.tabPageCompletedJobs.TabIndex = 1;
      this.tabPageCompletedJobs.Text = "Completed Jobs";
      this.tabPageCompletedJobs.UseVisualStyleBackColor = true;
      // 
      // dataGridViewCompletedJobs
      // 
      this.dataGridViewCompletedJobs.AllowUserToAddRows = false;
      this.dataGridViewCompletedJobs.AllowUserToDeleteRows = false;
      this.dataGridViewCompletedJobs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dataGridViewCompletedJobs.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewCompletedJobsId,
            this.dataGridViewCompletedJobsSourceCity,
            this.dataGridViewCompletedJobsSourceCompany,
            this.dataGridViewCompletedJobsDestinationCity,
            this.dataGridViewCompletedJobsDestinationCompany,
            this.dataGridViewCompletedJobsCargo,
            this.dataGridViewCompletedJobsDistance,
            this.dataGridViewCompletedProfit});
      this.dataGridViewCompletedJobs.Dock = System.Windows.Forms.DockStyle.Fill;
      this.dataGridViewCompletedJobs.Location = new System.Drawing.Point(3, 3);
      this.dataGridViewCompletedJobs.Name = "dataGridViewCompletedJobs";
      this.dataGridViewCompletedJobs.ReadOnly = true;
      this.dataGridViewCompletedJobs.Size = new System.Drawing.Size(660, 330);
      this.dataGridViewCompletedJobs.TabIndex = 7;
      // 
      // dataGridViewCompletedJobsId
      // 
      this.dataGridViewCompletedJobsId.HeaderText = "ID";
      this.dataGridViewCompletedJobsId.Name = "dataGridViewCompletedJobsId";
      this.dataGridViewCompletedJobsId.ReadOnly = true;
      this.dataGridViewCompletedJobsId.Visible = false;
      // 
      // dataGridViewCompletedJobsSourceCity
      // 
      this.dataGridViewCompletedJobsSourceCity.HeaderText = "Source City";
      this.dataGridViewCompletedJobsSourceCity.Name = "dataGridViewCompletedJobsSourceCity";
      this.dataGridViewCompletedJobsSourceCity.ReadOnly = true;
      // 
      // dataGridViewCompletedJobsSourceCompany
      // 
      this.dataGridViewCompletedJobsSourceCompany.HeaderText = "Source Company";
      this.dataGridViewCompletedJobsSourceCompany.Name = "dataGridViewCompletedJobsSourceCompany";
      this.dataGridViewCompletedJobsSourceCompany.ReadOnly = true;
      // 
      // dataGridViewCompletedJobsDestinationCity
      // 
      this.dataGridViewCompletedJobsDestinationCity.HeaderText = "Destination City";
      this.dataGridViewCompletedJobsDestinationCity.Name = "dataGridViewCompletedJobsDestinationCity";
      this.dataGridViewCompletedJobsDestinationCity.ReadOnly = true;
      // 
      // dataGridViewCompletedJobsDestinationCompany
      // 
      this.dataGridViewCompletedJobsDestinationCompany.HeaderText = "Destination Company";
      this.dataGridViewCompletedJobsDestinationCompany.Name = "dataGridViewCompletedJobsDestinationCompany";
      this.dataGridViewCompletedJobsDestinationCompany.ReadOnly = true;
      // 
      // dataGridViewCompletedJobsCargo
      // 
      this.dataGridViewCompletedJobsCargo.HeaderText = "Cargo";
      this.dataGridViewCompletedJobsCargo.Name = "dataGridViewCompletedJobsCargo";
      this.dataGridViewCompletedJobsCargo.ReadOnly = true;
      // 
      // dataGridViewCompletedJobsDistance
      // 
      this.dataGridViewCompletedJobsDistance.HeaderText = "Distance";
      this.dataGridViewCompletedJobsDistance.Name = "dataGridViewCompletedJobsDistance";
      this.dataGridViewCompletedJobsDistance.ReadOnly = true;
      // 
      // dataGridViewCompletedProfit
      // 
      this.dataGridViewCompletedProfit.HeaderText = "Profit";
      this.dataGridViewCompletedProfit.Name = "dataGridViewCompletedProfit";
      this.dataGridViewCompletedProfit.ReadOnly = true;
      // 
      // openFileDialog
      // 
      this.openFileDialog.FileName = "game.sii";
      this.openFileDialog.Filter = "SII files|*.sii|All files|*.*";
      this.openFileDialog.SupportMultiDottedExtensions = true;
      // 
      // labelSearch
      // 
      this.labelSearch.AutoSize = true;
      this.labelSearch.Location = new System.Drawing.Point(82, 16);
      this.labelSearch.Name = "labelSearch";
      this.labelSearch.Size = new System.Drawing.Size(44, 13);
      this.labelSearch.TabIndex = 2;
      this.labelSearch.Text = "Search:";
      // 
      // labelCount
      // 
      this.labelCount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
      this.labelCount.AutoSize = true;
      this.labelCount.Location = new System.Drawing.Point(12, 411);
      this.labelCount.Name = "labelCount";
      this.labelCount.Size = new System.Drawing.Size(58, 13);
      this.labelCount.TabIndex = 11;
      this.labelCount.Text = "Job Count:";
      // 
      // labelCountValue
      // 
      this.labelCountValue.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
      this.labelCountValue.AutoSize = true;
      this.labelCountValue.Location = new System.Drawing.Point(67, 411);
      this.labelCountValue.Name = "labelCountValue";
      this.labelCountValue.Size = new System.Drawing.Size(13, 13);
      this.labelCountValue.TabIndex = 12;
      this.labelCountValue.Text = "0";
      // 
      // linkLabelGitHub
      // 
      this.linkLabelGitHub.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
      this.linkLabelGitHub.AutoSize = true;
      this.linkLabelGitHub.Location = new System.Drawing.Point(467, 411);
      this.linkLabelGitHub.Name = "linkLabelGitHub";
      this.linkLabelGitHub.Size = new System.Drawing.Size(149, 13);
      this.linkLabelGitHub.TabIndex = 13;
      this.linkLabelGitHub.TabStop = true;
      this.linkLabelGitHub.Text = "github.com/Technicism/TSJS";
      this.linkLabelGitHub.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelGitHub_LinkClicked);
      // 
      // labelVersion
      // 
      this.labelVersion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
      this.labelVersion.AutoSize = true;
      this.labelVersion.Location = new System.Drawing.Point(640, 411);
      this.labelVersion.Name = "labelVersion";
      this.labelVersion.Size = new System.Drawing.Size(46, 13);
      this.labelVersion.TabIndex = 12;
      this.labelVersion.Text = "v0.0.0.0";
      // 
      // buttonSetup
      // 
      this.buttonSetup.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this.buttonSetup.Location = new System.Drawing.Point(622, 12);
      this.buttonSetup.Name = "buttonSetup";
      this.buttonSetup.Size = new System.Drawing.Size(64, 22);
      this.buttonSetup.TabIndex = 14;
      this.buttonSetup.Text = "Setup";
      this.buttonSetup.UseVisualStyleBackColor = true;
      this.buttonSetup.Click += new System.EventHandler(this.buttonSetup_Click);
      // 
      // Main
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(698, 441);
      this.Controls.Add(this.buttonSetup);
      this.Controls.Add(this.labelVersion);
      this.Controls.Add(this.linkLabelGitHub);
      this.Controls.Add(this.labelCountValue);
      this.Controls.Add(this.labelCount);
      this.Controls.Add(this.labelSearch);
      this.Controls.Add(this.tabControl);
      this.Controls.Add(this.textBoxSearch);
      this.Controls.Add(this.buttonOpen);
      this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
      this.MinimumSize = new System.Drawing.Size(400, 240);
      this.Name = "Main";
      this.Text = "TSJS - Truck Simulator Job Searcher";
      this.Load += new System.EventHandler(this.Main_Load);
      ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOfferedJobs)).EndInit();
      this.tabControl.ResumeLayout(false);
      this.tabPageOfferedJobs.ResumeLayout(false);
      this.tabPageCompletedJobs.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCompletedJobs)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.DataGridView dataGridViewOfferedJobs;
    private System.Windows.Forms.Button buttonOpen;
    private System.Windows.Forms.TextBox textBoxSearch;
    private System.Windows.Forms.TabControl tabControl;
    private System.Windows.Forms.TabPage tabPageOfferedJobs;
    private System.Windows.Forms.TabPage tabPageCompletedJobs;
    private System.Windows.Forms.OpenFileDialog openFileDialog;
    private System.Windows.Forms.Label labelSearch;
    private System.Windows.Forms.Label labelCount;
    private System.Windows.Forms.Label labelCountValue;
    private System.Windows.Forms.DataGridView dataGridViewCompletedJobs;
    private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewCompletedJobsId;
    private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewCompletedJobsSourceCity;
    private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewCompletedJobsSourceCompany;
    private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewCompletedJobsDestinationCity;
    private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewCompletedJobsDestinationCompany;
    private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewCompletedJobsCargo;
    private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewCompletedJobsDistance;
    private System.Windows.Forms.LinkLabel linkLabelGitHub;
    private System.Windows.Forms.Label labelVersion;
    private System.Windows.Forms.Button buttonSetup;
    private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewOfferedJobsId;
    private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewOfferedJobsSourceCity;
    private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewOfferedJobsSourceCompany;
    private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewOfferedJobsDestinationCity;
    private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewOfferedJobsDestinationCompany;
    private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewOfferedJobsCargo;
    private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewOfferedJobsDistance;
    private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewOfferedProfit;
    private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewCompletedProfit;
  }
}

