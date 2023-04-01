using System;

public class Program2
{
    private static void Main2()
    {
        Parent A = new Parent();
        A.Print();
        A.Print("Hello");                                                              // Overload
        A.Print(5);

        Console.WriteLine("\n\n---------------------- A --------------------------\n\n");

        Parent B = new Child();
        B.Print();                                                                      // Override

        Console.WriteLine("\n\n---------------------- B --------------------------\n\n");

        Child C = new Child();
        C.Print();
        C.Print(5);                                                                    // Method Hide
        C.Print("Hey");
        C.Print(5, 7);

        Console.ReadLine();
    }
}

public class Parent
{
    public virtual void Print()
    {
        Console.WriteLine("1st Method of Parent Class");
    }

    public void Print(string G)
    {
        Console.WriteLine($"2nd Method of Parent Class  {G}");
    }

    public void Print(int K)                                                      // Overload : in same class, Same method name but different Parameters or different Signature.
    {                                                                             // We can also Continue that in derived Class.
        Console.WriteLine($"3rd Method of Parent Class {K}");
    }
}

public class Child : Parent
{
    public override void Print()                                                  // Override : Same Signature of Method in both Parent and Child Class.
    {
        Console.WriteLine("1st Method of Child Class");
    }

    public void Print(int K, int j)                                               // Overloading from base + derived class
    {
        Console.WriteLine($"2nd Method of Child Class {K + j}");
    }

    public new void Print(int K)                                                  // Method Hide
    {
        Console.WriteLine($"3rd Method of Parent Class {K}");
    }
}