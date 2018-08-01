﻿namespace Open_Miracle
{
    partial class frmCompanyCreation
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
            if (disposing && (components != null))
            {
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCompanyCreation));
      this.btnReset = new System.Windows.Forms.Button();
      this.btnSave = new System.Windows.Forms.Button();
      this.txtAddress = new System.Windows.Forms.TextBox();
      this.txtCompanyName = new System.Windows.Forms.TextBox();
      this.lblAddress = new System.Windows.Forms.Label();
      this.lblMailingName = new System.Windows.Forms.Label();
      this.lblCompanyName = new System.Windows.Forms.Label();
      this.txtMailingName = new System.Windows.Forms.TextBox();
      this.txtEmail = new System.Windows.Forms.TextBox();
      this.txtPhoneNo = new System.Windows.Forms.TextBox();
      this.lblMobile = new System.Windows.Forms.Label();
      this.lblPhoneNo = new System.Windows.Forms.Label();
      this.txtMobile = new System.Windows.Forms.TextBox();
      this.txtWeb = new System.Windows.Forms.TextBox();
      this.lblWeb = new System.Windows.Forms.Label();
      this.lblEmail = new System.Windows.Forms.Label();
      this.txtCountry = new System.Windows.Forms.TextBox();
      this.lblState = new System.Windows.Forms.Label();
      this.lblCountry = new System.Windows.Forms.Label();
      this.txtState = new System.Windows.Forms.TextBox();
      this.lblCurrency = new System.Windows.Forms.Label();
      this.lblPincode = new System.Windows.Forms.Label();
      this.lblBooksBegining = new System.Windows.Forms.Label();
      this.lblFinancialYearFrom = new System.Windows.Forms.Label();
      this.txtCstNo = new System.Windows.Forms.TextBox();
      this.txtTinNo = new System.Windows.Forms.TextBox();
      this.lblCstNo = new System.Windows.Forms.Label();
      this.lblTinNo = new System.Windows.Forms.Label();
      this.txtPanNo = new System.Windows.Forms.TextBox();
      this.lblPanNo = new System.Windows.Forms.Label();
      this.cmbCurrency = new System.Windows.Forms.ComboBox();
      this.pbxLogo = new System.Windows.Forms.PictureBox();
      this.btnBrowse = new System.Windows.Forms.Button();
      this.btnClear = new System.Windows.Forms.Button();
      this.txtPincode = new System.Windows.Forms.TextBox();
      this.btnClose = new System.Windows.Forms.Button();
      this.dtpFinancialYearFrom = new System.Windows.Forms.DateTimePicker();
      this.dtpBooksBegining = new System.Windows.Forms.DateTimePicker();
      this.ofdCompany = new System.Windows.Forms.OpenFileDialog();
      this.lblCompanyNameValidator = new System.Windows.Forms.Label();
      this.lblCurrencyValidator = new System.Windows.Forms.Label();
      this.txtFinancialYearFrom = new System.Windows.Forms.TextBox();
      this.txtBooksBegining = new System.Windows.Forms.TextBox();
      this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
      this.label1 = new System.Windows.Forms.Label();
      ((System.ComponentModel.ISupportInitialize)(this.pbxLogo)).BeginInit();
      this.SuspendLayout();
      // 
      // btnReset
      // 
      this.btnReset.BackColor = System.Drawing.Color.LightSteelBlue;
      this.btnReset.FlatAppearance.BorderSize = 0;
      this.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.btnReset.ForeColor = System.Drawing.Color.Black;
      this.btnReset.Location = new System.Drawing.Point(794, 562);
      this.btnReset.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
      this.btnReset.Name = "btnReset";
      this.btnReset.Size = new System.Drawing.Size(113, 33);
      this.btnReset.TabIndex = 24;
      this.btnReset.Text = "Reset";
      this.btnReset.UseVisualStyleBackColor = false;
      this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
      this.btnReset.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btnReset_KeyDown);
      // 
      // btnSave
      // 
      this.btnSave.BackColor = System.Drawing.Color.LightSteelBlue;
      this.btnSave.FlatAppearance.BorderSize = 0;
      this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.btnSave.ForeColor = System.Drawing.Color.Black;
      this.btnSave.Location = new System.Drawing.Point(672, 562);
      this.btnSave.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
      this.btnSave.Name = "btnSave";
      this.btnSave.Size = new System.Drawing.Size(113, 33);
      this.btnSave.TabIndex = 23;
      this.btnSave.Text = "Save";
      this.btnSave.UseVisualStyleBackColor = false;
      this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
      this.btnSave.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btnSave_KeyDown);
      // 
      // txtAddress
      // 
      this.txtAddress.Location = new System.Drawing.Point(165, 80);
      this.txtAddress.Margin = new System.Windows.Forms.Padding(7, 6, 7, 0);
      this.txtAddress.Multiline = true;
      this.txtAddress.Name = "txtAddress";
      this.txtAddress.Size = new System.Drawing.Size(852, 61);
      this.txtAddress.TabIndex = 3;
      this.txtAddress.Enter += new System.EventHandler(this.txtAddress_Enter);
      this.txtAddress.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtAddress_KeyDown);
      // 
      // txtCompanyName
      // 
      this.txtCompanyName.Location = new System.Drawing.Point(165, 18);
      this.txtCompanyName.Margin = new System.Windows.Forms.Padding(7, 6, 7, 0);
      this.txtCompanyName.Name = "txtCompanyName";
      this.txtCompanyName.Size = new System.Drawing.Size(852, 22);
      this.txtCompanyName.TabIndex = 1;
      this.txtCompanyName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCompanyName_KeyDown);
      // 
      // lblAddress
      // 
      this.lblAddress.AutoSize = true;
      this.lblAddress.ForeColor = System.Drawing.Color.Black;
      this.lblAddress.Location = new System.Drawing.Point(27, 79);
      this.lblAddress.Margin = new System.Windows.Forms.Padding(7, 6, 7, 0);
      this.lblAddress.Name = "lblAddress";
      this.lblAddress.Size = new System.Drawing.Size(60, 17);
      this.lblAddress.TabIndex = 37;
      this.lblAddress.Text = "Address";
      // 
      // lblMailingName
      // 
      this.lblMailingName.AutoSize = true;
      this.lblMailingName.ForeColor = System.Drawing.Color.Black;
      this.lblMailingName.Location = new System.Drawing.Point(27, 53);
      this.lblMailingName.Margin = new System.Windows.Forms.Padding(7, 6, 7, 0);
      this.lblMailingName.Name = "lblMailingName";
      this.lblMailingName.Size = new System.Drawing.Size(93, 17);
      this.lblMailingName.TabIndex = 36;
      this.lblMailingName.Text = "Mailing Name";
      // 
      // lblCompanyName
      // 
      this.lblCompanyName.AutoSize = true;
      this.lblCompanyName.ForeColor = System.Drawing.SystemColors.ControlText;
      this.lblCompanyName.Location = new System.Drawing.Point(27, 21);
      this.lblCompanyName.Margin = new System.Windows.Forms.Padding(7, 6, 7, 0);
      this.lblCompanyName.Name = "lblCompanyName";
      this.lblCompanyName.Size = new System.Drawing.Size(108, 17);
      this.lblCompanyName.TabIndex = 34;
      this.lblCompanyName.Text = "Company Name";
      // 
      // txtMailingName
      // 
      this.txtMailingName.Location = new System.Drawing.Point(165, 49);
      this.txtMailingName.Margin = new System.Windows.Forms.Padding(7, 6, 7, 0);
      this.txtMailingName.Name = "txtMailingName";
      this.txtMailingName.Size = new System.Drawing.Size(851, 22);
      this.txtMailingName.TabIndex = 2;
      this.txtMailingName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtMailingName_KeyDown);
      // 
      // txtEmail
      // 
      this.txtEmail.Location = new System.Drawing.Point(165, 178);
      this.txtEmail.Margin = new System.Windows.Forms.Padding(7, 6, 7, 0);
      this.txtEmail.Name = "txtEmail";
      this.txtEmail.Size = new System.Drawing.Size(311, 22);
      this.txtEmail.TabIndex = 5;
      this.txtEmail.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtEmail_KeyDown);
      // 
      // txtPhoneNo
      // 
      this.txtPhoneNo.Location = new System.Drawing.Point(165, 148);
      this.txtPhoneNo.Margin = new System.Windows.Forms.Padding(7, 6, 7, 0);
      this.txtPhoneNo.Name = "txtPhoneNo";
      this.txtPhoneNo.Size = new System.Drawing.Size(311, 22);
      this.txtPhoneNo.TabIndex = 4;
      this.txtPhoneNo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtPhoneNo_KeyDown);
      // 
      // lblMobile
      // 
      this.lblMobile.AutoSize = true;
      this.lblMobile.ForeColor = System.Drawing.Color.Black;
      this.lblMobile.Location = new System.Drawing.Point(27, 213);
      this.lblMobile.Margin = new System.Windows.Forms.Padding(7, 6, 7, 0);
      this.lblMobile.Name = "lblMobile";
      this.lblMobile.Size = new System.Drawing.Size(49, 17);
      this.lblMobile.TabIndex = 47;
      this.lblMobile.Text = "Mobile";
      // 
      // lblPhoneNo
      // 
      this.lblPhoneNo.AutoSize = true;
      this.lblPhoneNo.ForeColor = System.Drawing.Color.Black;
      this.lblPhoneNo.Location = new System.Drawing.Point(27, 151);
      this.lblPhoneNo.Margin = new System.Windows.Forms.Padding(7, 6, 7, 0);
      this.lblPhoneNo.Name = "lblPhoneNo";
      this.lblPhoneNo.Size = new System.Drawing.Size(75, 17);
      this.lblPhoneNo.TabIndex = 46;
      this.lblPhoneNo.Text = "Phone No.";
      // 
      // txtMobile
      // 
      this.txtMobile.Location = new System.Drawing.Point(165, 209);
      this.txtMobile.Margin = new System.Windows.Forms.Padding(7, 6, 7, 0);
      this.txtMobile.Name = "txtMobile";
      this.txtMobile.Size = new System.Drawing.Size(311, 22);
      this.txtMobile.TabIndex = 6;
      this.txtMobile.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtMobile_KeyDown);
      // 
      // txtWeb
      // 
      this.txtWeb.Location = new System.Drawing.Point(165, 240);
      this.txtWeb.Margin = new System.Windows.Forms.Padding(7, 6, 7, 0);
      this.txtWeb.Name = "txtWeb";
      this.txtWeb.Size = new System.Drawing.Size(311, 22);
      this.txtWeb.TabIndex = 7;
      this.txtWeb.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtWeb_KeyDown);
      // 
      // lblWeb
      // 
      this.lblWeb.AutoSize = true;
      this.lblWeb.ForeColor = System.Drawing.Color.Black;
      this.lblWeb.Location = new System.Drawing.Point(27, 244);
      this.lblWeb.Margin = new System.Windows.Forms.Padding(7, 6, 7, 0);
      this.lblWeb.Name = "lblWeb";
      this.lblWeb.Size = new System.Drawing.Size(37, 17);
      this.lblWeb.TabIndex = 51;
      this.lblWeb.Text = "Web";
      // 
      // lblEmail
      // 
      this.lblEmail.AutoSize = true;
      this.lblEmail.ForeColor = System.Drawing.Color.Black;
      this.lblEmail.Location = new System.Drawing.Point(27, 182);
      this.lblEmail.Margin = new System.Windows.Forms.Padding(7, 6, 7, 0);
      this.lblEmail.Name = "lblEmail";
      this.lblEmail.Size = new System.Drawing.Size(47, 17);
      this.lblEmail.TabIndex = 50;
      this.lblEmail.Text = "E-mail";
      // 
      // txtCountry
      // 
      this.txtCountry.Location = new System.Drawing.Point(165, 271);
      this.txtCountry.Margin = new System.Windows.Forms.Padding(7, 6, 7, 0);
      this.txtCountry.Name = "txtCountry";
      this.txtCountry.Size = new System.Drawing.Size(311, 22);
      this.txtCountry.TabIndex = 8;
      this.txtCountry.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCountry_KeyDown);
      // 
      // lblState
      // 
      this.lblState.AutoSize = true;
      this.lblState.ForeColor = System.Drawing.Color.Black;
      this.lblState.Location = new System.Drawing.Point(27, 305);
      this.lblState.Margin = new System.Windows.Forms.Padding(7, 6, 7, 0);
      this.lblState.Name = "lblState";
      this.lblState.Size = new System.Drawing.Size(41, 17);
      this.lblState.TabIndex = 55;
      this.lblState.Text = "State";
      // 
      // lblCountry
      // 
      this.lblCountry.AutoSize = true;
      this.lblCountry.ForeColor = System.Drawing.Color.Black;
      this.lblCountry.Location = new System.Drawing.Point(27, 274);
      this.lblCountry.Margin = new System.Windows.Forms.Padding(7, 6, 7, 0);
      this.lblCountry.Name = "lblCountry";
      this.lblCountry.Size = new System.Drawing.Size(57, 17);
      this.lblCountry.TabIndex = 54;
      this.lblCountry.Text = "Country";
      // 
      // txtState
      // 
      this.txtState.Location = new System.Drawing.Point(165, 302);
      this.txtState.Margin = new System.Windows.Forms.Padding(7, 6, 7, 0);
      this.txtState.Name = "txtState";
      this.txtState.Size = new System.Drawing.Size(311, 22);
      this.txtState.TabIndex = 9;
      this.txtState.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtState_KeyDown);
      // 
      // lblCurrency
      // 
      this.lblCurrency.AutoSize = true;
      this.lblCurrency.ForeColor = System.Drawing.Color.Black;
      this.lblCurrency.Location = new System.Drawing.Point(27, 368);
      this.lblCurrency.Margin = new System.Windows.Forms.Padding(7, 6, 7, 0);
      this.lblCurrency.Name = "lblCurrency";
      this.lblCurrency.Size = new System.Drawing.Size(65, 17);
      this.lblCurrency.TabIndex = 59;
      this.lblCurrency.Text = "Currency";
      // 
      // lblPincode
      // 
      this.lblPincode.AutoSize = true;
      this.lblPincode.ForeColor = System.Drawing.Color.Black;
      this.lblPincode.Location = new System.Drawing.Point(27, 336);
      this.lblPincode.Margin = new System.Windows.Forms.Padding(7, 6, 7, 0);
      this.lblPincode.Name = "lblPincode";
      this.lblPincode.Size = new System.Drawing.Size(59, 17);
      this.lblPincode.TabIndex = 58;
      this.lblPincode.Text = "Pincode";
      // 
      // lblBooksBegining
      // 
      this.lblBooksBegining.AutoSize = true;
      this.lblBooksBegining.ForeColor = System.Drawing.Color.Black;
      this.lblBooksBegining.Location = new System.Drawing.Point(27, 431);
      this.lblBooksBegining.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
      this.lblBooksBegining.Name = "lblBooksBegining";
      this.lblBooksBegining.Size = new System.Drawing.Size(142, 17);
      this.lblBooksBegining.TabIndex = 63;
      this.lblBooksBegining.Text = "Books Begining From";
      // 
      // lblFinancialYearFrom
      // 
      this.lblFinancialYearFrom.AutoSize = true;
      this.lblFinancialYearFrom.ForeColor = System.Drawing.Color.Black;
      this.lblFinancialYearFrom.Location = new System.Drawing.Point(27, 400);
      this.lblFinancialYearFrom.Margin = new System.Windows.Forms.Padding(7, 6, 7, 0);
      this.lblFinancialYearFrom.Name = "lblFinancialYearFrom";
      this.lblFinancialYearFrom.Size = new System.Drawing.Size(134, 17);
      this.lblFinancialYearFrom.TabIndex = 62;
      this.lblFinancialYearFrom.Text = "Financial Year From";
      // 
      // txtCstNo
      // 
      this.txtCstNo.Location = new System.Drawing.Point(165, 518);
      this.txtCstNo.Margin = new System.Windows.Forms.Padding(7, 6, 7, 0);
      this.txtCstNo.MaxLength = 25;
      this.txtCstNo.Name = "txtCstNo";
      this.txtCstNo.Size = new System.Drawing.Size(311, 22);
      this.txtCstNo.TabIndex = 16;
      this.txtCstNo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCstNo_KeyDown);
      // 
      // txtTinNo
      // 
      this.txtTinNo.Location = new System.Drawing.Point(165, 457);
      this.txtTinNo.Margin = new System.Windows.Forms.Padding(7, 6, 7, 0);
      this.txtTinNo.MaxLength = 20;
      this.txtTinNo.Name = "txtTinNo";
      this.txtTinNo.Size = new System.Drawing.Size(311, 22);
      this.txtTinNo.TabIndex = 14;
      this.txtTinNo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtTinNo_KeyDown);
      // 
      // lblCstNo
      // 
      this.lblCstNo.AutoSize = true;
      this.lblCstNo.ForeColor = System.Drawing.Color.Black;
      this.lblCstNo.Location = new System.Drawing.Point(27, 523);
      this.lblCstNo.Margin = new System.Windows.Forms.Padding(7, 6, 7, 0);
      this.lblCstNo.Name = "lblCstNo";
      this.lblCstNo.Size = new System.Drawing.Size(61, 17);
      this.lblCstNo.TabIndex = 67;
      this.lblCstNo.Text = "CST No.";
      // 
      // lblTinNo
      // 
      this.lblTinNo.AutoSize = true;
      this.lblTinNo.ForeColor = System.Drawing.Color.Black;
      this.lblTinNo.Location = new System.Drawing.Point(27, 462);
      this.lblTinNo.Margin = new System.Windows.Forms.Padding(7, 6, 7, 0);
      this.lblTinNo.Name = "lblTinNo";
      this.lblTinNo.Size = new System.Drawing.Size(56, 17);
      this.lblTinNo.TabIndex = 66;
      this.lblTinNo.Text = "TIN No.";
      // 
      // txtPanNo
      // 
      this.txtPanNo.Location = new System.Drawing.Point(165, 487);
      this.txtPanNo.Margin = new System.Windows.Forms.Padding(7, 6, 7, 0);
      this.txtPanNo.MaxLength = 15;
      this.txtPanNo.Name = "txtPanNo";
      this.txtPanNo.Size = new System.Drawing.Size(311, 22);
      this.txtPanNo.TabIndex = 15;
      this.txtPanNo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtPanNo_KeyDown);
      // 
      // lblPanNo
      // 
      this.lblPanNo.AutoSize = true;
      this.lblPanNo.ForeColor = System.Drawing.Color.Black;
      this.lblPanNo.Location = new System.Drawing.Point(27, 492);
      this.lblPanNo.Margin = new System.Windows.Forms.Padding(7, 6, 7, 0);
      this.lblPanNo.Name = "lblPanNo";
      this.lblPanNo.Size = new System.Drawing.Size(62, 17);
      this.lblPanNo.TabIndex = 70;
      this.lblPanNo.Text = "PAN No.";
      // 
      // cmbCurrency
      // 
      this.cmbCurrency.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.cmbCurrency.FormattingEnabled = true;
      this.cmbCurrency.Location = new System.Drawing.Point(165, 363);
      this.cmbCurrency.Margin = new System.Windows.Forms.Padding(7, 6, 7, 0);
      this.cmbCurrency.Name = "cmbCurrency";
      this.cmbCurrency.Size = new System.Drawing.Size(311, 24);
      this.cmbCurrency.TabIndex = 11;
      this.cmbCurrency.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbCurrency_KeyDown);
      // 
      // pbxLogo
      // 
      this.pbxLogo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.pbxLogo.Location = new System.Drawing.Point(713, 187);
      this.pbxLogo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
      this.pbxLogo.Name = "pbxLogo";
      this.pbxLogo.Size = new System.Drawing.Size(149, 119);
      this.pbxLogo.TabIndex = 77;
      this.pbxLogo.TabStop = false;
      // 
      // btnBrowse
      // 
      this.btnBrowse.BackColor = System.Drawing.Color.LightSteelBlue;
      this.btnBrowse.FlatAppearance.BorderSize = 0;
      this.btnBrowse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.btnBrowse.ForeColor = System.Drawing.Color.Black;
      this.btnBrowse.Location = new System.Drawing.Point(713, 314);
      this.btnBrowse.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
      this.btnBrowse.Name = "btnBrowse";
      this.btnBrowse.Size = new System.Drawing.Size(69, 28);
      this.btnBrowse.TabIndex = 17;
      this.btnBrowse.Text = "Browse";
      this.btnBrowse.UseVisualStyleBackColor = false;
      this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
      // 
      // btnClear
      // 
      this.btnClear.BackColor = System.Drawing.Color.LightSteelBlue;
      this.btnClear.FlatAppearance.BorderSize = 0;
      this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.btnClear.ForeColor = System.Drawing.Color.Black;
      this.btnClear.Location = new System.Drawing.Point(792, 314);
      this.btnClear.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
      this.btnClear.Name = "btnClear";
      this.btnClear.Size = new System.Drawing.Size(71, 28);
      this.btnClear.TabIndex = 18;
      this.btnClear.Text = "Clear";
      this.btnClear.UseVisualStyleBackColor = false;
      this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
      // 
      // txtPincode
      // 
      this.txtPincode.Location = new System.Drawing.Point(165, 332);
      this.txtPincode.Margin = new System.Windows.Forms.Padding(7, 6, 7, 0);
      this.txtPincode.MaxLength = 10;
      this.txtPincode.Name = "txtPincode";
      this.txtPincode.Size = new System.Drawing.Size(311, 22);
      this.txtPincode.TabIndex = 10;
      this.txtPincode.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtPincode_KeyDown);
      // 
      // btnClose
      // 
      this.btnClose.BackColor = System.Drawing.Color.LightSteelBlue;
      this.btnClose.FlatAppearance.BorderSize = 0;
      this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.btnClose.ForeColor = System.Drawing.Color.Black;
      this.btnClose.Location = new System.Drawing.Point(915, 562);
      this.btnClose.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
      this.btnClose.Name = "btnClose";
      this.btnClose.Size = new System.Drawing.Size(113, 33);
      this.btnClose.TabIndex = 26;
      this.btnClose.Text = "Close";
      this.btnClose.UseVisualStyleBackColor = false;
      this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
      // 
      // dtpFinancialYearFrom
      // 
      this.dtpFinancialYearFrom.CustomFormat = "dd-MMM-yyyy";
      this.dtpFinancialYearFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
      this.dtpFinancialYearFrom.Location = new System.Drawing.Point(451, 395);
      this.dtpFinancialYearFrom.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
      this.dtpFinancialYearFrom.Name = "dtpFinancialYearFrom";
      this.dtpFinancialYearFrom.Size = new System.Drawing.Size(25, 22);
      this.dtpFinancialYearFrom.TabIndex = 12;
      this.dtpFinancialYearFrom.TabStop = false;
      this.dtpFinancialYearFrom.ValueChanged += new System.EventHandler(this.dtpFinancialYearFrom_ValueChanged);
      // 
      // dtpBooksBegining
      // 
      this.dtpBooksBegining.CustomFormat = "dd-MMM-yyyy";
      this.dtpBooksBegining.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
      this.dtpBooksBegining.Location = new System.Drawing.Point(451, 427);
      this.dtpBooksBegining.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
      this.dtpBooksBegining.Name = "dtpBooksBegining";
      this.dtpBooksBegining.Size = new System.Drawing.Size(25, 22);
      this.dtpBooksBegining.TabIndex = 13;
      this.dtpBooksBegining.TabStop = false;
      this.dtpBooksBegining.ValueChanged += new System.EventHandler(this.dtpBooksBegining_ValueChanged);
      // 
      // ofdCompany
      // 
      this.ofdCompany.FileName = "ofdCompany";
      // 
      // lblCompanyNameValidator
      // 
      this.lblCompanyNameValidator.AutoSize = true;
      this.lblCompanyNameValidator.ForeColor = System.Drawing.Color.Red;
      this.lblCompanyNameValidator.Location = new System.Drawing.Point(1052, 44);
      this.lblCompanyNameValidator.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
      this.lblCompanyNameValidator.Name = "lblCompanyNameValidator";
      this.lblCompanyNameValidator.Size = new System.Drawing.Size(13, 17);
      this.lblCompanyNameValidator.TabIndex = 117;
      this.lblCompanyNameValidator.Text = "*";
      // 
      // lblCurrencyValidator
      // 
      this.lblCurrencyValidator.AutoSize = true;
      this.lblCurrencyValidator.ForeColor = System.Drawing.Color.Red;
      this.lblCurrencyValidator.Location = new System.Drawing.Point(479, 369);
      this.lblCurrencyValidator.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
      this.lblCurrencyValidator.Name = "lblCurrencyValidator";
      this.lblCurrencyValidator.Size = new System.Drawing.Size(13, 17);
      this.lblCurrencyValidator.TabIndex = 118;
      this.lblCurrencyValidator.Text = "*";
      // 
      // txtFinancialYearFrom
      // 
      this.txtFinancialYearFrom.Location = new System.Drawing.Point(165, 395);
      this.txtFinancialYearFrom.Margin = new System.Windows.Forms.Padding(7, 6, 7, 0);
      this.txtFinancialYearFrom.Name = "txtFinancialYearFrom";
      this.txtFinancialYearFrom.Size = new System.Drawing.Size(285, 22);
      this.txtFinancialYearFrom.TabIndex = 12;
      this.txtFinancialYearFrom.TextChanged += new System.EventHandler(this.txtFinancialYearFrom_TextChanged);
      this.txtFinancialYearFrom.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtFinancialyearFrom_KeyDown);
      this.txtFinancialYearFrom.Leave += new System.EventHandler(this.txtFinancialyearFrom_Leave);
      // 
      // txtBooksBegining
      // 
      this.txtBooksBegining.Location = new System.Drawing.Point(165, 427);
      this.txtBooksBegining.Margin = new System.Windows.Forms.Padding(7, 6, 7, 0);
      this.txtBooksBegining.Name = "txtBooksBegining";
      this.txtBooksBegining.Size = new System.Drawing.Size(285, 22);
      this.txtBooksBegining.TabIndex = 13;
      this.txtBooksBegining.TextChanged += new System.EventHandler(this.txtBooksBegining_TextChanged);
      this.txtBooksBegining.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtBooksBegining_KeyDown);
      this.txtBooksBegining.Leave += new System.EventHandler(this.txtBooksBegining_Leave);
      // 
      // backgroundWorker1
      // 
      this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
      this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.ForeColor = System.Drawing.Color.Red;
      this.label1.Location = new System.Drawing.Point(1019, 27);
      this.label1.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(13, 17);
      this.label1.TabIndex = 120;
      this.label1.Text = "*";
      // 
      // frmCompanyCreation
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackColor = System.Drawing.Color.Gainsboro;
      this.ClientSize = new System.Drawing.Size(1056, 615);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.txtBooksBegining);
      this.Controls.Add(this.txtFinancialYearFrom);
      this.Controls.Add(this.lblCurrencyValidator);
      this.Controls.Add(this.lblCompanyNameValidator);
      this.Controls.Add(this.dtpBooksBegining);
      this.Controls.Add(this.dtpFinancialYearFrom);
      this.Controls.Add(this.btnClose);
      this.Controls.Add(this.txtPincode);
      this.Controls.Add(this.btnClear);
      this.Controls.Add(this.btnBrowse);
      this.Controls.Add(this.pbxLogo);
      this.Controls.Add(this.cmbCurrency);
      this.Controls.Add(this.txtPanNo);
      this.Controls.Add(this.lblPanNo);
      this.Controls.Add(this.txtCstNo);
      this.Controls.Add(this.txtTinNo);
      this.Controls.Add(this.lblCstNo);
      this.Controls.Add(this.lblTinNo);
      this.Controls.Add(this.lblBooksBegining);
      this.Controls.Add(this.lblFinancialYearFrom);
      this.Controls.Add(this.txtState);
      this.Controls.Add(this.lblCurrency);
      this.Controls.Add(this.lblPincode);
      this.Controls.Add(this.txtCountry);
      this.Controls.Add(this.lblState);
      this.Controls.Add(this.lblCountry);
      this.Controls.Add(this.txtMobile);
      this.Controls.Add(this.txtWeb);
      this.Controls.Add(this.lblWeb);
      this.Controls.Add(this.lblEmail);
      this.Controls.Add(this.txtEmail);
      this.Controls.Add(this.txtPhoneNo);
      this.Controls.Add(this.lblMobile);
      this.Controls.Add(this.lblPhoneNo);
      this.Controls.Add(this.txtMailingName);
      this.Controls.Add(this.btnReset);
      this.Controls.Add(this.btnSave);
      this.Controls.Add(this.txtAddress);
      this.Controls.Add(this.txtCompanyName);
      this.Controls.Add(this.lblAddress);
      this.Controls.Add(this.lblMailingName);
      this.Controls.Add(this.lblCompanyName);
      this.ForeColor = System.Drawing.Color.Black;
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
      this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
      this.KeyPreview = true;
      this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
      this.MaximizeBox = false;
      this.Name = "frmCompanyCreation";
      this.Padding = new System.Windows.Forms.Padding(20, 12, 20, 12);
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "Company Setup";
      this.Load += new System.EventHandler(this.frmCompanyCreation_Load);
      this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmCompanyCreation_KeyDown);
      ((System.ComponentModel.ISupportInitialize)(this.pbxLogo)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtCompanyName;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Label lblMailingName;
        private System.Windows.Forms.Label lblCompanyName;
        private System.Windows.Forms.TextBox txtMailingName;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtPhoneNo;
        private System.Windows.Forms.Label lblMobile;
        private System.Windows.Forms.Label lblPhoneNo;
        private System.Windows.Forms.TextBox txtMobile;
        private System.Windows.Forms.TextBox txtWeb;
        private System.Windows.Forms.Label lblWeb;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtCountry;
        private System.Windows.Forms.Label lblState;
        private System.Windows.Forms.Label lblCountry;
        private System.Windows.Forms.TextBox txtState;
        private System.Windows.Forms.Label lblCurrency;
        private System.Windows.Forms.Label lblPincode;
        private System.Windows.Forms.Label lblBooksBegining;
        private System.Windows.Forms.Label lblFinancialYearFrom;
        private System.Windows.Forms.TextBox txtCstNo;
        private System.Windows.Forms.TextBox txtTinNo;
        private System.Windows.Forms.Label lblCstNo;
        private System.Windows.Forms.Label lblTinNo;
        private System.Windows.Forms.TextBox txtPanNo;
        private System.Windows.Forms.Label lblPanNo;
        private System.Windows.Forms.ComboBox cmbCurrency;
        private System.Windows.Forms.PictureBox pbxLogo;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.TextBox txtPincode;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.DateTimePicker dtpFinancialYearFrom;
        private System.Windows.Forms.DateTimePicker dtpBooksBegining;
        private System.Windows.Forms.OpenFileDialog ofdCompany;
        private System.Windows.Forms.Label lblCompanyNameValidator;
        private System.Windows.Forms.Label lblCurrencyValidator;
        private System.Windows.Forms.TextBox txtFinancialYearFrom;
        private System.Windows.Forms.TextBox txtBooksBegining;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label label1;
    }
}