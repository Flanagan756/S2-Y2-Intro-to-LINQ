using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Q3
{
    class Program
    {
        static void Main(string[] args)
        {
            AnonymousTypeLinq();
        }
        private static void AnonymousTypeLamda()
        {
            var files = new DirectoryInfo("C:\\Windows").GetFiles();

            var query = from item in files
                        where item.Length > 10000
                        orderby item.Length, item.Name
                        select new
                        {
                            Name = item.Name,
                            Length = item.Length,
                            CreationTime = item.CreationTime
                        };
            Console.WriteLine("Filename\tSize\tztCreation Date");

            foreach (var item in query)
            {
                Console.WriteLine("{0} \t{1} bytes, \t{2}", item.Name, item.Length, item.CreationTime);
            }

            Console.ReadLine();
        }

        private static void AnonymousTypeLinq()
        {
            var files = new DirectoryInfo("C:\\Windows").GetFiles();
            var query = files
               .Where(f => f.Length > 10000)
               .OrderBy(f => f.Length).ThenBy(f => f.Name)
               .Select(f => new
               {
                   Name = f.Name,
                   Length = f.Length,
                   CreationTime = f.CreationTime
               });

            Console.WriteLine("Filename\tSize\tztCreation Date");

            foreach (var item in query)
            {
                Console.WriteLine("{0} \t{1} bytes, \t{2}", item.Name, item.Length, item.CreationTime);
            }
        }
    }
}
