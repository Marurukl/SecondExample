using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TenExample
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 20; i < 36; i++)
            {
                Console.WriteLine(i + "  ");
            }
            int Value1;
            Int32.TryParse(Console.ReadLine(), out Value1);
            for (int i = 10; i <= Value1; i++)
            {
                Console.WriteLine(i*i + "  " );
            }
            int Value2;
            Int32.TryParse(Console.ReadLine(), out Value2);
            for (int i = 50; Value2 <= i; Value2++)
            {
                Console.WriteLine(Value2*Value2*Value2 + "  ");
            }
            int Value3, Value4 ;
            Int32.TryParse(Console.ReadLine(), out Value3);
            Int32.TryParse(Console.ReadLine(), out Value4);
            for (; Value3 <= Value4; Value3++)
            {
                Console.WriteLine(Value3 + "  ");
            }
                Console.ReadLine();

        }
    }
}
