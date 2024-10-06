using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartControl
{
    internal class UserRepository: IUser
    {
        private DBConnection connection = new DBConnection();
        private string loginQuery = "SELECT * FROM usuarios WHERE NombreUsuario = @username and Contraseña = @password";
        private MySqlDataReader dataReader;
        private MySqlCommand command;

        public User Login(string username, string password)
        {
            try
            {
                MySqlConnection conn = connection.getConnection();
                conn.Open();
                command = conn.CreateCommand();
                command.CommandText = loginQuery;
                command.Parameters.AddWithValue("@username", username);
                command.Parameters.AddWithValue("@password", password);
                dataReader = command.ExecuteReader();

                if (dataReader.Read())
                {
                    User user = new User(
                        Convert.ToInt32(dataReader.GetInt32("id")),
                        dataReader.GetString("NombreUsuario"),
                        dataReader.GetString("Contraseña")
                    );

                    return user;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                connection.closeConnection();
            }

            return null;
        }
    }
}
