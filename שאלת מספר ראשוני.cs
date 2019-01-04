using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ely_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("choose a num");
            int x = Convert.ToInt32(Console.ReadLine());
            int i = 2;
            
            while (x%i != 0 && i<x)
            {
               
               
                i++;
            }
            if (x == i || x ==0)
            { Console.WriteLine("prime"); }
            else
            { Console.WriteLine("not prime"); }
        }
    }
}
