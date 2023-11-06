using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz2
{
    public class FizzBuzz
    {
        public static string CheckFizzBuzz(int i)
        {
            if (i % 3 == 0 && i % 5 == 0)
            {
               return "FizzBuzz";
            }
            else if (i % 3 == 0)
            {
               return "Fizz";
            }
            else if (i % 5 == 0)
            {
               return "Buzz";
            }
            else
            {
               return i.ToString();
            }
        }

        public static string GetFizzBuzz()
        {
            string result = "";
            for (int i = 1; i <= 100; i++)
            {
                result += CheckFizzBuzz(i);
            }
            return result;
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(FizzBuzz.GetFizzBuzz());
        }
    }
}