using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PDB_1
{
    class Program
    {
        static void Main(string[] args)
        {
            MatrixType a = new MatrixType(5, 6);
            Console.WriteLine("Before:");
            a.Write();
            Console.WriteLine("\n\n\n");
            MatrixSort.SortMatrix(a, MatrixSort.SortParamLineSum, MatrixSort.CompTypeAsc);
            Console.WriteLine("After:");
            a.Write();
        }
    }
}
