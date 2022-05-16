using NUnit.Framework;
using PDB_1;
using System.Linq;

namespace PDB_MatrixTests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void SortLineSumAsc()
        {
            MatrixType matrix = new MatrixType(5, 6);
            MatrixSort.SortMatrix(matrix, MatrixSort.SortParamLineSum, MatrixSort.CompTypeAsc);
            
            bool itWorks = true;

            for(int i = 1; i < matrix.Columns; i++)
            {
                if(matrix.GetLine(i).Sum() < matrix.GetLine(i-1).Sum())
                {
                    itWorks = false;
                    break;
                }
            }

            Assert.IsTrue(itWorks);
        }

        [Test]
        public void SortLineSumDesc()
        {
            MatrixType matrix = new MatrixType(5, 6);
            MatrixSort.SortMatrix(matrix, MatrixSort.SortParamLineSum, MatrixSort.CompTypeDesc);

            bool itWorks = true;

            for (int i = 1; i < matrix.Columns; i++)
            {
                if (matrix.GetLine(i).Sum() > matrix.GetLine(i - 1).Sum())
                {
                    itWorks = false;
                    break;
                }
            }

            Assert.IsTrue(itWorks);
        }

        [Test]
        public void SortMaxElemAsc()
        {
            MatrixType matrix = new MatrixType(5, 6);
            MatrixSort.SortMatrix(matrix, MatrixSort.SortParamMaxElem, MatrixSort.CompTypeAsc);

            bool itWorks = true;

            for (int i = 1; i < matrix.Columns; i++)
            {
                if (matrix.GetLine(i).Max() < matrix.GetLine(i - 1).Max())
                {
                    itWorks = false;
                    break;
                }
            }

            Assert.IsTrue(itWorks);
        }

        [Test]
        public void SortMaxElemDesc()
        {
            MatrixType matrix = new MatrixType(5, 6);
            MatrixSort.SortMatrix(matrix, MatrixSort.SortParamMaxElem, MatrixSort.CompTypeDesc);

            bool itWorks = true;

            for (int i = 1; i < matrix.Columns; i++)
            {
                if (matrix.GetLine(i).Max() > matrix.GetLine(i - 1).Max())
                {
                    itWorks = false;
                    break;
                }
            }

            Assert.IsTrue(itWorks);
        }

        [Test]
        public void SortMinElemAsc()
        {
            MatrixType matrix = new MatrixType(5, 6);
            MatrixSort.SortMatrix(matrix, MatrixSort.SortParamMinElem, MatrixSort.CompTypeAsc);

            bool itWorks = true;

            for (int i = 1; i < matrix.Columns; i++)
            {
                if (matrix.GetLine(i).Min() < matrix.GetLine(i - 1).Min())
                {
                    itWorks = false;
                    break;
                }
            }

            Assert.IsTrue(itWorks);
        }

        [Test]
        public void SortMinElemDesc()
        {
            MatrixType matrix = new MatrixType(5, 6);
            MatrixSort.SortMatrix(matrix, MatrixSort.SortParamMinElem, MatrixSort.CompTypeDesc);

            bool itWorks = true;

            for (int i = 1; i < matrix.Columns; i++)
            {
                if (matrix.GetLine(i).Min() > matrix.GetLine(i - 1).Min())
                {
                    itWorks = false;
                    break;
                }
            }

            Assert.IsTrue(itWorks);
        }
    }
}