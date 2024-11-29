using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//namespace ConsoleApp1
//{
//    public class A
//    {
//        public int x = 10;
//        protected int y = 20;
//        private int z = 30;
//    }

//    public class B : A
//    {
//        public int X()
//         {
//            return x + y;

//         }

//    }


//    public class C : A 
//    {
//        public int X()
//        {
//            return x + y;

//        }

//    }




//    //we have in c#
//    //singel inheritance : normal inheritance
//    //MultiLevel Inheritance : when B inherite A and c Inherite B
//    // hiercharical inheritance : when C And B both Inherite A

//    //in c++ there are others:
//    // multiple inheritance : when C inherite From A and B
//    // hybrid inheritance : when B and C inherite From A and D  finally  inherite from B and C 


//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            B b = new B();
//            Console.WriteLine(b.X());

//            C c = new C();  
//            Console.WriteLine(c.X());


//            Console.ReadKey();
//        }
//    }
//}


//Multi Level inheritence A <-- B <-- c
//namespace consoleApp1
//{

//    class Person
//    {
//        public int _Age { get; set; }
//        public string _Name { set; get; }

//        public Person(int Age , string Name)
//        {
//            _Age = Age;
//            _Name = Name;   

//        }
//        public void Introduce()
//        {
//            Console.WriteLine($"Hi My Name Is {_Name}Im {_Age} Years Old");
//        }
//    }

//    class Employye : Person
//    {
//        public int _EmpID { get; set; }
//        public int _Salary { set; get; }

//        public Employye( int EmpID ,int Age,string Name ,int Salary ):base(Age,Name)
//        {
//            _EmpID = EmpID;
//            _Salary = Salary;

//        }
//        public void Work() 
//        {
//            Console.WriteLine($"Employee ID {_EmpID} and Salary  {_Salary} Is Working");
//        }

//    }

//    class Doctor : Employye
//    {
//        public string _Specialty { set; get; }
//        public Doctor(int ID , int Age, string Name,int Salary , string Specialty): base(ID,Age,Name,Salary)
//        {
//            _Specialty = Specialty;
//        }

//        public void Heal()
//        {
//            Console.WriteLine($"Doctor Name  {_Name} and Specialty  {_Specialty} Is Healing a patient");
//        }

//    }




//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            Doctor doctor = new Doctor(101,20,"Mustapha",5000,"eyes");
//           // doctor.EmpID = 10;
//           // doctor.Age = 25;
//           // doctor.Name = "Alex";
//           // doctor.Salary = 5000;
//           // doctor.Specialty = "Eyes";

//            doctor.Introduce();
//            doctor.Work();
//            doctor.Heal();
//            Console.ReadKey();
//        }


//    }



//}



//hierarchal inheritance
// A<--B  A<--C


namespace consoleApp1
{

    class Machine
    {
        public string _Name { set; get; }
        public string _Type { set; get; }
        public int _YearOfProduction { get; set; }
        public string _Use { set; get; }
        public int _Price { set; get; }


        public Machine(string type, string Name, int Year,int Price,string Use)
        {
            _Type = type;
            _Name = Name;
            _Use = Use;
            _YearOfProduction = Year;
            _Price = Price;
            
        }
        public void Introduce()
        {
            Console.WriteLine($"Machine Name {_Name}, And Machine Type {_Type} Its factured In {_YearOfProduction}, With Coast  {_Price}$, Use To {_Use}");
        }
    }

    class Phone : Machine
    {
       
        public int _PhoneID { set; get; }

        public string _Company { set; get; }

        public Phone(int PhoneID, string Company,int Price, int YearOfProduction, string Use,string Type, string Name) 
            : base(Type, Name, YearOfProduction,Price,Use)
        {
            _PhoneID = PhoneID;
            _Company = Company;
        }
        public void Explain()
        {
            Console.WriteLine($"Phone ID  {_PhoneID} Manufactured By {_Company}");
        }

    }

    class Tv : Machine 
    {
      

        public int _TvID { set; get; }

        public string _Company { set; get; }

        public Tv(int PlayerID, string Company, int Price, int YearOfProduction, string Use, string Type, string Name) :
            base(Type, Name, YearOfProduction, Price, Use)
        {
            _TvID = PlayerID;
            _Company = Company;
        }
        public void Explain()
        {
            Console.WriteLine($"TV ID  {_TvID} Manufactured By {_Company}");
        }


    }




    internal class Program
    {
        static void Main(string[] args)
        {
            Phone Phone1 = new Phone(10,"Huawei",100, 2019, "Browsing And Communication And Calls","Phone","Huawei Y7Prime 2019");
            Tv Tv1 = new Tv(10, "LG", 300, 2022, "Watching Channels", "TV", "LG S500");
           
            Phone1.Introduce();
            Phone1.Explain();
            Tv1.Introduce();
            Tv1.Explain();
            Console.ReadKey();
        }


    }



}