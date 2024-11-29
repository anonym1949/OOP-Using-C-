using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



//The class Myclass Is seperated in two files its better for orgnize big project
// and its recommended to use namespace for better control
// use same name of namespace or use [using (namespace name) ]




//use this
//using Project;


//or better this
namespace Project
{
    internal class Program
    {
        static void Main(string[] args)
        {

            MyClass myClass = new MyClass();
            myClass.method1();
            myClass.method2();

        
            Console.ReadKey();

        }
    }
}
