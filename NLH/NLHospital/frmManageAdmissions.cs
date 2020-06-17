using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using NLHospitalLibrary;
using NLHBaseWindow;

namespace NLHospital
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class frmManageAdmissions : NLHBase
	{
		private System.Windows.Forms.Button btnQuit;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		DataSet m_oDS = new DataSet();
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Label lblName;
		private System.Windows.Forms.Label lblPatient;
		private System.Windows.Forms.Label lblHealthNumber;
		private System.Windows.Forms.TextBox txtPatName;
		private System.Windows.Forms.TextBox txtPatientID;
		private System.Windows.Forms.TextBox txtAdmissionID;
		private System.Windows.Forms.Button btnAdd;
        private Label label8;
        private TextBox txtInsurCompany;
        private Label label4;
        private TextBox txtInsuranceNumber;
        private DateTimePicker dtpAdmission;
        private Label label1;
        private Panel panel2;
        private Panel panel5;
        private CheckBox cbPhone;
        private CheckBox cbTV;
        private Label label15;
        private Panel panel4;
        private Label label14;
        private TextBox txtDoctorName;
        private Label label13;
        private TextBox txtDoctorID;
        private Label label12;
        private Label label11;
        private Panel panel3;
        private Label label2;
        private Button btnFindBed;
        private TextBox txtBed;
        private Label label5;
        private ComboBox cboWard;
        private Label label10;
        private DateTimePicker dtpSurgery;
        private Label label3;
        private Label label9;
        private Panel panel6;
        private Label label17;
        private Label label16;
        private ComboBox cboBedType;
        private TextBox txtSpeciality;
        private DateTimePicker dtpBirth;
        private Label label6;
        private Button btnFind;
        private Button btnUpdate;
        private Button btnClear;
        DataSet m_oSP = new DataSet();

		public frmManageAdmissions()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();

			//
			// TODO: Add any constructor code after InitializeComponent call
			//
		}

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if (components != null) 
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}

		#region Windows Form Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
            this.btnQuit = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.btnFind = new System.Windows.Forms.Button();
            this.label17 = new System.Windows.Forms.Label();
            this.dtpAdmission = new System.Windows.Forms.DateTimePicker();
            this.txtAdmissionID = new System.Windows.Forms.TextBox();
            this.lblHealthNumber = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpSurgery = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.cbPhone = new System.Windows.Forms.CheckBox();
            this.cbTV = new System.Windows.Forms.CheckBox();
            this.label15 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.txtSpeciality = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtDoctorName = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtDoctorID = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label16 = new System.Windows.Forms.Label();
            this.cboBedType = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnFindBed = new System.Windows.Forms.Button();
            this.txtBed = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cboWard = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dtpBirth = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtPatName = new System.Windows.Forms.TextBox();
            this.txtPatientID = new System.Windows.Forms.TextBox();
            this.lblPatient = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtInsuranceNumber = new System.Windows.Forms.TextBox();
            this.txtInsurCompany = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnQuit
            // 
            this.btnQuit.Location = new System.Drawing.Point(617, 460);
            this.btnQuit.Name = "btnQuit";
            this.btnQuit.Size = new System.Drawing.Size(75, 23);
            this.btnQuit.TabIndex = 4;
            this.btnQuit.Text = "Quit";
            this.btnQuit.Click += new System.EventHandler(this.btnQuit_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.panel6);
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(27, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(665, 442);
            this.panel1.TabIndex = 21;
            // 
            // panel6
            // 
            this.panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel6.Controls.Add(this.btnFind);
            this.panel6.Controls.Add(this.label17);
            this.panel6.Controls.Add(this.dtpAdmission);
            this.panel6.Controls.Add(this.txtAdmissionID);
            this.panel6.Controls.Add(this.lblHealthNumber);
            this.panel6.Controls.Add(this.label1);
            this.panel6.Controls.Add(this.dtpSurgery);
            this.panel6.Controls.Add(this.label3);
            this.panel6.Location = new System.Drawing.Point(12, 16);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(628, 100);
            this.panel6.TabIndex = 63;
            // 
            // btnFind
            // 
            this.btnFind.Location = new System.Drawing.Point(105, 60);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(193, 23);
            this.btnFind.TabIndex = 30;
            this.btnFind.Text = "Find Admission by ID";
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(7, 10);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(91, 20);
            this.label17.TabIndex = 63;
            this.label17.Text = "Admission";
            // 
            // dtpAdmission
            // 
            this.dtpAdmission.Location = new System.Drawing.Point(457, 31);
            this.dtpAdmission.Name = "dtpAdmission";
            this.dtpAdmission.Size = new System.Drawing.Size(143, 20);
            this.dtpAdmission.TabIndex = 34;
            // 
            // txtAdmissionID
            // 
            this.txtAdmissionID.Location = new System.Drawing.Point(105, 34);
            this.txtAdmissionID.MaxLength = 4;
            this.txtAdmissionID.Name = "txtAdmissionID";
            this.txtAdmissionID.Size = new System.Drawing.Size(193, 20);
            this.txtAdmissionID.TabIndex = 20;
            this.txtAdmissionID.Leave += new System.EventHandler(this.btnFind_Click);
            // 
            // lblHealthNumber
            // 
            this.lblHealthNumber.AutoSize = true;
            this.lblHealthNumber.Location = new System.Drawing.Point(20, 37);
            this.lblHealthNumber.Name = "lblHealthNumber";
            this.lblHealthNumber.Size = new System.Drawing.Size(71, 13);
            this.lblHealthNumber.TabIndex = 23;
            this.lblHealthNumber.Text = "Admission ID:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(342, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 33;
            this.label1.Text = "Admission Date:";
            // 
            // dtpSurgery
            // 
            this.dtpSurgery.CustomFormat = " ";
            this.dtpSurgery.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpSurgery.Location = new System.Drawing.Point(457, 57);
            this.dtpSurgery.Name = "dtpSurgery";
            this.dtpSurgery.Size = new System.Drawing.Size(143, 20);
            this.dtpSurgery.TabIndex = 53;
            this.dtpSurgery.ValueChanged += new System.EventHandler(this.dtpSurgery_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(342, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 13);
            this.label3.TabIndex = 52;
            this.label3.Text = "Surgery Date:";
            // 
            // panel5
            // 
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Controls.Add(this.cbPhone);
            this.panel5.Controls.Add(this.cbTV);
            this.panel5.Controls.Add(this.label15);
            this.panel5.Location = new System.Drawing.Point(342, 329);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(298, 86);
            this.panel5.TabIndex = 62;
            // 
            // cbPhone
            // 
            this.cbPhone.AutoSize = true;
            this.cbPhone.Location = new System.Drawing.Point(83, 44);
            this.cbPhone.Name = "cbPhone";
            this.cbPhone.Size = new System.Drawing.Size(57, 17);
            this.cbPhone.TabIndex = 62;
            this.cbPhone.Text = "Phone";
            this.cbPhone.UseVisualStyleBackColor = true;
            // 
            // cbTV
            // 
            this.cbTV.AutoSize = true;
            this.cbTV.Location = new System.Drawing.Point(12, 44);
            this.cbTV.Name = "cbTV";
            this.cbTV.Size = new System.Drawing.Size(40, 17);
            this.cbTV.TabIndex = 61;
            this.cbTV.Text = "TV";
            this.cbTV.UseVisualStyleBackColor = true;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(7, 10);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(60, 20);
            this.label15.TabIndex = 60;
            this.label15.Text = "Extras";
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.txtSpeciality);
            this.panel4.Controls.Add(this.label14);
            this.panel4.Controls.Add(this.txtDoctorName);
            this.panel4.Controls.Add(this.label13);
            this.panel4.Controls.Add(this.txtDoctorID);
            this.panel4.Controls.Add(this.label12);
            this.panel4.Controls.Add(this.label11);
            this.panel4.Location = new System.Drawing.Point(12, 122);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(324, 144);
            this.panel4.TabIndex = 61;
            // 
            // txtSpeciality
            // 
            this.txtSpeciality.Enabled = false;
            this.txtSpeciality.Location = new System.Drawing.Point(105, 101);
            this.txtSpeciality.MaxLength = 20;
            this.txtSpeciality.Name = "txtSpeciality";
            this.txtSpeciality.ReadOnly = true;
            this.txtSpeciality.Size = new System.Drawing.Size(193, 20);
            this.txtSpeciality.TabIndex = 63;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(20, 102);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(55, 13);
            this.label14.TabIndex = 60;
            this.label14.Text = "Speciality:";
            // 
            // txtDoctorName
            // 
            this.txtDoctorName.Enabled = false;
            this.txtDoctorName.Location = new System.Drawing.Point(105, 73);
            this.txtDoctorName.MaxLength = 20;
            this.txtDoctorName.Name = "txtDoctorName";
            this.txtDoctorName.ReadOnly = true;
            this.txtDoctorName.Size = new System.Drawing.Size(193, 20);
            this.txtDoctorName.TabIndex = 61;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(19, 76);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(38, 13);
            this.label13.TabIndex = 62;
            this.label13.Text = "Name:";
            // 
            // txtDoctorID
            // 
            this.txtDoctorID.Location = new System.Drawing.Point(105, 47);
            this.txtDoctorID.MaxLength = 20;
            this.txtDoctorID.Name = "txtDoctorID";
            this.txtDoctorID.Size = new System.Drawing.Size(193, 20);
            this.txtDoctorID.TabIndex = 61;
            this.txtDoctorID.Leave += new System.EventHandler(this.txtDoctorID_Leave);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(19, 50);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(56, 13);
            this.label12.TabIndex = 62;
            this.label12.Text = "Doctor ID:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(6, 11);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(63, 20);
            this.label11.TabIndex = 61;
            this.label11.Text = "Doctor";
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.label16);
            this.panel3.Controls.Add(this.cboBedType);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.btnFindBed);
            this.panel3.Controls.Add(this.txtBed);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.cboWard);
            this.panel3.Controls.Add(this.label10);
            this.panel3.Location = new System.Drawing.Point(12, 276);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(324, 139);
            this.panel3.TabIndex = 60;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(20, 73);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(56, 13);
            this.label16.TabIndex = 60;
            this.label16.Text = "Bed Type:";
            // 
            // cboBedType
            // 
            this.cboBedType.FormattingEnabled = true;
            this.cboBedType.Items.AddRange(new object[] {
            "Ward",
            "Semi-private",
            "Private"});
            this.cboBedType.Location = new System.Drawing.Point(105, 72);
            this.cboBedType.Name = "cboBedType";
            this.cboBedType.Size = new System.Drawing.Size(193, 21);
            this.cboBedType.TabIndex = 61;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 20);
            this.label2.TabIndex = 50;
            this.label2.Text = "Acomodations";
            // 
            // btnFindBed
            // 
            this.btnFindBed.Location = new System.Drawing.Point(223, 99);
            this.btnFindBed.Name = "btnFindBed";
            this.btnFindBed.Size = new System.Drawing.Size(75, 23);
            this.btnFindBed.TabIndex = 59;
            this.btnFindBed.Text = "Find Bed";
            this.btnFindBed.Click += new System.EventHandler(this.btnFindBed_Click);
            // 
            // txtBed
            // 
            this.txtBed.Enabled = false;
            this.txtBed.Location = new System.Drawing.Point(105, 99);
            this.txtBed.MaxLength = 4;
            this.txtBed.Name = "txtBed";
            this.txtBed.ReadOnly = true;
            this.txtBed.Size = new System.Drawing.Size(112, 20);
            this.txtBed.TabIndex = 58;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 46);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 13);
            this.label5.TabIndex = 55;
            this.label5.Text = "Ward:";
            // 
            // cboWard
            // 
            this.cboWard.FormattingEnabled = true;
            this.cboWard.Location = new System.Drawing.Point(105, 45);
            this.cboWard.Name = "cboWard";
            this.cboWard.Size = new System.Drawing.Size(193, 21);
            this.cboWard.TabIndex = 57;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(20, 102);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(29, 13);
            this.label10.TabIndex = 56;
            this.label10.Text = "Bed:";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.dtpBirth);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.txtPatName);
            this.panel2.Controls.Add(this.txtPatientID);
            this.panel2.Controls.Add(this.lblPatient);
            this.panel2.Controls.Add(this.lblName);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.txtInsuranceNumber);
            this.panel2.Controls.Add(this.txtInsurCompany);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Location = new System.Drawing.Point(342, 122);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(298, 201);
            this.panel2.TabIndex = 49;
            // 
            // dtpBirth
            // 
            this.dtpBirth.CustomFormat = " ";
            this.dtpBirth.Enabled = false;
            this.dtpBirth.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpBirth.Location = new System.Drawing.Point(126, 99);
            this.dtpBirth.Name = "dtpBirth";
            this.dtpBirth.Size = new System.Drawing.Size(143, 20);
            this.dtpBirth.TabIndex = 65;
            this.dtpBirth.ValueChanged += new System.EventHandler(this.dtpBirth_ValueChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(11, 104);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 13);
            this.label6.TabIndex = 64;
            this.label6.Text = "Birth Date:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(10, 10);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(159, 20);
            this.label9.TabIndex = 49;
            this.label9.Text = "Patient Informaton";
            // 
            // txtPatName
            // 
            this.txtPatName.Enabled = false;
            this.txtPatName.Location = new System.Drawing.Point(126, 72);
            this.txtPatName.MaxLength = 20;
            this.txtPatName.Name = "txtPatName";
            this.txtPatName.ReadOnly = true;
            this.txtPatName.Size = new System.Drawing.Size(143, 20);
            this.txtPatName.TabIndex = 22;
            // 
            // txtPatientID
            // 
            this.txtPatientID.Location = new System.Drawing.Point(126, 45);
            this.txtPatientID.MaxLength = 20;
            this.txtPatientID.Name = "txtPatientID";
            this.txtPatientID.Size = new System.Drawing.Size(143, 20);
            this.txtPatientID.TabIndex = 21;
            this.txtPatientID.Leave += new System.EventHandler(this.txtPatientID_Leave);
            // 
            // lblPatient
            // 
            this.lblPatient.AutoSize = true;
            this.lblPatient.Location = new System.Drawing.Point(11, 52);
            this.lblPatient.Name = "lblPatient";
            this.lblPatient.Size = new System.Drawing.Size(57, 13);
            this.lblPatient.TabIndex = 24;
            this.lblPatient.Text = "Patient ID:";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(11, 78);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(38, 13);
            this.lblName.TabIndex = 25;
            this.lblName.Text = "Name:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(11, 156);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(104, 13);
            this.label8.TabIndex = 44;
            this.label8.Text = "Insurance Company:";
            // 
            // txtInsuranceNumber
            // 
            this.txtInsuranceNumber.Enabled = false;
            this.txtInsuranceNumber.Location = new System.Drawing.Point(126, 126);
            this.txtInsuranceNumber.MaxLength = 20;
            this.txtInsuranceNumber.Name = "txtInsuranceNumber";
            this.txtInsuranceNumber.ReadOnly = true;
            this.txtInsuranceNumber.Size = new System.Drawing.Size(143, 20);
            this.txtInsuranceNumber.TabIndex = 40;
            // 
            // txtInsurCompany
            // 
            this.txtInsurCompany.Enabled = false;
            this.txtInsurCompany.Location = new System.Drawing.Point(126, 153);
            this.txtInsurCompany.MaxLength = 20;
            this.txtInsurCompany.Name = "txtInsurCompany";
            this.txtInsurCompany.ReadOnly = true;
            this.txtInsurCompany.Size = new System.Drawing.Size(143, 20);
            this.txtInsurCompany.TabIndex = 43;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 130);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 13);
            this.label4.TabIndex = 42;
            this.label4.Text = "Insurance Number:";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(221, 460);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 28;
            this.btnAdd.Text = "Add";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(309, 460);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 29;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(397, 460);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 30;
            this.btnClear.Text = "Clear Fields";
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // frmManageAdmissions
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.ClientSize = new System.Drawing.Size(718, 499);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnQuit);
            this.Controls.Add(this.btnAdd);
            this.Name = "frmManageAdmissions";
            this.Text = "Admissions";
            this.Load += new System.EventHandler(this.frmPatients_Load);
            this.panel1.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

		}
		#endregion


		private void frmPatients_Load(object sender, System.EventArgs e)
		{
            LoadWardsData();
            LoadBedTypeData();

        }
        private void ResetFields()
        {

            txtAdmissionID.Text = "";
            dtpAdmission.Value = DateTime.Now;
            dtpSurgery.Format = DateTimePickerFormat.Custom;
            txtDoctorID.Text = "";
            txtDoctorName.Text = "";
            txtSpeciality.Text = "";
            txtPatientID.Text = "";
            txtPatName.Text = "";
            dtpBirth.Format = DateTimePickerFormat.Custom;
            txtInsuranceNumber.Text = "";
            txtInsurCompany.Text = "";
            LoadWardsData();
            LoadBedTypeData();
            txtBed.Text = "";
            cbPhone.Checked = false;
            cbTV.Checked = false;
        }

        private void LoadWardsData()
		{
			Wards oWards = new Wards();
			cboWard.DataBindings.Clear();
			m_oDS = oWards.GetData();
            cboWard.DataSource = m_oDS.Tables["Wards"];
            cboWard.DisplayMember = "Name";
            cboWard.ValueMember = "Name";
            
        }
        private void LoadBedTypeData()
        {
            BedTypes oTypes = new BedTypes();
            cboBedType.DataBindings.Clear();
            m_oDS = oTypes.GetData();
            cboBedType.DataSource = m_oDS.Tables["BedType"];
            cboBedType.DisplayMember = "BedType";
            cboBedType.ValueMember = "BedType";
            cboBedType.SelectedValue = "Ward";

        }
        private void btnAdd_Click(object sender, System.EventArgs e)
		{
			string admID = txtAdmissionID.Text ;
            DateTime admission = dtpAdmission.Value;
            DateTime surgery = dtpSurgery.Value;

            string docID = txtDoctorID.Text ;
            string patID = txtPatientID.Text;

            string ward = cboWard.Text;
            string bedType = cboBedType.Text;
            string bed = txtBed.Text;

            bool tv = cbTV.Checked;
            bool phone = cbPhone.Checked;
            bool semi = false;
            bool priv = false;

            if (bedType.Equals("Semi-private"))
                semi = true;
            if (bedType.Equals("Private"))
                priv = true;

            string sMsg = "";

			Admissions oAdmissions = new Admissions();
            string obField = "";
            if (admID == "")
            {
                obField = "Admission ID";
            }
            else if (docID == "")
            {
                obField = "Doctor ID";
            }else if (patID == "")
            {
                obField = "Patient ID";
            }else if (bed == "")
            {
                obField = "Bed";
            }

            if (obField == "")
            {
                MessageBox.Show("Field " + obField + "is obligatory.");
                return;
            }

			try
			{
				sMsg = oAdmissions.AddData(admID, admission, surgery, docID, patID, ward, bed, tv,phone,semi,priv);
            }
			catch
			{
				sMsg = "Error saving data." + "\n\n" + e.ToString();
			}
			finally
			{
				MessageBox.Show (sMsg, "Add Record", MessageBoxButtons.OK);
			}
		}

		private void btnQuit_Click(object sender, System.EventArgs e)
		{
			this.Close ();
		}

        private void btnFindBed_Click(object sender, EventArgs e)
        {
            Beds oBeds = new Beds();
            string msg = "";

            string bed = oBeds.FindAvailableBed(cboWard.Text, cboBedType.Text);

            if (bed.Equals("none available"))
            {
                msg = "No " + cboBedType.Text + " bed available in " + cboWard.Text + ".\n";
                if (cboBedType.Text.Equals("Ward"))
                {
                    bed = UpdateBedForFree();
                    if (!bed.Equals("none available"))
                    {
                        msg += "Patient upgraded bed type at no cost.\n";
                        txtBed.Text = bed;
                        MessageBox.Show(msg + "Bed " + bed + " found");
                        return;
                    }
                    msg = "No beds available in " + cboWard.Text + ".\n";
                }
                MessageBox.Show(msg);
            }
            else
            {
                txtBed.Text = bed;
                MessageBox.Show("Bed " + bed + " found");
                return;
            }
        }

        private string UpdateBedForFree()
        {
            string bed="none available";
            Beds oBeds = new Beds();

            bed = oBeds.FindAvailableBed(cboWard.Text, "Semi-private");
            if (bed.Equals("none available"))
                bed = oBeds.FindAvailableBed(cboWard.Text, "Private");

            return bed;
        }
        private string FillDoctorInfo (string doctorID)
        {
            string sMsg = "";
            Employees oEmployees = new Employees();
            DataRow doctor = null;

            doctor = oEmployees.FindDoctor(txtDoctorID.Text);
            if (doctor != null)
            {
                txtDoctorID.Text = doctor["ID"].ToString();
                txtDoctorName.Text = doctor["FName"].ToString() + " " + doctor["LName"].ToString();
                txtSpeciality.Text = doctor["Specialty"].ToString();
                sMsg = "Doctor found.";
            }
            else
            {
                sMsg = "Doctor not found.";
                txtDoctorID.Text = "";
                txtDoctorName.Text = "";
                txtSpeciality.Text = "";
            }
                

            return sMsg;
            
        }
        private string FillPatientInfo(string patientID)
        {
            Patients oPatients = new Patients();
            DataSet patient = null;
            string sMsg = "";
            patient = oPatients.FindData(txtPatientID.Text);
            if(patient.Tables["Patients"] != null)
            {
                txtPatName.Text = patient.Tables["Patients"].Rows[0]["FirstName"].ToString() + " " + patient.Tables["Patients"].Rows[0]["LastName"].ToString();
                dtpBirth.Format = DateTimePickerFormat.Long;
                dtpBirth.Value = Convert.ToDateTime(patient.Tables["Patients"].Rows[0]["Birth"]);
                txtInsuranceNumber.Text = patient.Tables["Patients"].Rows[0]["InsuranceNumber"].ToString();
                txtInsurCompany.Text = patient.Tables["Patients"].Rows[0]["InsuranceCompany"].ToString();
                sMsg = "Patient found.";
            }
            else
            {
                sMsg = "Patient not found.";
                txtPatName.Text = "";
                dtpBirth.Format = DateTimePickerFormat.Custom;
                txtInsuranceNumber.Text = "";
                txtInsurCompany.Text = "";
            }
            return sMsg;
        }

        private void dtpSurgery_ValueChanged(object sender, EventArgs e)
        {
            dtpSurgery.Format = DateTimePickerFormat.Long;
        }

        private void dtpBirth_ValueChanged(object sender, EventArgs e)
        {
            dtpBirth.Format = DateTimePickerFormat.Long;
            if ((DateTime.Now.Year - dtpBirth.Value.Year) <= 16)
            {
                cboWard.SelectedValue = "Pediatrics";
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string admID = txtAdmissionID.Text;
            DateTime admission = dtpAdmission.Value;
            DateTime surgery = dtpSurgery.Value;

            string docID = txtDoctorID.Text;
            string patID = txtPatientID.Text;

            string ward = cboWard.Text;
            string bedType = cboBedType.Text;
            string bed = txtBed.Text;

            bool tv = cbTV.Checked;
            bool phone = cbPhone.Checked;
            bool semi = false;
            bool priv = false;

            if (bedType.Equals("Semi-private"))
                semi = true;
            if (bedType.Equals("Private"))
                priv = true;

            string sMsg = "";

            Admissions oAdmissions = new Admissions();

            try
            {
                sMsg = oAdmissions.UpdateData(admID, admission, surgery, docID, patID, ward, bed, tv, phone, semi, priv);
            }
            catch
            {
                sMsg = "Error saving data." + "\n\n" + e.ToString();
            }
            finally
            {
                MessageBox.Show(sMsg, "Record Update", MessageBoxButtons.OK);
            }
        }
        private string FillAdmissionInfo(string ID)
        {
            string admID = txtAdmissionID.Text;
            string sMsg = "";

            DataSet o_Find = new DataSet();
            Admissions oAdmissions = new Admissions();
            try
            {
                o_Find = oAdmissions.FindData(admID);
                dtpAdmission.Value = Convert.ToDateTime(o_Find.Tables["Admissions"].Rows[0]["AdmissionDate"]);

                if (o_Find.Tables["Admissions"].Rows[0]["SurgeryDate"] != DBNull.Value)
                    dtpSurgery.Value = Convert.ToDateTime(o_Find.Tables["Admissions"].Rows[0]["SurgeryDate"]);

                txtDoctorID.Text = o_Find.Tables["Admissions"].Rows[0]["DoctorID"].ToString();
                txtPatientID.Text = o_Find.Tables["Admissions"].Rows[0]["PatientID"].ToString();
                cboWard.SelectedValue = o_Find.Tables["Admissions"].Rows[0]["Ward"].ToString();
                txtBed.Text = o_Find.Tables["Admissions"].Rows[0]["Bed"].ToString();
                cbTV.Checked = Convert.ToBoolean(o_Find.Tables["Admissions"].Rows[0]["TV"]);
                cbPhone.Checked = Convert.ToBoolean(o_Find.Tables["Admissions"].Rows[0]["Phone"]);

                FillDoctorInfo(txtDoctorID.Text);
                FillPatientInfo(txtPatientID.Text);
                if (!o_Find.Tables["Admissions"].Rows[0].IsNull("DischargeDate"))
                {
                    btnUpdate.Enabled = false;
                }

                Beds oBeds = new Beds();
                o_Find = oBeds.FindData(txtBed.Text);
                cboBedType.SelectedValue = o_Find.Tables["Beds"].Rows[0]["BedType"].ToString();
                sMsg = "Admission record found.";

                
            }
            catch
            {
                sMsg = "Admission not in database.";
                ResetFields();
                return sMsg;
            }
            return sMsg;
        }
        private void btnFind_Click(object sender, EventArgs e)
        {
            string sMsg = "";

            if (txtAdmissionID.Text != "")
            {
                sMsg = FillAdmissionInfo(txtAdmissionID.Text);
            }
            else
            {
                //search doctor form
            }
            MessageBox.Show(sMsg);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ResetFields();
        }

        private void txtDoctorID_Leave(object sender, EventArgs e)
        {
            string sMsg = "";
            txtDoctorName.Text = "";
            txtSpeciality.Text = "";

            if (txtDoctorID.Text != "")
            {
                sMsg = FillDoctorInfo(txtDoctorID.Text);
            }
            MessageBox.Show(sMsg);
        }

        private void txtPatientID_Leave(object sender, EventArgs e)
        {
            string sMsg = "";
            txtPatName.Text = "";
            dtpBirth.Format = DateTimePickerFormat.Custom;
            txtInsuranceNumber.Text = "";
            txtInsurCompany.Text = "";

            if (txtPatientID.Text != "")
            {
                sMsg = FillPatientInfo(txtPatientID.Text);

            }
            MessageBox.Show(sMsg);
        }
    }
}
