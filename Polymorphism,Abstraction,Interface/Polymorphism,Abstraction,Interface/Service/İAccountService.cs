using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism_Abstraction_Interface.Service
{
    internal interface İAccountService
    {
        void Users(string username, string password);
        void Login(string username,string password);
        
    }
}
