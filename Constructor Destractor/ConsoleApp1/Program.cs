
using System;
using System.IO;
using System.Security.Cryptography.X509Certificates;


////this is a non Parameter Less Constructor
//class ConsoleApp1
//{
//    internal class ClsPerson
//    {
//        public int     ID { get; set; }
//        public string Name { get; set; }
//        public byte   Age { get; set; }
//        public ClsPerson()
//        {
//            ID = -1;
//            Age = 10;
//            Name = "X";
//        }





//    }  
//    internal class program
//    {
//        static void Main()
//        {
//            ClsPerson ClsA = new ClsPerson();
//            Console.WriteLine(ClsA.ID.ToString());
//            Console.WriteLine(ClsA.Age.ToString());
//            Console.WriteLine(ClsA.Name.ToString());

//            Console.ReadKey();
//        }
//    }
//}


//this is a  Parameterized Constructor
//class ConsoleApp1
//{
//    internal class ClsPerson
//    {
//        public int _ID { get; set; }
//        public string _Name { get; set; }
//        public byte _Age { get; set; }
//        public ClsPerson(int ID=1, byte Age=1, string Name)
//        {
//            _ID = ID;
//            _Age = Age;
//            _Name = Name;
//        }







//        static void Main()
//        {
//            ClsPerson ClsA = new ClsPerson(1001111, 100, "Mustapha");
//            Console.WriteLine(ClsA._ID.ToString());
//            Console.WriteLine(ClsA._Age.ToString());
//            Console.WriteLine(ClsA._Name.ToString());

//            Console.ReadKey();
//        }
//    }
//}




//this is a  Private Constructor
//class ConsoleApp1
//{
//  class Settings
//{
//        public static int DayNumber
//        {
//            get
//            {
//                return DateTime.Now.Day;
//            }
//        }

//        public static string DayName
//        {
//            get
//            {
//                return DateTime.Today.DayOfWeek.ToString();
//            }
//        }

//        public static string Path
//        {
//            get
//            {
//                return Path;
//            }

//            set
//            {
//                Path = value;
//            }

//        }

//        private Settings()
//        {

//        }

// }


//    class program
//    {
//        static void Main()
//        {
//you cant create object because constructor is private
// we use this when we dont want to have an object at all , and all methods are static , shared
// or define the class as static (when the class are static all methode must be static)
//Settings ClsA = new Settings();
//            Console.WriteLine(Settings.DayNumber.ToString());
//            Console.WriteLine(Settings.DayName);
//            Settings.Path = "/X";
//            Console.WriteLine(Settings.Path);

//            Console.ReadKey();
//        }
//    }   
//}


//this is a multiple Constructor

//class ConsoleApp1
//{
//    internal class ClsPerson
//    {
//        public int _ID { get; set; }
//        public string _Name { get; set; }
//        public byte _Age { get; set; }
//        public ClsPerson(int ID, byte Age, string Name)
//        {
//            this._ID = ID;
//            this._Age = Age;
//            this._Name = Name;
//        }



//        public ClsPerson()
//        {
//            this._ID  = 10;
//            this._Age = 20;
//            this._Name = "Botte";
//        }

//    }




//    internal class program
//    { 
//        static void Main()
//        {
//            ClsPerson ClsA = new ClsPerson(1001111, 100, "Mustapha");
//            Console.WriteLine(ClsA._ID.ToString());
//            Console.WriteLine(ClsA._Age.ToString());
//            Console.WriteLine(ClsA._Name.ToString());


//           ClsPerson ClsB = new ClsPerson();
//           Console.WriteLine(ClsB._ID.ToString());
//           Console.WriteLine(ClsB._Age.ToString());
//           Console.WriteLine(ClsB._Name.ToString());



//            Console.ReadKey();
//        }

//    }
//}










//this is a  static Constructor
static class ConsoleApp1
{
  class Settings
{
        static string  Path ="";
        public static int DayNumber
        {
            get
            {
                return DateTime.Now.Day;
            }
        }

        public static string DayName
        {
            get
            {
                return DateTime.Today.DayOfWeek.ToString();
            }
        }

        public static string _Path
        {
            get
            {
                return Path;
            }

            set
            {
                Path = value;
            }

        }
        static Settings()
        {
            Path = "jkhekujdgegdgeuyg";
        }

 }


    class program
    {
        static void Main()
        {

           
            Console.WriteLine(Settings.DayNumber.ToString());
            Console.WriteLine(Settings.DayName);
          //  Settings.Path = "ouoiuoj";
            Console.WriteLine(Settings._Path);


         


            Console.ReadKey();
        }
    }   
}