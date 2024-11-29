using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{

    class ClsPerson
    {
        public int _ID {  get; set; }
        public string _NAme { get; set; }
        public int _Age { get; set; }

        public ClsPerson(int ID, int Age, string Name="")
        {
               _ID = ID;
            _NAme = Name;
            _Age = Age;
        }

        public static ClsPerson Find(string user , string pass)
        {
            if(user=="user1" && pass =="1234")
            {
                return new ClsPerson(10, 20, "Mustapha");
            }
            return null;
        }
        public static ClsPerson Find(int ID, int x = 4)
        {
            if (ID == 10)
            {
                return new ClsPerson(10, 20, "Mustapha");
            }
            return null;
        }

    
    }



    internal class Program
    {
        static void Main(string[] args)
        {
            //ClsPerson P1 = new ClsPerson(10, 20);

            ClsPerson P1 = ClsPerson.Find(10);
            if(P1 != null)
            {
                Console.WriteLine("Person Id {0}", P1._ID.ToString());
                Console.WriteLine("Person Name {0} ", P1._NAme);
                Console.WriteLine("Person Age {0}", P1._Age.ToString());
                Console.ReadKey();
            }

            else
            {
                Console.WriteLine("empty");
                Console.ReadKey();

            }


        }
    }
}
