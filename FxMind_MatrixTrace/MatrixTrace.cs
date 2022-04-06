using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FxMind_MatrixTrace
{
    public class MatrixTrace
    {
        public static int CheckInputNumber(string nameNumber, int maxNumber)
        {
            int number = 0;
            bool f;
            do
            {
                try
                {
                    f = false;
                    Console.Write($"To randomly create a matrix, enter the number of {nameNumber} in the matrix: ");
                    number = Convert.ToInt32(Console.ReadLine());
                }
                catch (FormatException)
                {
                    f = true;
                    Console.WriteLine("Invalid input format. The number must be in the format of integer digits, for example - '1', '7', '14', etc.\n");
                    continue;
                }
                if (number <= 0)
                {
                    f = true;
                    Console.WriteLine("Invalid input format. The number cannot be reflective or equal to 0.\n");
                    continue;
                }
                if (number > maxNumber)
                {
                    f = true;
                    Console.WriteLine($"Too large matrix will come out. The number cannot be more than {maxNumber}.\n");
                    continue;
                }
            } while (f);
            return number;
        }
        public static int[,] CreateRandomMatrix(int numberOfRows, int numberOfColumns)
        {
            Random rnd = new Random();
            int[,] matrix = new int[numberOfRows, numberOfColumns];
            for (int i = 0; i < numberOfRows; i++)
            {
                for (int j = 0; j < numberOfColumns; j++)
                {
                    matrix[i, j] = rnd.Next(101);
                }
            }
            return matrix;
        }
        public static void VisualMatrixTrace(int [,] matrix)
        {
            if (matrix == null)
            {
                throw new ArgumentNullException("Input reference data is null");
            }
            int tmp = -1;
            Console.WriteLine("\nVisual random matrix trace:\n");
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                tmp++;
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (j == tmp)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Gray;
                    }
                    Console.Write($"{matrix[i, j]}\t");
                }
                Console.WriteLine("\n");
            }
            Console.ForegroundColor = ConsoleColor.Gray;
        }
        public static int FindMatrixTrace(int[,] matrix)
        {
            if (matrix == null)
            {
                throw new ArgumentNullException("Input reference data is null");
            }
            int sum = 0;
            if(matrix.GetLength(0) < matrix.GetLength(1))
            {
                for (int i = 0; i < matrix.GetLength(0); i++)
                {
                    sum += matrix[i, i];
                }
            }
            else
            {
                for (int i = 0; i < matrix.GetLength(1); i++)
                {
                    sum += matrix[i, i];
                }
            }
            return sum;
        }
    }
}
