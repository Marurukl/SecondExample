using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SevenExemple
{
    class Program
    {
        static void Main(string[] args)
        {
            int Radius = 5;
            int SideSquare = 3;
            double AreaCircle = 3.14 * Radius * Radius;
            int AreaSquare = SideSquare * SideSquare;
            if (AreaCircle > AreaSquare)
            {
                Console.WriteLine("Площадь круга больше.");
            }
            else if(AreaSquare > AreaCircle)
            {
                Console.WriteLine("Площадь квадрата больше.");
            }
            else
            {
                Console.WriteLine("Они одинаковые");
            }
            Console.ReadLine();
        }
    }
}
