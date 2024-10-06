using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartControl
{
    internal class DBConnection
    {
        private string stringConnection = "Server=localhost;Database=smartcontroldb;User ID=root;Password=pass22;";
        private MySqlConnection dbConnection;

        public MySqlConnection getConnection()
        {
            try
            {
                dbConnection = new MySqlConnection(stringConnection);
                return dbConnection;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            return null;

        }

        public void closeConnection()
        {
            if (dbConnection != null)
            {
                dbConnection.Close();
            }
        }
    }
}
