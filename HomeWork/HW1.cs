using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork
{
    public class HW1
    {
        //Линейные алгоритмы
        #region
        //tasks (1)
        public double[] ClacCreditPyyments(double credit, double years, double p)
        {
            double precent = (p / 12 / 100);
            double m = Math.Round((credit * precent * Math.Pow((1 + precent), years)) / (12 * (Math.Pow((1 + precent), years) - 1)), 2);
            double sum = Math.Round((m * 12 * years), 2);

            return new double[] { sum, m, precent };
        }

        //tasks (2)
        public double CalcHypotenuse(double cathetX, double cathetY)
        {
            double hypotenuse = Math.Round(Math.Sqrt(Math.Pow(cathetX, 2) + Math.Pow(cathetY, 2)));

            return hypotenuse;
        }

        //tasks (3)
        public double CalcUravneniePrymoiK(double x1, double y1, double x2, double y2)
        {
            double k = Math.Round((y1 - y2) / (x1 - x2), 1);

            return k;
        }

        public double CalcUravneniePrymoiB(double x1, double y1, double x2, double y2)
        {
            double k = CalcUravneniePrymoiK(x1, y1, x2, y2);
            double b = Math.Round((y2 - k * x2), 1);

            return b;
        }

        //tasks (4)
        public double CalcDiskr(double a, double b, double c)
        {
            double d = Math.Pow(b, 2) - 4 * a * c;

            return d;
        }
        public double[] CalcRoots(double a, double b, double c)
        {
            double diskr = CalcDiskr(a, b, c);

            if (diskr > 0)
            {
                double x1 = (-b + Math.Sqrt(diskr)) / (2 * a);
                double x2 = (-b - Math.Sqrt(diskr)) / (2 * a);

                return new double[] { x1, x2 };
            }
            else if (diskr == 0)
            {
                double x1 = (-b) / (2 * a);

                return new double[] { x1 };
            }

            return new double[] { };

        }
        #endregion

        //УСЛОВИЯ
        #region
        //tasks (1)
        public int CalcMax(int a, int b, int c)
        {
            int sum = a + b + c;
            int pr = a * b * c;
            int max = 0;

            if (pr >= sum)
            {
                max = pr + 3;
            }
            else if (pr < sum)
            {
                max = sum + 3;
            }

            return max;
        }

        //tasks (2)
        public string CalcDivisionWithoutRemainder(int a, int b)
        {
            if (a % b == 0)
            {
                return $"a, b делятся без остатка, частное: {a / b}";
            }
            else
            {
                return $"a, b делятся с остатком, остаток от деления: {a % b}, частное: {a / b}";
            }
        }

        //tasks (3)
        public string CalcQuarterСoordinates(int x, int y)
        {
            if (x == 0 && y == 0)
            {
                return "Точка нулевая, лежит на пересечении координат";
            }
            else if (x == 0)
            {
                return y > 0 ? "Точка лежит на оси ординат между 1 и 4 четвертью"
                    : "Точка лежит на оси ординат между 2 и 3 четвертью";
            }
            else if (y == 0)
            {
                return x > 0 ? "Точка лежит на оси абсцисс между 1 и 2 четвертью"
                    : "Точка лежит на оси абсцисс между 3 и 4 четвертью";
            }

            return x > 0 ? (y > 0 ? "Точка принадлежит 1 четверти" : "Точка принадлежит 2 четверти")
                : (y < 0 ? "Точка принадлежит 3 четверти" : "Точка принадлежит 4 четверти");
        }

        //tasks (4)
        public string CalcCirclePoint(double x, double y, double radius)
        {
            double straightLength = CalcHypotenuse(x, y);

            if (radius != 0)
            {
                return straightLength > radius ? "Точка не принадлежит кругу" : "Точка принадлежит кругу";
            }
            else
            {
                return "Задача не может быть выполнена";

            }
        }
        #endregion

        //ЦИКЛЫ
        #region
        //tasks (1)
        public int CalcFactorial(int n)
        {
            int factorial = 1;
            if (n != 0)
            {
                for (int i = 2; i <= n; i++)
                {
                    factorial *= i;
                }
                return factorial;
            }
            else
            {
                return factorial;
            }
        }

        //tasks (2)
        public int CalcSumNumber(int n)
        {
            int sum = 0;
            while (n != 0)
            {
                sum += n % 10;
                n = n / 10;
            }
            return sum;
        }

        public int CalcPrNumber(int n)
        {
            int pr = 1;
            while (n != 0)
            {
                pr *= n % 10;
                n = n / 10;
            }
            return pr;
        }

        //tasks (3)

        public int CalcSumNaturalNumbers(int n)
        {
            int result = 0;

            for (int i = 1; i <= n; i++)
            {
                result += i;
            }
            return result;
        }

        public bool CheckeQuality(int n)
        {
            if (CalcSumNaturalNumbers(n) == (n * (n + 1) / 2))
            {
                return true;
            }

            return false;
        }

        //tasks (4)

        public double[] CalcTableValuesFunctions(int minX, int maxX, int step)
        {
            double[] arr = new double[((maxX - minX) / step) + 1];
            double y = 0;
            for (int index = 0, i = minX; i <= maxX; i += step, index++)
            {
                y = Math.Round((-0.23 * (i * i) + i), 2);
                arr[index] = y;
            }
            Utils.PrintArrayDouble(arr);
            return arr;
        }

        #endregion
    }
}
