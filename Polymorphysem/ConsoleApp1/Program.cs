using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{

    // this is examples of polymorphism


    //Compile Time Polymorphism (OverLoading Or Shadowing)
    class Poly
    {
        public  int Sum(int Num1, int Num2)
        {
            return Num1 + Num2;
        }
        public int Sum(int Num1, int Num2 ,int Num3)
        {
            return Num1 + Num2+ Num3;
        }

    }



    //Run Time Polymorphism (Overriding )

    class Person
    {
        public virtual void introduce()
        {
            Console.WriteLine("Hi Im Person");
        }
    }
    class Employee : Person
    {
     public override void introduce()
        {
            Console.WriteLine("Hi Im Employee");
        }

    }

    //And olso Polymorphism its when employee and user inherite from person
    // now person have two faces one for user and one for employee
    //known as SubTyping Or Subtype polymorphism

    internal class Program
    {
        static void Main(string[] args)
        {
            Poly poly = new Poly();
            Console.WriteLine(poly.Sum(1, 1));
            Console.WriteLine(poly.Sum(1, 1,3));

            Employee employee = new Employee();
            employee.introduce();

            Console.Read();
        }

    }
}

//Encapsulation
//Abstraction
//Inheritance
//Polymorphism