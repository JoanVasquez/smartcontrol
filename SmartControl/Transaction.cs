using Mysqlx.Cursor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartControl
{
    // Clase que representa una transacción en el sistema
    internal class Transaction
    {
        // Propiedad que almacena el identificador de la transacción
        public int Id { get; set; }

        // Propiedad que almacena el monto de la transacción
        public decimal Amount { get; set; }

        // Propiedad que indica el tipo de transacción (ej. Ingreso o Gasto)
        public string TransactionType { get; set; }

        // Propiedad que almacena la categoría de la transacción
        public string Category { get; set; }

        // Propiedad que almacena la descripción de la transacción
        public string Description { get; set; }

        // Propiedad que almacena la fecha en que se realizó la transacción
        public DateTime Date { get; set; }

        // Constructor vacío, permite crear una instancia de Transaction sin inicializar sus propiedades
        public Transaction() { }

        // Constructor que inicializa algunas propiedades al crear una instancia de Transaction
        // Las propiedades inicializadas son: Amount, TransactionType, Category y Description
        public Transaction(decimal amount, string transactionType, string category, string description)
        {
            // Asignación de los valores de los parámetros a las propiedades de la clase
            Amount = amount;
            TransactionType = transactionType;
            Category = category;
            Description = description;

            // La fecha de la transacción se establece automáticamente en el momento de creación
            Date = DateTime.Now; // Por defecto, la fecha será el momento actual
        }
    }
}
