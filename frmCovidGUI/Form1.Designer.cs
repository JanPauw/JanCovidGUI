
namespace frmCovidGUI
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblMainTitle = new System.Windows.Forms.Label();
            this.pnlAddHospital = new System.Windows.Forms.Panel();
            this.cbxType = new System.Windows.Forms.ComboBox();
            this.btnAddHospital = new System.Windows.Forms.Button();
            this.lblHospitalName = new System.Windows.Forms.Label();
            this.edtHosNameInput = new System.Windows.Forms.TextBox();
            this.lblHopitalType = new System.Windows.Forms.Label();
            this.lblHospitalAddress = new System.Windows.Forms.Label();
            this.edtHosProvinceInput = new System.Windows.Forms.TextBox();
            this.edtHosAddressInput = new System.Windows.Forms.TextBox();
            this.lblHospitalProvince = new System.Windows.Forms.Label();
            this.pnlAddPatient = new System.Windows.Forms.Panel();
            this.btnAddPatient = new System.Windows.Forms.Button();
            this.cbxHadCovid = new System.Windows.Forms.CheckBox();
            this.edtBloodType = new System.Windows.Forms.TextBox();
            this.edtVaccine = new System.Windows.Forms.TextBox();
            this.edtAllergies = new System.Windows.Forms.TextBox();
            this.edtRefDoc = new System.Windows.Forms.TextBox();
            this.lblBloodType = new System.Windows.Forms.Label();
            this.lblVaccine = new System.Windows.Forms.Label();
            this.lblAllergies = new System.Windows.Forms.Label();
            this.lblRefDoc = new System.Windows.Forms.Label();
            this.lblMedAid = new System.Windows.Forms.Label();
            this.lblPID = new System.Windows.Forms.Label();
            this.edtMedAid = new System.Windows.Forms.TextBox();
            this.edtPID = new System.Windows.Forms.TextBox();
            this.edtSurname = new System.Windows.Forms.TextBox();
            this.edtPName = new System.Windows.Forms.TextBox();
            this.lblPName = new System.Windows.Forms.Label();
            this.lblPSurname = new System.Windows.Forms.Label();
            this.edtHospitalInfo = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.edtHosTypeOutput = new System.Windows.Forms.TextBox();
            this.lblPatientInfo = new System.Windows.Forms.Label();
            this.edtHosNameOutput = new System.Windows.Forms.TextBox();
            this.lbxPatientInfo = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.edtHosAddressOutput = new System.Windows.Forms.TextBox();
            this.edtHosProvinceOutput = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.pnlAddHospital.SuspendLayout();
            this.pnlAddPatient.SuspendLayout();
            this.edtHospitalInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblMainTitle
            // 
            this.lblMainTitle.AutoSize = true;
            this.lblMainTitle.Location = new System.Drawing.Point(12, 9);
            this.lblMainTitle.Name = "lblMainTitle";
            this.lblMainTitle.Size = new System.Drawing.Size(138, 15);
            this.lblMainTitle.TabIndex = 0;
            this.lblMainTitle.Text = "Covid-19 Vaccine Tracker";
            // 
            // pnlAddHospital
            // 
            this.pnlAddHospital.Controls.Add(this.cbxType);
            this.pnlAddHospital.Controls.Add(this.btnAddHospital);
            this.pnlAddHospital.Controls.Add(this.lblHospitalName);
            this.pnlAddHospital.Controls.Add(this.edtHosNameInput);
            this.pnlAddHospital.Controls.Add(this.lblHopitalType);
            this.pnlAddHospital.Controls.Add(this.lblHospitalAddress);
            this.pnlAddHospital.Controls.Add(this.edtHosProvinceInput);
            this.pnlAddHospital.Controls.Add(this.edtHosAddressInput);
            this.pnlAddHospital.Controls.Add(this.lblHospitalProvince);
            this.pnlAddHospital.Location = new System.Drawing.Point(12, 27);
            this.pnlAddHospital.Name = "pnlAddHospital";
            this.pnlAddHospital.Size = new System.Drawing.Size(320, 224);
            this.pnlAddHospital.TabIndex = 1;
            // 
            // cbxType
            // 
            this.cbxType.FormattingEnabled = true;
            this.cbxType.Items.AddRange(new object[] {
            "Private",
            "Public"});
            this.cbxType.Location = new System.Drawing.Point(10, 163);
            this.cbxType.Name = "cbxType";
            this.cbxType.Size = new System.Drawing.Size(301, 23);
            this.cbxType.TabIndex = 10;
            // 
            // btnAddHospital
            // 
            this.btnAddHospital.Location = new System.Drawing.Point(203, 192);
            this.btnAddHospital.Name = "btnAddHospital";
            this.btnAddHospital.Size = new System.Drawing.Size(108, 23);
            this.btnAddHospital.TabIndex = 8;
            this.btnAddHospital.Text = "Add Hospital";
            this.btnAddHospital.UseVisualStyleBackColor = true;
            this.btnAddHospital.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblHospitalName
            // 
            this.lblHospitalName.AutoSize = true;
            this.lblHospitalName.Location = new System.Drawing.Point(10, 13);
            this.lblHospitalName.Name = "lblHospitalName";
            this.lblHospitalName.Size = new System.Drawing.Size(86, 15);
            this.lblHospitalName.TabIndex = 1;
            this.lblHospitalName.Text = "Hospital Name";
            // 
            // edtHosNameInput
            // 
            this.edtHosNameInput.Location = new System.Drawing.Point(10, 31);
            this.edtHosNameInput.Name = "edtHosNameInput";
            this.edtHosNameInput.Size = new System.Drawing.Size(301, 23);
            this.edtHosNameInput.TabIndex = 3;
            // 
            // lblHopitalType
            // 
            this.lblHopitalType.AutoSize = true;
            this.lblHopitalType.Location = new System.Drawing.Point(10, 145);
            this.lblHopitalType.Name = "lblHopitalType";
            this.lblHopitalType.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblHopitalType.Size = new System.Drawing.Size(78, 15);
            this.lblHopitalType.TabIndex = 6;
            this.lblHopitalType.Text = "Hospital Type";
            this.lblHopitalType.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblHospitalAddress
            // 
            this.lblHospitalAddress.AutoSize = true;
            this.lblHospitalAddress.Location = new System.Drawing.Point(10, 57);
            this.lblHospitalAddress.Name = "lblHospitalAddress";
            this.lblHospitalAddress.Size = new System.Drawing.Size(96, 15);
            this.lblHospitalAddress.TabIndex = 4;
            this.lblHospitalAddress.Text = "Hospital Address";
            // 
            // edtHosProvinceInput
            // 
            this.edtHosProvinceInput.Location = new System.Drawing.Point(10, 119);
            this.edtHosProvinceInput.Name = "edtHosProvinceInput";
            this.edtHosProvinceInput.Size = new System.Drawing.Size(301, 23);
            this.edtHosProvinceInput.TabIndex = 7;
            // 
            // edtHosAddressInput
            // 
            this.edtHosAddressInput.Location = new System.Drawing.Point(10, 75);
            this.edtHosAddressInput.Name = "edtHosAddressInput";
            this.edtHosAddressInput.Size = new System.Drawing.Size(301, 23);
            this.edtHosAddressInput.TabIndex = 5;
            // 
            // lblHospitalProvince
            // 
            this.lblHospitalProvince.AutoSize = true;
            this.lblHospitalProvince.Location = new System.Drawing.Point(10, 101);
            this.lblHospitalProvince.Name = "lblHospitalProvince";
            this.lblHospitalProvince.Size = new System.Drawing.Size(100, 15);
            this.lblHospitalProvince.TabIndex = 6;
            this.lblHospitalProvince.Text = "Hospital Province";
            this.lblHospitalProvince.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pnlAddPatient
            // 
            this.pnlAddPatient.Controls.Add(this.btnAddPatient);
            this.pnlAddPatient.Controls.Add(this.cbxHadCovid);
            this.pnlAddPatient.Controls.Add(this.edtBloodType);
            this.pnlAddPatient.Controls.Add(this.edtVaccine);
            this.pnlAddPatient.Controls.Add(this.edtAllergies);
            this.pnlAddPatient.Controls.Add(this.edtRefDoc);
            this.pnlAddPatient.Controls.Add(this.lblBloodType);
            this.pnlAddPatient.Controls.Add(this.lblVaccine);
            this.pnlAddPatient.Controls.Add(this.lblAllergies);
            this.pnlAddPatient.Controls.Add(this.lblRefDoc);
            this.pnlAddPatient.Controls.Add(this.lblMedAid);
            this.pnlAddPatient.Controls.Add(this.lblPID);
            this.pnlAddPatient.Controls.Add(this.edtMedAid);
            this.pnlAddPatient.Controls.Add(this.edtPID);
            this.pnlAddPatient.Controls.Add(this.edtSurname);
            this.pnlAddPatient.Controls.Add(this.edtPName);
            this.pnlAddPatient.Controls.Add(this.lblPName);
            this.pnlAddPatient.Controls.Add(this.lblPSurname);
            this.pnlAddPatient.Location = new System.Drawing.Point(12, 257);
            this.pnlAddPatient.Name = "pnlAddPatient";
            this.pnlAddPatient.Size = new System.Drawing.Size(320, 224);
            this.pnlAddPatient.TabIndex = 2;
            this.pnlAddPatient.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // btnAddPatient
            // 
            this.btnAddPatient.Location = new System.Drawing.Point(203, 189);
            this.btnAddPatient.Name = "btnAddPatient";
            this.btnAddPatient.Size = new System.Drawing.Size(108, 23);
            this.btnAddPatient.TabIndex = 5;
            this.btnAddPatient.Text = "Add Patient";
            this.btnAddPatient.UseVisualStyleBackColor = true;
            this.btnAddPatient.Click += new System.EventHandler(this.btnAddPatient_Click);
            // 
            // cbxHadCovid
            // 
            this.cbxHadCovid.AutoSize = true;
            this.cbxHadCovid.Location = new System.Drawing.Point(10, 189);
            this.cbxHadCovid.Name = "cbxHadCovid";
            this.cbxHadCovid.Size = new System.Drawing.Size(137, 19);
            this.cbxHadCovid.TabIndex = 4;
            this.cbxHadCovid.Text = "Patient had Covid-19";
            this.cbxHadCovid.UseVisualStyleBackColor = true;
            // 
            // edtBloodType
            // 
            this.edtBloodType.Location = new System.Drawing.Point(161, 116);
            this.edtBloodType.Name = "edtBloodType";
            this.edtBloodType.Size = new System.Drawing.Size(150, 23);
            this.edtBloodType.TabIndex = 3;
            // 
            // edtVaccine
            // 
            this.edtVaccine.Location = new System.Drawing.Point(161, 160);
            this.edtVaccine.Name = "edtVaccine";
            this.edtVaccine.Size = new System.Drawing.Size(150, 23);
            this.edtVaccine.TabIndex = 3;
            // 
            // edtAllergies
            // 
            this.edtAllergies.Location = new System.Drawing.Point(10, 160);
            this.edtAllergies.Name = "edtAllergies";
            this.edtAllergies.Size = new System.Drawing.Size(150, 23);
            this.edtAllergies.TabIndex = 3;
            // 
            // edtRefDoc
            // 
            this.edtRefDoc.Location = new System.Drawing.Point(10, 116);
            this.edtRefDoc.Name = "edtRefDoc";
            this.edtRefDoc.Size = new System.Drawing.Size(150, 23);
            this.edtRefDoc.TabIndex = 3;
            // 
            // lblBloodType
            // 
            this.lblBloodType.AutoSize = true;
            this.lblBloodType.Location = new System.Drawing.Point(161, 98);
            this.lblBloodType.Name = "lblBloodType";
            this.lblBloodType.Size = new System.Drawing.Size(65, 15);
            this.lblBloodType.TabIndex = 2;
            this.lblBloodType.Text = "Blood Type";
            // 
            // lblVaccine
            // 
            this.lblVaccine.AutoSize = true;
            this.lblVaccine.Location = new System.Drawing.Point(161, 142);
            this.lblVaccine.Name = "lblVaccine";
            this.lblVaccine.Size = new System.Drawing.Size(47, 15);
            this.lblVaccine.TabIndex = 2;
            this.lblVaccine.Text = "Vaccine";
            // 
            // lblAllergies
            // 
            this.lblAllergies.AutoSize = true;
            this.lblAllergies.Location = new System.Drawing.Point(10, 142);
            this.lblAllergies.Name = "lblAllergies";
            this.lblAllergies.Size = new System.Drawing.Size(52, 15);
            this.lblAllergies.TabIndex = 2;
            this.lblAllergies.Text = "Allergies";
            // 
            // lblRefDoc
            // 
            this.lblRefDoc.AutoSize = true;
            this.lblRefDoc.Location = new System.Drawing.Point(10, 98);
            this.lblRefDoc.Name = "lblRefDoc";
            this.lblRefDoc.Size = new System.Drawing.Size(94, 15);
            this.lblRefDoc.TabIndex = 2;
            this.lblRefDoc.Text = "Referring Doctor";
            // 
            // lblMedAid
            // 
            this.lblMedAid.AutoSize = true;
            this.lblMedAid.Location = new System.Drawing.Point(161, 54);
            this.lblMedAid.Name = "lblMedAid";
            this.lblMedAid.Size = new System.Drawing.Size(70, 15);
            this.lblMedAid.TabIndex = 2;
            this.lblMedAid.Text = "Medical Aid";
            // 
            // lblPID
            // 
            this.lblPID.AutoSize = true;
            this.lblPID.Location = new System.Drawing.Point(10, 54);
            this.lblPID.Name = "lblPID";
            this.lblPID.Size = new System.Drawing.Size(58, 15);
            this.lblPID.TabIndex = 2;
            this.lblPID.Text = "Patient ID";
            // 
            // edtMedAid
            // 
            this.edtMedAid.Location = new System.Drawing.Point(161, 72);
            this.edtMedAid.Name = "edtMedAid";
            this.edtMedAid.Size = new System.Drawing.Size(150, 23);
            this.edtMedAid.TabIndex = 1;
            // 
            // edtPID
            // 
            this.edtPID.Location = new System.Drawing.Point(10, 72);
            this.edtPID.Name = "edtPID";
            this.edtPID.Size = new System.Drawing.Size(150, 23);
            this.edtPID.TabIndex = 1;
            // 
            // edtSurname
            // 
            this.edtSurname.Location = new System.Drawing.Point(161, 28);
            this.edtSurname.Name = "edtSurname";
            this.edtSurname.Size = new System.Drawing.Size(150, 23);
            this.edtSurname.TabIndex = 1;
            // 
            // edtPName
            // 
            this.edtPName.Location = new System.Drawing.Point(10, 28);
            this.edtPName.Name = "edtPName";
            this.edtPName.Size = new System.Drawing.Size(150, 23);
            this.edtPName.TabIndex = 1;
            // 
            // lblPName
            // 
            this.lblPName.AutoSize = true;
            this.lblPName.Location = new System.Drawing.Point(10, 10);
            this.lblPName.Name = "lblPName";
            this.lblPName.Size = new System.Drawing.Size(79, 15);
            this.lblPName.TabIndex = 0;
            this.lblPName.Text = "Patient Name";
            // 
            // lblPSurname
            // 
            this.lblPSurname.AutoSize = true;
            this.lblPSurname.Location = new System.Drawing.Point(161, 10);
            this.lblPSurname.Name = "lblPSurname";
            this.lblPSurname.Size = new System.Drawing.Size(94, 15);
            this.lblPSurname.TabIndex = 0;
            this.lblPSurname.Text = "Patient Surname";
            // 
            // edtHospitalInfo
            // 
            this.edtHospitalInfo.Controls.Add(this.label5);
            this.edtHospitalInfo.Controls.Add(this.edtHosTypeOutput);
            this.edtHospitalInfo.Controls.Add(this.lblPatientInfo);
            this.edtHospitalInfo.Controls.Add(this.edtHosNameOutput);
            this.edtHospitalInfo.Controls.Add(this.lbxPatientInfo);
            this.edtHospitalInfo.Controls.Add(this.label4);
            this.edtHospitalInfo.Controls.Add(this.label1);
            this.edtHospitalInfo.Controls.Add(this.label3);
            this.edtHospitalInfo.Controls.Add(this.edtHosAddressOutput);
            this.edtHospitalInfo.Controls.Add(this.edtHosProvinceOutput);
            this.edtHospitalInfo.Location = new System.Drawing.Point(338, 27);
            this.edtHospitalInfo.Name = "edtHospitalInfo";
            this.edtHospitalInfo.Size = new System.Drawing.Size(320, 454);
            this.edtHospitalInfo.TabIndex = 3;
            this.edtHospitalInfo.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 13);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 15);
            this.label5.TabIndex = 1;
            this.label5.Text = "Hospital Name";
            // 
            // edtHosTypeOutput
            // 
            this.edtHosTypeOutput.Location = new System.Drawing.Point(9, 163);
            this.edtHosTypeOutput.Name = "edtHosTypeOutput";
            this.edtHosTypeOutput.ReadOnly = true;
            this.edtHosTypeOutput.Size = new System.Drawing.Size(301, 23);
            this.edtHosTypeOutput.TabIndex = 7;
            // 
            // lblPatientInfo
            // 
            this.lblPatientInfo.AutoSize = true;
            this.lblPatientInfo.Location = new System.Drawing.Point(9, 240);
            this.lblPatientInfo.Name = "lblPatientInfo";
            this.lblPatientInfo.Size = new System.Drawing.Size(115, 15);
            this.lblPatientInfo.TabIndex = 8;
            this.lblPatientInfo.Text = "Hospital Patient Info";
            // 
            // edtHosNameOutput
            // 
            this.edtHosNameOutput.Location = new System.Drawing.Point(9, 31);
            this.edtHosNameOutput.Name = "edtHosNameOutput";
            this.edtHosNameOutput.ReadOnly = true;
            this.edtHosNameOutput.Size = new System.Drawing.Size(301, 23);
            this.edtHosNameOutput.TabIndex = 3;
            // 
            // lbxPatientInfo
            // 
            this.lbxPatientInfo.FormattingEnabled = true;
            this.lbxPatientInfo.ItemHeight = 15;
            this.lbxPatientInfo.Location = new System.Drawing.Point(9, 258);
            this.lbxPatientInfo.Name = "lbxPatientInfo";
            this.lbxPatientInfo.Size = new System.Drawing.Size(301, 154);
            this.lbxPatientInfo.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 145);
            this.label4.Name = "label4";
            this.label4.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label4.Size = new System.Drawing.Size(78, 15);
            this.label4.TabIndex = 6;
            this.label4.Text = "Hospital Type";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 101);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 15);
            this.label1.TabIndex = 6;
            this.label1.Text = "Hospital Province";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Hospital Address";
            // 
            // edtHosAddressOutput
            // 
            this.edtHosAddressOutput.Location = new System.Drawing.Point(9, 75);
            this.edtHosAddressOutput.Name = "edtHosAddressOutput";
            this.edtHosAddressOutput.ReadOnly = true;
            this.edtHosAddressOutput.Size = new System.Drawing.Size(301, 23);
            this.edtHosAddressOutput.TabIndex = 5;
            // 
            // edtHosProvinceOutput
            // 
            this.edtHosProvinceOutput.Location = new System.Drawing.Point(9, 119);
            this.edtHosProvinceOutput.Name = "edtHosProvinceOutput";
            this.edtHosProvinceOutput.ReadOnly = true;
            this.edtHosProvinceOutput.Size = new System.Drawing.Size(301, 23);
            this.edtHosProvinceOutput.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 212);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 15);
            this.label2.TabIndex = 8;
            this.label2.Text = "Hospital Province";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(23, 230);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(301, 23);
            this.textBox3.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(674, 495);
            this.Controls.Add(this.edtHospitalInfo);
            this.Controls.Add(this.pnlAddPatient);
            this.Controls.Add(this.pnlAddHospital);
            this.Controls.Add(this.lblMainTitle);
            this.Name = "Form1";
            this.Text = "Form1";
            this.pnlAddHospital.ResumeLayout(false);
            this.pnlAddHospital.PerformLayout();
            this.pnlAddPatient.ResumeLayout(false);
            this.pnlAddPatient.PerformLayout();
            this.edtHospitalInfo.ResumeLayout(false);
            this.edtHospitalInfo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMainTitle;
        private System.Windows.Forms.Panel pnlAddHospital;
        private System.Windows.Forms.Button btnAddHospital;
        private System.Windows.Forms.Label lblHospitalName;
        private System.Windows.Forms.TextBox edtHosNameInput;
        private System.Windows.Forms.Label lblHopitalType;
        private System.Windows.Forms.Label lblHospitalAddress;
        private System.Windows.Forms.TextBox edtHosProvinceInput;
        private System.Windows.Forms.TextBox edtHosAddressInput;
        private System.Windows.Forms.Label lblHospitalProvince;
        private System.Windows.Forms.Panel pnlAddPatient;
        private System.Windows.Forms.Panel edtHospitalInfo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox edtHosTypeOutput;
        private System.Windows.Forms.Label lblPatientInfo;
        private System.Windows.Forms.TextBox edtHosNameOutput;
        private System.Windows.Forms.ListBox lbxPatientInfo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox edtHosAddressOutput;
        private System.Windows.Forms.TextBox edtHosProvinceOutput;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.ComboBox cbxType;
        private System.Windows.Forms.Label lblRefDoc;
        private System.Windows.Forms.Label lblPID;
        private System.Windows.Forms.TextBox edtPID;
        private System.Windows.Forms.TextBox edtSurname;
        private System.Windows.Forms.TextBox edtPName;
        private System.Windows.Forms.Label lblPName;
        private System.Windows.Forms.Label lblPSurname;
        private System.Windows.Forms.Label lblMedAid;
        private System.Windows.Forms.TextBox edtMedAid;
        private System.Windows.Forms.TextBox edtRefDoc;
        private System.Windows.Forms.TextBox edtBloodType;
        private System.Windows.Forms.Label lblBloodType;
        private System.Windows.Forms.TextBox edtVaccine;
        private System.Windows.Forms.TextBox edtAllergies;
        private System.Windows.Forms.Label lblVaccine;
        private System.Windows.Forms.Label lblAllergies;
        private System.Windows.Forms.CheckBox cbxHadCovid;
        private System.Windows.Forms.Button btnAddPatient;
    }
}

