using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W5_EVENODD
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //find out all Even & Odd from 1to50

            string even="", odd="";
            for(int i = 1; i <= 50; i++)
            {
                if (i % 2 == 0)
                {
                    even += i + "\t";
                }
                else
                {
                    odd += i + "\t";
                }
            }
            Console.WriteLine("Odd number between 1 to 50");
            Console.WriteLine("====================================================");
            Console.Write(odd +"\n");
            Console.WriteLine("Even number between 1 to 50");
            Console.WriteLine("====================================================");
            Console.Write (even);
           
          
            Console.ReadKey();
        }
    }
}
