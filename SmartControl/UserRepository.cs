using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartControl
{
    //Esta clase implementa la interfaz IUser la cual contiene el metodo login
    internal class UserRepository: IUser
    {
        /*
         * Creamos una instancia de la clase DBConnection para conectarnos a la BD
         * creamos una variable string para la query del usuario en donde estaremos pasandole como parametros el username y la password para evitar inyecciones de dependencias
         * Creamos una instancia de MySqlDataReader para leer datos de la BD
         * Creamos una instancia de MySqlCommand para ejecutar query sql
         */
        private DBConnection connection = new DBConnection();
        private string loginQuery = "SELECT * FROM usuarios WHERE NombreUsuario = @username and Contraseña = @password";
        private MySqlDataReader dataReader;
        private MySqlCommand command;

        //Este metodo es el de la interfaz IUser que devolvera un usuario, basado en la logica de negocio para loguearse
        public User Login(string username, string password)
        {
            try
            {
                //Conseguimos la conexion de la BD
                MySqlConnection conn = connection.getConnection();
                //Abrimos la conexion
                conn.Open();
                //Conseguimos una instancia de MysqlCommand
                command = conn.CreateCommand();
                //Le asignamos la query al mysqlcommand
                command.CommandText = loginQuery;
                //Le pasamos los paratros de usuario y password
                command.Parameters.AddWithValue("@username", username);
                command.Parameters.AddWithValue("@password", password);
                //Ejecutamos la query
                dataReader = command.ExecuteReader();

                //Verificamos que se haya traido un usuario de la BD
                if (dataReader.Read())
                {
                    //Creamos un objeto de usuario
                    User user = new User(
                        Convert.ToInt32(dataReader.GetInt32("id")),
                        dataReader.GetString("NombreUsuario"),
                        dataReader.GetString("Contraseña")
                    );

                    //retornamos dicho objeto
                    return user;
                }
            }
            catch (Exception ex)
            {
                //En caso de que haya habido un error muestra el mensaje de error
                MessageBox.Show(ex.Message);
            }
            finally
            {
                //Cerramos la conexion de la BD
                connection.closeConnection();
            }

            return null;
        }
    }
}
