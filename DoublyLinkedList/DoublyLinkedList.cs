using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyDoublyLinkedList
{
    public class DoublyLinkedList
    {
        DoublyNode head;
        DoublyNode tail;
        int size;

        public DoublyLinkedList()
        {
            head = null;
            tail = null;
            size = 0;
        }

        public DoublyLinkedList(int[] array)
        {
            DoublyNode prev = null;

            for (int i = 0; i < array.Length; i++)
            {
                DoublyNode node = new DoublyNode();
                node.Value = array[i];

                if (i == 0)
                {
                    head = node;
                    tail = node;
                }
                else
                {
                    prev.Next = node;
                    tail = node;
                    tail.Previous = prev;
                }
                prev = node;
            }
            size = array.Length;
        }

        //список в массив
        public int[] ToArray()
        {
            DoublyNode current = head;
            int[] arr = new int[size];
            int count = 0;

            while (current != null)
            {
                arr[count] = current.Value;
                current = current.Next;
                count++;
            }
            return arr;
        }

        //добавление в начало списка
        public void AddFirst(int val)
        {
            DoublyNode node = new DoublyNode();
            node.Value = val;
            node.Next = head;
            head = node;

            if (size == 0)
                tail = head;
            else
                head.Previous = node;
        
            size++;
        }

        //массив в начало
        public void AddFirst(int[] vals)
        {
            for (int i = vals.Length-1; i >= 0; i--)
            {
                AddFirst(vals[i]);
            }
        }

        //эл в конец списка
        public void AddLast(int val)
        {
            DoublyNode node = new DoublyNode();
            node.Value = val;

            if (head == null)
            {
                head = node;
            }
            else
            {
                tail.Next = node;
                node.Previous = tail;
            }
            tail = node;
            size++;
        }

        //Массив в конец списка
        public void AddLast(int[] vals)
        {
            for (int i = 0; i < vals.Length; i++)
            {
                AddLast(vals[i]);
            }
        }

        //вставить по индексу
        public void AddAt(int idx, int val)
        {
            DoublyNode node = new DoublyNode();
            node.Value = val;

            DoublyNode prev = head;
            int count = 0;

            while (count < idx)
            {
                prev = prev.Next;
                count++;
            }

            if (size == idx)
            {
                tail.Next = node;
                node.Previous = tail;
                tail = node;
            }

            node.Next = prev.Next;
            prev.Next = node;
            node.Previous = prev;
            prev.Next.Previous = node;
            size++;
        }

        //вставить массив по индексу
        public void AddAt(int idx, int[] vals)
        {
            if (idx > size)
            {
                return;
            }

            for (int i = 0; i < vals.Length; i++)
            {
                AddAt(idx, vals[i]);
                idx++;
            }

        }

        //кол-во эл в списке
        public int GetSize()
        {
            return size;
        }

        //вернёт значение первого  элемента списка
        public int GetFirst()
        {
            if (head == null)
            {
                return -1;
            }

            return head.Value;
        }

        //вернёт значение последнего элемента списка
        public int GetLast()
        {
            if (head == null)
            {
                return -1;
            }

            return tail.Value;
        }

        //вернёт значение элемента списка c указанным индексом
        public int Get(int idx)
        {
            if (idx < 0 || idx > size)
            {
                return -1;
            }

            DoublyNode prev = head;
            int count = 0;

            while (count < idx)
            {
                prev = prev.Next;
                count++;
            }

            return prev.Value;
        }

        //проверка, есть ли элемент в списке
        public bool Contains(int val)
        {
            DoublyNode node = head;

            if (GetSize() == 0) return false;

            while (node.Next != null)
            {
                if (node.Value == val)
                {
                    return true;
                }
                node = node.Next;
            }

            return false;
        }

        //поменять значение элемента с указанным индексом
        public void Set(int idx, int val)
        {
            if (idx > size) return;

            DoublyNode prev = head;
            int count = 0;

            while (count < idx)
            {
                prev = prev.Next;
                count++;
            }
            prev.Value = val;
        }

        //удалить первый элемент
        public void RemoveFirst()
        {
            head = head.Next;
            head.Previous = null;

            if (head == null) { tail = null; }
            size--;
        }

        //удаление последнего элемента
        public void RemoveLast()
        {
            if (head == null) return;

            tail.Previous.Next = null;
            tail = tail.Previous;

            size--;
        }

        //удаление по индексу
        public void RemoveAt(int idx)
        {
            if (head == null) return;

            DoublyNode current = head, prev = null;
            int count = 0;

            while (count < idx)
            {
                prev = current;
                current = current.Next;
                count++;
            }

            if (prev == null)
            {
                head = head.Next;
                head.Previous = null;
            }
            else
            {
                if (current.Next == null)
                {
                    tail = prev.Previous;
                    prev.Next = null;
                }
                else
                {
                    prev.Next = current.Next;
                    current.Next.Previous = prev;
                }
            }
            size--;
        }

        //вернёт индекс первого найденного элемента
        public int IndexOf(int val)
        {
            DoublyNode node = head;
            int idx = 0;

            while (node != null)
            {
                if (node.Value == val)
                {
                    return idx;
                }
                node = node.Next;
                idx++;
            }

            return -1;
        }

        public void Reverse()
        {
            if (head == null) return;

            DoublyNode tmp = head;
            while (tmp.Next != null)
            {
                DoublyNode tmp1 = tmp.Next;
                tmp.Next = tmp.Next.Next;//ссылка на следующий эл смотрит на следующий

                if (tmp.Previous == null)
                {
                    tmp.Previous = tmp1;
                }
                
                tmp1.Next = head;
                tmp1.Previous = null;
                head = tmp1;

                if (tmp.Next != null)
                {
                    tmp.Next.Previous = tmp;
                }
            }
        }

        //удалить все элементы, равные val
        public void RemoveAll(int val)
        {
            if (head == null) return;

            DoublyNode current = head, prev = null;

            while (current != null)
            {
                if (current.Value.Equals(val))
                {
                    if (prev == null)
                    {
                        head = head.Next;
                        head.Previous = null;
                    }
                    else
                    {
                        if (current.Next == null)
                        {
                            tail = prev.Previous;
                            prev.Next = null;
                        }
                        else
                        {
                            prev.Next = current.Next;
                            current.Next.Previous = prev;
                        }
                    }

                    size--;
                }
                prev = current;
                current = current.Next;
            }
        }
    }
}
