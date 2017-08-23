using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SixExample
{
    class Program
    {
        static void Main(string[] args)
        {
            bool A = true , B = false , C = false;
                Console.WriteLine("A||B = " + (A||B));
            Console.WriteLine("A&&B = "+(A && B));
            Console.WriteLine("B&&C = "+(B && C));
            Console.ReadLine();
        }
    }
}
