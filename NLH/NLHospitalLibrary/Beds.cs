using System;
using System.Data;
using System.Data.SqlClient ;

namespace NLHospitalLibrary
{
	/// <summary>
	/// Summary description for Beds.
	/// </summary>
	public class Beds
	{
		private DataSet m_oDS ; 
		private SqlConnection m_oCn ;    
		private SqlDataAdapter m_oDA;
		private string m_sClassName = "Beds";
		private string sSQL;

		public Beds()
		{
			//
			// TODO: Add constructor logic here
			//
			SqlCommand oSelCmd;

			InitializeConnection();

			sSQL = "SELECT ID, BedType, Occupied, Ward "  +
				" FROM	Beds " +
				" ORDER BY ID ";
			oSelCmd = null;
			oSelCmd = new SqlCommand(sSQL, m_oCn);
			oSelCmd.CommandType = CommandType.Text;

			m_oDA = new SqlDataAdapter();
			m_oDA.SelectCommand = oSelCmd;

			m_oCn = null;

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
        public DataSet FindData(string ID)
        {
            InitializeConnection();
            m_oCn.Open();
            DataSet thisDataSet = new DataSet();
            DataSet foundDataSet = new DataSet();


            try
            {
                m_oDA.Fill(thisDataSet, m_sClassName);
                for (int n = 0; n < thisDataSet.Tables["Beds"].Rows.Count; n++)
                {
                    if (thisDataSet.Tables["Beds"].Rows[n]["ID"].ToString() == ID)
                    {
                        m_oDA.Fill(foundDataSet, n, 1, m_sClassName);

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

        public string FindAvailableBed(string wardName, string bedType)
		{
            string ward = wardName.Substring(0, 1);
			string bednumber = "none available";
			string tempbed;
			bool occupied = true;

			DataSet thisDataSet = new DataSet();

			m_oDA.Fill (thisDataSet, m_sClassName);
            
            for (int n = 0; n < thisDataSet.Tables["Beds"].Rows.Count ; n++)
			{
				tempbed = thisDataSet.Tables["Beds"].Rows[n]["ID"].ToString ();
				if (tempbed.StartsWith(ward))
				{
                    if (thisDataSet.Tables["Beds"].Rows[n]["BedType"].ToString() == bedType)
                    {
                        occupied = Convert.ToBoolean(thisDataSet.Tables["Beds"].Rows[n]["Occupied"]);
                        if (!occupied)
                            return tempbed;
                    }
				}
			}
            
			return bednumber;
		}
        public string OccupyBed (string ID)
        {
            string sMsg = "";

            try
            {
                DataSet oBed = FindData(ID);


                if (oBed != null)
                {
                    oBed.Tables["Beds"].Rows[0]["Occupied"] = true;

                    sMsg = " Bed " + ID + "is now occupied";
                }
                else
                {
                    sMsg = " Bed " +ID+ " not present in database.";
                }

                m_oDA.Update(oBed, m_sClassName);

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
        public string FreeBed(string ID)
        {
            string sMsg = "";

            try
            {
                DataSet oBed = FindData(ID);


                if (oBed != null)
                {
                    oBed.Tables["Beds"].Rows[0]["Occupied"] = false;

                    sMsg = " Bed " + ID + "is now free";
                }
                else
                {
                    sMsg = " Bed " + ID + " not present in database.";
                }

                m_oDA.Update(oBed, m_sClassName);

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
