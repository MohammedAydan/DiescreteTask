using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Perfect_Number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter start number : ");
            int n1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter stop number : ");
            int n2 = int.Parse(Console.ReadLine());

            Console.WriteLine("..........");

            for (int i=n1; i < n2; i++)
            {
                int sum = 0;
                for(int j = 1; j < i; j++)
                {
                    if (i % j == 0)
                    {
                        sum = sum + j;
                    }
                }
                if(sum == i)
                {
                    Console.WriteLine(".  "+sum);
                }
            }
            Console.WriteLine("..........");

            Console.ReadKey();
        }
    }
}
