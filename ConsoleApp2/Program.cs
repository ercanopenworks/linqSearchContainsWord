using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            //what is the output ?
            //int i = 10;
            //int res = 10 * ++i * i;
            //Console.Write(res);


            List<string> names = new List<string>() { "ercan", "ahmet", "ali", "veli" };
            Console.Write("Search for = > ");
            string searchKey =  Console.ReadLine();
            var containSearchKey = returnContains(names, searchKey);


            foreach (var item in containSearchKey)
            {
                Console.WriteLine(item.ToString());
            }
            

            Console.Read();

        }

        static List<string> returnContains(List<string> names, string searchKey)
        {
            return names.Where(isim => isim.Contains(searchKey)).ToList();
        }
    }
}
