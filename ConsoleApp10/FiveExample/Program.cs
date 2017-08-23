using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiveExample
{
    class Program
    {
        
        static void Main(string[] args)
        {
            Console.WriteLine("Введите Цифру : ");
            int Number;
            Int32.TryParse(Console.ReadLine(),out Number);
            int TenInNumber=Number / 10 ;
            int OneInNumber = Number - (TenInNumber * 10);

            Console.WriteLine("a.	число десятков : " + TenInNumber);
            Console.WriteLine("b.	число единиц  : "+ OneInNumber);
            Console.WriteLine("c.	сумму его цифр : " + (TenInNumber + OneInNumber));
            Console.WriteLine("d.	произведение его цифр : " + (TenInNumber * OneInNumber));
            Console.ReadLine();

        }
    }
}
