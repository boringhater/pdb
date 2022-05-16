using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PDB_1
{
    public class MatrixSort
    {
        public static bool CompTypeDesc(int a, int b) //убывание
        {
            return a < b;
        }
        public static bool CompTypeAsc(int a, int b) //возрастание
        {
            return a > b;
        }


        public static int SortParamLineSum(int[] mxLine) //по сумме
        {
            return mxLine.Sum();
        }

        public static int SortParamMaxElem(int[] mxLine) //по максимальному элементу строки
        {
            return mxLine.Max();
        }

        public static int SortParamMinElem(int[] mxLine) //по минимальному элементу строки
        {
            return mxLine.Min();
        }

        public static void SortMatrix(MatrixType matrix, Func<int[], int> sortParam, Func<int, int, bool> compType)
        {
            for (int i = 0; i < matrix.Rows; i++)
            {
                for (int j = i + 1; j < matrix.Rows; j++)
                {
                    if (compType(sortParam(matrix.GetLine(i)), sortParam(matrix.GetLine(j))))
                    {
                        matrix.SwapLines(i, j);
                    }
                }
            }
        }
    }
}
