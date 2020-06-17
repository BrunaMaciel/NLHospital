using System;
using System.Data ;
using System.Data.SqlClient ;

namespace NLHospitalLibrary
{
	/// <summary>
	/// Summary description for Patients.
	/// </summary>
	public class Patients
	{
		private DataSet m_oDS ; 
		private SqlConnection m_oCn ;    
		private SqlDataAdapter m_oDA;
		private string m_sClassName = "Patients";
		private string sSQL;

		public string pLast;
		public string pFirst;
		public string pAddress;
		public string pCity;
		public string pProv;
		public string pPost;

		public Patients()
		{
			//
			// TODO: Add constructor logic here
			//

			SqlCommand oSelCmd;
			SqlCommand oInsCmd;
			SqlCommand oUpdCmd;

			InitializeConnection();

			sSQL = "SELECT HealthNumber, LastName, FirstName, Birth, " +
				" Address, PostalCode, City, Province,Phone, InsuranceCompany, InsuranceNumber, " +
				" NextOfKin, NextOfKinRelationship " +
				" FROM	Patients " +
				" ORDER BY HealthNumber  ";
			oSelCmd = null;
			oSelCmd = new SqlCommand(sSQL, m_oCn);
			oSelCmd.CommandType = CommandType.Text;

			sSQL = "UPDATE Patients " +
				" SET LastName = @LastName, FirstName = @FirstName, " +
				" Birth = @Birth, Address = @Address, "+
                " PostalCode = @PostalCode, City=@City, Province=@Province," +
                "Phone = @Phone, InsuranceCompany = @InsuranceCompany, " +
				" InsuranceNumber = @InsuranceNumber, NextOfKin = @NextOfKin, " +
				" NextOfKinRelationship = @NextOfKinRelationship"+
				" WHERE HealthNumber  = @HealthNumber  ";
			oUpdCmd = null;
			oUpdCmd = new SqlCommand(sSQL, m_oCn);
			oUpdCmd.CommandType = CommandType.Text;
			oUpdCmd.Parameters.Add(new SqlParameter("@LastName", SqlDbType.NVarChar, 30, "LastName"));
			oUpdCmd.Parameters.Add(new SqlParameter("@FirstName", SqlDbType.NVarChar, 30, "FirstName"));
			oUpdCmd.Parameters.Add(new SqlParameter("@HealthNumber", SqlDbType.NVarChar, 15, "HealthNumber"));
			oUpdCmd.Parameters.Add(new SqlParameter("@Birth", SqlDbType.DateTime, 8, "Birth"));
			oUpdCmd.Parameters.Add(new SqlParameter("@Address", SqlDbType.NVarChar, 50, "Address"));
			oUpdCmd.Parameters.Add(new SqlParameter("@PostalCode", SqlDbType.NVarChar, 7, "PostalCode"));
            oUpdCmd.Parameters.Add(new SqlParameter("@City", SqlDbType.NVarChar, 30, "City"));
            oUpdCmd.Parameters.Add(new SqlParameter("@Province", SqlDbType.NVarChar, 2, "Province"));
            oUpdCmd.Parameters.Add(new SqlParameter("@Phone", SqlDbType.NVarChar , 14, "Phone"));
			oUpdCmd.Parameters.Add(new SqlParameter("@InsuranceCompany", SqlDbType.NVarChar, 15, "InsuranceCompany"));
			oUpdCmd.Parameters.Add(new SqlParameter("@InsuranceNumber", SqlDbType.NVarChar, 15, "InsuranceNumber"));
			oUpdCmd.Parameters.Add(new SqlParameter("@NextOfKin", SqlDbType.NVarChar, 10, "NextOfKin"));
            oUpdCmd.Parameters.Add(new SqlParameter("@NextOfKinRelationship", SqlDbType.NVarChar, 10, "NextOfKinRelationship"));

            sSQL = "INSERT INTO Patients " +
				" (LastName, FirstName, HealthNumber, " +
				" Birth, Address, " +
				" PostalCode, City, Province, Phone, InsuranceCompany, " +
				" InsuranceNumber, NextOfKin , NextOfKinRelationship)" +
				" VALUES (@LastName, @FirstName, @HealthNumber, " +
				" @Birth, @Address, PostalCode, @City, @Province, @Phone, @InsuranceCompany, " +
				" @InsuranceNumber, @NextOfKin , @NextOfKinRelationship)" ;
			oInsCmd = null;
			oInsCmd = new SqlCommand(sSQL, m_oCn);
			oInsCmd.CommandType = CommandType.Text;
			oInsCmd.Parameters.Add(new SqlParameter("@LastName", SqlDbType.NVarChar, 30, "LastName"));
			oInsCmd.Parameters.Add(new SqlParameter("@FirstName", SqlDbType.NVarChar, 30, "FirstName"));
			oInsCmd.Parameters.Add(new SqlParameter("@HealthNumber", SqlDbType.NVarChar, 15, "HealthNumber"));
			oInsCmd.Parameters.Add(new SqlParameter("@Birth", SqlDbType.DateTime, 8, "Birth"));
			oInsCmd.Parameters.Add(new SqlParameter("@Address", SqlDbType.NVarChar, 50, "Address"));
			oInsCmd.Parameters.Add(new SqlParameter("@PostalCode", SqlDbType.NVarChar, 7, "PostalCode"));
            oInsCmd.Parameters.Add(new SqlParameter("@City", SqlDbType.NVarChar, 30, "City"));
            oInsCmd.Parameters.Add(new SqlParameter("@Province", SqlDbType.NVarChar, 2, "Province"));
            oInsCmd.Parameters.Add(new SqlParameter("@Phone", SqlDbType.NVarChar , 14, "Phone"));
			oInsCmd.Parameters.Add(new SqlParameter("@InsuranceCompany", SqlDbType.NVarChar, 15, "InsuranceCompany"));
			oInsCmd.Parameters.Add(new SqlParameter("@InsuranceNumber", SqlDbType.NVarChar, 15, "InsuranceNumber"));
			oInsCmd.Parameters.Add(new SqlParameter("@NextOfKin", SqlDbType.NVarChar, 30, "NextOfKin"));
			oInsCmd.Parameters.Add(new SqlParameter("@NextOfKinRelationship", SqlDbType.NVarChar, 10, "NextOfKinRelationship"));


			m_oDA = new SqlDataAdapter();
			m_oDA.SelectCommand = oSelCmd;
			m_oDA.UpdateCommand = oUpdCmd;
			m_oDA.InsertCommand = oInsCmd;

			m_oCn = null;

		}

