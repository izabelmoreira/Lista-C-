using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            double n1, n2, n3, result;
            Console.WriteLine("Escreva um número");

            n1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Escreva outro número");
            n2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Escreva outro número");
            n3 = Convert.ToDouble(Console.ReadLine());

            result = n1 * n2 * n3;
            Console.WriteLine("o resultado é  " + result);

        }
    }
}
