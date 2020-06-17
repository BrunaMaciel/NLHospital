using System;
using System.Data ;
using System.Data.SqlClient ;

namespace NLHospitalLibrary
{
	/// <summary>
	/// Summary description for Admissions.
	/// </summary>
	public class Admissions
	{
		private DataSet m_oDS ; 
		private SqlConnection m_oCn ;    
		private SqlDataAdapter m_oDA;
		private string m_sClassName = "Admissions";
		private string sSQL;	

		public Admissions()
		{
			//
			// TODO: Add constructor logic here
			//
			SqlCommand oSelCmd;
            SqlCommand oInsCmd;
            SqlCommand oUpdCmd;

            InitializeConnection();

			sSQL = "SELECT ID, PatientID, DoctorID, Bed,Ward, " +
				" SurgeryDate, AdmissionDate, DischargeDate, TV , Phone, SemiPrivate, Private" +
				" FROM	Admissions " +
				" ORDER BY ID ";
			oSelCmd = null;
			oSelCmd = new SqlCommand(sSQL, m_oCn);
			oSelCmd.CommandType = CommandType.Text;

            sSQL = "UPDATE Admissions SET PatientID=@PatientID,DoctorID=@DoctorID, Bed=@Bed,Ward=@Ward, " +
                " SurgeryDate=@SurgeryDate, AdmissionDate=@AdmissionDate, DischargeDate=@DischargeDate, "+
                "TV=@TV , Phone=@Phone, SemiPrivate=@SemiPrivate, Private=@Private " +
                "WHERE ID=@ID ";
            oUpdCmd = null;
            oUpdCmd = new SqlCommand(sSQL, m_oCn);
            oUpdCmd.CommandType = CommandType.Text;
            oUpdCmd.Parameters.Add(new SqlParameter("@ID", SqlDbType.Int, 4, "ID"));
            oUpdCmd.Parameters.Add(new SqlParameter("@PatientID", SqlDbType.NVarChar, 15, "PatientID"));
            oUpdCmd.Parameters.Add(new SqlParameter("@DoctorID", SqlDbType.NVarChar, 15, "DoctorID"));
            oUpdCmd.Parameters.Add(new SqlParameter("@Bed", SqlDbType.NVarChar, 4, "Bed"));
            oUpdCmd.Parameters.Add(new SqlParameter("@Ward", SqlDbType.NVarChar, 15, "Ward"));
            oUpdCmd.Parameters.Add(new SqlParameter("@SurgeryDate", SqlDbType.DateTime, 8, "SurgeryDate"));
            oUpdCmd.Parameters.Add(new SqlParameter("@AdmissionDate", SqlDbType.DateTime, 8, "AdmissionDate"));
            oUpdCmd.Parameters.Add(new SqlParameter("@DischargeDate", SqlDbType.DateTime, 8, "DischargeDate"));
            oUpdCmd.Parameters.Add(new SqlParameter("@TV", SqlDbType.Bit, 1, "TV"));
            oUpdCmd.Parameters.Add(new SqlParameter("@Phone", SqlDbType.Bit, 1, "Phone"));
            oUpdCmd.Parameters.Add(new SqlParameter("@SemiPrivate", SqlDbType.Bit, 1, "SemiPrivate"));
            oUpdCmd.Parameters.Add(new SqlParameter("@Private", SqlDbType.Bit, 1, "Private"));


            sSQL = "INSERT INTO Admissions " +
                " (ID,PatientID, DoctorID, Bed,Ward, " +
                " SurgeryDate, AdmissionDate, DischargeDate, TV , Phone, SemiPrivate, Private)" +
                " VALUES (@ID, @PatientID, @DoctorID, @Bed,@Ward, " +
                " @SurgeryDate, @AdmissionDate, @DischargeDate, @TV , @Phone, @SemiPrivate, @Private)";
            oInsCmd = null;
            oInsCmd = new SqlCommand(sSQL, m_oCn);
            oInsCmd.CommandType = CommandType.Text;
            oInsCmd.Parameters.Add(new SqlParameter("@ID", SqlDbType.Int, 4, "ID"));
            oInsCmd.Parameters.Add(new SqlParameter("@PatientID", SqlDbType.NVarChar, 15, "PatientID"));
            oInsCmd.Parameters.Add(new SqlParameter("@DoctorID", SqlDbType.NVarChar, 15, "DoctorID"));
            oInsCmd.Parameters.Add(new SqlParameter("@Bed", SqlDbType.NVarChar, 4, "Bed"));
            oInsCmd.Parameters.Add(new SqlParameter("@Ward", SqlDbType.NVarChar, 15, "Ward"));
            oInsCmd.Parameters.Add(new SqlParameter("@SurgeryDate", SqlDbType.DateTime, 8, "SurgeryDate"));
            oInsCmd.Parameters.Add(new SqlParameter("@AdmissionDate", SqlDbType.DateTime, 8, "AdmissionDate"));
            oInsCmd.Parameters.Add(new SqlParameter("@DischargeDate", SqlDbType.DateTime, 8, "DischargeDate"));
            oInsCmd.Parameters.Add(new SqlParameter("@TV", SqlDbType.Bit, 1, "TV"));
            oInsCmd.Parameters.Add(new SqlParameter("@Phone", SqlDbType.Bit, 1, "Phone"));
            oInsCmd.Parameters.Add(new SqlParameter("@SemiPrivate", SqlDbType.Bit, 1, "SemiPrivate"));
            oInsCmd.Parameters.Add(new SqlParameter("@Private", SqlDbType.Bit, 1, "Private"));

            m_oDA = new SqlDataAdapter();
            m_oDA.SelectCommand = oSelCmd;
            m_oDA.UpdateCommand = oUpdCmd;
            m_oDA.InsertCommand = oInsCmd;

            m_oCn = null;

        }
        
