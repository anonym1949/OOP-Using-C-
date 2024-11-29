using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class ConsoleApp1
{
    public class Test
    {
       public Test()
        {
            Console.WriteLine("Constructor Called");
        }

       ~Test()
        {
            Console.WriteLine("Destructor Called");
        }
   
    }

    static public void X()
    {
        Console.WriteLine("HEllo");
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Test T1 = new Test();

            Test T2 = new Test();


            T1 = null;
            T2 = null;

            GC.Collect();
            Console.ReadKey();
        }
    }
}
