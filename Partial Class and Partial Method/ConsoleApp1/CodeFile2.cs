using System;
namespace Project
{

    partial class MyClass
    {
        //This is Partial Method its when you declare a method and 
        // the implementation will be in other partial class
         partial void PrintDate();

        public void method2()
        {
            Console.WriteLine("Hi IAm Method 2");
            PrintDate();
        }

    }
}