using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism_Abstraction_Interface.Service
{
    internal interface ICalculation
    {
        double Calculate(int num1,int num2,string operation);
    }
}
