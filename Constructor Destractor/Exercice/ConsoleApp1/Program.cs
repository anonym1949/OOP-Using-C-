using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{


    public class ClsPerson
    {
        public int _ID { get; set; }
        public string _Name { get; set; }
        public byte _Age { get; set; }
        public string _User{ get; set; }
        public string _Pass { get; set; }


        public ClsPerson(int ID, string Name, byte Age)
        {
            _ID = ID; _Name = Name; _Age = Age;
        }


        public static ClsPerson Find(string UserName,string PassWord)
        {
            if(UserName == "User1" || PassWord == "1234")
            {
                return new ClsPerson(10, "Mustapha", 20);
            }
            return null;
        }



       public static ClsPerson Find(int ID)
        {
            if (ID == 10 )
            {
                return new ClsPerson(10, "Mustapha", 20);
            }
            return null;
        }



    }








    internal class Program
    {
        static void Main(string[] args)
        {
            // ClsPerson Person1 = new ClsPerson(10, "Mustapha", 20);

            ClsPerson Person2= ClsPerson.Find(10);

            if (Person2 != null)
            {
                Console.WriteLine("Person ID {0} ",Person2._ID);
                Console.WriteLine("Person Age {0} ", Person2._Age);
                Console.WriteLine("Person Name {0} ", Person2._Name);
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("NOt Found :(- ID {0} ");
               
                Console.ReadKey();

            }

            ClsPerson Person3 = ClsPerson.Find("User","1434");

            if (Person2 != null)
            {
                Console.WriteLine("Person ID {0} ",  Person3._ID);
                Console.WriteLine("Person Age {0} ", Person3._Age);
                Console.WriteLine("Person Name {0} ", Person3._Name);
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("NOt Found :(- ID {0} ");

                Console.ReadKey();

            }



        }
    }
}
