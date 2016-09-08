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
            double Hora, minutos, Hconvert, TotalMin, Seg;


            Console.WriteLine("informe a hora");
            Hora = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Informe os minutos");
            minutos = Convert.ToDouble(Console.ReadLine());

          Hconvert = (Hora * 60);
            TotalMin = minutos + Hconvert;
            Seg = TotalMin * 60;

            Console.WriteLine("A hora digitada em minutos é  :   " + Hconvert + ".  O horário em minutos é  :  " + TotalMin + ". O horário em segundos é  :  " + Seg); 
        }
    }
}
