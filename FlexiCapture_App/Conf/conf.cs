using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlexiCapture_App.Conf
{
    class conf
    {
        private String connectionString;

        public String getConnectionString()
        {
            // Calls Connection String thru ConfigureManager getting the content from the App.config
            connectionString = ConfigurationManager.ConnectionStrings["DBConsoleApp.Properties.Settings.ConsoleDB_ConnectionString"].ConnectionString; // Gets the <connectionStrings> tag information in the App.config
            return connectionString; // Returns the ConnectionString
        }
    }
}
