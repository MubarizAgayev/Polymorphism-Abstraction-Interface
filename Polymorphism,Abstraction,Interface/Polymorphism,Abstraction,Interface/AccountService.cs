using Polymorphism_Abstraction_Interface.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism_Abstraction_Interface
{
    internal class AccountService : İAccountService
    {
        public string username;
        public string password;

        public void Users(string username, string password)
        {
            this.username = username;
            this.password= password;
        }

        public void Login(string username, string password)
        {
            if (username == "Cavid123" && password == "Cavid1993")
            {
                Console.WriteLine("Emeliyyat ugurludur");

            }
            else
            {
                Console.WriteLine("Emeliyyat ugursuzdur");
            }
        }

    }
}
