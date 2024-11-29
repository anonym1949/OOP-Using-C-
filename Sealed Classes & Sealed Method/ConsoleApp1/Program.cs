using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//sealed class
sealed class ClsA
{

}
//This is Cannot Happen
// You can't inherite from a sealed class

 //class ClsB : ClsA{}


//sealed method
class ClsC
{
    public virtual string C()
    {
        return "C";
    }
}

class ClsD : ClsC
{
    public sealed override string C()
    {
        return "D";
    }

}
class ClsE : ClsD
{
    //You cannot override C function becuase its sealed
    public  override string C()
    {
        return "D";
    }

}


internal class Program
    {
        static void Main(string[] args)
        {
        }
    }

