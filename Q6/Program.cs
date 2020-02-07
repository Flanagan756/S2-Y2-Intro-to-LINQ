using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q6_Q7_Q8
{

    class Program
    {
        static void Main(string[] args)
        {
            string[] names = { "Mary", "Joseph", "Michael", "Sarah", "Margaret", "John" };

            /*Linq Query*/
            //var displayNames = from name in names
            //                   select name;

            /*Q7 Order above alpabetically
     
            //var displayNames = from name in names
            //                   orderby name
            //                   select name;

            /*Q8 Include only names that begin with M*/

            var displayNames = from name in names
                               where name.StartsWith("M")
                               orderby name
                               select name;

            ///*Lamda Query*/
            //var displayNames = names
            //    .Select(n => n);

            /*Q7 Order above alpabetically*/

            //var displayNames = names
            //    .OrderBy(n => n)
            //    .Select(n => n);

            ///*Q8 Include only names that begin with M*/
            //var displayNames = names
            //    .Where(n => n.StartsWith("M"))
            //    .OrderBy(n => n)
            //    .Select(n => n);

            foreach (var name in displayNames)
            {
                Console.WriteLine(name);                       
            }

        }
    }
}
