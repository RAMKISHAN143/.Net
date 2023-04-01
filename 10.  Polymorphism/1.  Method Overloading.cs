using System;

public class Program1
{
    private static void Main1()
    {
        Program1.add();

        Console.WriteLine();                                                            // Here,  Console => class, Writeline => Method, This method have 19 different forms.

        Console.ReadLine();
    }

    #region

    private static int _FirstNumber, _LastNumber;

    private static void add()
    { }

    private static void add(int FN, int LN)
    {
        _FirstNumber = FN;
        _LastNumber = LN;

        Console.WriteLine($"Sum of {_FirstNumber} and {_LastNumber} = {_FirstNumber + _LastNumber}");
    }

    private static void add(int FN, int LN, int TN)
    { }                                                                   // By Number of Parameters

    //static int add(int FN, int LN, int TN) { return 10; }               // Cannot do only on Return Type

    private static int add(int FN, int LN, int TN, int FL)
    { return 10; }

    private static void add(int FN, int LN, float TN)
    { }                                                                   // By Type of Parameters

    private static void add(float TN, int FN, int LN)
    { }                                                                   // By order of Parameters

    private static void add(int FN, int LN, int[] TN)
    { }                                                                   // By Kind of Parameters

    //static void add(int FN, int LN, params int[] TN) { }            // Cannot do only on Params keyword.

    private static void add(int FN, int LN, int k, params int[] TN)
    { }

    private static void add(int TN, int FN, ref int LN)
    { }

    //static void add(int TN, int FN, out int LN) { }                    // Cannot do only on ref and out keyword.  Compiler Consider ref and out same.

    #endregion
}