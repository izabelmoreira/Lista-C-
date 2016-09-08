using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication8
{
    class Program
    {
        static void Main(string[] args)
        {
            double n1, n2, n3, n4, media;


            Console.WriteLine("informe a primeira nota:");
            n1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Informe a segunda nota");
            n2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Informe a terceira nota");
            n3 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Informe a quarta nota");
            n4 = Convert.ToDouble(Console.ReadLine());


            media = (n1+n2+n3+n4) / 4 ;

            if (media >= 70)
                 Console.WriteLine("aluno aprovado");
            else
                Console.WriteLine("aluno reprovado");

                        
        }
    }
}
