using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Work_4EvenOdd
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string opinion = "";
            do
            {
                Console.WriteLine("Enter number");
                int number = int.Parse(Console.ReadLine());
                EvenorOdd(number);
                Console.WriteLine("Do you want more[yes/no].");
                opinion = Console.ReadLine();
            } while (opinion =="yes");
            Environment.Exit(0);
            Console.ReadKey();
        }
        static void EvenorOdd(int n)
        {
            if (n % 2 == 0)
            {
                Console.WriteLine($"{n} is even.");
            }
            else
            {
                Console.WriteLine($"{n} is odd.");
            }
        }
    }
}
