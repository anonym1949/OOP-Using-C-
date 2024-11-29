using System;

class ClsA
{
    public void Method()
    {
        Console.WriteLine("Hi Im Method 1");
    }

    public void Method2()
    {
        //This is Composition when you declare An object from other class
        //inside a class
        ClsB B = new ClsB();
        B.Method();
    }

}

class ClsB
{
    public void Method()
    {
        Console.WriteLine("Hi Im Method From Class B");
    }

}
    internal class Program
    {
        static void Main(string[] args)
        {
        ClsA clsA = new ClsA();
        clsA.Method();
        clsA.Method2();
        Console.ReadKey();    
        }
    }
