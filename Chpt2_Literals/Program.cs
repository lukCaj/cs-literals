using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chpt2_Literals
{
    class Program
    {
        public struct Complex
        {
            public double Real { get; set; }
            public double Imaginary { get; set; }
        }


        static void Main(string[] args)
        {
            // uint literals are defined by using the suffix U or u, or by using
            // an integral values within the range of uint.
            uint ui = 5U;

            Console.WriteLine("{0} {1}", "uint ui variable is:" , ui);
            System.Threading.Thread.Sleep(2000); // Wait for 2 seconds.

            // int literals are defined by simply using integral values within
            // the range of int.
            int i = 5;

            Console.WriteLine("{0} {1}" , "int i variable is:" , i);
            System.Threading.Thread.Sleep(1000);
            Console.WriteLine("{0} {1}" , "i + 4 =" , i + 4);
            System.Threading.Thread.Sleep(2000);
            
            // sbyte type has no literal suffix. Integer literals are implicitly
            // converted from int.
            sbyte sb = 127;

            Console.WriteLine("{0} {1}", "sbyte sb variable is:", sb);
            System.Threading.Thread.Sleep(2000);
            Console.WriteLine("{0} {1}", "sb + i = ", sb + i);
            System.Threading.Thread.Sleep(2000);

            // decimal literals are defined by using the suffix M or m on a real
            // number.
            decimal m = 30.5M;

            Console.WriteLine("{0} {1}", "decimal m variable is:", m);
            System.Threading.Thread.Sleep(2000);
            Console.WriteLine("{0} {1}", "m + 12.5 = ", m + 12.5M); // You need to have the M (or m) if you combine a decimal variable with a decimal.
            System.Threading.Thread.Sleep(2000);

            // double literals are defined by using the suffix D or d, or by
            // using a real number
            double d = 30.5D;

            Console.WriteLine("{0} {1}", "double d variable is:", d);
            System.Threading.Thread.Sleep(2000);
            Console.WriteLine("{0} {1}", "d + 12.5 = ", d + 12.5D); // You need to have the D (or d) if you combine a double variable with a double.
            System.Threading.Thread.Sleep(2000);

            // float literals are defined by using the suffix F or f, or by
            // using a real number.
            float f = 30.5F;

            Console.WriteLine("{0} {1}", "float f variable is:", f);
            System.Threading.Thread.Sleep(2000);
            Console.WriteLine("{0} {1}", "f + 12.5 = ", f + 12.5); // You can (but don't need) to have the f (or F) if you combine a float variable with a float.
            System.Threading.Thread.Sleep(2000);

            // long literals are defined by using the suffix L or l, or by
            // using an integral values within the range of a "long".
            long l = 5L;

            Console.WriteLine("{0} {1}", "long l variable is:", l);
            System.Threading.Thread.Sleep(2000);
            Console.WriteLine("{0} {1}", "l + 12.5 = ", l + 4); // You can (but don't need) to have the l (or L) if you combine a long variable with a long/float.
            System.Threading.Thread.Sleep(2000);

            // ulong literals are defined by using the suffix UL, ul, uL,
            // LU, lu, Lu or lU, or by using an integral values within the
            // range of ulong.
            ulong ul = 5UL;

            Console.WriteLine("{0} {1}", "ulong ul variable is:", ul);
            System.Threading.Thread.Sleep(2000);
            Console.WriteLine("{0} {1}", "ul + 4 = ", ul + 4); // You can (but don't need) to have the ul (or UL or some combinations) if you combine a ulong variable with a long/float.
            System.Threading.Thread.Sleep(2000);

            // string literals are defined by wrapping the value with
            // double-quotes.
            // String literals may contain escape sequences.
            string s = "Hello, this is a string literal";

            Console.WriteLine("{0} {1}", "string s variable is:", s);
            System.Threading.Thread.Sleep(2000);
            Console.WriteLine(s);
            System.Threading.Thread.Sleep(2000);

            // char literals are defined by wrapping the value with
            // single-quotes.
            // Character literals may contain escape sequences.
            char c = 'h';

            Console.WriteLine("{0} {1}", "char c variable is:", c);
            System.Threading.Thread.Sleep(2000);
            Console.WriteLine("The character has to have single quotes."); 
            System.Threading.Thread.Sleep(2000);

            // byte type has no literal suffix. Integer literals are
            // implicitly converted from int.
            byte b = 127;

            Console.WriteLine("{0} {1}", "byte b variable is:", b);
            System.Threading.Thread.Sleep(2000);
            Console.WriteLine("I have no clue why this exists."); 
            System.Threading.Thread.Sleep(2000);

            // short type has no literal. Integer literals are implicitly
            // converted from int.
            short sh = 127;

            Console.WriteLine("{0} {1}", "short sh variable is:", sh);
            System.Threading.Thread.Sleep(2000);
            Console.WriteLine("This is basically for small numbers to save space."); 
            System.Threading.Thread.Sleep(2000);

            // ushort type has no literal suffix. Integer literals are
            // implicitly converted from int.
            ushort us = 127;

            Console.WriteLine("{0} {1}", "ushort us variable is:", us);
            System.Threading.Thread.Sleep(2000);
            Console.WriteLine("I have no clue why this exists."); 
            System.Threading.Thread.Sleep(2000);

            // bool literals are either true or false.
            bool bo = true;

            Console.WriteLine("{0} {1}", "bool bo variable is:", bo);
            System.Threading.Thread.Sleep(2000);
            Console.WriteLine("True!"); 
            System.Threading.Thread.Sleep(2000);

            Console.WriteLine("Press any key to close.");
            System.Console.ReadKey(true); // To close the program.
            Console.WriteLine("Okay, Bye!");
            System.Threading.Thread.Sleep(1000);

            // Would like to know:
            // - How to use this Main method variables in another method that is
            //   in the same class, since I have not been able to do that
            //   well, and possibly having a method to define variables could
            //   make it easier for testing for different variables since
            //   it is easier to organise and easier to clone for testing.
            //   Another way to do this is to make them global variables which
            //   would be outside of the program.
        }
    }
}
