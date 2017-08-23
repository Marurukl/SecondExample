using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NineExample
{
    class Program
    {
        static void Main(string[] args)
        {
            double Voltage1 = 5, Voltage2 = 6;
            double Resistance1 = 2.5, Resistance2 = 2.8;
            if ((Voltage1 / Resistance1) > (Voltage2 / Resistance2))
            {
                Console.WriteLine("2 Участок Протекает меньше тока чем 1 ");
                
            }
            else
            {
                Console.WriteLine("1 Участок Протекает меньше тока чем 2 ");
            }
            Console.ReadLine();
        }
    }
}
