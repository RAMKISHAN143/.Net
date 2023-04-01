using System;

namespace MethodOverloading
{
    internal class Program2
    {
        private static void Main2()
        {
            int i = 10;

            //int j = i; // copy i into j
            int j = 10;                                       // assigning 10 value to j

            if (i == j)
            {
                Console.WriteLine("i & j are equal");
            }
            else
            {
                Console.WriteLine("i & j are not equal");
            }

            // Complex Type

            //If Calculator c2 = c1; Copy c1 into c2   =>  Same Memory Locations and Two Pointers. Equal.

            Calculator c1 = new Calculator() { Number1 = 10, Number2 = 20 };

            Calculator c2 = new Calculator() { Number1 = 10, Number2 = 20 };

            // But Here  two different Memory Locations and Two Pointers.  Not Equal.

            if (c1 == c2)
            {
                Console.WriteLine("c1 & c2 are equal");
            }
            else
            {
                Console.WriteLine("c1 & c2 are not equal");
            }

            Console.ReadLine();
        }
    }

    public class Calculator
    {
        public int Number1;
        public int Number2;
    }
}