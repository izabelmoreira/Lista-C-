using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication7
{
    class Questao16
    {
        static void Main(string[] args)
        {
            double valor, final;

            Console.WriteLine("Informe o valor do carro");
            valor = Convert.ToDouble(Console.ReadLine());

            if(valor <12000)
            {
                final = (0.05 * valor) + valor;
            } else if(valor >= 12000 && valor <= 25000)
            {
                final = (0.10 * valor) + (0.15 * valor) + valor;
            } else
            {
                final = (0.15 * valor) + (0.20 * valor) + valor;
            }
            Console.WriteLine("O valor final do carro é:  " + final);
        }
    }
}
