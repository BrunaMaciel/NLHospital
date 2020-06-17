using System;
using System.Data ;
using System.Data .SqlClient ;

namespace NLHospitalLibrary
{
	/// <summary>
	/// Summary description for Rates.
	/// </summary>
	public class Rates
	{
		private DataSet m_oDS ; 
		private SqlConnection m_oCn ;    
		private SqlDataAdapter m_oDA;
		private string m_sClassName = "ExtraRates";
		private string sSQL;

		public decimal TVRate;
		public decimal PhoneRate;
		public decimal SemiRate;
		public decimal PrivateRate;

		public Rates()
		{
			//
			// TODO: Add constructor logic here
			//
			SqlCommand oSelCmd;

			InitializeConnection();

			sSQL = "SELECT Name, DailyRate FROM ExtraRates " ;
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


		public void GetRates ()
		{
			DataSet thisDataSet = new DataSet();

			thisDataSet = this.GetData();

			for (int n = 0; n < thisDataSet.Tables["ExtraRates"].Rows.Count ; n++)
			{
				
				if (thisDataSet.Tables ["ExtraRates"].Rows[n]["Name"].ToString () == "TV")
				{
					TVRate = Convert.ToDecimal (thisDataSet.Tables ["ExtraRates"].Rows[n]["DailyRate"]);
				}

				if (thisDataSet.Tables ["ExtraRates"].Rows[n]["Name"].ToString () == "Phone")
				{
					PhoneRate = Convert.ToDecimal (thisDataSet.Tables ["ExtraRates"].Rows[n]["DailyRate"]);
				}

				if (thisDataSet.Tables ["ExtraRates"].Rows[n]["Name"].ToString () == "Semi-private")
				{
					SemiRate = Convert.ToDecimal (thisDataSet.Tables ["ExtraRates"].Rows[n]["DailyRate"]);
				}

				if (thisDataSet.Tables ["ExtraRates"].Rows[n]["Name"].ToString () == "Private")
				{
                    //missing convert
					PrivateRate = Convert.ToDecimal(thisDataSet.Tables ["ExtraRates"].Rows[n]["DailyRate"]);
				}
			}

		}
	}
}
