using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day4
{
    internal class ex2
    {
        class GenericOperationTable<T>
        {
            public delegate T FuncOP(T x, T y);
            T[,] arr;
            public GenericOperationTable(List<T> rows, List<T> columns, FuncOP op)
            {
                arr= new T[rows.Count, columns.Count];
                for (int i = 0; i < rows.Count; i++) {
                    for (int j = 0; j < columns.Count; j++) { 
                        arr[i,j]=op(rows[i], columns[j]);
                    }
                }
            }

            public void printList() {
                for (int i = 0; i < arr.GetLength(0); i++)
                {
                    for (int j = 0; j < arr.GetLength(1); j++)
                    {
                        Console.Write(arr[i,j]+" ");
                    }
                    Console.WriteLine();
                }
            }

        }

        public static void main()
        {
            List<int> rows = new List<int>();
            List<int> columns = new List<int>();
            for(int i=0; i < 5; i++)
            {
                rows.Add(i+1);
                columns.Add(i+1);
            }

            GenericOperationTable<int> got = new GenericOperationTable<int>(rows, columns, (x, y)=>x+y);
            got.printList();

            Console.WriteLine();

            List<double> rows1 = new List<double>();
            List<double> columns1 = new List<double>();
            for(double i=1; i < 6; i++)
            {
                rows1.Add(1/i);
                columns1.Add(1/i);
            }

            GenericOperationTable<double> got2 = new GenericOperationTable<double>(rows1, columns1, (x, y)=>x*y);
            got2.printList();
        }


    }
}
