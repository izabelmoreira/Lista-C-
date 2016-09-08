using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4
{
    class Questao13
    {
        static void Main(string[] args)
        {
            double n1, n2, n3, maior;

            Console.WriteLine("Escreva um número");
            n1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Escreva outro número");
            n2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Escreva outro número");
            n3 = Convert.ToDouble(Console.ReadLine());

            if(n1 > n2 && n1 > n3)
            {
                Console.WriteLine(n1 + "é maior");
            } else 

            if (n2 > n3 && n2 > n1) 

            {
                Console.WriteLine(n2 + " é maior");
            } else  
            
            if (n3 > n1 && n3 > n2) 

            {
                Console.WriteLine(n3 + " é maior");
            }



        }
    }
}