		public DataSet FindData(string ID)
		{
			InitializeConnection();
			m_oCn.Open();
			DataSet thisDataSet = new DataSet();
			DataSet foundDataSet = new DataSet();
			try
			{
				m_oDA.Fill (thisDataSet, m_sClassName);
				for (int n = 0; n < thisDataSet.Tables["Admissions"].Rows.Count ; n++)
				{
					if (thisDataSet.Tables["Admissions"].Rows[n]["ID"].ToString () == ID)
					{
						m_oDA.Fill(foundDataSet,n,1,"Admissions");							
					}
				}
			}
			catch 
			{
			}
			finally
			{
				m_oCn.Close();
				m_oCn = null;
			}
			return foundDataSet;
		}


		public DataSet GetData()
		{
			m_oDS = new DataSet();
			m_oDA.Fill(m_oDS, m_sClassName);
			return m_oDS;
		}

		private void InitializeConnection()
		{
			m_oCn = new SqlConnection(
				@"Data Source=(local);Integrated Security=SSPI;" 
				+ "Initial Catalog=NLHospital");
		}


		public string SetPatientDischarge(string ID)
		{
            /*Function changed:
             * return voit to string
             * new if that checks if patient wasn't already discharged
            */
			InitializeConnection();
			m_oCn.Open();
            string sMsg = "";
            DataSet thisDataSet = new DataSet ();
            Beds oBeds = new Beds();
			try
			{
				m_oDA.Fill (thisDataSet, m_sClassName);
				for (int n = 0; n < thisDataSet.Tables["Admissions"].Rows.Count ; n++)
				{
					if (thisDataSet.Tables["Admissions"].Rows[n]["PatientID"].ToString () == ID)
					{
                        if (thisDataSet.Tables["Admissions"].Rows[n]["DischargeDate"] == System.DBNull.Value)
                        {
                            thisDataSet.Tables["Admissions"].Rows[n]["DischargeDate"] = DateTime.Today.Date;

                            m_oDA.Update(thisDataSet, m_sClassName);
                            oBeds.FreeBed(thisDataSet.Tables["Admissions"].Rows[n]["Bed"].ToString());
                            sMsg = "Patient Discharged";
                        }
                        else
                        {
                            sMsg = "Patient already discharged.";
                        }
                    }
				}
            }
            catch (Exception e)
            {
                sMsg = "Patient was not discharged. " + e.Message.ToString();
            }
            finally
			{
				m_oCn.Close();
				m_oCn = null;
			}
            return sMsg;
		}

