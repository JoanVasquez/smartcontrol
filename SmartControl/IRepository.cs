using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartControl
{
    internal interface IRepository<Entity>
    {
        public Entity Save(Entity entity);
        public List<Entity> FindAll();
    }
}
