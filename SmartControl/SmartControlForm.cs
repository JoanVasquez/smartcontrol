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
    // Clase parcial que representa la ventana principal de la aplicación SmartControl
    public partial class SmartControlForm : Form
    {
        // Repositorios para gestionar las entidades Category y Transaction
        private CategoryRepository categoryRepository = new CategoryRepository();
        private TransactionRepository transactionRepository = new TransactionRepository();

        // Constructor del formulario, inicializa los componentes y llena la tabla de transacciones
        public SmartControlForm()
        {
            InitializeComponent();
            fillDataGridView();
        }

        // Método para cambiar los encabezados de las columnas del DataGridView de transacciones
        private void changeDataGridViewHeaders()
        {
            dgvTransactions.Columns[0].HeaderCell.Value = "Id"; // Encabezado para la columna Id
            dgvTransactions.Columns[1].HeaderCell.Value = "Monto"; // Encabezado para la columna Monto
            dgvTransactions.Columns[2].HeaderCell.Value = "Tipo"; // Encabezado para la columna Tipo
            dgvTransactions.Columns[3].HeaderCell.Value = "Categoria"; // Encabezado para la columna Categoria
            dgvTransactions.Columns[4].HeaderCell.Value = "Descripcion"; // Encabezado para la columna Descripcion
            dgvTransactions.Columns[5].HeaderCell.Value = "Fecha"; // Encabezado para la columna Fecha
        }

        // Método para llenar el DataGridView con todas las transacciones y actualizar las etiquetas de ingresos/gastos
        private void fillDataGridView()
        {
            List<Transaction> transactionList = transactionRepository.FindAll(); // Obtiene todas las transacciones
            dgvTransactions.DataSource = transactionList; // Asigna los datos al DataGridView
            fillTransactionTxt(transactionList); // Actualiza los textos de ingresos, gastos y balance
            changeDataGridViewHeaders(); // Cambia los encabezados de las columnas
        }

        // Método para calcular y mostrar la suma de ingresos, gastos y el balance
        private void fillTransactionTxt(List<Transaction> transactions)
        {
            Decimal incomeSum = 0; // Suma de ingresos
            Decimal spentSum = 0; // Suma de gastos

            // Itera sobre todas las transacciones para calcular ingresos y gastos
            foreach (Transaction transaction in transactions)
            {
                // Si es ingreso o depósito bancario, se suma a los ingresos
                if (transaction.TransactionType == "Ingreso" || transaction.Category == "Depósito Bancario")
                {
                    incomeSum += transaction.Amount;
                }
                // Si es gasto, transferencia o pago con tarjeta de crédito, se suma a los gastos
                else if (transaction.TransactionType == "Gasto" || transaction.Category == "Transferencia Bancaria" || transaction.Category == "Pago Tarjeta de Crédito")
                {
                    spentSum += transaction.Amount;
                }
            }

            // Actualiza los campos de texto con los resultados
            txtIncome.Text = incomeSum.ToString(); // Muestra la suma de ingresos
            txtTotalBills.Text = spentSum.ToString(); // Muestra la suma de gastos
            txtBalance.Text = (incomeSum - spentSum).ToString(); // Calcula y muestra el balance
        }

        // Método para llenar el ComboBox de categorías en función del tipo de transacción seleccionado
        private void fillCategory(string type)
        {
            List<Category> categories = new List<Category>();

            // Filtra las categorías según el tipo y las añade a la lista
            foreach (Category categoryItem in categoryRepository.FindAll())
            {
                if (type == categoryItem.Type)
                {
                    categories.Add(categoryItem);
                }
            }

            // Asigna las categorías filtradas al ComboBox y establece el campo a mostrar
            cbCategory.DataSource = categories;
            cbCategory.DisplayMember = "Name";
        }

        // Evento que se dispara al cambiar el tipo de transacción en el ComboBox
        private void cbTransactionType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbTransactionType.SelectedItem != null)
            {
                // Llena el ComboBox de categorías según el tipo de transacción seleccionado
                fillCategory(cbTransactionType.Text);
            }
        }

        // Evento que se dispara al hacer clic en el botón de agregar una transacción
        private void btnAdd_Click(object sender, EventArgs e)
        {
            // Crea una nueva transacción con los datos ingresados en los campos de texto
            Transaction transaction = new Transaction(Decimal.Parse(txtAmount.Text), cbTransactionType.Text, cbCategory.Text, txtDescription.Text);

            // Guarda la transacción en el repositorio
            Transaction savedTransaction = transactionRepository.Save(transaction);

            // Muestra un mensaje de confirmación si la transacción fue guardada correctamente
            if (savedTransaction != null)
            {
                MessageBox.Show("Transaccion realizada");
            }
        }

        // Evento que se dispara al hacer clic en el botón de filtrar transacciones por fechas
        private void btnFilter_Click(object sender, EventArgs e)
        {
            DateTime startDateFilter = dtpStartDateFilter.Value; // Fecha de inicio del filtro
            DateTime endDateFilter = dtpEndDatePicker.Value; // Fecha de fin del filtro

            List<Transaction> transactionList = transactionRepository.FindAll(); // Obtiene todas las transacciones
            List<Transaction> filteredTransactions = new List<Transaction>(); // Lista de transacciones filtradas

            // Valida que la fecha de inicio no sea mayor a la fecha final
            if (endDateFilter < startDateFilter)
            {
                MessageBox.Show("La fecha de inicio debe ser mayor que la fecha final");
                return;
            }

            // Filtra las transacciones según las fechas seleccionadas
            foreach (Transaction transaction in transactionList)
            {
                if (transaction.Date >= startDateFilter && transaction.Date <= endDateFilter)
                {
                    filteredTransactions.Add(transaction);
                }
            }

            // Actualiza el DataGridView con las transacciones filtradas y los textos de ingresos/gastos
            dgvTransactions.DataSource = filteredTransactions;
            fillTransactionTxt(filteredTransactions);
            changeDataGridViewHeaders();
        }

        // Evento que se dispara al hacer clic en el botón para limpiar el filtro de fechas
        private void btnCleanFilter_Click(object sender, EventArgs e)
        {
            fillDataGridView(); // Rellena el DataGridView con todas las transacciones sin filtros
        }
    }
}
