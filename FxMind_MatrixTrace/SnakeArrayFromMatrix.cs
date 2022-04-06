using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FxMind_MatrixTrace
{
    public class SnakeArrayFromMatrix
    {
        public static void PrintSnakeFromMatrixt(int endingRowIndex, int endingColumnIndex, int[,] matrix)
        {
            if (matrix == null)
            {
                throw new ArgumentNullException("Input reference data is null");
            }
            Console.Write($"\n\nSnake withdrawal from the matrix: ");
            int startingRowIndex = 0, startingColumnIndex = 0;
            while (startingRowIndex < endingRowIndex && startingColumnIndex < endingColumnIndex)
            {
                for (int i = startingColumnIndex; i < endingColumnIndex; i++)
                {
                    Console.Write(matrix[startingRowIndex, i] + " ");
                }
                startingRowIndex++;
                for (int i = startingRowIndex; i < endingRowIndex; ++i)
                {
                    Console.Write(matrix[i, endingColumnIndex - 1] + " ");
                }
                endingColumnIndex--;
                if (startingRowIndex < endingRowIndex)
                {
                    for (int i = endingColumnIndex - 1; i >= startingColumnIndex; --i)
                    {
                        Console.Write(matrix[endingRowIndex - 1, i] + " ");
                    }
                    endingRowIndex--;
                }
                if (startingColumnIndex < endingColumnIndex)
                {
                    for (int i = endingRowIndex - 1; i >= startingRowIndex; --i)
                    {
                        Console.Write(matrix[i, startingColumnIndex] + " ");
                    }
                    startingColumnIndex++;
                }
            }
        }
    }
}
