using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YoureASquare
{
    internal class Program
    {
//              A square of squares
//      You like building blocks.You especially like building blocks that are squares.And what you even like more, is to arrange them into a square of square building blocks!

//      However, sometimes, you can't arrange them into a square. Instead, you end up with an ordinary rectangle! Those blasted things! If you just had a way to know, whether you're currently working in vain… Wait! That's it! You just have to check if your number of building blocks is a perfect square.

//      Task
//      Given an integral number, determine if it's a square number:

//      In mathematics, a square number or perfect square is an integer that is the square of an integer; in other words, it is the product of some integer with itself.

//      The tests will always use some integral number, so don't worry about that in dynamic typed languages.

//      Examples
//      -1  =>  false
//       0  =>  true
//       3  =>  false
//       4  =>  true
//      25  =>  true
//      26  =>  false
        static void Main(string[] args)
        {
            IsSquare(4);
            Console.WriteLine($"{IsSquare(5)}");
            Console.ReadLine();
        }

        public static bool IsSquare(int n)
        {
            //int a=n%10;
            //if ((a != 0) && (a != 1) && (a != 4) && (a != 9))
            //{
            //    return false;
            //}
            //else if (a == 189881)
            //    return false;
            //else if (a ==5&&a==196571)
            //    return true;
            //else if (a ==16)
            //    return false;

            //return Math.Sqrt(n) % 1 == 0;

            double a =Math.Sqrt(n);
            
            if(Math.Floor(a) != Math.Ceiling(a))
            {
                return false;
            }

            
            return true;
        }
    }
}
