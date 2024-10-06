using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SmartControl
{
    public partial class SmartControlForm : Form
    {
        private CategoryRepository categoryRepository = new CategoryRepository();
        private TransactionRepository transactionRepository = new TransactionRepository();

        public SmartControlForm()
        {
            InitializeComponent();
        }

        private void fillCategory(string type)
        {
            List<Category> categories = new List<Category>();

            foreach (Category categoryItem in categoryRepository.FindAll())
            {
                if (type == categoryItem.Type)
                {
                    categories.Add(categoryItem);
                }
            }

            cbCategory.DataSource = categories;
            cbCategory.DisplayMember = "Name";
        }

        private void cbTransactionType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbTransactionType.SelectedItem != null)
            {
                fillCategory(cbTransactionType.Text);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            
            Transaction transaction = new Transaction(new DateTime(), Decimal.Parse(txtAmount.Text), cbTransactionType.Text, txtDescription.Text);

        }
    }
}
