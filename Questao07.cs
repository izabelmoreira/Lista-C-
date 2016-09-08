using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication7
{
    class Questao07
    {
        static void Main(string[] args)
        {
            double SalMinimo, SalFuncionario, resultado;

            Console.WriteLine("Informe o valor do Salario Mínimo atual");
            SalMinimo = (Convert.ToDouble(Console.ReadLine()));

            Console.WriteLine("Informe o valor do Salario do funcionário");
            SalFuncionario = (Convert.ToDouble(Console.ReadLine()));

            resultado = SalFuncionario / SalMinimo;
            Console.WriteLine("O salário do funcionário equivale a:   "  +  resultado  + "   salários mínimos.");
            

        }
    }
}
