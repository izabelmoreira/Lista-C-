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
            double HorasT, HorasEx, ValorHorasT, ValorHorasEx, Sal, SalMin, Final;


            Console.WriteLine("informe o salario");
            Sal = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Informe as horas trabalhadas");
            HorasT = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Informe o salário mínimo atual");
            SalMin = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Informe a quantidade de horas extras");
            HorasEx = Convert.ToDouble(Console.ReadLine());
           

            ValorHorasEx = (0.25 * SalMin);
            HorasEx = HorasT * ValorHorasEx;
            ValorHorasT = (0.125 * Sal);
            Sal = HorasT * ValorHorasT;
            Final = Sal + HorasEx;

                                         
            Console.WriteLine("O salário final é =   " + Final);
        }
    }
}
