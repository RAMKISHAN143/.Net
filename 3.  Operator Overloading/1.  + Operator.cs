using System;

namespace MethodO
{
    internal class Program1
    {
        private static void Main1()
        {
            int i = 10;
            int j = 10;
            int k = i + j;                                   //  + -> operator,      i, j -> operands

            Console.WriteLine(k);

            string s1 = "Vidya";
            string s2 = "Bhosale";
            string s3 = s1 + s2;                             // + -> operator,      s1 & s2 -> operands

            Console.WriteLine(s3);

            // Complex Type

            Calculator c1 = new Calculator() { Number1 = 10, Number2 = 50 };
            Calculator c2 = new Calculator() { Number1 = 20, Number2 = 70 };

            Calculator c3 = Calculator.Addition(c1, c2);                           //  3 Ways

            Calculator c4 = new Calculator();
            c4.Number1 = c1.Number1 + c2.Number1;
            c4.Number2 = c1.Number2 + c2.Number2;

            Calculator c5 = c1 + c2;                          // + -> operator,     c1 & c2 -> operands

            Console.WriteLine(c3.Number1);
            Console.WriteLine(c3.Number2);

            Console.ReadLine();
        }
    }

    public class Calculator
    {
        public int Number1;
        public int Number2;

        public static Calculator Addition(Calculator c1, Calculator c2)
        {
            Calculator c = new Calculator();
            c.Number1 = c1.Number1 + c2.Number1;
            c.Number2 = c1.Number2 + c2.Number2;

            return c;
        }

        // Or we can use + Operator here => Always Static
        // It is also Method. Instead of Method name we use Operator keyword and + .

        public static Calculator operator +(Calculator c1, Calculator c2)
        {
            Calculator c = new Calculator();
            c.Number1 = c1.Number1 + c2.Number1;
            c.Number2 = c1.Number2 + c2.Number2;

            return c;
        }
    }
}