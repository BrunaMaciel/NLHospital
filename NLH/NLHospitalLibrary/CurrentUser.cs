using System;

namespace NLHospitalLibrary
{
	/// <summary>
	/// Summary description for Class1.
	/// </summary>
	public class CurrentUser
	{
		private string user;
        private string type;

		public string UserName
		{
			get
			{
				return user;
			}
			set
			{
				user = value;
			}
		}

        public string Type { get => type; set => type = value; }

        public CurrentUser()
		{
			//
			// TODO: Add constructor logic here
			//
		}

		public CurrentUser(string userID, string type)
		{
            //include type variable to identify the employee type
			UserName = userID;
            Type = type;
		}
	}
}
