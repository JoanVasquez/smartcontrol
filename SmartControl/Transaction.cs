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
        public string Type { get; set; }
        public Category Category { get; set; }
        public decimal Amount { get; set; }
        public string PaymentType { get; set; }
        public string Description { get; set; }

        public Transaction(int id, DateTime date, string type, Category category, decimal amount, string paymentType, string description)
        {
            Id = id;
            Date = date;
            Type = type;
            Category = category;
            Amount = amount;
            PaymentType = paymentType;
            Description = description;
        }
    }
}
