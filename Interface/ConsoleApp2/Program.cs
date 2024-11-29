using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{

    public abstract class Employee
    {
        string _Role = "";
        public Employee(string role)
        {
            _Role = role;
        }

        public abstract string Project();
     
        public void Role()
        {
            Console.WriteLine(_Role);
        }
    }
    public abstract class Employee1
    {
        public abstract string Project1();

        public void Role1()
        {
            Console.WriteLine("Developer");
        }
    }

    //You Cannto do This Abstract Not Support Multiple Inheritance
    //public class Dev : Employee1,Employee{}
    public class Dev :Employee
    {
        public Dev(string Role) : base(Role)
        { }
        public override string Project()
        {
           return ("Banking System");
        }

        
    }


   


    public interface PersonnelEmpInfo
    {
    
        int Age { get; set; }
        string FN { get; set; }
        string LN { get; set; }
     

    }
    public interface WorkEmpInfo
    {
        int ID { get; set; }
        string Role { get; set; }
        int salary { get; set; }

        void SendEmail(string email) ;
    }
    public interface SendEmailToEmp
    {
        void SendEmail(string email);

    }
    public class EmpInfo :PersonnelEmpInfo,WorkEmpInfo, SendEmailToEmp
    {
        public int ID { get; set; }
        public string Role { get; set; }
        public int salary { get; set; }

        public int Age { set; get; }
        public string FN { set; get; }
        public string LN { set; get; }

        public void SendEmail(string message) 
        {
            Console.WriteLine(message);
        }
    }






    internal class Program
    {
        static void Main(string[] args)
        {
            //This Wrong Abstract use for inherite only>>-----<< Employee employee = new Employee();
            // This is The true:
            Dev Developer = new Dev("Dev");
            Console.WriteLine(Developer.Project());
            Developer.Role();






            //Now To Interface Example

            //EmpInfo EmpInfo = new EmpInfo();
            //EmpInfo.ID = 110;
            //EmpInfo.Role = "Dev";
            //EmpInfo.salary = 5000;
            //EmpInfo.LN = "Botte";
            //EmpInfo.FN = "Mustapha";
            //EmpInfo.Age = 20;
            //
            //Console.WriteLine(EmpInfo.ID);
            //Console.WriteLine(EmpInfo.FN);
            //Console.WriteLine(EmpInfo.Age);
            //Console.WriteLine(EmpInfo.LN);
            //Console.WriteLine(EmpInfo.salary);
            //Console.WriteLine(EmpInfo.Role);
            //EmpInfo.SendEmail("Hi Come");




            //Difference:
            //     Abstract                                      |Interface
            //   ________________________________________________
            //Have Both Declaration And implementation Of Methods|Have Only Declaration Of Methods
            //   Not Support Multiple interface                |Support multiple interface(illimited)
            //   CAn HAve  Fields Like string x ,int x           |cannot have fields only methods and properties 
            //   Can Have Constructor                            |Dont Have Constructor



            Console.ReadLine();
        }

    }



}
