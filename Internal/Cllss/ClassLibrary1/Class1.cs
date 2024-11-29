using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Class1
    {
       protected internal int X = 10;
        public void Show()
        {
            Console.WriteLine(X.ToString());
        }

    }
}


//Internal its a Acces Modifier 
// its used when you want a class or methode to be used with in the current assembly only
// the only way to acess internal method it from other assembly its to use protected internal and inherite the class
// the internal class nooo way to acess from other assembly 