using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_2_perfect_numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sum = 0, n1, n2, i, j;
            Console.WriteLine("please enter n1");
            n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("please enter n2");
            n2 = int.Parse(Console.ReadLine());
            for (i = n1; i <= n2; i++)
            {
                for (j = 1; j <= i / 2; j++)
                {
                    if (i % j == 0)
                        sum += j;
                }
                if (sum == i)
                {
                    Console.WriteLine("the perfect number is" + " " + i);
                    sum = 0;
                }
                else
                {
                    sum = 0;
                }
            }
        }
    }
}
