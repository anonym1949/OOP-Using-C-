using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



    enum Level
    {
        Low,
        Medium,
        High
    }

 //   internal class Program
 //   {
 //       static void Main(string[] args)
 //       {
 //       Level level =Level.High;
 //
 //       Level level2 = level;
 //       level2 = Level.Low;
 //
 //       Console.WriteLine(level);
 //       Console.WriteLine(level2);
 //
 //
 //       Array Arr = Enum.GetValues(typeof(Level));
 //
 //       foreach (Level arr in Arr)
 //       {
 //           Console.WriteLine($"Level :{arr}, Value {(int)arr}");
 //       }
 //
 //       for (int i = 0; i < Arr.Length; i++)
 //       {
 //           Level L = (Level)Arr.GetValue(i);
 //           Console.WriteLine($"Level :{L}, Value :{(int)L}");
 //       }
 //
 //
 //
 //
 //
 //
 //       Console.ReadLine();
 //   }
 //   }


namespace StStruct
{
    struct Point
    {
        public int X;
        public int Y;


        public Point(int x, int y)
        {
            X = x;
            Y = y;
        }

        public override string ToString()
        {
            return ($"({X},{Y})");
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Point point = new Point(10,20);
            Console.WriteLine(point);

            Console.ReadLine();
        }
    }
}