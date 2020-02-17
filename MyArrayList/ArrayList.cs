using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyArrayList
{
    public class ArrayList
    {
        int[] array;
        int realLenght;

        public ArrayList()
        {
            array = new int[10];
            realLenght = 0;
        }

        public ArrayList(int[] array)
        {
            this.array = array;
            realLenght = array.Length;
        }

        public int[] ToArray()
        {
            int[] arr = new int[realLenght];
            for (int i = 0; i < realLenght; i++)
            {
                arr[i] = array[i];
            }

            return arr;
        }

        void Resize()
        {
            int[] arr = new int[array.Length + (array.Length * 3) / 2 + 1];

            if (realLenght == array.Length)
            {
                for (int i = 0; i < array.Length; i++)
                {
                    arr[i] = array[i];
                }
            }

            array = arr;
        }

        void Resize(int[] val)
        {
            int[] arr = new int[realLenght + (array.Length + val.Length)];

            for (int i = 0; i < array.Length; i++)
            {
                arr[i] = array[i];
            }

            array = arr;
        }

        //добавить элемент в конец массива
        public void Add(int val)
        {
            Resize();

            array[realLenght] = val;
            realLenght++;
        }

        //добавить элемент в массив по индексу со сдвигом в право
        public void Add(int idx, int val)
        {
            Resize();

            for (int i = realLenght; i >= idx; i--)
            {
                array[i + 1] = array[i];
            }
            array[idx] = val;
            realLenght++;
        }

        //добавить элемент по индексу
        public void Set(int idx, int val)
        {
            Resize();

            if (idx >= 0)
            {
                array[idx] = val;
            }
        }

        //вернуть элемент по индексу
        public int Get(int idx)
        {
            if (idx >= 0 && idx < realLenght)
            {
                return array[idx];
            }

            throw new IndexOutOfRangeException("Индекс находится вне границ массива");
        }

        //возвращиет длину массива
        public int Size()
        {
            return array.Length;
        }

        //возвращает тру или фолс 
        public bool Contains(int val)
        {
            if (IndexOf(val) == -1)
            { return false; }

            return true;
        }

        //удалить элемент по индексу со сдвигом
        public void RemoveIndex(int idx)
        {
            if (idx < realLenght && idx >= 0)
            {
                int[] arr = new int[array.Length - 1];

                for (int i = 0; i < array.Length; i++)
                {
                    if (i < idx)
                    {
                        arr[i] = array[i];
                    }
                    else if (i > idx)
                    {
                        arr[i - 1] = array[i];
                    }
                }
                array = arr;
                realLenght--;
            }
        }

        //удалить первый элемент с вход. значением
        public void RemoveVal(int val)
        {
            if (Contains(val))
            {
                bool a = false;
                int[] arr = new int[realLenght - 1];
                for (int i = 0; i < array.Length; i++)
                {
                    if (!a)
                    {
                        if (array[i] == val)
                        {
                            a = true;
                            realLenght--;
                            continue;
                        }

                        arr[i] = array[i];
                    }
                    else
                    {
                        arr[i - 1] = array[i];
                    }
                }
                array = arr;
            }
        }

        //сколько всего элементов
        public int CountOf(int val)
        {
            int count = 0;

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == val)
                {
                    count++;
                }
            }

            return count;
        }

        //удалить все элементы с вход. значением
        public void RemoveALL(int val)
        {
            int count = CountOf(val);

            int offset = 0;
            int[] arr = new int[realLenght - count];
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == val)
                {
                    offset++;
                    realLenght--;
                    continue;
                }
                arr[i - offset] = array[i];
            }

            array = arr;
        }

        //вернет массив со всеми индексами
        public int[] Search(int val)
        {
            int count = CountOf(val);
            if (count == 0)
            {
                return array;
            }

            int offset = 0;
            int[] arrIdx = new int[count];
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] != val)
                {
                    offset++;
                    continue;
                }

                arrIdx[i - offset] = i;
            }

            return arrIdx;
        }

        //вернет первый индекс вход. элемента 
        public int IndexOf(int val)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == val)
                {
                    return i;
                }
            }
            return -1;
            //throw new IndexOutOfRangeException("Элемент отсутствует в массиве");
        }

        //добавить элементы по индексу
        public void AddAll(int idx, int[] val)
        {
            Resize(val);

            for (int i = realLenght; i >= idx; i--)
            {
                array[i + val.Length] = array[i];
            }
            int count = 0;
            for (int i = 0; i < val.Length; i++)
            {
                array[idx + count] = val[i];
                count++;
                realLenght++;
            }
        }

        //добавить все элементы в массив
        public void AddAll(int[] val)
        {
            Resize(val);

            for (int i = 0; i < val.Length; i++)
            {
                array[realLenght] = val[i];
                realLenght++;
            }
        }
    }
}
