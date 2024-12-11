using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Program;

namespace day4
{
    internal class ex1
    {
        public static void main()
        {
            int a = 6, b = 9;
            a = SortTwo(ref a, ref b, (x, y) => x > y);
            Console.WriteLine("#1. The maximum is: " + a);
            a = SortTwoByFunc(ref a, ref b);
            Console.WriteLine("#2. The maximum is: " + a);
            Console.WriteLine();

            double d1 = 62, d2 = 9;
            d1 = SortTwo(ref d1, ref d2, (x, y) => x > y);
            Console.WriteLine("#1. The maximum is: " + d1);
            d1 = SortTwoByFunc(ref d1, ref d2);
            Console.WriteLine("#2. The maximum is: " + d1);
            Console.WriteLine();

            char ch = 'a', ch1 = 'h';
            ch = SortTwo(ref ch, ref ch1, (x, y) => x.CompareTo(y) > 0);
            Console.WriteLine("#1. The maximum is: " + ch);
            ch1 = SortTwoByFunc(ref ch, ref ch1);
            Console.WriteLine("#2. The maximum is: " + ch1);
            Console.WriteLine();

            string s = "123", s1 = "1234";
            s = SortTwo(ref s, ref s1, (x, y) => x.CompareTo(y) > 0);
            Console.WriteLine("#1. The maximum is: " + s);
            s = SortTwoByFunc(ref s, ref s1);
            Console.WriteLine("#2. The maximum is: " + s);

        }
        public static T SortTwo<T>(ref T a, ref T b, ComparisonDel<T> comparison)
        {
            if (comparison(a, b))
                return a;
            else
                return b;
        }

        public static T SortTwoByFunc<T>(ref T a, ref T b) where T : IComparable<T>
        {
            if (a.CompareTo(b) > 0)
                return a;
            else
                return b;
        }
    }

}
