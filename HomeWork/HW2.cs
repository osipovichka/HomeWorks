using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork
{
    public class HW2
    {
        //ЦИКЛЫ
        #region

        //tasks (1)
        public int CreateInvertedNumber(int num)
        {
            int invertedNum = 0;

            while (num > 0)
            {
                invertedNum = invertedNum * 10 + num % 10;
                num /= 10;
            }
            return invertedNum;
        }

        //tasks (2)

        public double СalcSum(double a, double b)
        {
            return a + b;
        }

        public double СalcSubtract(double a, double b)
        {
            return a - b;
        }

        public double СalcMultiply(double a, double b)
        {
            return a * b;
        }

        public double СalcDivide(double a, double b)
        {
            return a / b;
        }

        public double Сalculator(double a, double b, string c)
        {
            switch (c)
            {
                case "+":
                    return СalcSum(a, b);
                case "-":
                    return СalcSubtract(a, b);
                case "*":
                    return СalcMultiply(a, b);
                case "/":
                    return СalcDivide(a, b);
            }

            return 0;
        }

        //tasks (4)
        public bool CalcGuessNumber(int num, int a)
        {
            if (num != a)
            {
                if (num < a)
                {
                    return false;
                }
                else if (num > a)
                {
                    return false;
                }
                else if (num == a)
                {
                    return true;
                }
            }

            return true;
        }

        //tasks (5)
        public int[] CalcElementsRowFibonacci(int fib)
        {
            int a = 1;
            int b = 1;
            int[] arr = new int[fib];
            for (int i = 0; i < fib; i++)
            {
                int tmp = a;
                a = b;
                b += tmp;
                arr[i] = a;
            }
            Utils.PrintArrayInt(arr);
            return arr;
        }

        #endregion

        // Массивы
        #region
        //tasks 1
        public int[] GetMaxNamberAndIndexArray(int[] arr)
        {
            int max = arr[0], index = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (max < arr[i])
                {
                    max = arr[i];
                    index = i;
                }
            }
            return new int[] { max, index };
        }

        //tasks 2
        public int[] GetReverseArray(int[] arr)
        {
            int a = arr.Length;
            int[] arrRev = new int[a];
            for (int i = arr.Length - 1; i >= 0; i--)
            {
                arrRev[a - i - 1] = arr[i];
            }
            Utils.PrintArrayInt(arrRev);
            return arrRev;
        }

        //tasks 3
        public int[] GetArray(int[] arr)
        {
            int a = arr.Length / 2, b = arr.Length % 2;

            for (int i = 0; i < a; i++)
            {
                int c = arr[i];
                arr[i] = arr[a + i + b];
                arr[a + i + b] = c;
            }
            Utils.PrintArrayInt(arr);
            return arr;
        }

        //tasks 4
        public int CalcArithmeticMean(int[] arr)
        {
            int arithmeticMean = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                arithmeticMean += arr[i];
            }
            return arithmeticMean / arr.Length;
        }

        //public int[] CalcArr(int[] arr)
        //{
        //    int arithmeticMean = CalcArithmeticMean(arr);
        //    int count = 0;
        //    int[] array = new int[arr.Length];

        //    for (int i = 0; i < arr.Length; i++)
        //    {
        //        if (arr[i] < arithmeticMean)
        //        {
        //            array[i] = arr[i];
        //            count++;
        //        }
        //    }

        //    int[] array2 = Utils.SubArray(array, count);
        //    return array2;
        //}

        //tasks 5 
        public int GetMaxIndexArray(int[] arr)
        {
            int max1 = arr[0], indexMax = 0;

            for (int i = 1; i < arr.Length; i++)
            {
                if (max1 < arr[i])
                {
                    max1 = arr[i];
                    indexMax = i;
                }
            }

            return indexMax;
        }

        public int GetMinIndexArray(int[] arr)
        {
            int min1 = arr[0], indexMin = 0;

            for (int i = 1; i < arr.Length; i++)
            {
                if (min1 > arr[i])
                {
                    min1 = arr[i];
                    indexMin = i;
                }
            }

            return indexMin;
        }

        public int CalcSumNambers(int[] arr)
        {
            int indexMin = GetMaxIndexArray(arr);
            int indexMax = GetMinIndexArray(arr);
            int sum = 0;

            if (indexMin < indexMax)
            {
                for (int i = indexMin + 1; i < indexMax; i++)
                {
                    sum += arr[i];
                }
            }
            else if (indexMin > indexMax)
            {
                for (int i = indexMax + 1; i < indexMin; i++)
                {
                    sum += arr[i];
                }
            }

            return sum;
        }
        #endregion
    }
}
