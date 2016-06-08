using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SeriesApplication;

namespace SeriesApplication
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int num;
           
            Console.WriteLine("---Enter any Number---");
            num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("=======================================================");

            FizzBuzz obj = new FizzBuzz();
            obj.DivisibleByThreeOrFive(num);
          
        }
    }
}
                
        
   

