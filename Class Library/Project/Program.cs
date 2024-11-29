using System;
using MathLibrary;
class Cls
{

    public int Calculate(int N1,int N2)
    { 
        ClassLibrary classLibrary = new ClassLibrary();
         return  classLibrary.Sum(N1, N2);
    }
}

internal class Program

{
        static void Main()
        {
         Cls cls = new Cls();
        Console.WriteLine(cls.Calculate(10, 20));
        Console.Read();
        }
}

