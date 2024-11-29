using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public  interface IPerson
    {
        string FirstName { set; get; }
        string LastName { set; get; }
        string BirthDate { set; get; }
        char Gender {  set; get; }
        void Introduce(string Message);
        int CalculeAge();
        string int_To_String(int Num);

    }

    public  class Employee : IPerson
    {
        public string FirstName { set; get; }
        public string LastName { set; get; }

        public string BirthDate { set; get; }

        public char Gender { set; get; }
        public  void Introduce(string Message) { Console.WriteLine(Message); }
        
        public int CalculeAge()
        {
            return 20;
        }

        public string int_To_String(int num)
        {
            return num.ToString();  
        }


    }

    //Abstract Example
    public abstract class Employee1 : IPerson
    {
        public string FirstName { set; get; }
        public string LastName { set; get; }

        public string BirthDate { set; get; }

        public char Gender { set; get; }
        public abstract void Introduce(string Message);

        public int CalculeAge()
        {
            return 20;
        }

        public string int_To_String(int num)
        {
            return num.ToString();
        }


    }

    public class Test : Employee1
    {
        public override void Introduce(string Message)
        {
            Console.WriteLine(Message);
           
        }
    }


    internal class Program
    {
        static void Main(string[] args)
        {
            Employee Emp = new  Employee();
            Emp.FirstName = "Mustapha";
            Emp.LastName = "Botte";
            Emp.BirthDate = "27/10/2004";
            Emp.Gender = 'M';
            Console.WriteLine(Emp.FirstName);
            Console.WriteLine(Emp.LastName);
            Console.WriteLine(Emp.BirthDate);
            Console.WriteLine(Emp.Gender);
            Emp.Introduce("Hello");
            Console.WriteLine(Emp.CalculeAge());


            Test T = new Test();
            T.Introduce("Test");

            Console.ReadLine(); 
        }
    }
}
