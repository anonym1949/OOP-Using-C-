using System;
//using Library;
using Library1;


namespace Library
{
    internal class Program
    {
        static void Main()
        {
            MyClass myClass = new MyClass();
            myClass.Indroduce();

            MyClass1 myClass1 = new MyClass1();
            myClass1.Hello();

            MyClass2 myClass2 = new MyClass2();
            myClass2.Indroduce();
            Console.ReadLine();
        }
    }

}