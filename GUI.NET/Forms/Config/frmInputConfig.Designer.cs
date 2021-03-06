﻿namespace Mesen.GUI.Forms.Config
{
	partial class frmInputConfig
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if(disposing && (components != null)) {
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.tabMain = new System.Windows.Forms.TabControl();
			this.tpgControllers = new System.Windows.Forms.TabPage();
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.btnSetupP4 = new System.Windows.Forms.Button();
			this.btnSetupP3 = new System.Windows.Forms.Button();
			this.lblPlayer1 = new System.Windows.Forms.Label();
			this.lblPlayer2 = new System.Windows.Forms.Label();
			this.cboPlayer4 = new System.Windows.Forms.ComboBox();
			this.cboPlayer3 = new System.Windows.Forms.ComboBox();
			this.cboPlayer1 = new System.Windows.Forms.ComboBox();
			this.lblPlayer4 = new System.Windows.Forms.Label();
			this.cboPlayer2 = new System.Windows.Forms.ComboBox();
			this.lblPlayer3 = new System.Windows.Forms.Label();
			this.btnSetupP1 = new System.Windows.Forms.Button();
			this.btnSetupP2 = new System.Windows.Forms.Button();
			this.lblNesType = new System.Windows.Forms.Label();
			this.cboConsoleType = new System.Windows.Forms.ComboBox();
			this.lblExpansionPort = new System.Windows.Forms.Label();
			this.cboExpansionPort = new System.Windows.Forms.ComboBox();
			this.chkFourScore = new System.Windows.Forms.CheckBox();
			this.chkAutoConfigureInput = new System.Windows.Forms.CheckBox();
			this.tpgAdvanced = new System.Windows.Forms.TabPage();
			this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
			this.grpDisplayInput = new System.Windows.Forms.GroupBox();
			this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
			this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
			this.chkDisplayPort1 = new System.Windows.Forms.CheckBox();
			this.chkDisplayPort2 = new System.Windows.Forms.CheckBox();
			this.chkDisplayPort3 = new System.Windows.Forms.CheckBox();
			this.chkDisplayPort4 = new System.Windows.Forms.CheckBox();
			this.chkDisplayInputHorizontally = new System.Windows.Forms.CheckBox();
			this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
			this.lblDisplayPosition = new System.Windows.Forms.Label();
			this.cboDisplayInputPosition = new System.Windows.Forms.ComboBox();
			this.tabMain.SuspendLayout();
			this.tpgControllers.SuspendLayout();
			this.tableLayoutPanel1.SuspendLayout();
			this.tpgAdvanced.SuspendLayout();
			this.tableLayoutPanel2.SuspendLayout();
			this.grpDisplayInput.SuspendLayout();
			this.tableLayoutPanel3.SuspendLayout();
			this.flowLayoutPanel2.SuspendLayout();
			this.flowLayoutPanel3.SuspendLayout();
			this.SuspendLayout();
			// 
			// baseConfigPanel
			// 
			this.baseConfigPanel.Location = new System.Drawing.Point(0, 251);
			this.baseConfigPanel.Size = new System.Drawing.Size(370, 29);
			// 
			// tabMain
			// 
			this.tabMain.Controls.Add(this.tpgControllers);
			this.tabMain.Controls.Add(this.tpgAdvanced);
			this.tabMain.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tabMain.Location = new System.Drawing.Point(0, 0);
			this.tabMain.Name = "tabMain";
			this.tabMain.SelectedIndex = 0;
			this.tabMain.Size = new System.Drawing.Size(370, 251);
			this.tabMain.TabIndex = 11;
			// 
			// tpgControllers
			// 
			this.tpgControllers.Controls.Add(this.tableLayoutPanel1);
			this.tpgControllers.Location = new System.Drawing.Point(4, 22);
			this.tpgControllers.Name = "tpgControllers";
			this.tpgControllers.Size = new System.Drawing.Size(362, 225);
			this.tpgControllers.TabIndex = 0;
			this.tpgControllers.Text = "Controllers";
			this.tpgControllers.UseVisualStyleBackColor = true;
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.ColumnCount = 3;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.tableLayoutPanel1.Controls.Add(this.btnSetupP4, 2, 7);
			this.tableLayoutPanel1.Controls.Add(this.btnSetupP3, 2, 6);
			this.tableLayoutPanel1.Controls.Add(this.lblPlayer1, 0, 2);
			this.tableLayoutPanel1.Controls.Add(this.lblPlayer2, 0, 3);
			this.tableLayoutPanel1.Controls.Add(this.cboPlayer4, 1, 7);
			this.tableLayoutPanel1.Controls.Add(this.cboPlayer3, 1, 6);
			this.tableLayoutPanel1.Controls.Add(this.cboPlayer1, 1, 2);
			this.tableLayoutPanel1.Controls.Add(this.lblPlayer4, 0, 7);
			this.tableLayoutPanel1.Controls.Add(this.cboPlayer2, 1, 3);
			this.tableLayoutPanel1.Controls.Add(this.lblPlayer3, 0, 6);
			this.tableLayoutPanel1.Controls.Add(this.btnSetupP1, 2, 2);
			this.tableLayoutPanel1.Controls.Add(this.btnSetupP2, 2, 3);
			this.tableLayoutPanel1.Controls.Add(this.lblNesType, 0, 0);
			this.tableLayoutPanel1.Controls.Add(this.cboConsoleType, 1, 0);
			this.tableLayoutPanel1.Controls.Add(this.lblExpansionPort, 0, 5);
			this.tableLayoutPanel1.Controls.Add(this.cboExpansionPort, 1, 5);
			this.tableLayoutPanel1.Controls.Add(this.chkFourScore, 0, 4);
			this.tableLayoutPanel1.Controls.Add(this.chkAutoConfigureInput, 0, 1);
			this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 10;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel1.Size = new System.Drawing.Size(362, 225);
			this.tableLayoutPanel1.TabIndex = 0;
			// 
			// btnSetupP4
			// 
			this.btnSetupP4.AutoSize = true;
			this.btnSetupP4.Location = new System.Drawing.Point(297, 192);
			this.btnSetupP4.Name = "btnSetupP4";
			this.btnSetupP4.Size = new System.Drawing.Size(62, 23);
			this.btnSetupP4.TabIndex = 12;
			this.btnSetupP4.Text = "Setup";
			this.btnSetupP4.UseVisualStyleBackColor = true;
			this.btnSetupP4.Click += new System.EventHandler(this.btnSetup_Click);
			// 
			// btnSetupP3
			// 
			this.btnSetupP3.AutoSize = true;
			this.btnSetupP3.Location = new System.Drawing.Point(297, 163);
			this.btnSetupP3.Name = "btnSetupP3";
			this.btnSetupP3.Size = new System.Drawing.Size(62, 23);
			this.btnSetupP3.TabIndex = 11;
			this.btnSetupP3.Text = "Setup";
			this.btnSetupP3.UseVisualStyleBackColor = true;
			this.btnSetupP3.Click += new System.EventHandler(this.btnSetup_Click);
			// 
			// lblPlayer1
			// 
			this.lblPlayer1.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.lblPlayer1.AutoSize = true;
			this.lblPlayer1.Location = new System.Drawing.Point(3, 60);
			this.lblPlayer1.Name = "lblPlayer1";
			this.lblPlayer1.Size = new System.Drawing.Size(48, 13);
			this.lblPlayer1.TabIndex = 0;
			this.lblPlayer1.Text = "Player 1:";
			// 
			// lblPlayer2
			// 
			this.lblPlayer2.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.lblPlayer2.AutoSize = true;
			this.lblPlayer2.Location = new System.Drawing.Point(3, 89);
			this.lblPlayer2.Name = "lblPlayer2";
			this.lblPlayer2.Size = new System.Drawing.Size(48, 13);
			this.lblPlayer2.TabIndex = 1;
			this.lblPlayer2.Text = "Player 2:";
			// 
			// cboPlayer4
			// 
			this.cboPlayer4.Dock = System.Windows.Forms.DockStyle.Fill;
			this.cboPlayer4.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cboPlayer4.FormattingEnabled = true;
			this.cboPlayer4.Location = new System.Drawing.Point(90, 192);
			this.cboPlayer4.Name = "cboPlayer4";
			this.cboPlayer4.Size = new System.Drawing.Size(201, 21);
			this.cboPlayer4.TabIndex = 8;
			this.cboPlayer4.SelectedIndexChanged += new System.EventHandler(this.cboPlayerController_SelectedIndexChanged);
			// 
			// cboPlayer3
			// 
			this.cboPlayer3.Dock = System.Windows.Forms.DockStyle.Fill;
			this.cboPlayer3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cboPlayer3.FormattingEnabled = true;
			this.cboPlayer3.Location = new System.Drawing.Point(90, 163);
			this.cboPlayer3.Name = "cboPlayer3";
			this.cboPlayer3.Size = new System.Drawing.Size(201, 21);
			this.cboPlayer3.TabIndex = 7;
			this.cboPlayer3.SelectedIndexChanged += new System.EventHandler(this.cboPlayerController_SelectedIndexChanged);
			// 
			// cboPlayer1
			// 
			this.cboPlayer1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.cboPlayer1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cboPlayer1.FormattingEnabled = true;
			this.cboPlayer1.Location = new System.Drawing.Point(90, 55);
			this.cboPlayer1.Name = "cboPlayer1";
			this.cboPlayer1.Size = new System.Drawing.Size(201, 21);
			this.cboPlayer1.TabIndex = 4;
			this.cboPlayer1.SelectedIndexChanged += new System.EventHandler(this.cboPlayerController_SelectedIndexChanged);
			// 
			// lblPlayer4
			// 
			this.lblPlayer4.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.lblPlayer4.AutoSize = true;
			this.lblPlayer4.Location = new System.Drawing.Point(3, 197);
			this.lblPlayer4.Name = "lblPlayer4";
			this.lblPlayer4.Size = new System.Drawing.Size(48, 13);
			this.lblPlayer4.TabIndex = 3;
			this.lblPlayer4.Text = "Player 4:";
			// 
			// cboPlayer2
			// 
			this.cboPlayer2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.cboPlayer2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cboPlayer2.FormattingEnabled = true;
			this.cboPlayer2.Location = new System.Drawing.Point(90, 84);
			this.cboPlayer2.Name = "cboPlayer2";
			this.cboPlayer2.Size = new System.Drawing.Size(201, 21);
			this.cboPlayer2.TabIndex = 6;
			this.cboPlayer2.SelectedIndexChanged += new System.EventHandler(this.cboPlayerController_SelectedIndexChanged);
			// 
			// lblPlayer3
			// 
			this.lblPlayer3.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.lblPlayer3.AutoSize = true;
			this.lblPlayer3.Location = new System.Drawing.Point(3, 168);
			this.lblPlayer3.Name = "lblPlayer3";
			this.lblPlayer3.Size = new System.Drawing.Size(48, 13);
			this.lblPlayer3.TabIndex = 2;
			this.lblPlayer3.Text = "Player 3:";
			// 
			// btnSetupP1
			// 
			this.btnSetupP1.AutoSize = true;
			this.btnSetupP1.Location = new System.Drawing.Point(297, 55);
			this.btnSetupP1.Name = "btnSetupP1";
			this.btnSetupP1.Size = new System.Drawing.Size(62, 23);
			this.btnSetupP1.TabIndex = 9;
			this.btnSetupP1.Text = "Setup";
			this.btnSetupP1.UseVisualStyleBackColor = true;
			this.btnSetupP1.Click += new System.EventHandler(this.btnSetup_Click);
			// 
			// btnSetupP2
			// 
			this.btnSetupP2.AutoSize = true;
			this.btnSetupP2.Location = new System.Drawing.Point(297, 84);
			this.btnSetupP2.Name = "btnSetupP2";
			this.btnSetupP2.Size = new System.Drawing.Size(62, 23);
			this.btnSetupP2.TabIndex = 10;
			this.btnSetupP2.Text = "Setup";
			this.btnSetupP2.UseVisualStyleBackColor = true;
			this.btnSetupP2.Click += new System.EventHandler(this.btnSetup_Click);
			// 
			// lblNesType
			// 
			this.lblNesType.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.lblNesType.AutoSize = true;
			this.lblNesType.Location = new System.Drawing.Point(3, 7);
			this.lblNesType.Name = "lblNesType";
			this.lblNesType.Size = new System.Drawing.Size(75, 13);
			this.lblNesType.TabIndex = 13;
			this.lblNesType.Text = "Console Type:";
			// 
			// cboConsoleType
			// 
			this.cboConsoleType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cboConsoleType.FormattingEnabled = true;
			this.cboConsoleType.Items.AddRange(new object[] {
            "NES",
            "Famicom"});
			this.cboConsoleType.Location = new System.Drawing.Point(90, 3);
			this.cboConsoleType.Name = "cboConsoleType";
			this.cboConsoleType.Size = new System.Drawing.Size(109, 21);
			this.cboConsoleType.TabIndex = 14;
			this.cboConsoleType.SelectedIndexChanged += new System.EventHandler(this.cboNesType_SelectedIndexChanged);
			// 
			// lblExpansionPort
			// 
			this.lblExpansionPort.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.lblExpansionPort.AutoSize = true;
			this.lblExpansionPort.Location = new System.Drawing.Point(3, 140);
			this.lblExpansionPort.Name = "lblExpansionPort";
			this.lblExpansionPort.Size = new System.Drawing.Size(81, 13);
			this.lblExpansionPort.TabIndex = 16;
			this.lblExpansionPort.Text = "Expansion Port:";
			// 
			// cboExpansionPort
			// 
			this.cboExpansionPort.Dock = System.Windows.Forms.DockStyle.Fill;
			this.cboExpansionPort.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cboExpansionPort.FormattingEnabled = true;
			this.cboExpansionPort.Location = new System.Drawing.Point(90, 136);
			this.cboExpansionPort.Name = "cboExpansionPort";
			this.cboExpansionPort.Size = new System.Drawing.Size(201, 21);
			this.cboExpansionPort.TabIndex = 17;
			this.cboExpansionPort.SelectedIndexChanged += new System.EventHandler(this.cboExpansionPort_SelectedIndexChanged);
			// 
			// chkFourScore
			// 
			this.chkFourScore.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.chkFourScore.AutoSize = true;
			this.tableLayoutPanel1.SetColumnSpan(this.chkFourScore, 2);
			this.chkFourScore.Location = new System.Drawing.Point(3, 113);
			this.chkFourScore.Name = "chkFourScore";
			this.chkFourScore.Size = new System.Drawing.Size(151, 17);
			this.chkFourScore.TabIndex = 15;
			this.chkFourScore.Text = "Use Four Score accessory";
			this.chkFourScore.UseVisualStyleBackColor = true;
			this.chkFourScore.CheckedChanged += new System.EventHandler(this.chkFourScore_CheckedChanged);
			// 
			// chkAutoConfigureInput
			// 
			this.chkAutoConfigureInput.AutoSize = true;
			this.tableLayoutPanel1.SetColumnSpan(this.chkAutoConfigureInput, 3);
			this.chkAutoConfigureInput.Location = new System.Drawing.Point(3, 30);
			this.chkAutoConfigureInput.Name = "chkAutoConfigureInput";
			this.chkAutoConfigureInput.Size = new System.Drawing.Size(290, 17);
			this.chkAutoConfigureInput.TabIndex = 18;
			this.chkAutoConfigureInput.Text = "Automatically configure controllers when loading a game";
			this.chkAutoConfigureInput.UseVisualStyleBackColor = true;
			// 
			// tpgAdvanced
			// 
			this.tpgAdvanced.Controls.Add(this.tableLayoutPanel2);
			this.tpgAdvanced.Location = new System.Drawing.Point(4, 22);
			this.tpgAdvanced.Name = "tpgAdvanced";
			this.tpgAdvanced.Size = new System.Drawing.Size(362, 225);
			this.tpgAdvanced.TabIndex = 5;
			this.tpgAdvanced.Text = "Advanced";
			this.tpgAdvanced.UseVisualStyleBackColor = true;
			// 
			// tableLayoutPanel2
			// 
			this.tableLayoutPanel2.ColumnCount = 1;
			this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel2.Controls.Add(this.grpDisplayInput, 0, 0);
			this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
			this.tableLayoutPanel2.Name = "tableLayoutPanel2";
			this.tableLayoutPanel2.RowCount = 2;
			this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel2.Size = new System.Drawing.Size(362, 225);
			this.tableLayoutPanel2.TabIndex = 0;
			// 
			// grpDisplayInput
			// 
			this.grpDisplayInput.Controls.Add(this.tableLayoutPanel3);
			this.grpDisplayInput.Dock = System.Windows.Forms.DockStyle.Fill;
			this.grpDisplayInput.Location = new System.Drawing.Point(3, 3);
			this.grpDisplayInput.Name = "grpDisplayInput";
			this.grpDisplayInput.Size = new System.Drawing.Size(356, 90);
			this.grpDisplayInput.TabIndex = 0;
			this.grpDisplayInput.TabStop = false;
			this.grpDisplayInput.Text = "Display Controller Input";
			// 
			// tableLayoutPanel3
			// 
			this.tableLayoutPanel3.ColumnCount = 1;
			this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel3.Controls.Add(this.flowLayoutPanel2, 0, 0);
			this.tableLayoutPanel3.Controls.Add(this.chkDisplayInputHorizontally, 0, 2);
			this.tableLayoutPanel3.Controls.Add(this.flowLayoutPanel3, 0, 1);
			this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 16);
			this.tableLayoutPanel3.Name = "tableLayoutPanel3";
			this.tableLayoutPanel3.RowCount = 4;
			this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel3.Size = new System.Drawing.Size(350, 71);
			this.tableLayoutPanel3.TabIndex = 0;
			// 
			// flowLayoutPanel2
			// 
			this.flowLayoutPanel2.Controls.Add(this.chkDisplayPort1);
			this.flowLayoutPanel2.Controls.Add(this.chkDisplayPort2);
			this.flowLayoutPanel2.Controls.Add(this.chkDisplayPort3);
			this.flowLayoutPanel2.Controls.Add(this.chkDisplayPort4);
			this.flowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Top;
			this.flowLayoutPanel2.Location = new System.Drawing.Point(0, 0);
			this.flowLayoutPanel2.Margin = new System.Windows.Forms.Padding(0);
			this.flowLayoutPanel2.Name = "flowLayoutPanel2";
			this.flowLayoutPanel2.Size = new System.Drawing.Size(350, 24);
			this.flowLayoutPanel2.TabIndex = 0;
			// 
			// chkDisplayPort1
			// 
			this.chkDisplayPort1.AutoSize = true;
			this.chkDisplayPort1.Location = new System.Drawing.Point(3, 3);
			this.chkDisplayPort1.Name = "chkDisplayPort1";
			this.chkDisplayPort1.Size = new System.Drawing.Size(54, 17);
			this.chkDisplayPort1.TabIndex = 0;
			this.chkDisplayPort1.Text = "Port 1";
			this.chkDisplayPort1.UseVisualStyleBackColor = true;
			// 
			// chkDisplayPort2
			// 
			this.chkDisplayPort2.AutoSize = true;
			this.chkDisplayPort2.Location = new System.Drawing.Point(63, 3);
			this.chkDisplayPort2.Name = "chkDisplayPort2";
			this.chkDisplayPort2.Size = new System.Drawing.Size(54, 17);
			this.chkDisplayPort2.TabIndex = 1;
			this.chkDisplayPort2.Text = "Port 2";
			this.chkDisplayPort2.UseVisualStyleBackColor = true;
			// 
			// chkDisplayPort3
			// 
			this.chkDisplayPort3.AutoSize = true;
			this.chkDisplayPort3.Location = new System.Drawing.Point(123, 3);
			this.chkDisplayPort3.Name = "chkDisplayPort3";
			this.chkDisplayPort3.Size = new System.Drawing.Size(54, 17);
			this.chkDisplayPort3.TabIndex = 2;
			this.chkDisplayPort3.Text = "Port 3";
			this.chkDisplayPort3.UseVisualStyleBackColor = true;
			// 
			// chkDisplayPort4
			// 
			this.chkDisplayPort4.AutoSize = true;
			this.chkDisplayPort4.Location = new System.Drawing.Point(183, 3);
			this.chkDisplayPort4.Name = "chkDisplayPort4";
			this.chkDisplayPort4.Size = new System.Drawing.Size(54, 17);
			this.chkDisplayPort4.TabIndex = 3;
			this.chkDisplayPort4.Text = "Port 4";
			this.chkDisplayPort4.UseVisualStyleBackColor = true;
			// 
			// chkDisplayInputHorizontally
			// 
			this.chkDisplayInputHorizontally.AutoSize = true;
			this.chkDisplayInputHorizontally.Location = new System.Drawing.Point(3, 54);
			this.chkDisplayInputHorizontally.Name = "chkDisplayInputHorizontally";
			this.chkDisplayInputHorizontally.Size = new System.Drawing.Size(115, 17);
			this.chkDisplayInputHorizontally.TabIndex = 1;
			this.chkDisplayInputHorizontally.Text = "Display horizontally";
			this.chkDisplayInputHorizontally.UseVisualStyleBackColor = true;
			// 
			// flowLayoutPanel3
			// 
			this.flowLayoutPanel3.Controls.Add(this.lblDisplayPosition);
			this.flowLayoutPanel3.Controls.Add(this.cboDisplayInputPosition);
			this.flowLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
			this.flowLayoutPanel3.Location = new System.Drawing.Point(0, 24);
			this.flowLayoutPanel3.Margin = new System.Windows.Forms.Padding(0);
			this.flowLayoutPanel3.Name = "flowLayoutPanel3";
			this.flowLayoutPanel3.Size = new System.Drawing.Size(350, 27);
			this.flowLayoutPanel3.TabIndex = 2;
			// 
			// lblDisplayPosition
			// 
			this.lblDisplayPosition.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.lblDisplayPosition.AutoSize = true;
			this.lblDisplayPosition.Location = new System.Drawing.Point(3, 7);
			this.lblDisplayPosition.Name = "lblDisplayPosition";
			this.lblDisplayPosition.Size = new System.Drawing.Size(84, 13);
			this.lblDisplayPosition.TabIndex = 0;
			this.lblDisplayPosition.Text = "Display Position:";
			// 
			// cboDisplayInputPosition
			// 
			this.cboDisplayInputPosition.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cboDisplayInputPosition.FormattingEnabled = true;
			this.cboDisplayInputPosition.Location = new System.Drawing.Point(93, 3);
			this.cboDisplayInputPosition.Name = "cboDisplayInputPosition";
			this.cboDisplayInputPosition.Size = new System.Drawing.Size(121, 21);
			this.cboDisplayInputPosition.TabIndex = 1;
			// 
			// frmInputConfig
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(370, 280);
			this.Controls.Add(this.tabMain);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "frmInputConfig";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Input Settings";
			this.Controls.SetChildIndex(this.baseConfigPanel, 0);
			this.Controls.SetChildIndex(this.tabMain, 0);
			this.tabMain.ResumeLayout(false);
			this.tpgControllers.ResumeLayout(false);
			this.tableLayoutPanel1.ResumeLayout(false);
			this.tableLayoutPanel1.PerformLayout();
			this.tpgAdvanced.ResumeLayout(false);
			this.tableLayoutPanel2.ResumeLayout(false);
			this.grpDisplayInput.ResumeLayout(false);
			this.tableLayoutPanel3.ResumeLayout(false);
			this.tableLayoutPanel3.PerformLayout();
			this.flowLayoutPanel2.ResumeLayout(false);
			this.flowLayoutPanel2.PerformLayout();
			this.flowLayoutPanel3.ResumeLayout(false);
			this.flowLayoutPanel3.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.TabControl tabMain;
		private System.Windows.Forms.TabPage tpgControllers;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
		private System.Windows.Forms.Label lblPlayer1;
		private System.Windows.Forms.Label lblPlayer2;
		private System.Windows.Forms.Label lblPlayer3;
		private System.Windows.Forms.Label lblPlayer4;
		private System.Windows.Forms.ComboBox cboPlayer1;
		private System.Windows.Forms.ComboBox cboPlayer2;
		private System.Windows.Forms.Button btnSetupP1;
		private System.Windows.Forms.Button btnSetupP2;
		private System.Windows.Forms.Label lblNesType;
		private System.Windows.Forms.ComboBox cboConsoleType;
		private System.Windows.Forms.Label lblExpansionPort;
		private System.Windows.Forms.ComboBox cboExpansionPort;
		private System.Windows.Forms.CheckBox chkFourScore;
		private System.Windows.Forms.Button btnSetupP3;
		private System.Windows.Forms.Button btnSetupP4;
		private System.Windows.Forms.ComboBox cboPlayer3;
		private System.Windows.Forms.ComboBox cboPlayer4;
		private System.Windows.Forms.CheckBox chkAutoConfigureInput;
		private System.Windows.Forms.TabPage tpgAdvanced;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
		private System.Windows.Forms.GroupBox grpDisplayInput;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
		private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
		private System.Windows.Forms.CheckBox chkDisplayPort1;
		private System.Windows.Forms.CheckBox chkDisplayPort2;
		private System.Windows.Forms.CheckBox chkDisplayPort3;
		private System.Windows.Forms.CheckBox chkDisplayPort4;
		private System.Windows.Forms.CheckBox chkDisplayInputHorizontally;
		private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
		private System.Windows.Forms.Label lblDisplayPosition;
		private System.Windows.Forms.ComboBox cboDisplayInputPosition;
	}
}