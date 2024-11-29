
//class Test
//{

//   public class clsEmployee
//    {
//        private int _age = 0;
//        private string _Name = string.Empty;
//        private int _ID = 1;


//        public int ID
//        {
//            get { return _ID; }
//        }



//        public int Age
//        {
//            set
//            {
//                if (value >= 20)
//                {
//                    _age = 0;
//                    return;
//                }
//                _age = value;

//            }

//            get
//            {
//                return _age;
//            }
//        }


//        public string Name
//        {
//            set
//            {
               
//                _Name = value.ToString();
//            }
//            get
//            {
//                return _Name;
//            }
//        }

//    }
//       internal
//        class program
//        {
//            static void Main()
//            {
//                clsEmployee Emp = new clsEmployee();
//                Emp.Age = 20;

//                Console.WriteLine("emp Age = {0}", Emp.Age);

//                Emp.Name = "Mustapha";
//                Console.WriteLine("Emp Name = {0}", Emp.Name);

//               //Read Only
//               Console.WriteLine("Emp ID = {0}", Emp.ID);

//            }
//        }

//}

//Auto implement property
// Note : better use it when you dont need to do some action when user do set or get 



//class Test1
//{

//    public class clsEmployee
//    {
       

//        public int ID
//        {
//            get;
            
//        }


//        private int _age = 0;
//        public int Age
//        {
            
//            set
//            {
//                if(value >= 20)
//                {
//                    _age = 0;
//                }
//            }
//            get
//            {
//                return _age; 
//            }
//        }


//        public string Name
//        {
//            set;
//            get;
//        }

//    }
//    internal class program
//    {
//        static void Main()
//        {
//            clsEmployee Emp = new clsEmployee();
//            Emp.Age = 20;

//            Console.WriteLine("emp Age = {0}", Emp.Age);

//            Emp.Name = "Mustapha";
//            Console.WriteLine("Emp Name = {0}", Emp.Name);

//            //Read Only
//            Console.WriteLine("Emp ID = {0}", Emp.ID);

//        }
//    }

//}

//property set get for static member
class Settings
{

    public static int Day
    {
        get { return DateTime.Today.Day; }

    }

    public static string DayName
    {
        get { return DateTime.Today.DayOfWeek.ToString(); }

    }

    public static string PATH
    {
        get;
        set;
    }

    static void Main()
    {
        Console.WriteLine(Settings.Day.ToString());
        Console.WriteLine(Settings.DayName.ToString());
       
        Settings.PATH= "C/User ";
        Console.WriteLine(Settings.PATH.ToString());

    }


}

