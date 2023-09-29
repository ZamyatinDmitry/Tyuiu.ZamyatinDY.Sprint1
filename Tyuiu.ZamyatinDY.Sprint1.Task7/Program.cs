using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tyuiu.ZamyatinDY.Sprint1.Task7
{
    internal class Program
    {
        static void Main(string[] args)

        {

            int a = 0, b = 0, c = 0, d = 0;

            Console.WriteLine("Enter data");

            a = Convert.ToInt32(Console.ReadLine());

            b = Convert.ToInt32(Console.ReadLine());

            c = Convert.ToInt32(Console.ReadLine());

            b *= a * c;

            d = a + c;

            a = b - d;

            c -= a;

            Console.WriteLine("Result = {0}", d);

            Console.ReadKey();
        }
    }
}
