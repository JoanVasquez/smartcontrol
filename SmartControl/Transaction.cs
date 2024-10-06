using Mysqlx.Cursor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartControl
{
    internal class Transaction
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public decimal Amount { get; set; }
        public string TransactionType { get; set; }
        public string Description { get; set; }

        public Transaction(DateTime date, decimal amount, string transactionType, string description)
        {
            Date = date;
            Amount = amount;
            TransactionType = transactionType;
            Description = description;
        }
    }
}
