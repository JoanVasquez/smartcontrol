using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartControl
{
    internal class CategoryRepository : IRepository<Category>
    {
        private DBConnection connection = new DBConnection();
        private string allCategoryQuery = "SELECT * FROM categories";
        private MySqlDataReader dataReader;
        private MySqlCommand command;

        public List<Category> FindAll()
        {
            List<Category> categories = new List<Category>();
            try
            {
                MySqlConnection conn = connection.getConnection();
                conn.Open();
                command = conn.CreateCommand();
                command.CommandText = allCategoryQuery;
                dataReader = command.ExecuteReader();


                while (dataReader.Read())
                {
                    Category category = new Category(
                        Convert.ToInt32(dataReader.GetInt32("id")),
                        dataReader.GetString("Nombre"),
                        dataReader.GetString("Tipo")
                    );

                    categories.Add(category);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            } finally
            {
                connection.closeConnection();
            }

            return categories;
        }

        public Category Save(Category entity)
        {
            throw new NotImplementedException();
        }
    }
}
