using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Q1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Both Methods do the exact same but just use different syntax
            NumbersQuery();
            NumberQuery2();
        }
        private static void NumbersQuery()
        {
            //Array to store numbers
            int[] numbers = { 1, 5, 3, 6, 11, 2, 15, 21, 13, 12, 10 };
            //var that stores numbers that are greater or equal to 5
            /*n=> n is just lamda syntax and doesn't change the equation*/
            var outputNumbers = numbers.Where(n => n > 5).OrderByDescending(n => n);

            foreach (int number in outputNumbers)
            {
                Console.WriteLine(number.ToString());
            }
        }
        private static void NumberQuery2()
        {
            int[] numbers = { 1, 5, 3, 6, 11, 2, 15, 21, 13, 12, 10 };

            var outputNumbers = from number in numbers
                                where number > 5
                                orderby number descending
                                select number;

            foreach (int number in outputNumbers)
            {
                Console.WriteLine(number.ToString());
            }
        }
    }
}
