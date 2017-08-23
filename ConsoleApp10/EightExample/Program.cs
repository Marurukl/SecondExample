using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EightExample
{
    class Program
    {
        static void Main(string[] args)
        {
            double Weight1 = 5 , Weight2 = 6;
            double Amount1 = 2.5, Amount2 = 2.8;
            if ((Weight1/Amount1)>(Weight2/Amount2))
            {
                Console.WriteLine("1 вещь плотнее чем 2 ");
            }
            else
            {
                Console.WriteLine("2 вещь плотнее чем 1 ");
            }
            Console.ReadLine();
        }
    }
}