		public string AddData(string health, string LN, string FN, DateTime dob,
			string address, string post, string city, string province,string phone, 
			string insCo, string insNum, string kin, string kinRel)
		{
			string sMsg = "";

			try
			{
				InitializeConnection();
				m_oCn.Open();
				DataSet thisDataSet = new DataSet();
				m_oDA.Fill (thisDataSet, m_sClassName);

				DataColumn[] keys = new DataColumn [1];
				keys[0] = thisDataSet.Tables ["Patients"].Columns["HealthNumber"];
				thisDataSet.Tables ["Patients"].PrimaryKey = keys;
				DataRow findRow = thisDataSet.Tables ["Patients"].Rows.Find (health);


                if (findRow == null)
				{
					DataRow thisRow = thisDataSet.Tables["Patients"].NewRow();
					thisRow["HealthNumber"] = health;
					thisRow["LastName"] = LN;
					thisRow["FirstName"] = FN;
					thisRow["Birth"] = dob;
					thisRow["Address"] = address;
					thisRow["PostalCode"] = post;
                    thisRow["City"] = city;
                    thisRow["Province"] = province;
                    thisRow["Phone"] = phone;
                    if (insCo!="")
                        thisRow["InsuranceCompany"] = Convert.ToInt32(insCo);
                    if(insNum!="")
                        thisRow["InsuranceNumber"] = insNum;
					thisRow["NextOfKin"] = kin;
					thisRow["NextOfKinRelationship"] = kinRel;
					
					thisDataSet.Tables["Patients"].Rows.Add(thisRow);
					if ((findRow = thisDataSet.Tables ["Patients"].Rows.Find (health)) != null)
					{
						sMsg = " Patient Record Was Added";
					}					
				}
				else
				{
					sMsg = " Patient " + " already present in database.";
				}

				m_oDA.Update (thisDataSet, m_sClassName);

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

		public DataSet FindData(string ID)
		{
			InitializeConnection();
			m_oCn.Open();
			DataSet thisDataSet = new DataSet();
			DataSet foundDataSet = new DataSet();
            

            try
			{
				m_oDA.Fill (thisDataSet, m_sClassName);
				for (int n = 0; n < thisDataSet.Tables["Patients"].Rows.Count ; n++)
				{
					if (thisDataSet.Tables["Patients"].Rows[n]["HealthNumber"].ToString () == ID)
					{
						m_oDA.Fill(foundDataSet,n,1,m_sClassName);
                        
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

		public string UpdateData(string ID, string LN, string FN, DateTime birth,
			string address, string post, string city, string province,string phone, 
			string insCo, string insNum, string kin, string kinRel)
		{
			string sMsg = "";

			try
			{
				InitializeConnection();
				m_oCn.Open();
				DataSet thisDataSet = new DataSet();
				m_oDA.Fill (thisDataSet, m_sClassName);

				thisDataSet.Tables["Patients"].Rows[0]["HealthNumber"] = ID;
				thisDataSet.Tables["Patients"].Rows[0]["LastName"] = LN;
				thisDataSet.Tables["Patients"].Rows[0]["FirstName"] = FN;
				thisDataSet.Tables["Patients"].Rows[0]["Birth"] = birth;
				thisDataSet.Tables["Patients"].Rows[0]["Address"] = address;
				thisDataSet.Tables["Patients"].Rows[0]["PostalCode"] = post;
                thisDataSet.Tables["Patients"].Rows[0]["City"] = city;
                thisDataSet.Tables["Patients"].Rows[0]["Province"] = province;
                thisDataSet.Tables["Patients"].Rows[0]["Phone"] = phone;
                if (insCo!="")
				    thisDataSet.Tables["Patients"].Rows[0]["InsuranceCompany"] = Convert.ToInt32(insCo);
				thisDataSet.Tables["Patients"].Rows[0]["InsuranceNumber"] = insNum;
				thisDataSet.Tables["Patients"].Rows[0]["NextOfKin"] = kin;
				thisDataSet.Tables["Patients"].Rows[0]["NextOfKinRelationship"] = kinRel;

				m_oDA.Update (thisDataSet, m_sClassName);
                sMsg = "Record Updated";

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
				sMsg = lRecsAffected + " Patient Records Were Updated";
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



		private void InitializeConnection()
		{
			m_oCn = new SqlConnection(
				@"Data Source=(local);Integrated Security=SSPI;" 
				+ "Initial Catalog=NLHospital");
		}

        public DataSet GetData()
        {
            m_oDS = new DataSet();
            m_oDA.Fill(m_oDS, m_sClassName);
            return m_oDS;
        }

        public void GetPatientInfo(string pID)
		{
			DataSet pDataSet = new DataSet();
			pDataSet = FindData (pID);

			pLast = pDataSet.Tables["Patients"].Rows[0]["LastName"].ToString ();
			pFirst = pDataSet.Tables["Patients"].Rows[0]["FirstName"].ToString ();
			pAddress = pDataSet.Tables["Patients"].Rows[0]["Address"].ToString ();			
			pCity = pDataSet.Tables["Patients"].Rows[0]["City"].ToString ();
			pProv = pDataSet.Tables["Patients"].Rows[0]["Province"].ToString ();
			pPost = pDataSet.Tables["Patients"].Rows[0]["PostalCode"].ToString ();
		}
	}
}
