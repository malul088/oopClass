using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day5
{
    class GenericOperationTable<T>
    {
        public delegate T FuncOP(T x, T y);
        T[,] arr;
        public GenericOperationTable(List<T> rows, List<T> columns, FuncOP op)
        {
            arr = new T[rows.Count, columns.Count];
            for (int i = 0; i < rows.Count; i++)
            {
                for (int j = 0; j < columns.Count; j++)
                {
                    arr[i, j] = op(rows[i], columns[j]);
                }
            }
        }

        public void printList()
        {
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    Console.Write(arr[i, j] + " ");
                }
                Console.WriteLine();
            }
        }

    }

}
