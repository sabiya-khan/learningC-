using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeriesApplication
{
    class Program
    {
        public static void Main(string[] args)
        {
            Program p = new Program();
            int num, i;
            Console.WriteLine("---Enter any Number---");
            num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("============================================");
            for (i = 1; i <= num; i++)
            {
                p.IsDivisibleByThreeOrFive(i);
                Console.WriteLine(i);
                Console.ReadLine();
            
            }

        }
        public void IsDivisibleByThreeOrFive(int n)
        {
            if (n % 5 == 0 && n % 3 == 0)
            {
                Console.WriteLine("FizzBuzz");
            }
            else if (n % 5 == 0)
            {
                Console.WriteLine("Buzz");
            }
            else if (n % 3 == 0)
            {
                Console.WriteLine("Fizz");
            }
        }
    }
}
                
        
   

