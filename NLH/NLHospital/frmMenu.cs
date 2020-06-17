using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using NLHospitalLibrary;
using NLHBaseWindow;


namespace NLHospital
{
	/// <summary>
	/// Summary description for frmMenu.
	/// </summary>
	public class frmMenu : NLHBase
	{
		private System.Windows.Forms.Label lblAdministrator;
		private System.Windows.Forms.Button btnEmployees;
		private System.Windows.Forms.Label lblAdmin;
		private System.Windows.Forms.Panel pnlAdministrator;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button btnDischarge;
		private System.Windows.Forms.Button btnSurgery;
		private System.Windows.Forms.Label lblNurses;
		private System.Windows.Forms.Button btnForSurgery;
		private System.Windows.Forms.Button btnBilling;
		private System.Windows.Forms.Button btnHPatients;
		private System.Windows.Forms.Button btnQuit;
		private System.Windows.Forms.Panel pnlDoctors;
		private System.Windows.Forms.Panel pnlNurses;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox txtPatientID;
		private System.Windows.Forms.Label label1;
        private Panel pnlAdmissions;
        private Button btnAdmissionsReport;
        private Label label5;
        private Button btnAdmissions;
        private Label label6;
        private Panel pnlPatients;
        private Button btnHospPatients;
        private Label label7;
        private Button btnPatients;
        private Label label8;
        public CurrentUser oCurrent = new CurrentUser();

