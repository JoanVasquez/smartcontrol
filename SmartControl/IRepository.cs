using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartControl
{
    // Definición de una interfaz genérica para el patrón de repositorio
    // 'Entity' es un parámetro de tipo que representa la entidad con la que trabajará el repositorio
    internal interface IRepository<Entity>
    {
        // Método para guardar una entidad en la base de datos o en el repositorio
        // Recibe una instancia de 'Entity' y retorna la entidad guardada
        public Entity Save(Entity entity);

        // Método para encontrar y devolver todas las instancias de 'Entity'
        // Retorna una lista de todas las entidades almacenadas
        public List<Entity> FindAll();
    }
}
