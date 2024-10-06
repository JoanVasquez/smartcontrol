namespace SmartControl
{
    partial class SmartControlForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblTransactionType = new Label();
            cbCategory = new ComboBox();
            cbTransactionType = new ComboBox();
            txtAmount = new TextBox();
            txtDescription = new TextBox();
            dtpTransaction = new DateTimePicker();
            btnAdd = new Button();
            lblCategory = new Label();
            lblAmount = new Label();
            lblDescription = new Label();
            lblIncome = new Label();
            lblTotalBills = new Label();
            lblBalance = new Label();
            txtIncome = new TextBox();
            txtTotalBills = new TextBox();
            txtBalance = new TextBox();
            dataGridView1 = new DataGridView();
            dtpStartDateFilter = new DateTimePicker();
            dtpEndDatePicker = new DateTimePicker();
            btnFilter = new Button();
            lblStartDateFilter = new Label();
            lblEndDateFilter = new Label();
            lblLatestTransactions = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // lblTransactionType
            // 
            lblTransactionType.AutoSize = true;
            lblTransactionType.Location = new Point(12, 12);
            lblTransactionType.Name = "lblTransactionType";
            lblTransactionType.Size = new Size(110, 15);
            lblTransactionType.TabIndex = 0;
            lblTransactionType.Text = "Tipo de transaccion";
            // 
            // cbCategory
            // 
            cbCategory.Location = new Point(143, 49);
            cbCategory.Name = "cbCategory";
            cbCategory.Size = new Size(200, 23);
            cbCategory.TabIndex = 1;
            // 
            // cbTransactionType
            // 
            cbTransactionType.Items.AddRange(new object[] { "Ingreso", "Gasto", "Transacción Bancaria" });
            cbTransactionType.Location = new Point(143, 9);
            cbTransactionType.Name = "cbTransactionType";
            cbTransactionType.Size = new Size(200, 23);
            cbTransactionType.TabIndex = 2;
            cbTransactionType.SelectedIndexChanged += cbTransactionType_SelectedIndexChanged;
            // 
            // txtAmount
            // 
            txtAmount.Location = new Point(143, 97);
            txtAmount.Name = "txtAmount";
            txtAmount.Size = new Size(200, 23);
            txtAmount.TabIndex = 3;
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(143, 139);
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(200, 23);
            txtDescription.TabIndex = 4;
            // 
            // dtpTransaction
            // 
            dtpTransaction.Location = new Point(435, 9);
            dtpTransaction.Name = "dtpTransaction";
            dtpTransaction.Size = new Size(200, 23);
            dtpTransaction.TabIndex = 5;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(435, 52);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(200, 30);
            btnAdd.TabIndex = 6;
            btnAdd.Text = "Agregar";
            btnAdd.Click += btnAdd_Click;
            // 
            // lblCategory
            // 
            lblCategory.AutoSize = true;
            lblCategory.Location = new Point(12, 52);
            lblCategory.Name = "lblCategory";
            lblCategory.Size = new Size(58, 15);
            lblCategory.TabIndex = 7;
            lblCategory.Text = "Categoria";
            // 
            // lblAmount
            // 
            lblAmount.AutoSize = true;
            lblAmount.Location = new Point(12, 105);
            lblAmount.Name = "lblAmount";
            lblAmount.Size = new Size(43, 15);
            lblAmount.TabIndex = 8;
            lblAmount.Text = "Monto";
            // 
            // lblDescription
            // 
            lblDescription.AutoSize = true;
            lblDescription.Location = new Point(12, 142);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new Size(69, 15);
            lblDescription.TabIndex = 9;
            lblDescription.Text = "Descripcion";
            // 
            // lblIncome
            // 
            lblIncome.AutoSize = true;
            lblIncome.Location = new Point(12, 180);
            lblIncome.Name = "lblIncome";
            lblIncome.Size = new Size(79, 15);
            lblIncome.TabIndex = 10;
            lblIncome.Text = "Total Ingresos";
            // 
            // lblTotalBills
            // 
            lblTotalBills.AutoSize = true;
            lblTotalBills.Location = new Point(216, 180);
            lblTotalBills.Name = "lblTotalBills";
            lblTotalBills.Size = new Size(70, 15);
            lblTotalBills.TabIndex = 11;
            lblTotalBills.Text = "Total Gastos";
            // 
            // lblBalance
            // 
            lblBalance.AutoSize = true;
            lblBalance.Location = new Point(435, 180);
            lblBalance.Name = "lblBalance";
            lblBalance.Size = new Size(48, 15);
            lblBalance.TabIndex = 12;
            lblBalance.Text = "Balance";
            // 
            // txtIncome
            // 
            txtIncome.Location = new Point(12, 207);
            txtIncome.Name = "txtIncome";
            txtIncome.ReadOnly = true;
            txtIncome.Size = new Size(152, 23);
            txtIncome.TabIndex = 13;
            // 
            // txtTotalBills
            // 
            txtTotalBills.Location = new Point(216, 207);
            txtTotalBills.Name = "txtTotalBills";
            txtTotalBills.ReadOnly = true;
            txtTotalBills.Size = new Size(164, 23);
            txtTotalBills.TabIndex = 14;
            // 
            // txtBalance
            // 
            txtBalance.Location = new Point(435, 207);
            txtBalance.Name = "txtBalance";
            txtBalance.ReadOnly = true;
            txtBalance.Size = new Size(164, 23);
            txtBalance.TabIndex = 15;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 283);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(776, 150);
            dataGridView1.TabIndex = 16;
            // 
            // dtpStartDateFilter
            // 
            dtpStartDateFilter.Location = new Point(12, 479);
            dtpStartDateFilter.Name = "dtpStartDateFilter";
            dtpStartDateFilter.Size = new Size(200, 23);
            dtpStartDateFilter.TabIndex = 17;
            // 
            // dtpEndDatePicker
            // 
            dtpEndDatePicker.Location = new Point(218, 479);
            dtpEndDatePicker.Name = "dtpEndDatePicker";
            dtpEndDatePicker.Size = new Size(200, 23);
            dtpEndDatePicker.TabIndex = 18;
            // 
            // btnFilter
            // 
            btnFilter.Location = new Point(424, 479);
            btnFilter.Name = "btnFilter";
            btnFilter.Size = new Size(75, 23);
            btnFilter.TabIndex = 19;
            btnFilter.Text = "Filtrar";
            btnFilter.UseVisualStyleBackColor = true;
            // 
            // lblStartDateFilter
            // 
            lblStartDateFilter.AutoSize = true;
            lblStartDateFilter.Location = new Point(12, 451);
            lblStartDateFilter.Name = "lblStartDateFilter";
            lblStartDateFilter.Size = new Size(39, 15);
            lblStartDateFilter.TabIndex = 20;
            lblStartDateFilter.Text = "Desde";
            // 
            // lblEndDateFilter
            // 
            lblEndDateFilter.AutoSize = true;
            lblEndDateFilter.Location = new Point(218, 451);
            lblEndDateFilter.Name = "lblEndDateFilter";
            lblEndDateFilter.Size = new Size(37, 15);
            lblEndDateFilter.TabIndex = 21;
            lblEndDateFilter.Text = "Hasta";
            // 
            // lblLatestTransactions
            // 
            lblLatestTransactions.AutoSize = true;
            lblLatestTransactions.Location = new Point(216, 250);
            lblLatestTransactions.Name = "lblLatestTransactions";
            lblLatestTransactions.Size = new Size(122, 15);
            lblLatestTransactions.TabIndex = 22;
            lblLatestTransactions.Text = "Ultimas transacciones";
            // 
            // SmartControlForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 514);
            Controls.Add(lblLatestTransactions);
            Controls.Add(lblEndDateFilter);
            Controls.Add(lblStartDateFilter);
            Controls.Add(btnFilter);
            Controls.Add(dtpEndDatePicker);
            Controls.Add(dtpStartDateFilter);
            Controls.Add(dataGridView1);
            Controls.Add(txtBalance);
            Controls.Add(txtTotalBills);
            Controls.Add(txtIncome);
            Controls.Add(lblBalance);
            Controls.Add(lblTotalBills);
            Controls.Add(lblIncome);
            Controls.Add(lblDescription);
            Controls.Add(lblAmount);
            Controls.Add(lblCategory);
            Controls.Add(lblTransactionType);
            Controls.Add(cbCategory);
            Controls.Add(cbTransactionType);
            Controls.Add(txtAmount);
            Controls.Add(txtDescription);
            Controls.Add(dtpTransaction);
            Controls.Add(btnAdd);
            Name = "SmartControlForm";
            Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTransactionType;
        private ComboBox cbCategory;
        private ComboBox cbTransactionType;
        private TextBox txtAmount;
        private TextBox txtDescription;
        private DateTimePicker dtpTransaction;
        private Button btnAdd;
        private Label lblCategory;
        private Label lblAmount;
        private Label lblDescription;
        private Label lblIncome;
        private Label lblTotalBills;
        private Label lblBalance;
        private TextBox txtIncome;
        private TextBox txtTotalBills;
        private TextBox txtBalance;
        private DataGridView dataGridView1;
        private DateTimePicker dtpStartDateFilter;
        private DateTimePicker dtpEndDatePicker;
        private Button btnFilter;
        private Label lblStartDateFilter;
        private Label lblEndDateFilter;
        private Label lblLatestTransactions;
    }
}