		public int GetDays(string ID)
		{
			int days;
			DateTime dis = new DateTime();
			DateTime ad = new DateTime ();
            
			DataSet thisDataSet = new DataSet();
			thisDataSet = this.FindData (ID);

			ad = Convert.ToDateTime (thisDataSet.Tables["Admissions"].Rows [0]["AdmissionDate"]);
			dis = Convert.ToDateTime (thisDataSet.Tables["Admissions"].Rows [0]["DischargeDate"]);
			
			days = dis.Day - ad.Day;

			return days;

		}

        public string AddData(string admID, DateTime admission,DateTime surgery, string docID, string patID, 
                                string ward, string bed,bool tv, bool phone, bool semi, bool priv)
        {
            string sMsg = "";

            try
            {
                InitializeConnection();
                m_oCn.Open();
                DataSet thisDataSet = new DataSet();
                m_oDA.Fill(thisDataSet, m_sClassName);

                string filter = "PatientID='" + patID + "' AND DischargeDate is null";
                DataRow[] patientHosp = thisDataSet.Tables["Admissions"].Select(filter);
                if (patientHosp.Length != 0)
                {
                    return " Patient already hospitalized.";
                }

                DataColumn[] keys = new DataColumn[1];
                keys[0] = thisDataSet.Tables["Admissions"].Columns["ID"];
                thisDataSet.Tables["Admissions"].PrimaryKey = keys;
                DataRow findRow = thisDataSet.Tables["Admissions"].Rows.Find(admID);


                if (findRow == null)
                {
                    DataRow thisRow = thisDataSet.Tables["Admissions"].NewRow();
                    thisRow["ID"] = admID;
                    thisRow["AdmissionDate"] = admission;
                    thisRow["SurgeryDate"] = surgery;
                    thisRow["DoctorID"] = docID;
                    thisRow["PatientID"] = patID;
                    thisRow["Ward"] = ward;
                    thisRow["Bed"] = bed;
                    thisRow["TV"] = tv;
                    thisRow["Phone"] = phone;
                    thisRow["SemiPrivate"] = semi;
                    thisRow["Private"] = priv;

                    Beds oBeds = new Beds();
                    oBeds.OccupyBed(bed);

                    thisDataSet.Tables["Admissions"].Rows.Add(thisRow);
                    if ((findRow = thisDataSet.Tables["Admissions"].Rows.Find(admID)) != null)
                    {
                        sMsg = " Admission Record Was Added";
                    }

                }
                else
                {
                    sMsg = " Admission " +admID + " already present in database.";
                }

                m_oDA.Update(thisDataSet, m_sClassName);

            }
            catch (Exception e)
            {
                sMsg = "Record was not added" + e.Message.ToString();
            }
            finally
            {
                m_oCn.Close();
                m_oCn = null;
            }
            return sMsg;
        }

        public string UpdateData(string admID, DateTime admission, DateTime surgery, string docID, string patID,
                                string ward, string bed, bool tv, bool phone, bool semi, bool priv)
        {
            string sMsg = "";

            try
            {
                InitializeConnection();
                m_oCn.Open();
                DataSet thisDataSet = new DataSet();
                m_oDA.Fill(thisDataSet, m_sClassName);

                DataColumn[] keys = new DataColumn[1];
                keys[0] = thisDataSet.Tables["Admissions"].Columns["ID"];
                thisDataSet.Tables["Admissions"].PrimaryKey = keys;
                DataRow findRow = thisDataSet.Tables["Admissions"].Rows.Find(admID);
                if (!findRow.IsNull("DischargeDate"))
                {
                    return "Can't update a discharged admission.";
                }

                if (findRow != null)
                {
                    findRow["ID"] = admID;
                    findRow["AdmissionDate"] = admission;
                    findRow["SurgeryDate"] = surgery;
                    findRow["DoctorID"] = docID;
                    findRow["PatientID"] = patID;
                    findRow["Ward"] = ward;
                    findRow["Bed"] = bed;
                    findRow["TV"] = tv;
                    findRow["Phone"] = phone;
                    findRow["SemiPrivate"] = semi;
                    findRow["Private"] = priv;

                    sMsg = " Admission Record Was Updated";
                }
                else
                {
                    sMsg = " Admission " + " not present in database.";
                }

                m_oDA.Update(thisDataSet, m_sClassName);

            }
            catch (Exception e)
            {
                sMsg = "Record was not updated" + e.Message.ToString();
            }
            finally
            {
                m_oCn.Close();
                m_oCn = null;
            }
            return sMsg;
        }
    }
}

