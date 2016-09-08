using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication8
{
    class Questao08
    {
        static void Main(string[] args)
        {
            double anoAtual, anoNasc, idadeA, idadeM, idadeD, idadeS;

            Console.WriteLine("Digite o ano atual:");
            anoAtual = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digite o ano do seu nascimento");
            anoNasc = Convert.ToDouble(Console.ReadLine());

            idadeA = anoAtual - anoNasc;
            idadeM = idadeA * 12;
            idadeD = idadeA * 365;
            idadeS = idadeA * 52;
            
            Console.WriteLine("Sua idade em anos é:   " + idadeA + "  , sua idade em meses é:   " + idadeM + "  , sua idade em dias é:   " + idadeD + "  , sua idade em semanas é:   " + idadeS);



        }
    }
}
