using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartControl
{
    internal interface IUser
    {
        //Este metodo se utilizara para implementarlo en una clase para hacer el login
        public User Login(string username, string password);
    }
}
