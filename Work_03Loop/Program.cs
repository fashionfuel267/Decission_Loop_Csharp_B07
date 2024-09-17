using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Work_03Loop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //  ForLoop();
            // WhileLoop();
            DoWhileLoop();
            Console.ReadKey();
        }
        static void ForLoop()
        {
            string value = "";
            for (int i = 1; i <= 10; i++)
            {
                //Console.Write(i + "\t");
                //Console.Write(i + ",");
                value += i + ",";
            }
            Console.WriteLine(value.Length);
            value = value.Substring(0, value.Length - 1);
            Console.WriteLine(value);
        }
        static void WhileLoop()
        {
            string value = "";
            
            int i = 1;
            while (i <= 10)
            {
                value += i + ",";
                i++;
            }
            Console.WriteLine(value.Length);
            value = value.Substring(0, value.Length - 1);
            Console.WriteLine(value);
        }
        static void DoWhileLoop()
        {
            string value = "";

            int i = 12;
             
            do
            {
                value += i + ",";
                i++;

            } while(i <= 10);
            Console.WriteLine(value.Length);
            value = value.Substring(0, value.Length - 1);
            Console.WriteLine(value);
        }
    }
}
