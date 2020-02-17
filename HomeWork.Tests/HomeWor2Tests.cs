using HomeWork;
using NUnit.Framework;

namespace HomeWork.Tests
{
    [TestFixture]
    public class HomeWork2Tests
    {
        [SetUp]
        public void Setup()
        {
        }
        //циклы
        #region
        //tasks (1)
        [TestCase(123456789, ExpectedResult = 987654321)]
        [TestCase(1654781, ExpectedResult = 1874561)]
        [TestCase(1457458, ExpectedResult = 8547541)]
        public int CreateInvertedNumberTest(int num)
        {
            HW2 hw2 = new HW2();

            return hw2.CreateInvertedNumber(num);
        }

        //tasks (2)
        [TestCase(54, 102, ExpectedResult = 156)]
        [TestCase(-524, 12, ExpectedResult = -512)]
        [TestCase(4.15, 15.256, ExpectedResult = 19.406)]
        public double CalcSumTest(double a, double b)
        {
            HW2 hW2 = new HW2();

            return hW2.СalcSum(a, b);
        }

        [TestCase(54, 102, ExpectedResult = -48)]
        [TestCase(3.25, 10.15, ExpectedResult = -6.9)]
        [TestCase(4, 1, ExpectedResult = 3)]
        public double СalcSubtractTest(double a, double b)
        {
            HW2 hW2 = new HW2();

            return hW2.СalcSubtract(a, b);
        }

        [TestCase(54, 102, ExpectedResult = 5508)]
        [TestCase(3.2, -10.1, ExpectedResult = -32.32)]
        [TestCase(-4, -1, ExpectedResult = 4)]
        public double СalcMultiplyTest(double a, double b)
        {
            HW2 hW2 = new HW2();

            return hW2.СalcMultiply(a, b);
        }

        [TestCase(54, 10, ExpectedResult = 5.4)]
        [TestCase(3.2, -10, ExpectedResult = -0.32)]
        [TestCase(-4, -2, ExpectedResult = 2)]
        public double СalcDivideTest(double a, double b)
        {
            HW2 hW2 = new HW2();

            return hW2.СalcDivide(a, b);
        }

        [TestCase(54, 10, "/", ExpectedResult = 5.4)]
        [TestCase(3.2, -10, "+", ExpectedResult = -6.8)]
        [TestCase(-4, -2, "*", ExpectedResult = 8)]
        [TestCase(3.25, 10.15, "-", ExpectedResult = -6.9)]
        public double СalculatorTest(double a, double b, string c)
        {
            HW2 hW2 = new HW2();

            return hW2.Сalculator(a, b, c);
        }

        //tasks (4)
        [TestCase(2, 10, ExpectedResult = false)]
        [TestCase(10, 10, ExpectedResult = true)]
        [TestCase(13, 10, ExpectedResult = false)]
        public bool CalcGuessNumberTest(int num, int a)
        {
            HW2 hW2 = new HW2();

            return hW2.CalcGuessNumber(num, a);
        }

        //tasks (5)
        [TestCase(6, new int[] { 1, 2, 3, 5, 8, 13 })]
        [TestCase(8, new int[] { 1, 2, 3, 5, 8, 13, 21, 34 })]
        [TestCase(4, new int[] { 1, 2, 3, 5 })]
        public void CalcElementsRowFibonacciTest(int fib, int[] expected)
        {
            HW2 hW2 = new HW2();

            int[] actual = hW2.CalcElementsRowFibonacci(fib);

            Assert.AreEqual(expected, actual);
        }
        #endregion

        // Массивы
        #region
        //tasks 1
        [TestCase(new int[] { 12, 15, 48, 95, 152, 5, 45, 158, 159, 4 }, ExpectedResult = new int[] { 159, 8 })]
        [TestCase(new int[] { 145, 175, 458, 955, 159, 50, 405, 1058, 159, 40 }, ExpectedResult = new int[] { 1058, 7 })]
        [TestCase(new int[] { 1277, 105, 48, 95, 159, 528, 445, 158, 159, 144 }, ExpectedResult = new int[] { 1277, 0 })]
        public int[] GetMaxNamberAndIndexArrayTest(int[] arr)
        {
            HW2 hW2 = new HW2();

            return hW2.GetMaxNamberAndIndexArray(arr);
        }

        //taskas 2
        [TestCase(new int[] { 5, 9, 6, 4, 7 }, ExpectedResult = new int[] { 7, 4, 6, 9, 5 })]
        [TestCase(new int[] { 6, 78, 16, 14, 17 }, ExpectedResult = new int[] { 17, 14, 16, 78, 6 })]
        [TestCase(new int[] { 35, 39, 36, 34, 37 }, ExpectedResult = new int[] { 37, 34, 36, 39, 35 })]
        public int[] GetReverseArrayTest(int[] arr)
        {
            HW2 hW2 = new HW2();
            return hW2.GetReverseArray(arr);
        }
        //tasks 3
        [TestCase(new int[] { 5, 9, 6, 4, 7 }, ExpectedResult = new int[] { 4, 7, 6, 5, 9 })]
        [TestCase(new int[] { 6, 78, 16, 14, 17 }, ExpectedResult = new int[] { 14, 17, 16, 6, 78 })]
        [TestCase(new int[] { 35, 39, 36, 34 }, ExpectedResult = new int[] { 36, 34, 35, 39 })]
        public int[] GetArrayTest(int[] arr)
        {
            HW2 hW2 = new HW2();
            return hW2.GetArray(arr);
        }

        //tasks 4
        [TestCase(new int[] { 5, 9, 6, 4, 7 }, ExpectedResult = 6)]
        [TestCase(new int[] { 6, 78, 16, 14, 17 }, ExpectedResult = 26)]
        [TestCase(new int[] { 35, 39, 36, 34 }, ExpectedResult = 36)]
        public int CalcArithmeticMeanTest(int[] arithmeticMean)
        {
            HW2 hW2 = new HW2();
            return hW2.CalcArithmeticMean(arithmeticMean);
        }

        //[TestCase(new int[] { 5, 9, 6, 4, 7 }, ExpectedResult = new int[] { 5, 4, 7 })]
        //[TestCase(new int[] { 6, 78, 16, 14, 17 }, ExpectedResult = new int[] { 6, 16, 14, 17 })]
        //[TestCase(new int[] { 35, 39, 36, 34 }, ExpectedResult = new int[] { 35, 34 })]
        //public int[] CalcArrTest(int[] arr)
        //{
        //    HW2 hW2 = new HW2();
        //    return hW2.CalcArr(arr);
        //}

        //tasks 5
        [TestCase(new int[] { 5, 9, 6, 7, 4 }, ExpectedResult = 13)]
        [TestCase(new int[] { 6, 78, 16, 14, 17 }, ExpectedResult = 0)]
        [TestCase(new int[] { 35, 34, 36, 38, 78, 95 }, ExpectedResult = 152)]
        public int CalcSumNambers(int[] arr)
        {
            HW2 hW2 = new HW2();
            return hW2.CalcSumNambers(arr);
        }
        #endregion
    }
}
