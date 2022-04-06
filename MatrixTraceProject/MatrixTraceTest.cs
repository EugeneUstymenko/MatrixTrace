using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace FxMind_MatrixTraceTest
{
    [TestClass]
    public class MatrixTraceTest
    {
        [DataTestMethod]
        [DynamicData(nameof(GetData), DynamicDataSourceType.Method)]
        public void FindMatrixTrace_FindMatrixTrace_MatrixTrace(int[,] matrix, int expected)
        {

            int actual = FxMind_MatrixTrace.MatrixTrace.FindMatrixTrace(matrix);

            Assert.AreEqual(expected, actual);
        }
        public static IEnumerable<object[]> GetData()
        {
            yield return new object[] { new[,] { { 23, 44, 0, 5 }, { 99, 5, 3, 24 }, { 79, 23, 1, 0 } }, 29 };
            yield return new object[] { new[,] { { 0, 11, 5 }, { 42, 98, 1 }, { 43, 3, 5 } }, 103 };
            yield return new object[] { new[,] { { 14, 1, 15 }, { 99, 6, 36 }, { 87, 21, 0 } }, 20 };
        }
        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void FindMatrixTrace_MatrixTrace_NullReferenceException_ExpectedException()
        {
            int[,] matrix = null;
            FxMind_MatrixTrace.MatrixTrace.FindMatrixTrace(matrix);
        }
        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void VisualMatrixTrace_MatrixTrace_NullReferenceException_ExpectedException()
        {
            int[,] matrix = null;
            FxMind_MatrixTrace.MatrixTrace.VisualMatrixTrace(matrix);
        }
        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void PrintSnakeFromMatrix_SnakeArrayFromMatrix_NullReferenceException_ExpectedException()
        {
            Random rnd = new Random();
            int endingRowIndex = rnd.Next(0, 101);
            int endingColumnIndex = rnd.Next(0, 15);
            int[,] matrix = null;
            FxMind_MatrixTrace.SnakeArrayFromMatrix.PrintSnakeFromMatrixt( endingRowIndex, endingColumnIndex, matrix);
        }
    }
}
