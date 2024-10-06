using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartControl
{
    internal interface IUser
    {
        public User Login(string username, string password);
    }
}
