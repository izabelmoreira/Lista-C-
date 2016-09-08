using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication5
{
    class Questao14
    {
        static void Main(string[] args)
        {
            double n1, n2, opcao, result;

            Console.WriteLine("Digite um número");
            n1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digite outro número");
            n2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digite a opção de 1 a 4");
            opcao = Convert.ToDouble(Console.ReadLine());

            if (opcao == 1)
            {
                result = (n1 + n2) / 2;
                Console.WriteLine("O resultado da opção escolhida é:   " + result);

            }
            else if (opcao == 2)
            {
                result = n1 - n2;
                Console.WriteLine("O resultado da opção escolhida é:   " + result);

            }
            else if (opcao == 3)
            {
                result = n1 * n2;
                Console.WriteLine("O resultado da opção escolhida é:   " + result);
            }
            else if (opcao == 4)
            {
                result = n1 / n2;
                Console.WriteLine("O resultado da opção escolhida é:   " + result);
            }
        }
    }
}
