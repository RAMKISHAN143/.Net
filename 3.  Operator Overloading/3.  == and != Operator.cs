using System;

internal class Program3
{
    private static void Main3()
    {
        Employee A = new Employee();
        A._number1 = 20;
        A._number2 = 40;

        Employee B = new Employee();
        B._number1 = 20;
        B._number2 = 40;

        bool Result = A != B;
        bool Result2 = A == B;

        Console.WriteLine(Result);

        Console.ReadLine();
    }

    private class Employee
    {
        public int _number1, _number2;

        public static bool operator ==(Employee a, Employee b)
        {
            if (a._number1 == b._number1 && a._number2 == b._number2)
            {
                Console.WriteLine("Both Object are Equal in Value");

                return true;
            }
            else
            {
                Console.WriteLine("Both Object are Not Equal in Value");

                return false;
            }
        }

        public static bool operator !=(Employee a, Employee b)
        {
            if (a._number1 != b._number1 || a._number2 != b._number2)
            {
                Console.WriteLine("Both Object are Not Equal in Value");

                return false;
            }
            else
            {
                Console.WriteLine("Both Object are  Equal in Value");

                return true;
            }
        }
    }
}