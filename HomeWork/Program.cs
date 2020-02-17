using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork
{
    class Program
    {
        static void Main(string[] args)
        {
            HW1 HomeWork1 = new HW1();
            #region HW1

            #region Линейные алгоритмы
            //tasks (1)
            //Console.WriteLine("Сумма кредита: ");
            //double credit = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Кол-во лет: ");
            //double years = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Годовой процент: ");
            //double p = Convert.ToInt32(Console.ReadLine());

            //double[] ClacCreditPyyments = HomeWork1.ClacCreditPyyments(credit, years, p);
            //Utils.PrintArray(ClacCreditPyyments);

            //tasks (2)
            //Console.WriteLine("Введите значение катета 1: ");
            //double cathetX = Convert.ToDouble(Console.ReadLine());
            //Console.WriteLine("Введите значение катета 2: ");
            //double cathetY = Convert.ToDouble(Console.ReadLine());

            //double hypotenuse = HomeWork1.CalcHypotenuse(cathetX, cathetY);
            //Console.WriteLine(hypotenuse);
            //Console.ReadLine();

            //tasks (3)
            //Console.WriteLine("Введите значение x1: ");
            //double x1 = Convert.ToDouble(Console.ReadLine());
            //Console.WriteLine("Введите значение y1: ");
            //double y1 = Convert.ToDouble(Console.ReadLine());
            //Console.WriteLine("Введите значение x2: ");
            //double x2 = Convert.ToDouble(Console.ReadLine());
            //Console.WriteLine("Введите значение y2: ");
            //double y2 = Convert.ToDouble(Console.ReadLine());

            //double k = HomeWork1.CalcUravneniePrymoiK(x1, y1, x2, y2);
            //double b = HomeWork1.CalcUravneniePrymoiB(x1, y1, x2, y2);

            //if (b < 0)
            //{
            //    Console.WriteLine($"Уравнение прямой y = {k}x + ({b})");
            //}
            //else
            //{
            //    Console.WriteLine($"Уравнение прямой y = {k}x + {b}");
            //}


            //tasks (4)
            //Console.WriteLine("Введите значение a: ");
            //double a = Convert.ToDouble(Console.ReadLine());
            //Console.WriteLine("Введите значение b: ");
            //double b = Convert.ToDouble(Console.ReadLine());
            //Console.WriteLine("Введите значение c: ");
            //double c = Convert.ToDouble(Console.ReadLine());

            //double[] quantityСoren = HomeWork1.CalcRoots(a, b, c);
            //Utils.PrintArray(quantityСoren);

            #endregion

            #region УСЛОВИЯ
            //tasks (1)
            //Console.WriteLine("Введите значение a: ");
            //int a = Convert.ToInt16(Console.ReadLine());
            //Console.WriteLine("Введите значение b: ");
            //int b = Convert.ToInt16(Console.ReadLine());
            //Console.WriteLine("Введите значение c: ");
            //int c = Convert.ToInt16(Console.ReadLine());

            //int maxValue = HomeWork1.CalcMax(a, b, c);
            //Console.WriteLine(maxValue);

            //tasks (2)
            //Console.WriteLine("Введите значение a: ");
            //int a = Convert.ToInt16(Console.ReadLine());
            //Console.WriteLine("Введите значение b: ");
            //int b = Convert.ToInt16(Console.ReadLine());

            //string result = HomeWork1.CalcDivisionWithoutRemainder(a, b);
            //Console.WriteLine(result);

            //tasks (3)
            //Console.WriteLine("Введите координату точки Х: ");
            //int x = Convert.ToInt16(Console.ReadLine());
            //Console.WriteLine("Введите координату точки Y: ");
            //int y = Convert.ToInt16(Console.ReadLine());

            //string result = HomeWork1.ShowQuarterСoordinates(x, y);
            //Console.WriteLine(result);

            //tasks (4)
            //Console.WriteLine("Введите координату точки Х: ");
            //double x = Convert.ToDouble(Console.ReadLine());
            //Console.WriteLine("Введите координату точки Y: ");
            //double y = Convert.ToDouble(Console.ReadLine());
            //Console.WriteLine("Введите радиус окружности: ");
            //double radius = Convert.ToDouble(Console.ReadLine());

            //string result = HomeWork1.CalcCirclePoint(x, y, radius);
            //Console.WriteLine(result); 
            #endregion

            #region ЦИКЛЫ
            //tasks (1)

            //Console.WriteLine("Введите целое положительное число: ");
            //int n = Convert.ToInt16(Console.ReadLine());

            //if (n < 0) 
            //{
            //    Console.WriteLine("Задача не выполнима, попробуйте еще: ");
            //    n = Convert.ToInt16(Console.ReadLine());
            //}
            //int factorial = HomeWork1.CalcFactorial(n);
            //Console.WriteLine(factorial);

            //tasks (2)

            //int n = Utils.RandomValue(1000, 100000);
            //int n = 90849057;
            //int sum = HomeWork1.CalcSumNumber(n);
            //int pr = HomeWork1.CalcPrNumber(n);
            //Console.WriteLine(sum);
            //Console.WriteLine(pr);

            //tasks (3)

            //Console.WriteLine("Введите целое положительное число: ");
            //int n = Convert.ToInt16(Console.ReadLine());

            //bool checkeQuality = HomeWork1.CheckeQuality(n);
            //Console.WriteLine(checkeQuality);

            //tasks (4)

            //int minX = 2, maxX = 15, step = 2;
            //double[] TableValues = HomeWork1.CalcTableValuesFunctions(minX, maxX, step);
            #endregion

            #endregion

            HW2 HomeWork2 = new HW2();
            #region
            //домашка (2)

            //tasks (1)
            //int num = 1457458;
            //int invertedNum = HomeWork2.CreateInvertedNumber(num);
            //Console.WriteLine(invertedNum);

            //tasks (2)
            //Console.WriteLine("Введите значение a: ");
            //double a = Convert.ToDouble(Console.ReadLine());
            //Console.WriteLine("Введите знак операции: ");
            //string c = Convert.ToString(Console.ReadLine());

            //if (c == "0")
            //{
            //    Console.WriteLine("конец");
            //}
            //else
            //{
            //    Console.WriteLine("Введите значение b: ");
            //    double b = Convert.ToDouble(Console.ReadLine());

            //    while (c != "0")
            //    {
            //        if (b == 0)
            //        {
            //            Console.WriteLine("На 0 делить нельзя");
            //            Console.WriteLine("Введите значение b: ");
            //            b = Convert.ToDouble(Console.ReadLine());
            //        }

            //        double result = HomeWork2.Сalculator(a, b, c);
            //        Console.WriteLine(result);
            //        a = result;
            //        Console.WriteLine("Введите знак операции: ");
            //        c = Convert.ToString(Console.ReadLine());

            //        if (c == "0")
            //        {
            //            Console.WriteLine("конец");
            //        }
            //        else
            //        {
            //            Console.WriteLine("Введите значение b: ");
            //            b = Convert.ToDouble(Console.ReadLine());
            //        }
            //    }
            //}


            //tasks (4)

            //int a = 10;
            //Console.WriteLine("Угадай число: ");
            //int num = Convert.ToInt16(Console.ReadLine());

            //bool GuessNumber = HomeWork2.CalcGuessNumber(num, a);
            //int b = 9;
            //while (b > 0)
            //{
            //    b--;
            //    if (num < a && GuessNumber == false)
            //    {
            //        Console.WriteLine("Введенное число меньше загаданного");
            //        Console.WriteLine("Попробуй снова: ");
            //        num = Convert.ToInt16(Console.ReadLine());
            //        GuessNumber = HomeWork2.CalcGuessNumber(num, a);
            //    }
            //    else if (num > a && GuessNumber == false)
            //    {
            //        Console.WriteLine("Введенное число больше загаданного");
            //        Console.WriteLine("Попробуй снова: ");
            //        num = Convert.ToInt16(Console.ReadLine());
            //        GuessNumber = HomeWork2.CalcGuessNumber(num, a);
            //    }
            //    else if (num == a && GuessNumber == true)
            //    {
            //        Console.WriteLine("Урааа вы угадали число");
            //        break;
            //    }
            //}
            //if (b == 0)
            //{
            //    Console.WriteLine("Попыток больше нет");
            //}

            //tasks (5)

            //int fib = 4;
            //HomeWork2.CalcElementsRowFibonacci(fib);

            // Массивы
            //tasks 1

            //int[] arr = new int[] { 5, 48, 4, 9, 15, 10, 48, 2, 7, 5 };

            //int[] maxNamberAndIndexArray = HomeWork2.GetMaxNamberAndIndexArray(arr);
            //Utils.PrintArray2(maxNamberAndIndexArray);

            //tasks 2
            //int[] arr = new int[] { 1, 2, 3, 4, 5 };
            //HomeWork2.GetReverseArray(arr);

            //tasks 3
            //int[] arr = new int[] { 1, 2, 3, 4, 5 };
            //HomeWork2.GetArray(arr);

            //tasks 4
            //int[] arr = new int[] { 5, 9, 6, 4, 7 };
            //int[] array2 = HomeWork2.CalcArr(arr);
            //Utils.PrintArrayInt(array2);

            //tasks 5
            //int[] arr = new int[] { 5, 9, 6, 7, 4 };

            //int sum = HomeWork2.CalcSumNambers(arr);
            //Console.WriteLine(sum);

            #endregion

            HW3 HomeWork3 = new HW3();
            #region
            //Вложенные циклы
            //tasks 1
            //int[] arr = new int[] { 186, 292, 364, 856, 1258 };
            //int number = 6;

            //int amountNambers = HomeWork3.CalcAmountNambers(arr, number);
            //Console.WriteLine(amountNambers);

            //tasks 2

            //Console.WriteLine("Введите символ для рамки: ");
            //string a = Console.ReadLine();
            //Console.WriteLine("Введите символ для заливки: ");
            //string c = Console.ReadLine();
            //Console.WriteLine("Введите кол-во строк: ");
            //int row = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Введите кол-во столбцов: ");
            //int column = Convert.ToInt32(Console.ReadLine());

            //HomeWork3.CreateRectangle(row, column, c, a);

            //tasks 3 
            //int min = 50, max = 104, quantityDivisor = 9;

            //while (min <= max)
            //{
            //    int[] arr = HomeWork3.CalcQuantityDivisor(min);

            //    if (arr.Length >= quantityDivisor)
            //    {
            //        Console.Write($"{min} - {arr.Length} - ");
            //        Utils.PrintArray2(arr);
            //    }
            //    min++;
            //}

            //tasks 4
            //int[,] matrix = new int[7, 7] { { 1, 0, 0, 0, 0, 0, 2 },
            //                                { 0, 1, 0, 0, 0, 2, 0 },
            //                                { 0, 0, 1, 0, 2, 0, 0 },
            //                                { 0, 0, 0, 1, 0, 0, 0 },
            //                                { 0, 0, 2, 0, 1, 0, 0 },
            //                                { 0, 2, 0, 0, 0, 1, 0 },
            //                                { 2, 0, 0, 0, 0, 0, 1 }};

            //HomeWork3.CreateMatrixSwapDiagonals(matrix);

            //tasks 5
            //int quantityElem = HomeWork3.CreateMatrix2(matrix);
            //Console.WriteLine(quantityElem);


            //int[] d = HomeWork3.CalcQuantityDivisor(min, max, quantityDivisor);
            //Utils.PrintArray2(d);
            #endregion
        }
    }
}
