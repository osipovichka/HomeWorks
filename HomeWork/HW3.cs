using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork
{
    public class HW3
    {
        //tasks 1
        public int CalcAmountNambers(int[] arr, int number)
        {
            int count = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                int num = arr[i];

                while (num > 0)
                {
                    if (num % 10 == number)
                    {
                        count++;
                    }
                    num = num / 10;
                }
            }
            return count;
        }

        //tasks 2
        public string[,] CreateRectangle(int row, int column, string c, string a)
        {
            string[,] rectangle = new string[row, column];

            for (int i = 0; i < rectangle.GetLength(0); i++)
            {
                for (int j = 0; j < rectangle.GetLength(1); j++)
                {
                    rectangle[i, j] = c;

                    if (i == 0 || i == row - 1 || j == 0 || j == column - 1)
                    {
                        rectangle[i, j] = a;
                    }
                }
            }
            Utils.CreateRectangle(rectangle);
            return rectangle;
        }

        //tasks 3
        public int[] CalcQuantityDivisor(int min)
        {
            int count = 0;
            int[] arr = new int[min];

            for (int i = 1; i <= min; i++)
            {
                if (min % i == 0)
                {
                    arr[count] = i;
                    count++;
                }
            }

            return Utils.SubArray(arr, count);
        }

        //tasks 4

        public int[,] CreateMatrixSwapDiagonals(int[,] matrix)
        {
            int column = matrix.GetLength(1);
            int[,] matr = matrix;
            for (int i = 0; i < matr.GetLength(0); i++)
            {
                for (int j = 0; j < matr.GetLength(1); j++)
                {
                    if (i == j)
                    {
                        int temp = matr[i, j];
                        matr[i, j] = matr[i, column - 1 - j];
                        matr[i, column - 1 - j] = temp;
                    }
                }
            }
            Utils.CreateMatrix(matr);
            return matr;
        }

        //tasks 5 
        public int CreateMatrix2(int[,] matrix)
        {
            int el = 0;

            for (int i = 1; i < matrix.GetLength(0) - 1; i++)
            {
                for (int j = 1; j < matrix.GetLength(1) - 1; j++)
                {
                    if (matrix[i - 1, j] < matrix[i, j] &&
                        matrix[i, j + 1] < matrix[i, j] &&
                        matrix[i + 1, j] < matrix[i, j] &&
                        matrix[i, j - 1] < matrix[i, j])
                    {
                        el++;
                    }
                }
            }

            return el;
        }
    }
}
