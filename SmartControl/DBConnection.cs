using MySql.Data.MySqlClient; 
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartControl
{
    // Clase que maneja la conexión con la base de datos MySQL
    internal class DBConnection
    {
        // Cadena de conexión que especifica cómo conectarse a la base de datos
        // Incluye el servidor, la base de datos, el usuario y la contraseña
        private string stringConnection = "Server=localhost;Database=smartcontroldb;User ID=root;Password=pass22;";

        // Objeto MySqlConnection que manejará la conexión
        private MySqlConnection dbConnection;

        // Método que retorna la conexión a la base de datos
        public MySqlConnection getConnection()
        {
            try
            {
                // Inicializa el objeto MySqlConnection con la cadena de conexión
                dbConnection = new MySqlConnection(stringConnection);

                // Retorna la conexión
                return dbConnection;
            }
            catch (Exception ex) // Captura cualquier excepción que ocurra al intentar la conexión
            {
                // Muestra un mensaje de error si ocurre una excepción
                MessageBox.Show(ex.Message);
            }

            // Retorna null si ocurre un error
            return null;
        }

        // Método que cierra la conexión a la base de datos
        public void closeConnection()
        {
            // Verifica si la conexión no es nula antes de intentar cerrarla
            if (dbConnection != null)
            {
                dbConnection.Close(); // Cierra la conexión
            }
        }
    }
}
