using HomeWork;
using NUnit.Framework;

namespace HomeWork.Tests
{
    [TestFixture]
    public class HomeWork1Tests
    {
        [SetUp]
        public void Setup()
        {
        }
        //Линейные алгоритмы
        #region
        //tasks(1)
        [TestCase(100000, 2, 20, new double[] { 102506.88, 4271.12, 0.016666666666666666 })]
        [TestCase(256000, 5, 26, new double[] { 272877.6, 4547.96, 0.021666666666666664 })]
        [TestCase(598526, 16, 34, new double[] { 752705.28, 3920.34, 0.028333333333333335 })]
        public void ClacCreditPyymentsTest(double credit, double years, double percent, double[] expected)
        {
            HW1 hw1 = new HW1();

            double[] actual = hw1.ClacCreditPyyments(credit, years, percent);

            Assert.AreEqual(expected, actual);
        }

        //tasks (2)
        [TestCase(2, 3, 4)]
        [TestCase(3, 8, 9)]
        [TestCase(-6, -5, 8)]
        public void CalcHypotenuseTest(int cathetX, int cathetY, double expected)
        {
            HW1 hw1 = new HW1();
            double actual = hw1.CalcHypotenuse(cathetX, cathetY);

            Assert.AreEqual(expected, actual);
        }

        //tasks(3)
        [TestCase(-2, 5, 3, 6, 0.2)]
        [TestCase(4, 3, 2, 1, 1)]
        [TestCase(-8, -9, -6, -5, 2)]
        public void CalcUravneniePrymoiKTest(double x1, double y1, double x2, double y2, double expected)
        {
            HW1 hw1 = new HW1();

            double actual = hw1.CalcUravneniePrymoiK(x1, y1, x2, y2);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(-2, 5, 3, 6, 5.4)]
        [TestCase(4, 3, 2, 1, -1)]
        [TestCase(-8, -9, -6, -5, 7)]
        public void CalcUravneniePrymoiBTest(double x1, double y1, double x2, double y2, double expected)
        {
            HW1 hw1 = new HW1();

            double actual = hw1.CalcUravneniePrymoiB(x1, y1, x2, y2);

            Assert.AreEqual(expected, actual);
        }

        //tasks (4)
        [TestCase(2, 5, 7, -31)]
        [TestCase(1, 2, 1, 0)]
        [TestCase(5, -6, 1, 16)]
        public void CalcDiskrTest(double a, double b, double c, double expected)
        {
            HW1 hw1 = new HW1();

            double actual = hw1.CalcDiskr(a, b, c);

            Assert.AreEqual(expected, actual);
        }

        //tasks (4)
        [TestCase(2, 5, 7, new double[] { })]
        [TestCase(1, 2, 1, new double[] { -1 })]
        [TestCase(5, -6, 1, new double[] { 1, 0.2 })]
        public void CalcCorenTest(double x, double y, double c, double[] expected)
        {
            HW1 hw1 = new HW1();

            double[] actual = hw1.CalcRoots(x, y, c);

            Assert.AreEqual(expected, actual);
        }
        #endregion

        //УСЛОВИЯ
        #region
        //tasks (1)
        [TestCase(2, 2, 2, 11)]
        [TestCase(2, 2, 0, 7)]
        [TestCase(-2, -5, -19, -23)]
        public void CalcMaxTest(int a, int b, int c, int expected)
        {
            HW1 hW1 = new HW1();

            int actual = hW1.CalcMax(a, b, c);

            Assert.AreEqual(expected, actual);
        }

        //tasks (2)
        [TestCase(152, 18, "a, b делятся с остатком, остаток от деления: 8, частное: 8")]
        [TestCase(4118, 58, "a, b делятся без остатка, частное: 71")]
        [TestCase(857, 15, "a, b делятся с остатком, остаток от деления: 2, частное: 57")]
        public void CalcDivisionWithoutRemaindeTest(int a, int b, string expected)
        {
            HW1 hW1 = new HW1();

            string actual = hW1.CalcDivisionWithoutRemainder(a, b);

            Assert.AreEqual(expected, actual);
        }

        //tasks (3)
        [TestCase(5, 9, "Точка принадлежит 1 четверти")]
        [TestCase(5, -9, "Точка принадлежит 2 четверти")]
        [TestCase(-5, -9, "Точка принадлежит 3 четверти")]
        [TestCase(-5, 0, "Точка лежит на оси абсцисс между 3 и 4 четвертью")]
        [TestCase(5, 0, "Точка лежит на оси абсцисс между 1 и 2 четвертью")]
        [TestCase(0, 5, "Точка лежит на оси ординат между 1 и 4 четвертью")]
        [TestCase(0, -5, "Точка лежит на оси ординат между 2 и 3 четвертью")]
        [TestCase(0, 0, "Точка нулевая, лежит на пересечении координат")]
        public void ShowQuarterСoordinatesTest(int x, int y, string expected)
        {
            HW1 hW1 = new HW1();

            string actual = hW1.CalcQuarterСoordinates(x, y);

            Assert.AreEqual(expected, actual);
        }

        //tasks (4)
        [TestCase(2, 8, 2, "Точка не принадлежит кругу")]
        [TestCase(5, -2, 14, "Точка принадлежит кругу")]
        [TestCase(5, -2, 0, "Задача не может быть выполнена")]
        public void CalcCirclePointTest(double x, double y, double radius, string expected)
        {
            HW1 hW1 = new HW1();

            string actual = hW1.CalcCirclePoint(x, y, radius);

            Assert.AreEqual(expected, actual);
        }
        #endregion

        //ЦИКЛЫ

        //tasks (1)
        [TestCase(0, 1)]
        [TestCase(15, 2004310016)]
        [TestCase(10, 3628800)]
        public void CalcFactorialTest(int n, int expected)
        {
            HW1 hW1 = new HW1();

            int actual = hW1.CalcFactorial(n);

            Assert.AreEqual(expected, actual);
        }

        //tasks (2)
        [TestCase(186745, ExpectedResult = 31)]
        [TestCase(569782841, ExpectedResult = 50)]
        [TestCase(90849057, ExpectedResult = 42)]
        public int CalcSumNumberTest(int n)
        {
            HW1 hW1 = new HW1();

            return hW1.CalcSumNumber(n);
        }

        [TestCase(186745, ExpectedResult = 6720)]
        [TestCase(569782841, ExpectedResult = 967680)]
        [TestCase(90849057, ExpectedResult = 0)]
        public int CalcPrNumberTest(int n)
        {
            HW1 hW1 = new HW1();

            return hW1.CalcPrNumber(n);
        }

        //tasks (3)

        [TestCase(14578, ExpectedResult = true)]
        [TestCase(24785, ExpectedResult = true)]
        [TestCase(21358, ExpectedResult = true)]
        public bool CheckeQualityTest(int n)
        {
            HW1 hW1 = new HW1();

            return hW1.CheckeQuality(n);
        }

        //tasks (4)
        [TestCase(2, 15, 2, ExpectedResult = new double[] { 1.08, 0.32, -2.28, -6.72, -13, -21.12, -31.08 })]
        [TestCase(10, 21, 4, ExpectedResult = new double[] { -13, -31.08, -56.52 })]
        [TestCase(2, 13, 8, ExpectedResult = new double[] { 1.08, -13 })]
        public double[] CalcTableValuesFunctionsTest(int minX, int maxX, int step)
        {
            HW1 hW1 = new HW1();

            return hW1.CalcTableValuesFunctions(minX, maxX, step);
        }

    }
}