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
            double salario, vendas, comissao, NovoSal;
            Console.WriteLine("Informe o salário fixo");

            salario = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Informe o valor das vendas");
            vendas = Convert.ToDouble(Console.ReadLine());

         
           comissao = 0.96 * vendas;
            NovoSal = salario + comissao;

            Console.WriteLine("O salário é    " + NovoSal + "    sua comissão é:   " + comissao );

        }
    }
}
