using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace condition1
{
    class Program
    {
        static void Main(string[] args)
        {
            int a;
            a=Convert.ToInt32(Console.ReadLine());
            if (a % 2 == 0)
                Console.WriteLine(a + " is an even number");
            else
                Console.WriteLine(a + " is an odd number");
            Console.Read();
        }
    }
}
