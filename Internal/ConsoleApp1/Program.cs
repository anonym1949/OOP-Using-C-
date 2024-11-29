using System;
using ClassLibrary1;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ClassLibrary1.Class1 Cls = new ClassLibrary1.Class1();
            
            Cls.Show();
      
            Test test = new Test();
            test.show2();

            Console.ReadLine();
        }
    }

    class Test : ClassLibrary1.Class1
    {
        public void show2()
        {
            X = 100;
            Console.WriteLine(X);
        }

    }


}
