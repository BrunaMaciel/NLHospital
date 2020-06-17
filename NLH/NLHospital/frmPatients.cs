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
	public class frmPatients : NLHBase
	{
		private System.Windows.Forms.Button btnQuit;
		private System.Windows.Forms.DataGrid dgPatients;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		DataSet m_oDS = new DataSet();
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Label lblFName;
		private System.Windows.Forms.Label lblLName;
		private System.Windows.Forms.Label lblHealthNumber;
		private System.Windows.Forms.TextBox txtFName;
		private System.Windows.Forms.TextBox txtLName;
		private System.Windows.Forms.TextBox txtHealthNumber;
		private System.Windows.Forms.Button btnAdd;
		private System.Windows.Forms.Button btnFind;
		private System.Windows.Forms.Button btnUpdate;
        private Label label6;
        private Label label7;
        private TextBox txtNOKRelationship;
        private TextBox txtNextOfKin;
        private Label label8;
        private TextBox txtInsurCompany;
        private Label label4;
        private Label label5;
        private TextBox txtInsurenceNumber;
        private TextBox txtPostalCode;
        private Label label2;
        private Label label3;
        private TextBox txtAddress;
        private TextBox txtPhone;
        private DateTimePicker dtpBirth;
        private Label label1;
        private Label label9;
        private TextBox txtProvince;
        private Label label10;
        private TextBox txtCity;
        DataSet m_oSP = new DataSet();

		public frmPatients()
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
            this.dgPatients = new System.Windows.Forms.DataGrid();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtNOKRelationship = new System.Windows.Forms.TextBox();
            this.txtNextOfKin = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtInsurCompany = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtInsurenceNumber = new System.Windows.Forms.TextBox();
            this.txtPostalCode = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.dtpBirth = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnFind = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lblFName = new System.Windows.Forms.Label();
            this.lblLName = new System.Windows.Forms.Label();
            this.lblHealthNumber = new System.Windows.Forms.Label();
            this.txtFName = new System.Windows.Forms.TextBox();
            this.txtLName = new System.Windows.Forms.TextBox();
            this.txtHealthNumber = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtProvince = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtCity = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgPatients)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnQuit
            // 
            this.btnQuit.Location = new System.Drawing.Point(338, 425);
            this.btnQuit.Name = "btnQuit";
            this.btnQuit.Size = new System.Drawing.Size(75, 23);
            this.btnQuit.TabIndex = 4;
            this.btnQuit.Text = "Quit";
            this.btnQuit.Click += new System.EventHandler(this.btnQuit_Click);
            // 
            // dgPatients
            // 
            this.dgPatients.AlternatingBackColor = System.Drawing.Color.LightGray;
            this.dgPatients.BackColor = System.Drawing.Color.Gainsboro;
            this.dgPatients.BackgroundColor = System.Drawing.Color.Silver;
            this.dgPatients.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgPatients.CaptionBackColor = System.Drawing.Color.LightSteelBlue;
            this.dgPatients.CaptionForeColor = System.Drawing.Color.MidnightBlue;
            this.dgPatients.DataMember = "";
            this.dgPatients.FlatMode = true;
            this.dgPatients.Font = new System.Drawing.Font("Tahoma", 8F);
            this.dgPatients.ForeColor = System.Drawing.Color.Black;
            this.dgPatients.GridLineColor = System.Drawing.Color.DimGray;
            this.dgPatients.GridLineStyle = System.Windows.Forms.DataGridLineStyle.None;
            this.dgPatients.HeaderBackColor = System.Drawing.Color.MidnightBlue;
            this.dgPatients.HeaderFont = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.dgPatients.HeaderForeColor = System.Drawing.Color.White;
            this.dgPatients.LinkColor = System.Drawing.Color.MidnightBlue;
            this.dgPatients.Location = new System.Drawing.Point(26, 219);
            this.dgPatients.Name = "dgPatients";
            this.dgPatients.ParentRowsBackColor = System.Drawing.Color.DarkGray;
            this.dgPatients.ParentRowsForeColor = System.Drawing.Color.Black;
            this.dgPatients.ReadOnly = true;
            this.dgPatients.SelectionBackColor = System.Drawing.Color.CadetBlue;
            this.dgPatients.SelectionForeColor = System.Drawing.Color.White;
            this.dgPatients.Size = new System.Drawing.Size(708, 175);
            this.dgPatients.TabIndex = 7;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.txtProvince);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.txtCity);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.txtNOKRelationship);
            this.panel1.Controls.Add(this.txtNextOfKin);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.txtInsurCompany);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.txtInsurenceNumber);
            this.panel1.Controls.Add(this.txtPostalCode);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtAddress);
            this.panel1.Controls.Add(this.txtPhone);
            this.panel1.Controls.Add(this.dtpBirth);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnUpdate);
            this.panel1.Controls.Add(this.btnFind);
            this.panel1.Controls.Add(this.btnAdd);
            this.panel1.Controls.Add(this.lblFName);
            this.panel1.Controls.Add(this.lblLName);
            this.panel1.Controls.Add(this.lblHealthNumber);
            this.panel1.Controls.Add(this.txtFName);
            this.panel1.Controls.Add(this.txtLName);
            this.panel1.Controls.Add(this.txtHealthNumber);
            this.panel1.Location = new System.Drawing.Point(26, 21);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(708, 200);
            this.panel1.TabIndex = 21;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(295, 164);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 13);
            this.label6.TabIndex = 48;
            this.label6.Text = "Relationship:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(8, 164);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 13);
            this.label7.TabIndex = 47;
            this.label7.Text = "Next Of Kin:";
            // 
            // txtNOKRelationship
            // 
            this.txtNOKRelationship.Location = new System.Drawing.Point(405, 161);
            this.txtNOKRelationship.MaxLength = 20;
            this.txtNOKRelationship.Name = "txtNOKRelationship";
            this.txtNOKRelationship.Size = new System.Drawing.Size(168, 20);
            this.txtNOKRelationship.TabIndex = 46;
            // 
            // txtNextOfKin
            // 
            this.txtNextOfKin.Location = new System.Drawing.Point(108, 161);
            this.txtNextOfKin.MaxLength = 20;
            this.txtNextOfKin.Name = "txtNextOfKin";
            this.txtNextOfKin.Size = new System.Drawing.Size(168, 20);
            this.txtNextOfKin.TabIndex = 45;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(295, 138);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(104, 13);
            this.label8.TabIndex = 44;
            this.label8.Text = "Insurence Company:";
            // 
            // txtInsurCompany
            // 
            this.txtInsurCompany.Location = new System.Drawing.Point(405, 135);
            this.txtInsurCompany.MaxLength = 20;
            this.txtInsurCompany.Name = "txtInsurCompany";
            this.txtInsurCompany.Size = new System.Drawing.Size(168, 20);
            this.txtInsurCompany.TabIndex = 43;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 138);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 13);
            this.label4.TabIndex = 42;
            this.label4.Text = "Insurence Number";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(295, 86);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 13);
            this.label5.TabIndex = 41;
            this.label5.Text = "Postal Code:";
            // 
            // txtInsurenceNumber
            // 
            this.txtInsurenceNumber.Location = new System.Drawing.Point(108, 135);
            this.txtInsurenceNumber.MaxLength = 20;
            this.txtInsurenceNumber.Name = "txtInsurenceNumber";
            this.txtInsurenceNumber.Size = new System.Drawing.Size(168, 20);
            this.txtInsurenceNumber.TabIndex = 40;
            // 
            // txtPostalCode
            // 
            this.txtPostalCode.Location = new System.Drawing.Point(405, 83);
            this.txtPostalCode.MaxLength = 20;
            this.txtPostalCode.Name = "txtPostalCode";
            this.txtPostalCode.Size = new System.Drawing.Size(168, 20);
            this.txtPostalCode.TabIndex = 39;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 38;
            this.label2.Text = "Address:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(295, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 37;
            this.label3.Text = "Phone:";
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(108, 83);
            this.txtAddress.MaxLength = 20;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(168, 20);
            this.txtAddress.TabIndex = 36;
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(405, 56);
            this.txtPhone.MaxLength = 20;
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(168, 20);
            this.txtPhone.TabIndex = 35;
            // 
            // dtpBirth
            // 
            this.dtpBirth.Location = new System.Drawing.Point(108, 57);
            this.dtpBirth.Name = "dtpBirth";
            this.dtpBirth.Size = new System.Drawing.Size(168, 20);
            this.dtpBirth.TabIndex = 34;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 33;
            this.label1.Text = "Birth Date:";
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(614, 95);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 30;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnFind
            // 
            this.btnFind.Location = new System.Drawing.Point(614, 63);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(75, 23);
            this.btnFind.TabIndex = 29;
            this.btnFind.Text = "Find";
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(614, 31);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 28;
            this.btnAdd.Text = "Add";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lblFName
            // 
            this.lblFName.AutoSize = true;
            this.lblFName.Location = new System.Drawing.Point(295, 34);
            this.lblFName.Name = "lblFName";
            this.lblFName.Size = new System.Drawing.Size(60, 13);
            this.lblFName.TabIndex = 25;
            this.lblFName.Text = "First Name:";
            // 
            // lblLName
            // 
            this.lblLName.AutoSize = true;
            this.lblLName.Location = new System.Drawing.Point(8, 34);
            this.lblLName.Name = "lblLName";
            this.lblLName.Size = new System.Drawing.Size(61, 13);
            this.lblLName.TabIndex = 24;
            this.lblLName.Text = "Last Name:";
            // 
            // lblHealthNumber
            // 
            this.lblHealthNumber.AutoSize = true;
            this.lblHealthNumber.Location = new System.Drawing.Point(8, 10);
            this.lblHealthNumber.Name = "lblHealthNumber";
            this.lblHealthNumber.Size = new System.Drawing.Size(81, 13);
            this.lblHealthNumber.TabIndex = 23;
            this.lblHealthNumber.Text = "Health Number:";
            // 
            // txtFName
            // 
            this.txtFName.Location = new System.Drawing.Point(405, 31);
            this.txtFName.MaxLength = 20;
            this.txtFName.Name = "txtFName";
            this.txtFName.Size = new System.Drawing.Size(168, 20);
            this.txtFName.TabIndex = 22;
            // 
            // txtLName
            // 
            this.txtLName.Location = new System.Drawing.Point(108, 31);
            this.txtLName.MaxLength = 20;
            this.txtLName.Name = "txtLName";
            this.txtLName.Size = new System.Drawing.Size(168, 20);
            this.txtLName.TabIndex = 21;
            // 
            // txtHealthNumber
            // 
            this.txtHealthNumber.Location = new System.Drawing.Point(108, 7);
            this.txtHealthNumber.MaxLength = 4;
            this.txtHealthNumber.Name = "txtHealthNumber";
            this.txtHealthNumber.Size = new System.Drawing.Size(168, 20);
            this.txtHealthNumber.TabIndex = 20;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(295, 112);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(52, 13);
            this.label9.TabIndex = 52;
            this.label9.Text = "Province:";
            // 
            // txtProvince
            // 
            this.txtProvince.Location = new System.Drawing.Point(405, 109);
            this.txtProvince.MaxLength = 20;
            this.txtProvince.Name = "txtProvince";
            this.txtProvince.Size = new System.Drawing.Size(168, 20);
            this.txtProvince.TabIndex = 51;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(8, 112);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(27, 13);
            this.label10.TabIndex = 50;
            this.label10.Text = "City:";
            // 
            // txtCity
            // 
            this.txtCity.Location = new System.Drawing.Point(108, 109);
            this.txtCity.MaxLength = 20;
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(168, 20);
            this.txtCity.TabIndex = 49;
            // 
            // frmPatients
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.ClientSize = new System.Drawing.Size(752, 478);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgPatients);
            this.Controls.Add(this.btnQuit);
            this.Name = "frmPatients";
            this.Text = "Patients";
            this.Load += new System.EventHandler(this.frmPatients_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgPatients)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

		}
		#endregion


		private void frmPatients_Load(object sender, System.EventArgs e)
		{
			LoadPatientData();

		}

        private void LoadPatientData()
		{
			Patients oPatients = new Patients();
			dgPatients.DataBindings.Clear();
			m_oDS = oPatients.GetData();
			dgPatients.DataSource = m_oDS.Tables["Patients"];

        }

		private void btnAdd_Click(object sender, System.EventArgs e)
		{
			string healthNum = txtHealthNumber.Text ;
			string LName = txtLName.Text ;
			string FName = txtFName.Text;
            DateTime birth = dtpBirth.Value;
            string phone = txtPhone.Text;
            string address = txtAddress.Text;
            string postal = txtPostalCode.Text;
            string city = txtCity.Text;
            string province = txtProvince.Text;
            string insurNum = txtInsurenceNumber.Text;
            string insurComp = txtInsurCompany.Text;
            string nextOfKin = txtNextOfKin.Text;
            string nextOKRelation = txtNOKRelationship.Text;
            string sMsg = "";

			Patients oPatients = new Patients();

			try
			{
				sMsg = oPatients.AddData(healthNum,LName, FName, birth, address, postal,city,province, phone, insurComp, insurNum, nextOfKin, nextOKRelation);
                LoadPatientData();
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

		private void btnFind_Click(object sender, System.EventArgs e)
		{
			string patID = txtHealthNumber.Text ;
			string sMsg = "";

			DataSet o_Find = new DataSet ();
			Patients oPatients = new Patients();

			try
			{
				o_Find = oPatients.FindData(patID);
				txtLName.Text = o_Find.Tables["Patients"].Rows[0]["LastName"].ToString ();
				txtFName.Text = o_Find.Tables["Patients"].Rows[0]["FirstName"].ToString ();
                dtpBirth.Text = o_Find.Tables["Patients"].Rows[0]["Birth"].ToString();
                txtPhone.Text = o_Find.Tables["Patients"].Rows[0]["Phone"].ToString();
                txtAddress.Text = o_Find.Tables["Patients"].Rows[0]["Address"].ToString();
                txtPostalCode.Text = o_Find.Tables["Patients"].Rows[0]["PostalCode"].ToString();
                txtCity.Text = o_Find.Tables["Patients"].Rows[0]["City"].ToString();
                txtProvince.Text = o_Find.Tables["Patients"].Rows[0]["Province"].ToString();
                txtInsurenceNumber.Text = o_Find.Tables["Patients"].Rows[0]["InsuranceNumber"].ToString();
                txtInsurCompany.Text = o_Find.Tables["Patients"].Rows[0]["InsuranceCompany"].ToString();
                txtNextOfKin.Text = o_Find.Tables["Patients"].Rows[0]["NextOfKin"].ToString();
                txtNOKRelationship.Text = o_Find.Tables["Patients"].Rows[0]["NextOfKinRelationship"].ToString();
                sMsg = "Patient record found.";
			}
			catch
			{
				sMsg = "Patient not in database.";
				txtHealthNumber.Text = "";
			}
			finally
			{
				MessageBox.Show (sMsg, "Find Record", MessageBoxButtons.OK);
			}
		}

		private void btnUpdate_Click(object sender, System.EventArgs e)
		{
            string healthNum = txtHealthNumber.Text;
            string LName = txtLName.Text;
            string FName = txtFName.Text;
            DateTime birth = dtpBirth.Value;
            string phone = txtPhone.Text;
            string address = txtAddress.Text;
            string postal = txtPostalCode.Text;
            string city = txtCity.Text;
            string province = txtProvince.Text;
            string insurNum = txtInsurenceNumber.Text;
            string insurComp = txtInsurCompany.Text;
            string nextOfKin = txtNextOfKin.Text;
            string nextOKRelation = txtNOKRelationship.Text;
            string sMsg = "";

            Patients oPatients = new Patients();

			try
			{
				sMsg = oPatients.UpdateData(healthNum,LName, FName, birth, address, postal,city,province, phone, insurComp, insurNum, nextOfKin, nextOKRelation);
                LoadPatientData();
            }
			catch
			{
				sMsg = "Error saving data." + "\n\n" + e.ToString();
			}
			finally
			{
				MessageBox.Show (sMsg, "Update Record", MessageBoxButtons.OK);
			}		
		}

		private void btnQuit_Click(object sender, System.EventArgs e)
		{
			this.Close ();
		}

        private void btnSave_Click(object sender, EventArgs e)
        {
            
        }
    }
}
