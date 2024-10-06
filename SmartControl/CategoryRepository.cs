using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartControl
{
    // Clase que implementa el repositorio de la entidad 'Category', utilizando el patrón de repositorio
    internal class CategoryRepository : IRepository<Category>
    {
        // Instancia de la clase DBConnection para gestionar la conexión a la base de datos
        private DBConnection connection = new DBConnection();

        // Consulta SQL para obtener todas las categorías de la base de datos
        private string allCategoryQuery = "SELECT * FROM categorias";

        // DataReader para leer los resultados de la consulta
        private MySqlDataReader dataReader;

        // Comando SQL que se enviará a la base de datos
        private MySqlCommand command;

        // Método que recupera todas las categorías de la base de datos
        public List<Category> FindAll()
        {
            // Lista donde se almacenarán las categorías recuperadas
            List<Category> categories = new List<Category>();

            try
            {
                // Obtiene la conexión a la base de datos y la abre
                MySqlConnection conn = connection.getConnection();
                conn.Open();

                // Crea el comando SQL a partir de la conexión
                command = conn.CreateCommand();
                command.CommandText = allCategoryQuery; // Asigna la consulta SQL al comando

                // Ejecuta el comando y obtiene un lector de datos
                dataReader = command.ExecuteReader();

                // Itera sobre los resultados de la consulta
                while (dataReader.Read())
                {
                    // Crea una nueva instancia de Category con los datos obtenidos
                    Category category = new Category(
                        Convert.ToInt32(dataReader.GetInt32("id")), // Convierte el valor de "id" a int
                        dataReader.GetString("Nombre"),             // Obtiene el nombre de la categoría
                        dataReader.GetString("Tipo")                // Obtiene el tipo de la categoría
                    );

                    // Añade la categoría a la lista
                    categories.Add(category);
                }
            }
            catch (Exception ex) // Captura cualquier excepción que ocurra durante la operación
            {
                // Muestra un mensaje de error si ocurre una excepción
                MessageBox.Show(ex.Message);
            }
            finally
            {
                // Cierra la conexión a la base de datos
                connection.closeConnection();
            }

            // Retorna la lista de categorías
            return categories;
        }

        // Método que guarda una categoría en la base de datos (no implementado)
        public Category Save(Category entity)
        {
            throw new NotImplementedException(); // Indica que este método no está implementado
        }
    }
}
