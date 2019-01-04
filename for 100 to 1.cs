using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            int a;
            Console.WriteLine("pick a numver");
            a = Convert.ToInt32(Console.ReadLine());
           if (a / 10 != 0)
            
                if (a / 10 > a % 10)
                { Console.WriteLine("asarot"); }

                else
                { Console.WriteLine("ahadot"); }
            Console.ReadLine();
            
            
        }
        
    }
}
