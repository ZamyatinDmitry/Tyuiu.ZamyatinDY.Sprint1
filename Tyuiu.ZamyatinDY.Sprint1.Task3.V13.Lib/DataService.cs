using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint1;
namespace Tyuiu.ZamyatinDY.Sprint1.Task3.V13.Lib
{
    public class DataService
    {
        public int MultiplyOfDigits(int number)
        {
            int digit1 = number / 100;
            int digit2 = (number / 10) % 10;
            int digit3 = number % 10;
            int result = digit1 + digit2 + digit3;
            return result;
        }
    }
}
