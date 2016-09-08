using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication6
{
    class Questao15
    {
        static void Main(string[] args)
        {
            double Sal, NovoSal;

            Console.WriteLine("Informe o salário");
            Sal = Convert.ToDouble(Console.ReadLine());

            if (Sal <= 300) {
                NovoSal = (0.35 * Sal) + Sal;
            } else
                NovoSal = (0.15 * Sal) + Sal;

            {
                Console.WriteLine("O salário reajustado é:  " + NovoSal);

            }
        }
    }
}
