using System;
using System.Data ;
using System.Data.SqlClient ;


namespace NLHospitalLibrary
{
	/// <summary>
	/// Summary description for Class1.
	/// </summary>
	public class Employees
	{
		private DataSet m_oDS ; 
		private SqlConnection m_oCn ;    
		private SqlDataAdapter m_oDA;
		private string m_sClassName = "Employees";
		private string sSQL;

		public Employees()
		{
			//
			// TODO: Add constructor logic here
			SqlCommand oSelCmd;
			SqlCommand oInsCmd;
			SqlCommand oUpdCmd;
			SqlCommand oDelCmd;

			InitializeConnection();

			sSQL = "SELECT ID, LName, FName, EType, Specialty " +
				" FROM	Employees " +
				" ORDER BY ID ";
			oSelCmd = null;
			oSelCmd = new SqlCommand(sSQL, m_oCn);
			oSelCmd.CommandType = CommandType.Text;

			sSQL = "UPDATE Employees " +
				" SET LName = @LName, FName = @FName, EType = @EType, Specialty = @Specialty " +
				" WHERE ID = @ID ";
			oUpdCmd = null;
			oUpdCmd = new SqlCommand(sSQL, m_oCn);
			oUpdCmd.CommandType = CommandType.Text;
			oUpdCmd.Parameters.Add(new SqlParameter("@LName", SqlDbType.NVarChar, 30, "LName"));
			oUpdCmd.Parameters.Add(new SqlParameter("@FName", SqlDbType.NVarChar, 30, "FName"));
            oUpdCmd.Parameters.Add(new SqlParameter("@EType", SqlDbType.NVarChar, 15, "EType"));
            oUpdCmd.Parameters.Add(new SqlParameter("@Specialty", SqlDbType.NVarChar, 15, "Specialty"));
			oUpdCmd.Parameters.Add(new SqlParameter("@ID", SqlDbType.Int, 4, "ID"));

			sSQL = "INSERT INTO Employees " +
				" (LName, FName, EType, Specialty, ID)" +
				" VALUES (@LName, @FName, @EType, @Specialty, @ID)";
			oInsCmd = null;
			oInsCmd = new SqlCommand(sSQL, m_oCn);
			oInsCmd.CommandType = CommandType.Text;
			oInsCmd.Parameters.Add(new SqlParameter("@LName", SqlDbType.NVarChar, 30, "LName"));
			oInsCmd.Parameters.Add(new SqlParameter("@FName", SqlDbType.NVarChar, 30, "FName"));
            oInsCmd.Parameters.Add(new SqlParameter("@EType", SqlDbType.NVarChar, 15, "EType"));
            oInsCmd.Parameters.Add(new SqlParameter("@Specialty", SqlDbType.NVarChar, 15, "Specialty"));
			oInsCmd.Parameters.Add(new SqlParameter("@ID", SqlDbType.NChar, 4, "ID"));

			sSQL = "DELETE Employees " +
				" WHERE ID = @ID ";
			oDelCmd = null;
			oDelCmd = new SqlCommand(sSQL, m_oCn);
			oDelCmd.CommandType = CommandType.Text;
			oDelCmd.Parameters.Add(new SqlParameter("@ID", SqlDbType.NChar, 4, "ID"));

			m_oDA = new SqlDataAdapter();
			m_oDA.SelectCommand = oSelCmd;
			m_oDA.UpdateCommand = oUpdCmd;
			m_oDA.DeleteCommand = oDelCmd;
			m_oDA.InsertCommand = oInsCmd;

			m_oCn = null;

		}

		public string AddData(string ID, string LN, string FN, string ET, string spec)
		{
			string sMsg = "";

			try
			{
				InitializeConnection();
				m_oCn.Open();
				DataSet thisDataSet = new DataSet();
				m_oDA.Fill (thisDataSet, "Employees");

				DataColumn[] keys = new DataColumn [1];
				keys[0] = thisDataSet.Tables ["Employees"].Columns["ID"];
				thisDataSet.Tables ["Employees"].PrimaryKey = keys;
				DataRow findRow = thisDataSet.Tables ["Employees"].Rows.Find (ID);

				if (findRow == null)
				{
					DataRow thisRow = thisDataSet.Tables["Employees"].NewRow();
					thisRow["ID"] = ID;
					thisRow["LName"] = LN;
					thisRow["FName"] = FN;
                    thisRow["EType"] = ET;
                    thisRow["Specialty"] = spec;
					thisDataSet.Tables["Employees"].Rows.Add(thisRow);
					if ((findRow = thisDataSet.Tables ["Employees"].Rows.Find (ID)) != null)
					{
						sMsg = " Employee Record Was Added";
					}					
				}
				else
				{
					sMsg = " Employee " + ID + " already present in database.";
				}

				m_oDA.Update (thisDataSet, "Employees");

			}
			catch (Exception e)
			{
				sMsg = "Record was not added. " + e.Message.ToString();
			}
			finally
			{
				m_oCn.Close();
				m_oCn = null;
			}
			return sMsg;
			
		}

