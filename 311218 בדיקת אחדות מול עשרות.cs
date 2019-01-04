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
            int  x ;
            Console.WriteLine("how much money would you like to get");
            x = Convert.ToInt32(Console.ReadLine());
            do
            {

                Console.WriteLine(x/200);
                Console.WriteLine("200");
                x = x - (x/200)*200;
                Console.WriteLine(x/100);
                Console.WriteLine("100");               
                x = x - (x / 100) * 100;
                Console.WriteLine(x/50);
                Console.WriteLine("50");
                x = x - (x / 50) * 50;
                Console.WriteLine(x/20);
                Console.WriteLine("20");
                x = x - (x / 20) * 20;
                Console.WriteLine(x/10);
                Console.WriteLine("10");
                x = x- (x / 10) * 10;
                Console.WriteLine(x/5);
                Console.WriteLine("5");
                x = x - 1;
            }
            while (x / 5 != 0);
            Console.ReadLine();
                
                        

            
                
           

                    
                
                
            


            
            
        }
        
    }
}
