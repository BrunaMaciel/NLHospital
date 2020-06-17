namespace NLHospital
{
    partial class frmAdmissions
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
            this.crvAdmissions = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.AdmissionsReport = new NLHospital.AdmissionsReport();
            this.SuspendLayout();
            // 
            // crvAdmissions
            // 
            this.crvAdmissions.ActiveViewIndex = 0;
            this.crvAdmissions.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crvAdmissions.Cursor = System.Windows.Forms.Cursors.Default;
            this.crvAdmissions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crvAdmissions.Location = new System.Drawing.Point(0, 0);
            this.crvAdmissions.Name = "crvAdmissions";
            this.crvAdmissions.ReportSource = this.AdmissionsReport;
            this.crvAdmissions.Size = new System.Drawing.Size(1365, 450);
            this.crvAdmissions.TabIndex = 0;
            // 
            // frmAdmissions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1365, 450);
            this.Controls.Add(this.crvAdmissions);
            this.Name = "frmAdmissions";
            this.Text = "Admissions";
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crvAdmissions;
        private AdmissionsReport AdmissionsReport;
    }
}