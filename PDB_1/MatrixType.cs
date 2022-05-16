using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PDB_1

{
    public class MatrixType //примитивная реализация матрицы для демонстрации сортировки
    {
        public int[,] matrixArr;
        private int rows;
        private int columns;
        public MatrixType(int rows, int columns)
        {
            matrixArr = new int[rows, columns];
            this.rows = rows;
            this.columns = columns;
            Random rand = new Random();
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    matrixArr[i, j] = rand.Next(10);
                }
            }
        }
        public int Rows
        {
            get
            {
                return rows;
            }
        }
        public int Columns
        {
            get
            {
                return rows;
            }
        }

        public int[] GetLine(int lineNum)
        {
            if (lineNum > rows)
            {
                throw new IndexOutOfRangeException();
            }
            int[] line = new int[columns];
            for (int i = 0; i < columns; i++)
            {
                line[i] = matrixArr[lineNum, i];
            }
            return line;
        }
        public void SwapLines(int lineA, int lineB)
        {
            int temp;
            for (int i = 0; i < columns; i++)
            {
                temp = matrixArr[lineA, i];
                matrixArr[lineA, i] = matrixArr[lineB, i];
                matrixArr[lineB, i] = temp;
            }
        }

        public void Write()
        {
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    Console.Write(matrixArr[i, j] + "   ");
                }
                Console.WriteLine();
            }
        }
    }

}
