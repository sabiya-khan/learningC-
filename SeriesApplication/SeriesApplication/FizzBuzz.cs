using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SeriesApplication;

namespace SeriesApplication
{
    public class FizzBuzz
    {

        public  void DivisibleByThreeOrFive(int n)
        {
            
            for (int i = 1; i <= n; i++)
            {
                if (i % 5 == 0 && i % 3 == 0)
                {
                    Console.Write("FizzBuzz" + "\t");
                    Console.Write("\n");
                }
                else if (i % 5 == 0)
                {
                    Console.Write("Buzz" + "\t");
                    Console.Write("\n");
                }
                else if (i % 3 == 0)
                {
                    Console.Write("Fizz" + "\t");
                }
                else
                {
                    Console.Write(i + "\t");
                }
            }
            Console.ReadLine();
        }
    }
}
