using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WOrk_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
          /*
            Console.WriteLine("Enter your age");
            int age =int.Parse( Console.ReadLine());
            Output(age);//method call/execution
          */
            Console.WriteLine("Enter number");
            int number = int.Parse(Console.ReadLine());
            EvenorOdd(number);
           
            Console.ReadKey();
        }
        //method decaration
        static void Output(int age)
        {
            if (age > 50)
            {
                Console.WriteLine("You are old");
            }
            else
            {
                Console.WriteLine("You are Young");
            }
        }
        static void EvenorOdd(int n)
        {
            if (n%2==0)
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
