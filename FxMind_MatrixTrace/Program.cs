using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FxMind_MatrixTrace
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfRows = MatrixTrace.CheckInputNumber("rows", 100);
            int numberOfColumns = MatrixTrace.CheckInputNumber("columns", 14);

            int [,] matrix = MatrixTrace.CreateRandomMatrix(numberOfRows, numberOfColumns);
            MatrixTrace.VisualMatrixTrace(matrix);
            Console.WriteLine($"\nMatrix trace: {MatrixTrace.FindMatrixTrace(matrix)}");

            SnakeArrayFromMatrix.PrintSnakeFromMatrixt(numberOfRows, numberOfColumns, matrix);

            Console.ReadLine();
        }
    }
}
