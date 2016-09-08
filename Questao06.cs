using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication6
{
    class Questao06
    {
        static void Main(string[] args)
        {
            double DM, DN, area;

            Console.WriteLine("Escreva o valor da diagonal maior");

            DM = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Escreva o valor da diagonal menor");

            DN = Convert.ToDouble(Console.ReadLine());

            area = (DM * DN) / 2;

            Console.WriteLine("A área do losango é  :   "  +  area);



        }
    }
}
