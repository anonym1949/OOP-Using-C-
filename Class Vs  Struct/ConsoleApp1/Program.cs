using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Employee
    {
        public string Name
        {
            get; set;
        }

    }

    struct ST_Employee
    {
        public string Name ; 
    }




        internal class Program
        {
           static void Main(string[] args)
           {
                
            Employee Emp1 = new Employee();
            Emp1.Name = "Mustapha";
            Employee Emp2 = Emp1;
            Emp2.Name = "Botte";
            Console.WriteLine(Emp1.Name);//will show botte
            Console.WriteLine(Emp2.Name);//will show botte         
            //because class are a reference type when you edit a value its edited in the both objects
           
            
            //______________________________________________________________________________________________________________________
            ST_Employee StEmp = new ST_Employee();
            StEmp.Name = "Mustapha";
            ST_Employee STEmp2 = StEmp;
            STEmp2.Name = "Botte";
            Console.WriteLine(StEmp.Name);//will show Mustapha         
            Console.WriteLine(STEmp2.Name);//will show botte         
            //Because Structs Are Value Type when you edit a value its edited in the current struct container


            //struct are much faster than class BC struct are stored in stack
            // and class stored in heap
            //class support inheritance and struct not
            // class support default constructor and struct not
            Console.ReadKey();
           }
        }
    
}
