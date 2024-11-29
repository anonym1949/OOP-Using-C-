using System.Runtime.CompilerServices;

class MainClass
{
    class ClsA
    {
        public int X = 10;
        public static int Y =20;

        public int Method1()
        {
            return Y;
            return Method2();
            return 100;
        }

        public static int Method2()
        {
            
            return 200;
        }

    }


    internal class Program
    {
        static void Main()
        {
            ClsA A = new ClsA();


            Console.WriteLine("X VAlue {0}", A.X.ToString());

            Console.WriteLine("Method1 VAlue {0}", A.Method1().ToString());

            //You can acess The static members only using The class it self
            //Because the static value are shared by all objects
            //the object cannot acess the static members
            //the static members can access only other static member
            Console.WriteLine("Y VAlue {0}", ClsA.Y.ToString());

            Console.WriteLine("Method1 VAlue {0}", ClsA.Method2().ToString());

        }




    }






















}