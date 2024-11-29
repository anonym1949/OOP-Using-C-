using System;

namespace Project
{
   
    partial class MyClass
    {

        //If you didint implement the partial method nothing will happend
       partial void PrintDate()
       {
           Console.WriteLine(DateTime.Now.ToString());
       }
        
        public void method1()
        {
            Console.WriteLine("Hi IAm Method 1");
            
        }

    }
}