using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolimorfizmClassTask.Services.Interfaces
{
    internal interface ICalculateService:IAccountService,ICommonService
    {
        void SumNumbers(int num1, int num2);
        int GetSumNumbersFromArray(int[] numbers);
    }
}
