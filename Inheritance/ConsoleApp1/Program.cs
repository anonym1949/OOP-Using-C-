using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

//
class ConsoleApp1
{
    //Base/super class
    public class ClsPerson
    {

       public ClsPerson(int ID,int Age , string FName ,string LName , String Gender , string Email ,string Phone )
        {
            _ID = ID;
            _Age = Age;
            _FName = FName;
            _LName = LName;
            _Email = Email;
            _Phone = Phone;
            _Gender = Gender;

        }

        public int _ID { get; set; }
        public int _Age { get; set; }
        public string _FName { get; set; }
        public string _LName { get; set; }
        public string _Gender { get; set; }
        public string _Email { get; set; }
        public string _Phone { get; set; }

        public string FullName
        {
            get
            {
               return  _FName + " " + _LName;
            }
        }
        public void SendEmail(string Subject, string Body)
        {
            if (Subject != null && Body != null)
            {
                Console.WriteLine("Email Sended SuccesFully To " + this._Email + Environment.NewLine +
                    " Subject : " + Subject + Environment.NewLine + "Body :" + Body);
            }
        }
        public void SendSms(string Body)
        {
            Console.WriteLine("Sms Sended SuccesFully To " + this._Phone + Environment.NewLine +
             "Body :" + Body);

        }


    }

    //derived/sub class
    public class ClsEmployee : ClsPerson
    {
        public int _Salary { get; set; }
        public string _Department { get; set; }

        //This is Inheritance constructor you should use base to send data to base class [:base]
       public ClsEmployee(int ID, int Age, string FName, string LName, String Gender, string Email, string Phone,string Department, int Salary):
            base( ID,  Age,  FName,  LName,  Gender,  Email,Phone)
        {
            _Salary = Salary;
            _Department = Department;
        
        }
        public void Print()
        {
            Console.WriteLine("Employee ID: " + this._ID);
            Console.WriteLine("Age: " + this._Age);
            Console.WriteLine("First Name: " + this._FName);
            Console.WriteLine("Last Name: " + this._LName);
            Console.WriteLine("Gender: " + this._Gender);
            Console.WriteLine("Email: " + this._Email);
            Console.WriteLine("Phone: " + this._Phone);
            Console.WriteLine("Department: " + this._Department);
            Console.WriteLine("Salary: " + this._Salary);
            Console.WriteLine("Full Name: " + this.FullName);
        }

    }



    internal class Program
    {
        static void Main(string[] args)
        {
            ClsEmployee Emp1 = new ClsEmployee(10, 20, "Mustapha", "Botte", "M", "mail.com", "0608310061", "IT", 5000);
            Emp1.Print();

         
            Emp1.SendEmail("Warning", "Finish The Task Soon As Possible");
            Emp1.SendSms("Good Morning ");
            Console.ReadKey();
        }
    }
}





















// inherite the full class
//class Test : ConsoleApp1
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            ConsoleApp1.ClsEmployee X = new ConsoleApp1.ClsEmployee(10, 20, "Mustapha", "Botte", "M", "mail.com", "0608310061", "IT", 5000);
//            Console.WriteLine("Test");
//            X.Print();
//            Console.ReadKey();
//        }
//    }
//}