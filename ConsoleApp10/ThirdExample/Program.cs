using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThirdExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите Растояние в сантиметрах : ");
            int Range = Int32.Parse(Console.ReadLine());
            int RangeInMeter = Range / 100;
            Console.WriteLine("Полных Метров : " + RangeInMeter);
            Console.ReadLine();
        }
    }
}
