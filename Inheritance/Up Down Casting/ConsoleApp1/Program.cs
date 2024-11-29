using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ConsoleApp1
{
    public class Person
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }


        public void Greet()
        {
            Console.WriteLine($"Hi, my name is {Name} and I am {Age} years old.");
        }
    }
    public class Employee : Person
    {
        public string Company { get; set; }
        public int Salary { get; set; }


        public void Work()
        {
            Console.WriteLine($"I work at {Company} and earn {Salary:C} per year.");
        }

    }


    internal class Program
    {
        static void Main(string[] args)
        {
            //Up Casting we Convert the sub class (Big) to the base class (small) its always safe 
            //because the data needed in base class is guaranted that its in sub class because (inheritance)
            Employee Emp1 = new Employee {Id=10, Age=20, Name="Mustapha", Salary = 500000, Company = "XYZ" };
            Person P1 = Emp1;
            //P1 has acces only for methode that he already has
            //implicit type converstion ضمني



            //but
            //DownCasting
            Person P2 = new Employee {Age=1,Id=1,Name="x",Company="ghg",Salary=5000 };
            Employee Emp2 =(Employee) P2;
            Console.WriteLine(Emp2.Age);




            //this will give you a error
            //Person P3 = new Person();
            //Employee Emp3 = (Employee)P3;

            Console.ReadKey();

        }
    }
}
