using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartControl
{
    internal class TransactionRepository : IRepository<Transaction>
    {
        private DBConnection dbConnection = new DBConnection();
        private string insertTransaction = "INSERT INTO transacciones VALUES(@Fecha, @Tipo, @Monto, @Descripcion)"; 
        public List<Transaction> FindAll()
        {
            throw new NotImplementedException();
        }

        public Transaction Save(Transaction entity)
        {
            try
            {
                MySqlConnection myCon = dbConnection.getConnection();
                myCon.Open();
                MySqlCommand mySqlCommand = myCon.CreateCommand();
                mySqlCommand.CommandText = insertTransaction;
                mySqlCommand.Parameters.AddWithValue("@Fecha", entity.Date);
                mySqlCommand.Parameters.AddWithValue("@Tipo", entity.TransactionType);
                mySqlCommand.Parameters.AddWithValue("@Monto", entity.Amount);
                mySqlCommand.Parameters.AddWithValue("@Descripcion", entity.Description);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            return null;
        }
    }
}
