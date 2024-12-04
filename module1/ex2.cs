using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex1
{
    internal class ex2
    {
        class c
        {
            public int x;
            public int y;
            private static void Main(string[] args)
            {
                StackOverflowExperiment();
            }
            public static void StackOverflowExperiment()
            {
                static int RecursiveMethod(int depth, int localArraySize)
                {
                    c[] car = new c[localArraySize];
                    //byte[] localArray = new byte[localArraySize];
                    //int g = 90090;
                    try
                    {
                        return RecursiveMethod(depth + 1, localArraySize);
                    }
                    catch (StackOverflowException)
                    {
                        return depth;
                    }
                }
                // Experiment with different local array sizes
                int[] arraySizes = { 10000000 };
                foreach (int size in arraySizes)
                {
                    Console.WriteLine($"\nExperiment with local array size: {size} bytes");
                    try
                    {
                        int maxDepth = RecursiveMethod(0, size);
                        Console.WriteLine($"Maximum recursion depth: {maxDepth}");
                    }
                    catch (StackOverflowException)
                    {
                        Console.WriteLine("Stack overflow occurred!");
                    }
                }
            }
        }
    }
}
