using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            Tuple<int, int, string> numbers = new Tuple<int, int, string>(4, 5, "Nikhil");


            int a = numbers.Item1;



            Console.WriteLine(a);

            Console.ReadLine();

        }
    }
}
