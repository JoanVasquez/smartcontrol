using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartControl
{
    // Esta clase servirá como un modelo para un usuario, simulando una entidad (Tabla) en la base de datos
    internal class User
    {
        // Propiedad que almacena el identificador único del usuario
        public int Id { get; set; }

        // Propiedad que almacena el nombre de usuario
        public string Username { get; set; }

        // Propiedad que almacena la contraseña del usuario
        public string Password { get; set; }

        // Constructor que inicializa las propiedades del usuario: Id, Username y Password
        public User(int id, string username, string password)
        {
            // Asignación de los valores de los parámetros a las propiedades de la clase
            this.Id = id;
            this.Username = username;
            this.Password = password;
        }
    }
}