		public frmMenu()
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
				if(components != null)
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
            this.pnlAdministrator = new System.Windows.Forms.Panel();
            this.btnBilling = new System.Windows.Forms.Button();
            this.lblAdmin = new System.Windows.Forms.Label();
            this.btnEmployees = new System.Windows.Forms.Button();
            this.lblAdministrator = new System.Windows.Forms.Label();
            this.pnlDoctors = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPatientID = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnSurgery = new System.Windows.Forms.Button();
            this.btnDischarge = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.pnlNurses = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.btnHPatients = new System.Windows.Forms.Button();
            this.btnForSurgery = new System.Windows.Forms.Button();
            this.lblNurses = new System.Windows.Forms.Label();
            this.btnQuit = new System.Windows.Forms.Button();
            this.pnlAdmissions = new System.Windows.Forms.Panel();
            this.btnAdmissionsReport = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.btnAdmissions = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.pnlPatients = new System.Windows.Forms.Panel();
            this.btnHospPatients = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.btnPatients = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.pnlAdministrator.SuspendLayout();
            this.pnlDoctors.SuspendLayout();
            this.pnlNurses.SuspendLayout();
            this.pnlAdmissions.SuspendLayout();
            this.pnlPatients.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlAdministrator
            // 
            this.pnlAdministrator.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlAdministrator.Controls.Add(this.btnBilling);
            this.pnlAdministrator.Controls.Add(this.lblAdmin);
            this.pnlAdministrator.Controls.Add(this.btnEmployees);
            this.pnlAdministrator.Controls.Add(this.lblAdministrator);
            this.pnlAdministrator.Location = new System.Drawing.Point(16, 8);
            this.pnlAdministrator.Name = "pnlAdministrator";
            this.pnlAdministrator.Size = new System.Drawing.Size(320, 120);
            this.pnlAdministrator.TabIndex = 0;
            this.pnlAdministrator.Visible = false;
            // 
            // btnBilling
            // 
            this.btnBilling.Location = new System.Drawing.Point(160, 80);
            this.btnBilling.Name = "btnBilling";
            this.btnBilling.Size = new System.Drawing.Size(136, 23);
            this.btnBilling.TabIndex = 5;
            this.btnBilling.Text = "Bill Patient";
            this.btnBilling.Click += new System.EventHandler(this.btnBilling_Click);
            // 
            // lblAdmin
            // 
            this.lblAdmin.AutoSize = true;
            this.lblAdmin.Location = new System.Drawing.Point(16, 32);
            this.lblAdmin.Name = "lblAdmin";
            this.lblAdmin.Size = new System.Drawing.Size(168, 13);
            this.lblAdmin.TabIndex = 4;
            this.lblAdmin.Text = "Please select one of the following:";
            // 
            // btnEmployees
            // 
            this.btnEmployees.Location = new System.Drawing.Point(8, 80);
            this.btnEmployees.Name = "btnEmployees";
            this.btnEmployees.Size = new System.Drawing.Size(136, 23);
            this.btnEmployees.TabIndex = 1;
            this.btnEmployees.Text = "Manage Employees";
            this.btnEmployees.Click += new System.EventHandler(this.btnEmployees_Click);
            // 
            // lblAdministrator
            // 
            this.lblAdministrator.AutoSize = true;
            this.lblAdministrator.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdministrator.Location = new System.Drawing.Point(16, 8);
            this.lblAdministrator.Name = "lblAdministrator";
            this.lblAdministrator.Size = new System.Drawing.Size(111, 17);
            this.lblAdministrator.TabIndex = 0;
            this.lblAdministrator.Text = "Administration";
            // 
            // pnlDoctors
            // 
            this.pnlDoctors.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlDoctors.Controls.Add(this.label1);
            this.pnlDoctors.Controls.Add(this.txtPatientID);
            this.pnlDoctors.Controls.Add(this.label3);
            this.pnlDoctors.Controls.Add(this.btnSurgery);
            this.pnlDoctors.Controls.Add(this.btnDischarge);
            this.pnlDoctors.Controls.Add(this.label2);
            this.pnlDoctors.Location = new System.Drawing.Point(344, 8);
            this.pnlDoctors.Name = "pnlDoctors";
            this.pnlDoctors.Size = new System.Drawing.Size(320, 120);
            this.pnlDoctors.TabIndex = 2;
            this.pnlDoctors.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Patient ID:";
            // 
            // txtPatientID
            // 
            this.txtPatientID.Location = new System.Drawing.Point(80, 56);
            this.txtPatientID.Name = "txtPatientID";
            this.txtPatientID.Size = new System.Drawing.Size(72, 20);
            this.txtPatientID.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(168, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Please select one of the following:";
            // 
            // btnSurgery
            // 
            this.btnSurgery.Location = new System.Drawing.Point(168, 80);
            this.btnSurgery.Name = "btnSurgery";
            this.btnSurgery.Size = new System.Drawing.Size(136, 23);
            this.btnSurgery.TabIndex = 2;
            this.btnSurgery.Text = "Surgery Report";
            this.btnSurgery.Click += new System.EventHandler(this.btnSurgery_Click);
            // 
            // btnDischarge
            // 
            this.btnDischarge.Location = new System.Drawing.Point(16, 80);
            this.btnDischarge.Name = "btnDischarge";
            this.btnDischarge.Size = new System.Drawing.Size(136, 23);
            this.btnDischarge.TabIndex = 1;
            this.btnDischarge.Text = "Discharge Patient";
            this.btnDischarge.Click += new System.EventHandler(this.btnDischarge_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(32, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Doctors";
            // 
            // pnlNurses
            // 
            this.pnlNurses.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlNurses.Controls.Add(this.label4);
            this.pnlNurses.Controls.Add(this.btnHPatients);
            this.pnlNurses.Controls.Add(this.btnForSurgery);
            this.pnlNurses.Controls.Add(this.lblNurses);
            this.pnlNurses.Location = new System.Drawing.Point(18, 260);
            this.pnlNurses.Name = "pnlNurses";
            this.pnlNurses.Size = new System.Drawing.Size(320, 120);
            this.pnlNurses.TabIndex = 3;
            this.pnlNurses.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 32);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(135, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Select one of the following:";
            // 
            // btnHPatients
            // 
            this.btnHPatients.Location = new System.Drawing.Point(16, 80);
            this.btnHPatients.Name = "btnHPatients";
            this.btnHPatients.Size = new System.Drawing.Size(136, 23);
            this.btnHPatients.TabIndex = 2;
            this.btnHPatients.Text = "Hospitalized Patients";
            this.btnHPatients.Click += new System.EventHandler(this.btnHospPatients_Click);
            // 
            // btnForSurgery
            // 
            this.btnForSurgery.Location = new System.Drawing.Point(168, 80);
            this.btnForSurgery.Name = "btnForSurgery";
            this.btnForSurgery.Size = new System.Drawing.Size(136, 23);
            this.btnForSurgery.TabIndex = 1;
            this.btnForSurgery.Text = "Surgery Report";
            this.btnForSurgery.Click += new System.EventHandler(this.btnSurgery_Click);
            // 
            // lblNurses
            // 
            this.lblNurses.AutoSize = true;
            this.lblNurses.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNurses.Location = new System.Drawing.Point(32, 8);
            this.lblNurses.Name = "lblNurses";
            this.lblNurses.Size = new System.Drawing.Size(59, 17);
            this.lblNurses.TabIndex = 0;
            this.lblNurses.Text = "Nurses";
            // 
            // btnQuit
            // 
            this.btnQuit.Location = new System.Drawing.Point(322, 435);
            this.btnQuit.Name = "btnQuit";
            this.btnQuit.Size = new System.Drawing.Size(75, 23);
            this.btnQuit.TabIndex = 4;
            this.btnQuit.Text = "Quit";
            this.btnQuit.Click += new System.EventHandler(this.btnQuit_Click);
            // 
            // pnlAdmissions
            // 
            this.pnlAdmissions.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlAdmissions.Controls.Add(this.btnAdmissionsReport);
            this.pnlAdmissions.Controls.Add(this.label5);
            this.pnlAdmissions.Controls.Add(this.btnAdmissions);
            this.pnlAdmissions.Controls.Add(this.label6);
            this.pnlAdmissions.Location = new System.Drawing.Point(344, 134);
            this.pnlAdmissions.Name = "pnlAdmissions";
            this.pnlAdmissions.Size = new System.Drawing.Size(320, 120);
            this.pnlAdmissions.TabIndex = 9;
            this.pnlAdmissions.Visible = false;
            // 
            // btnAdmissionsReport
            // 
            this.btnAdmissionsReport.Location = new System.Drawing.Point(166, 80);
            this.btnAdmissionsReport.Name = "btnAdmissionsReport";
            this.btnAdmissionsReport.Size = new System.Drawing.Size(136, 23);
            this.btnAdmissionsReport.TabIndex = 9;
            this.btnAdmissionsReport.Text = "Admissions Report";
            this.btnAdmissionsReport.Click += new System.EventHandler(this.btnAdmissionsReport_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 32);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(168, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Please select one of the following:";
            // 
            // btnAdmissions
            // 
            this.btnAdmissions.Location = new System.Drawing.Point(8, 80);
            this.btnAdmissions.Name = "btnAdmissions";
            this.btnAdmissions.Size = new System.Drawing.Size(136, 23);
            this.btnAdmissions.TabIndex = 1;
            this.btnAdmissions.Text = "Manage Admissions";
            this.btnAdmissions.Click += new System.EventHandler(this.btnAdmissions_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(16, 8);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 17);
            this.label6.TabIndex = 0;
            this.label6.Text = "Admissions";
            // 
            // pnlPatients
            // 
            this.pnlPatients.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlPatients.Controls.Add(this.btnHospPatients);
            this.pnlPatients.Controls.Add(this.label7);
            this.pnlPatients.Controls.Add(this.btnPatients);
            this.pnlPatients.Controls.Add(this.label8);
            this.pnlPatients.Location = new System.Drawing.Point(18, 134);
            this.pnlPatients.Name = "pnlPatients";
            this.pnlPatients.Size = new System.Drawing.Size(320, 120);
            this.pnlPatients.TabIndex = 8;
            this.pnlPatients.Visible = false;
            // 
            // btnHospPatients
            // 
            this.btnHospPatients.Location = new System.Drawing.Point(165, 80);
            this.btnHospPatients.Name = "btnHospPatients";
            this.btnHospPatients.Size = new System.Drawing.Size(136, 23);
            this.btnHospPatients.TabIndex = 8;
            this.btnHospPatients.Text = "Hospitalized Patients";
            this.btnHospPatients.Click += new System.EventHandler(this.btnHospPatients_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(16, 32);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(168, 13);
            this.label7.TabIndex = 4;
            this.label7.Text = "Please select one of the following:";
            // 
            // btnPatients
            // 
            this.btnPatients.Location = new System.Drawing.Point(8, 80);
            this.btnPatients.Name = "btnPatients";
            this.btnPatients.Size = new System.Drawing.Size(136, 23);
            this.btnPatients.TabIndex = 1;
            this.btnPatients.Text = "Manage Patients";
            this.btnPatients.Click += new System.EventHandler(this.btnPatients_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(16, 8);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(67, 17);
            this.label8.TabIndex = 0;
            this.label8.Text = "Patients";
            // 
            // frmMenu
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.ClientSize = new System.Drawing.Size(672, 470);
            this.Controls.Add(this.pnlAdmissions);
            this.Controls.Add(this.btnQuit);
            this.Controls.Add(this.pnlPatients);
            this.Controls.Add(this.pnlDoctors);
            this.Controls.Add(this.pnlAdministrator);
            this.Controls.Add(this.pnlNurses);
            this.Name = "frmMenu";
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.frmMenu_Load);
            this.pnlAdministrator.ResumeLayout(false);
            this.pnlAdministrator.PerformLayout();
            this.pnlDoctors.ResumeLayout(false);
            this.pnlDoctors.PerformLayout();
            this.pnlNurses.ResumeLayout(false);
            this.pnlNurses.PerformLayout();
            this.pnlAdmissions.ResumeLayout(false);
            this.pnlAdmissions.PerformLayout();
            this.pnlPatients.ResumeLayout(false);
            this.pnlPatients.PerformLayout();
            this.ResumeLayout(false);

		}
		#endregion

		private void btnEmployees_Click(object sender, System.EventArgs e)
		{
			frmEmployees EmployeesForm = new frmEmployees ();
			EmployeesForm.Visible = true;
			EmployeesForm.Activate();
		}

		private void btnQuit_Click(object sender, System.EventArgs e)
		{
			Application.Exit ();
		}

		private void frmMenu_Load(object sender, System.EventArgs e)
		{

        }

		public void SelectUser()
		{
			switch (oCurrent.Type )
			{
				case "Admin":
					pnlAdministrator.Visible = true;
					break;
				case "Doctor":
					pnlDoctors.Visible = true;
					break;
				case "Nurse":
					pnlNurses.Visible = true;
					break;
                case "Admission":
                    pnlAdmissions.Visible = true;
                    pnlPatients.Visible = true;
                    break;
			}
			
		}

		private void btnDischarge_Click(object sender, System.EventArgs e)
		{
            string sMsg = "";
            Admissions oAdmissions = new Admissions();
            
            try
            {
                if (txtPatientID.Text != "")
                {
                    sMsg = oAdmissions.SetPatientDischarge(txtPatientID.Text);

                }
                    
                else
                    sMsg = "Input Patient ID to discharge";

            }
            catch
            {
                sMsg = "Error discharging patient" + "\n\n" + e.ToString();
            }
            finally
            {
                MessageBox.Show(sMsg, "Patient Discharge", MessageBoxButtons.OK);
            }

        }

		private void btnBilling_Click(object sender, System.EventArgs e)
		{
			frmBillPatient billForm = new frmBillPatient ();
			billForm.Visible = true;
			billForm.Activate();
		}

        private void btnSurgery_Click(object sender, EventArgs e)
        {
            frmSurgeries frmSurgeries = new frmSurgeries();
            frmSurgeries.Visible = true;
            frmSurgeries.Activate();
        }

        private void btnPatients_Click(object sender, EventArgs e)
        {
            frmPatients frmPatients = new frmPatients();
            frmPatients.Visible = true;
            frmPatients.Activate();
        }

        private void btnHospPatients_Click(object sender, EventArgs e)
        {
            frmHospitalizedPatients frmHPatients = new frmHospitalizedPatients();
            frmHPatients.Visible = true;
            frmHPatients.Activate();
        }

        private void btnAdmissions_Click(object sender, EventArgs e)
        {
            frmManageAdmissions frmManageAdmissions = new frmManageAdmissions();
            frmManageAdmissions.Visible = true;
            frmManageAdmissions.Activate();
        }

        private void btnAdmissionsReport_Click(object sender, EventArgs e)
        {
            frmAdmissions frmAdmissions = new frmAdmissions();
            frmAdmissions.Visible = true;
            frmAdmissions.Activate();
        }
    }
}
