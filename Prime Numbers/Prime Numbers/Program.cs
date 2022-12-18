using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prime_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter strart number : ");
            int n1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter stop number : ");
            int n2 = int.Parse(Console.ReadLine());

            int j, i;

            Console.WriteLine("...........");

            for (i = n1; i <= n2; i++)
            {
                for (j = 2; j < i; j++)
                {
                    if (i % j == 0)
                    {
                        break;
                    }
                }
                if (i == j)
                {
                    Console.WriteLine(".  " + i);
                }
            }
            Console.WriteLine("...........");

            Console.ReadKey();
        }
    }
}
