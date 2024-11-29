
 


namespace Project
{

    class ClsA
    {
        public    int X1 = 10;
        protected int X2 = 10;
        private   int X3 = 10;
     
        public int Fun1()
        {
            return 100;
        }
        protected int Fun2()
        {
            return 200;
        }
        private int Fun3()
        {
            return 300;
        }
    }
    class ClsB : ClsA
    {
        public void Fun1()
        {
            Console.WriteLine( X2.ToString());
           // Fun1();
           // Fun2();
            // You can access Here X1 and X2 
            // and fun 1 and Fun 2 
            // Because They are Public and Protected
        }

    }

    
    partial class Program
    {
        static void Main()
        {
            //Here You Can  accees only the public in clsb 
            ClsB B = new ClsB();
           Console.WriteLine( B.X1.ToString());
            B.Fun1();
            

            // and you can acess only X1 fun1 from claA
            ClsA A = new ClsA();
            Console.WriteLine(A.Fun1());
        }

    }


}