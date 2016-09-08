using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class Questao12
    {
        static void Main(string[] args)
        {
            double n1, n2, menor;

            Console.WriteLine("Informe um número");
            n1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Informe outro número");
            n2 = Convert.ToDouble(Console.ReadLine());

            if 
                (n1 < n2) { 

                Console.WriteLine(n1 + "é menor"); } else
            {
                Console.WriteLine(n2 + " é menor");
            }

        
       

        }
    }
}
