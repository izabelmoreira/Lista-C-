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
            double peso, NovoPeso;
            Console.WriteLine("Escreva seu peso");

            peso = Convert.ToDouble(Console.ReadLine());



            NovoPeso = peso + (peso * 0.15);

            Console.WriteLine("Engordou 15%.  Seu novo peso é  " + NovoPeso);

            NovoPeso = peso - (peso * 0.20);

            Console.WriteLine("Emagreceu 20%.  Seu novo peso é  " + NovoPeso);


        }
    }
}
