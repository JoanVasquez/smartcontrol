using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartControl
{
    // Definición de la clase 'Category', que representa una categoría en el sistema
    internal class Category
    {
        // Propiedad que almacena el identificador de la categoría
        public int Id { get; set; }

        // Propiedad que almacena el nombre de la categoría
        public string Name { get; set; }

        // Propiedad que almacena el tipo de la categoría
        public string Type { get; set; }

        // Constructor vacío, permite crear una instancia de la clase sin inicializar sus propiedades
        public Category() { }

        // Constructor que inicializa las propiedades 'Id', 'Name', y 'Type' al crear una instancia
        public Category(int id, string name, string type)
        {
            // Asignación de los valores de los parámetros a las propiedades de la clase
            Id = id;
            Name = name;
            Type = type;
        }
    }
}
