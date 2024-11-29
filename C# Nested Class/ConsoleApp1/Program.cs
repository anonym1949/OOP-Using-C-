using System;
using System.Runtime.CompilerServices;

public class OuterClass
{
    private int OuterVar;

    public OuterClass(int outer)
    {
        this.OuterVar = outer;
    }
    public void OuterPrint()
    {
        
        Console.WriteLine(this.OuterVar.ToString());
        InnerClass I = new InnerClass(44);
        Console.WriteLine(I.InnerVar);
    }

    public class InnerClass
    {
        public int InnerVar;

        public InnerClass(int Ineer)
        {
           
            this.InnerVar = Ineer;
        }
        public void IneerPrint()
        {
            OuterClass O = new OuterClass(45);
            Console.WriteLine(O.OuterVar);

            Console.WriteLine(this.InnerVar.ToString());
        }

        public void OuterPrint(OuterClass X)
        {
            Console.WriteLine(X.OuterVar.ToString());
        }
    }

}
//Note :if you define a object outer class in Inner class it Have  acees to all Methode and member private or public
// but if you define a object inner class in outer class it have acces to only public members 
// Because Inner class considered a seperated class it self 
    internal class Program
    {
        static void Main()
        {
            OuterClass outer = new OuterClass(100);
            outer.OuterPrint();

           OuterClass.InnerClass inner= new OuterClass.InnerClass(50);
           inner.IneerPrint();
           inner.OuterPrint(outer);
           Console.ReadKey();
        }

    }

