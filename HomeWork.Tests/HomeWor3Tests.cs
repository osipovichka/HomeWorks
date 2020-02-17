using HomeWork;
using NUnit.Framework;

namespace HomeWork.Tests
{
    [TestFixture]
    class HomeWork3Tests
    {

        //tasks 1
        [TestCase(new int[] { 5689, 4875, 21587, 365, 258, 1254, 5687 }, 5, ExpectedResult = 7)]
        [TestCase(new int[] { 268, 875, 217, 365, 251, 12, 5 }, 9, ExpectedResult = 0)]
        [TestCase(new int[] { 56, 48, 21, 36, 25, 12, 56 }, 4, ExpectedResult = 1)]
        public int CalcAmountNambersTest(int[] arr, int number)
        {
            HW3 hW3 = new HW3();

            return hW3.CalcAmountNambers(arr, number);
        }

        //tasks 2
        public string[,] GetMartixRectangle(string rectangle)
        {
            switch (rectangle)
            {
                case "matrix1":
                    return new string[,] { { "&&", "&&", "&&" }, { "&&", "5", "&&" }, { "&&", "&&", "&&" } };
                case "matrix2":
                    return new string[,] { { "^^", "^^", "^^", "^^", "^^" }, { "^^", "*", "*", "*", "^^" }, { "^^", "*", "*", "*", "^^" }, { "^^", "*", "*", "*", "^^" }, { "^^", "^^", "^^", "^^", "^^" } };
                default:
                    return new string[,] { { }, { } };
            }
        }

        [TestCase(3, 3, "5", "&&", "matrix1")]
        public void CreateRectangle(int row, int column, string c, string a, string expectedArrRectangle)
        {
            HW3 hW3 = new HW3();

            string[,] expectedArr = GetMartixRectangle(expectedArrRectangle);

            string[,] actualArr = hW3.CreateRectangle(row, column, c, a);

            CollectionAssert.AreEqual(expectedArr, actualArr);
        }
        [TestCase(5, 5, "*", "^^", "matrix2")]
        public void CreateRectangle2(int row, int column, string c, string a, string expectedArrRectangle)
        {
            HW3 hW3 = new HW3();

            string[,] expectedArr = GetMartixRectangle(expectedArrRectangle);

            string[,] actualArr = hW3.CreateRectangle(row, column, c, a);

            CollectionAssert.AreEqual(expectedArr, actualArr);
        }

        //tasks 3
        [TestCase(24, ExpectedResult = new int[] { 1, 2, 3, 4, 6, 8, 12, 24 })]
        [TestCase(72, ExpectedResult = new int[] { 1, 2, 3, 4, 6, 8, 9, 12, 18, 24, 36, 72 })]
        [TestCase(96, ExpectedResult = new int[] { 1, 2, 3, 4, 6, 8, 12, 16, 24, 32, 48, 96 })]
        public int[] CalcQuantityDivisorTest(int number)
        {
            HW3 hW3 = new HW3();

            return hW3.CalcQuantityDivisor(number);
        }

        //tasks 4
        [Test]
        public void CreateMatrixSwapDiagonalsTest()
        {
            HW3 hW3 = new HW3();

            int[,] matrix = new int[5, 5] { { 10, 12, 10, 12, 10 }, { 1, 29, 27, 26, 1 }, { 1, 25, 8, 36, 1 }, { 1, 5, 4, 3, 1 }, { 1, 1, 1, 1, 1 } };

            int[,] expected = new int[5, 5] { { 10, 12, 10, 12, 10 }, { 1, 26, 27, 29, 1 }, { 1, 25, 8, 36, 1 }, { 1, 3, 4, 5, 1 }, { 1, 1, 1, 1, 1 } };

            int[,] actual = hW3.CreateMatrixSwapDiagonals(matrix);

            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void CreateMatrixSwapDiagonalsTest2()
        {
            HW3 hW3 = new HW3();

            int[,] matrix = new int[7, 7] { { 1, 0, 0, 0, 0, 0, 2 },
                                            { 0, 1, 0, 0, 0, 2, 0 },
                                            { 0, 0, 1, 0, 2, 0, 0 },
                                            { 0, 0, 0, 1, 0, 0, 0 },
                                            { 0, 0, 2, 0, 1, 0, 0 },
                                            { 0, 2, 0, 0, 0, 1, 0 },
                                            { 2, 0, 0, 0, 0, 0, 1 }};

            int[,] expected = new int[7, 7] { { 2, 0, 0, 0, 0, 0, 1 },
                                              { 0, 2, 0, 0, 0, 1, 0 },
                                              { 0, 0, 2, 0, 1, 0, 0 },
                                              { 0, 0, 0, 1, 0, 0, 0 },
                                              { 0, 0, 1, 0, 2, 0, 0 },
                                              { 0, 1, 0, 0, 0, 2, 0 },
                                              { 1, 0, 0, 0, 0, 0, 2 }};

            int[,] actual = hW3.CreateMatrixSwapDiagonals(matrix);

            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void CreateMatrixSwapDiagonalsTest3()
        {
            HW3 hW3 = new HW3();

            int[,] matrix = new int[3, 3] { { 15, 18, 16 },
                                            { 15, 18, 16 },
                                            { 15, 18, 16 } };

            int[,] expected = new int[3, 3] { { 16, 18, 15 },
                                              { 15, 18, 16 },
                                              { 16, 18, 15 } };

            int[,] actual = hW3.CreateMatrixSwapDiagonals(matrix);

            Assert.AreEqual(expected, actual);
        }

        //tasks 5
        [Test]
        public void CreateMartixTest()
        {
            HW3 hW3 = new HW3();

            int[,] matrix = new int[5, 5] { { 1, 1, 1, 1, 1 }, { 1, 9, 7, 6, 1 }, { 1, 25, 8, 36, 1 }, { 1, 5, 4, 3, 1 }, { 1, 1, 1, 1, 1 } };

            int expected = 2;

            int actual = hW3.CreateMatrix2(matrix);

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void CreateMartixTest2()
        {
            HW3 hW3 = new HW3();

            int[,] matrix = new int[4, 4] { { 1, 3, 2, 5 }, { 4, 7, 6, 15 }, { 12, 18, 1, 0 }, { 4, 7, 6, 15 } };

            int expected = 1;

            int actual = hW3.CreateMatrix2(matrix);

            Assert.AreEqual(expected, actual);
        }
    }
}