		public DataSet FindData(string ID)
		{
			InitializeConnection();
			m_oCn.Open();
			DataSet thisDataSet = new DataSet();
			DataSet foundDataSet = new DataSet();
			try
			{
				m_oDA.Fill (thisDataSet, "Employees");
				for (int n = 0; n < thisDataSet.Tables["Employees"].Rows.Count ; n++)
				{
					if (thisDataSet.Tables["Employees"].Rows[n]["ID"].ToString () == ID)
					{
						m_oDA.Fill(foundDataSet,n,1,"Employees");							
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

        public DataRow FindDoctor(string ID)
        {
            InitializeConnection();
            m_oCn.Open();
            DataSet thisDataSet = new DataSet();
            DataSet foundDataSet = new DataSet();
            try
            {
                m_oDA.Fill(thisDataSet, "Employees");
                DataRow[] doctors = thisDataSet.Tables["Employees"].Select("EType='Doctor'");

                foreach(DataRow d in doctors)
                {
                    if (d["ID"].ToString() == ID)
                    {
                        return d;
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
            return null;
        }
        public string UpdateData(string ID, string LN, string FN, string ET,string spec)
		{
			string sMsg = "";

			try
			{

				InitializeConnection();
				m_oCn.Open();
				DataSet thisDataSet = new DataSet();
				m_oDA.Fill (thisDataSet, "Employees");

				thisDataSet.Tables["Employees"].Rows[0]["ID"] = ID;
				thisDataSet.Tables["Employees"].Rows[0]["LName"] = LN;
				thisDataSet.Tables["Employees"].Rows[0]["FName"] = FN;
                thisDataSet.Tables["Employees"].Rows[0]["EType"] = ET;
                thisDataSet.Tables["Employees"].Rows[0]["Specialty"] = spec;
				m_oDA.Update (thisDataSet, "Employees");
                sMsg = " Employee Record Was Updated";

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

		public string DeleteData(string ID)
		{
			string sMsg = "";

			try
			{
				InitializeConnection();
				m_oCn.Open();
				DataSet thisDataSet = new DataSet();
				m_oDA.Fill (thisDataSet, "Employees");

				DataColumn[] keys = new DataColumn [1];
				keys[0] = thisDataSet.Tables ["Employees"].Columns["ID"];
				thisDataSet.Tables ["Employees"].PrimaryKey = keys;
				DataRow findRow = thisDataSet.Tables ["Employees"].Rows.Find (ID);

				if (findRow == null)
				{
					sMsg = " Employee " + ID + " not present in database.";
				}
				else
				{
					findRow.Delete();
					m_oDA.Update (thisDataSet, "Employees");
					sMsg = " Employee " + ID + " deleted from database.";
				}

			}
			catch (Exception e)
			{
				sMsg = "Record was not deleted" + e.Message.ToString();
			}
			finally
			{
				m_oCn.Close();
				m_oCn = null;
			}
			return sMsg;
			
		}


		public string SaveData(DataSet oDS)
		{
			string sMsg;
			long lRecsAffected;
			SqlTransaction oTran = null;

			try
			{
				InitializeConnection();
				m_oCn.Open();
				oTran = m_oCn.BeginTransaction();
				lRecsAffected = m_oDA.Update(oDS, m_sClassName);
				oTran.Commit();
				sMsg = lRecsAffected + " Employee Records Were Updated";
			}
			catch (Exception e)
			{
				oTran.Rollback();
				sMsg = "Records were not updated" + e.Message.ToString();
			}
			finally
			{
				oTran = null;
				m_oCn.Close();
				m_oCn = null;
			}
			return sMsg;
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
	}
}
