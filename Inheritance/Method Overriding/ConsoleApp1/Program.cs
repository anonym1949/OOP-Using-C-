using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public  class Person
    {
        public virtual void Print()
        {
            Console.WriteLine("Hi Im Person Print");
        }

        public virtual void Print2()
        {
            Console.WriteLine("Hi Im Person Print2");
        }


    }
    public class Employee : Person
    {
        //overriding
        public override void Print()
        {
            Console.WriteLine("Hi Im Employee Print");
        }

        //shadowing/Hiding
        public new void Print2()
        {
            Console.WriteLine("Hi Im Employee Print2");
        }


    }




    internal class Program
    {
        static void Main(string[] args)
        {
            Person P1 = new Person();
            P1.Print();
            P1.Print2();


            Employee Emp = new Employee();
            Emp.Print();
            Emp.Print2();
             
            //when up casting The shadowing or hiding are returned to the base method
            //but the overriding are not , there maintain the derived method that overrided
            Person P2 = new Employee();
            P2.Print();// overeide method
            P2.Print2();//base method
           
           
      
            Console.ReadLine();
        }
    }
}
