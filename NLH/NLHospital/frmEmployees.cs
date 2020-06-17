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
	public class frmEmployees : NLHBase
	{
		private System.Windows.Forms.Button btnQuit;
		private System.Windows.Forms.DataGrid dgEmployees;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		DataSet m_oDS = new DataSet();
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Label lblSpecialty;
		private System.Windows.Forms.Label lblFName;
		private System.Windows.Forms.Label lblLName;
		private System.Windows.Forms.Label lblEmployeeID;
		private System.Windows.Forms.TextBox txtFName;
		private System.Windows.Forms.TextBox txtLName;
		private System.Windows.Forms.TextBox txtEmployeeID;
		private System.Windows.Forms.ComboBox cboSpecialty;
		private System.Windows.Forms.Button btnAdd;
		private System.Windows.Forms.Button btnFind;
		private System.Windows.Forms.Button btnUpdate;
		private System.Windows.Forms.Button btnDelete;
        private ComboBox cboType;
        private Label label1;
        DataSet m_oSP = new DataSet();

		public frmEmployees()
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
            this.dgEmployees = new System.Windows.Forms.DataGrid();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cboType = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnFind = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.cboSpecialty = new System.Windows.Forms.ComboBox();
            this.lblSpecialty = new System.Windows.Forms.Label();
            this.lblFName = new System.Windows.Forms.Label();
            this.lblLName = new System.Windows.Forms.Label();
            this.lblEmployeeID = new System.Windows.Forms.Label();
            this.txtFName = new System.Windows.Forms.TextBox();
            this.txtLName = new System.Windows.Forms.TextBox();
            this.txtEmployeeID = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgEmployees)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnQuit
            // 
            this.btnQuit.Location = new System.Drawing.Point(189, 374);
            this.btnQuit.Name = "btnQuit";
            this.btnQuit.Size = new System.Drawing.Size(75, 23);
            this.btnQuit.TabIndex = 4;
            this.btnQuit.Text = "Quit";
            this.btnQuit.Click += new System.EventHandler(this.btnQuit_Click);
            // 
            // dgEmployees
            // 
            this.dgEmployees.AlternatingBackColor = System.Drawing.Color.LightGray;
            this.dgEmployees.BackColor = System.Drawing.Color.Gainsboro;
            this.dgEmployees.BackgroundColor = System.Drawing.Color.Silver;
            this.dgEmployees.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgEmployees.CaptionBackColor = System.Drawing.Color.LightSteelBlue;
            this.dgEmployees.CaptionForeColor = System.Drawing.Color.MidnightBlue;
            this.dgEmployees.DataMember = "";
            this.dgEmployees.FlatMode = true;
            this.dgEmployees.Font = new System.Drawing.Font("Tahoma", 8F);
            this.dgEmployees.ForeColor = System.Drawing.Color.Black;
            this.dgEmployees.GridLineColor = System.Drawing.Color.DimGray;
            this.dgEmployees.GridLineStyle = System.Windows.Forms.DataGridLineStyle.None;
            this.dgEmployees.HeaderBackColor = System.Drawing.Color.MidnightBlue;
            this.dgEmployees.HeaderFont = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.dgEmployees.HeaderForeColor = System.Drawing.Color.White;
            this.dgEmployees.LinkColor = System.Drawing.Color.MidnightBlue;
            this.dgEmployees.Location = new System.Drawing.Point(24, 8);
            this.dgEmployees.Name = "dgEmployees";
            this.dgEmployees.ParentRowsBackColor = System.Drawing.Color.DarkGray;
            this.dgEmployees.ParentRowsForeColor = System.Drawing.Color.Black;
            this.dgEmployees.ReadOnly = true;
            this.dgEmployees.SelectionBackColor = System.Drawing.Color.CadetBlue;
            this.dgEmployees.SelectionForeColor = System.Drawing.Color.White;
            this.dgEmployees.Size = new System.Drawing.Size(408, 200);
            this.dgEmployees.TabIndex = 7;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.cboType);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnDelete);
            this.panel1.Controls.Add(this.btnUpdate);
            this.panel1.Controls.Add(this.btnFind);
            this.panel1.Controls.Add(this.btnAdd);
            this.panel1.Controls.Add(this.cboSpecialty);
            this.panel1.Controls.Add(this.lblSpecialty);
            this.panel1.Controls.Add(this.lblFName);
            this.panel1.Controls.Add(this.lblLName);
            this.panel1.Controls.Add(this.lblEmployeeID);
            this.panel1.Controls.Add(this.txtFName);
            this.panel1.Controls.Add(this.txtLName);
            this.panel1.Controls.Add(this.txtEmployeeID);
            this.panel1.Location = new System.Drawing.Point(16, 232);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(416, 136);
            this.panel1.TabIndex = 21;
            // 
            // cboType
            // 
            this.cboType.Location = new System.Drawing.Point(88, 80);
            this.cboType.Name = "cboType";
            this.cboType.Size = new System.Drawing.Size(168, 21);
            this.cboType.TabIndex = 33;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 32;
            this.label1.Text = "Type";
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(312, 104);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 31;
            this.btnDelete.Text = "Delete";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(312, 72);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 30;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnFind
            // 
            this.btnFind.Location = new System.Drawing.Point(312, 40);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(75, 23);
            this.btnFind.TabIndex = 29;
            this.btnFind.Text = "Find";
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(312, 8);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 28;
            this.btnAdd.Text = "Add";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click_1);
            // 
            // cboSpecialty
            // 
            this.cboSpecialty.Location = new System.Drawing.Point(88, 104);
            this.cboSpecialty.Name = "cboSpecialty";
            this.cboSpecialty.Size = new System.Drawing.Size(168, 21);
            this.cboSpecialty.TabIndex = 27;
            // 
            // lblSpecialty
            // 
            this.lblSpecialty.AutoSize = true;
            this.lblSpecialty.Location = new System.Drawing.Point(8, 106);
            this.lblSpecialty.Name = "lblSpecialty";
            this.lblSpecialty.Size = new System.Drawing.Size(50, 13);
            this.lblSpecialty.TabIndex = 26;
            this.lblSpecialty.Text = "Specialty";
            // 
            // lblFName
            // 
            this.lblFName.AutoSize = true;
            this.lblFName.Location = new System.Drawing.Point(8, 58);
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
            // lblEmployeeID
            // 
            this.lblEmployeeID.AutoSize = true;
            this.lblEmployeeID.Location = new System.Drawing.Point(8, 10);
            this.lblEmployeeID.Name = "lblEmployeeID";
            this.lblEmployeeID.Size = new System.Drawing.Size(70, 13);
            this.lblEmployeeID.TabIndex = 23;
            this.lblEmployeeID.Text = "Employee ID:";
            // 
            // txtFName
            // 
            this.txtFName.Location = new System.Drawing.Point(88, 58);
            this.txtFName.MaxLength = 20;
            this.txtFName.Name = "txtFName";
            this.txtFName.Size = new System.Drawing.Size(168, 20);
            this.txtFName.TabIndex = 22;
            // 
            // txtLName
            // 
            this.txtLName.Location = new System.Drawing.Point(88, 34);
            this.txtLName.MaxLength = 20;
            this.txtLName.Name = "txtLName";
            this.txtLName.Size = new System.Drawing.Size(168, 20);
            this.txtLName.TabIndex = 21;
            // 
            // txtEmployeeID
            // 
            this.txtEmployeeID.Location = new System.Drawing.Point(88, 10);
            this.txtEmployeeID.MaxLength = 4;
            this.txtEmployeeID.Name = "txtEmployeeID";
            this.txtEmployeeID.Size = new System.Drawing.Size(100, 20);
            this.txtEmployeeID.TabIndex = 20;
            // 
            // frmEmployees
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.ClientSize = new System.Drawing.Size(452, 404);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgEmployees);
            this.Controls.Add(this.btnQuit);
            this.Name = "frmEmployees";
            this.Text = "Employees";
            this.Load += new System.EventHandler(this.frmEmployees_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgEmployees)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

		}
		#endregion


		private void frmEmployees_Load(object sender, System.EventArgs e)
		{
			LoadEmployeeData();
			LoadSpecialtyData();
		}
         private void LoadSpecialtyData()
        {
            Specialities oSpecialities = new Specialities();
            cboSpecialty.DataBindings.Clear();
            m_oDS = oSpecialities.GetData();
            cboSpecialty.DataSource = m_oDS.Tables["Specialities"];
            cboSpecialty.DisplayMember = "Name";
            cboSpecialty.ValueMember = "Name";
            cboSpecialty.SelectedValue = "General";
        }

        private void LoadEmployeeData()
		{
			Employees oEmployee = new Employees();
			dgEmployees.DataBindings.Clear();
			m_oDS = oEmployee.GetData();
			dgEmployees.DataSource = m_oDS.Tables["Employees"];

            EmployeeType oEmployeeType = new EmployeeType();
            cboType.DataBindings.Clear();
            m_oDS = oEmployeeType.GetData();
            cboType.DataSource = m_oDS.Tables["EmployeeType"];
            cboType.DisplayMember = "Name";
            cboType.ValueMember = "Name";

        }

        //code without use
		/*private void btnAdd_Click(object sender, System.EventArgs e)
		{
			string empID = txtEmployeeID.Text ;
			string LName = txtLName.Text ;
			string FName = txtFName.Text;
			string sPec = cboSpecialty.SelectedItem.ToString();
			string sMsg = "";

			DataSet o_Add = new DataSet ();
			Employees oEmployees = new Employees();

			try
			{
				sMsg = oEmployees.AddData(empID,LName,FName,sPec);
			}
			catch
			{
				sMsg = "Error saving data." + "\n\n" + e.ToString();
			}
			finally
			{
				MessageBox.Show (sMsg, "Add Record", MessageBoxButtons.OK);
			}
		}*/

		private void btnAdd_Click_1(object sender, System.EventArgs e)
		{
			string empID = txtEmployeeID.Text ;
			string LName = txtLName.Text ;
			string FName = txtFName.Text;
			string sPec = cboSpecialty.Text;
            string etype = cboType.Text;
            string sMsg = "";

			Employees oEmployees = new Employees();

			try
			{
				sMsg = oEmployees.AddData(empID,LName,FName,etype,sPec);
                LoadEmployeeData();
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
			string empID = txtEmployeeID.Text ;
			string sMsg = "";

			DataSet o_Find = new DataSet ();
			Employees oEmployees = new Employees();

			try
			{
				o_Find = oEmployees.FindData(empID);
				txtLName.Text = o_Find.Tables["Employees"].Rows[0]["LName"].ToString ();
				txtFName.Text = o_Find.Tables["Employees"].Rows[0]["FName"].ToString ();
				cboSpecialty.Text = o_Find.Tables["Employees"].Rows[0]["Specialty"].ToString ();
                cboType.Text = o_Find.Tables["Employees"].Rows[0]["EType"].ToString();
                sMsg = "Employee record found.";
			}
			catch
			{
				sMsg = "Employee not in database.";
				txtEmployeeID.Text = "";
			}
			finally
			{
				MessageBox.Show (sMsg, "Find Record", MessageBoxButtons.OK);
			}
		}

		private void btnDelete_Click(object sender, System.EventArgs e)
		{
			string empID = txtEmployeeID.Text ;
			string sMsg = "";

			DataSet o_Delete = new DataSet ();
			Employees oEmployees = new Employees();

			try
			{
				sMsg = oEmployees.DeleteData(empID);
				LoadEmployeeData();
				txtEmployeeID.Text = "";
				txtLName.Text = "";
				txtFName.Text = "";
				sMsg = "Employee record deleted.";
			}
			catch
			{
				sMsg = "Error deleting data." + "\n\n" + e.ToString();
			}
			finally
			{
				MessageBox.Show (sMsg, "Delete Record", MessageBoxButtons.OK);
			}
		
		}

		private void btnUpdate_Click(object sender, System.EventArgs e)
		{
			string empID = txtEmployeeID.Text ;
			string LName = txtLName.Text ;
			string FName = txtFName.Text;
			string sPec = cboSpecialty.Text;
            string etype = cboType.Text;
            string sMsg = "";

			Employees oEmployees = new Employees();

			try
			{
				sMsg = oEmployees.UpdateData(empID,LName,FName, etype,sPec);
                LoadEmployeeData();
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
