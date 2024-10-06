using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartControl
{
    // Clase que implementa el repositorio para la entidad Transaction
    // Se utiliza el patrón de repositorio para gestionar las transacciones en la base de datos
    internal class TransactionRepository : IRepository<Transaction>
    {
        // Instancia de DBConnection para manejar la conexión a la base de datos
        private DBConnection dbConnection = new DBConnection();

        // Consulta SQL para insertar una nueva transacción en la tabla 'transacciones'
        private string insertTransaction = "INSERT INTO transacciones (Fecha, Tipo, Monto, Descripcion, Categoria) VALUES(@Fecha, @Tipo, @Monto, @Descripcion, @Categoria)";

        // Consulta SQL para leer todas las transacciones de la tabla 'transacciones'
        private string readTransactions = "SELECT * FROM transacciones";

        // Método que obtiene todas las transacciones desde la base de datos
        public List<Transaction> FindAll()
        {
            List<Transaction> transactions = new List<Transaction>(); // Lista donde se almacenarán las transacciones

            try
            {
                // Abre la conexión a la base de datos
                MySqlConnection myCon = dbConnection.getConnection();
                myCon.Open();

                // Crea un comando SQL para ejecutar la consulta de lectura de transacciones
                MySqlCommand mySqlCommand = myCon.CreateCommand();
                mySqlCommand.CommandText = readTransactions; // Asigna la consulta SQL al comando

                // Ejecuta la consulta y obtiene un lector de datos
                MySqlDataReader mySqlDataReader = mySqlCommand.ExecuteReader();

                // Lee los resultados de la consulta
                while (mySqlDataReader.Read())
                {
                    // Crea una nueva instancia de Transaction y asigna los valores obtenidos de la base de datos
                    Transaction transaction = new Transaction();
                    transaction.Id = Convert.ToInt32(mySqlDataReader["Id"]);
                    transaction.Amount = Convert.ToDecimal(mySqlDataReader["Monto"]);
                    transaction.TransactionType = mySqlDataReader.GetString("Tipo");
                    transaction.Category = mySqlDataReader.GetString("Categoria");
                    transaction.Description = mySqlDataReader.GetString("Descripcion");
                    transaction.Date = Convert.ToDateTime(mySqlDataReader["Fecha"]);

                    // Añade la transacción a la lista
                    transactions.Add(transaction);
                }
            }
            catch (Exception ex) // Captura cualquier error que ocurra durante la operación
            {
                // Muestra un mensaje de error si ocurre una excepción
                MessageBox.Show(ex.Message);
            }
            finally
            {
                // Cierra la conexión a la base de datos
                dbConnection.closeConnection();
            }

            // Retorna la lista de transacciones
            return transactions;
        }

        // Método que guarda una nueva transacción en la base de datos
        public Transaction Save(Transaction entity)
        {
            try
            {
                // Abre la conexión a la base de datos
                MySqlConnection myCon = dbConnection.getConnection();
                myCon.Open();

                // Crea un comando SQL para ejecutar la consulta de inserción
                MySqlCommand mySqlCommand = myCon.CreateCommand();
                mySqlCommand.CommandText = insertTransaction; // Asigna la consulta SQL al comando

                // Añade los parámetros correspondientes a la consulta SQL
                mySqlCommand.Parameters.AddWithValue("@Fecha", DateTime.Now); // Fecha actual
                mySqlCommand.Parameters.AddWithValue("@Tipo", entity.TransactionType); // Tipo de transacción
                mySqlCommand.Parameters.AddWithValue("@Monto", entity.Amount); // Monto de la transacción
                mySqlCommand.Parameters.AddWithValue("@Descripcion", entity.Description); // Descripción de la transacción
                mySqlCommand.Parameters.AddWithValue("@Categoria", entity.Category); // Categoría de la transacción

                // Ejecuta la consulta de inserción
                mySqlCommand.ExecuteNonQuery();

                // Obtiene el Id de la transacción recién insertada
                long insertedId = mySqlCommand.LastInsertedId;
                entity.Id = (int)insertedId; // Asigna el Id a la entidad

                return entity; // Retorna la transacción guardada con su Id
            }
            catch (Exception ex) // Captura cualquier error que ocurra durante la operación
            {
                // Muestra un mensaje de error si ocurre una excepción
                MessageBox.Show(ex.Message);
            }
            finally
            {
                // Cierra la conexión a la base de datos
                dbConnection.closeConnection();
            }

            return null; // Retorna null si ocurre un error
        }
    }
}
