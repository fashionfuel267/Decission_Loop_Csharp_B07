using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int age = 25;
            if(age>50)
            {
                Console.WriteLine("You are old");
            }
            else
            {
                Console.WriteLine(  "You are Young");
            }
            Console.ReadKey();
        }
    }
}
