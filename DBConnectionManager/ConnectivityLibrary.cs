using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace DBConnectionManager
{
    public class ConnectivityLibrary
    {
        public string GetConnectionString()
        {
            string returnValue = null;

            var settings =
                ConfigurationManager.ConnectionStrings["DBConnectionManager.Properties.Settings.mainSQLdbConnectionString"];

            //If found, return the connection string.  
            if (settings != null)
                returnValue = settings.ConnectionString;

            return returnValue;
        }

        
    }
}
