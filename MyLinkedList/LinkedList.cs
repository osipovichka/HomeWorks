using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLinkedList
{
    public class LinkedList
    {
        Node head;
        int size;
        
        public LinkedList()
        {
            head = null;
            size = 0;
        }

        public LinkedList(int[] array)
        {
            Node prev = null;
            
            for (int i = 0; i < array.Length; i++)
            {
                Node node = new Node();
                node.value = array[i];

                if (i == 0)
                {
                    head = node;
                }
                else
                {
                    prev.next = node;
                }
                prev = node;
            }
            size = array.Length;
        }

        //список в массив
        public int[] ToArray()
        {
            int[] arr = new int[size];
            int count = 0;
            Node node = head;

            while (node != null)
            {
                arr[count] = node.value;
                node = node.next;
                count++;
            }
            return arr;
        }

        //добавление в начало списка
        public void AddFirst(int val)
        {
            Node node = new Node();
            node.value = val;

            if (head != null)
            {
                node.next = head;
            }

            head = node;
            size++;
        }

        //массив в начало
        public void AddFirst(int[] vals)
        {
            Node prev = null;
            Node newHead = null;

            for (int i = 0; i < vals.Length; i++)
            {
                Node node = new Node();
                node.value = vals[i];

                if (i == 0)
                {
                    newHead = node;
                }
                else
                {
                    prev.next = node;
                }
                prev = node;
            }

            prev.next = head;
            head = newHead;
            size += vals.Length;
        }

        //эл в конец списка
        public void AddLast(int val)
        {
            Node prev = head;
            Node node = new Node();
            node.value = val;

            if (head == null)
            {
                head = node;
                size++;
                return;
            }

            while (prev.next != null)
            {
                prev = prev.next;
            }
            prev.next = node;
            size++;
        }

        //Массив в конец списка
        public void AddLast(int[] vals)
        {
            Node prev = head;

            while (prev.next != null)
            {
                prev = prev.next;
            }

            for (int i = 0; i < vals.Length; i++)
            {
                Node node = new Node();
                node.value = vals[i];
                prev.next = node;
                prev = node;
            }

            size += vals.Length;
        }

        //вставить по индексу
        public void AddAt(int idx, int val)
        {
            Node node = new Node();
            node.value = val;

            Node prev = head;
            int count = 0;

            while (count < idx)
            {
                prev = prev.next;
                count++;
            }
            node.next = prev.next;
            prev.next = node;
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

            return head.value;
        }

        //вернёт значение последнего элемента списка
        public int GetLast()
        {
            Node prev = head;
            if (head == null)
            {
                return -1;
            }
            else
            {
                while (prev.next != null)
                {
                    prev = prev.next;
                }
            }

            return prev.value;
        }

        //вернёт значение элемента списка c указанным индексом
        public int Get(int idx)
        {
            if (idx < 0 || idx > size)
            {
                return -1;
            }
            Node prev = head;
            int count = 0;

            while (count < idx)
            {
                prev = prev.next;
                count++;
            }

            return prev.value;
        }

        //проверка, есть ли элемент в списке
        public bool Contains(int val)
        {
            Node node = head;

            if (GetSize() == 0) return false;

            while (node.next != null)
            {
                if (node.value == val)
                {
                    return true;
                }
                node = node.next;
            }

            return false;
        }

        //поменять значение элемента с указанным индексом
        public void Set(int idx, int val)
        {
            if (idx > size) return;

            Node prev = head;
            int count = 0;

            while (count != idx)
            {
                prev = prev.next;
                count++;
            }
            prev.value = val;
        }

        //удалить первый элемент
        public void RemoveFirst()
        {
            head = head.next;
            size--;
        }

        //удаление последнего элемента
        public void RemoveLast()
        {
            if (head == null) return;

            Node current = head;
            Node prev = null;

            while (current.next != null)
            {
                prev = current;
                current = current.next;
            }
            prev.next = null;
            size--;
        }

        //удаление по индексу
        public void RemoveAt(int idx)
        {
            if (head == null) return;

            Node current = head, prev = null;
            int count = 0;

            while (count != idx)
            {
                prev = current;
                current = current.next;
                count++;
            }

            if (prev != null)
            {
                prev.next = current.next;
            }
            else
            {
                head = head.next;
            }
            size--;
        }

        //вернёт индекс первого найденного элемента
        public int IndexOf(int val)
        {
            Node node = head;
            int idx = 0;

            while (node != null)
            {
                if (node.value == val)
                {
                    return idx;
                }
                node = node.next;
                idx++;
            }

            return -1;
        }

        public void Reverse()
        {
            if (head == null) return;

            Node tmp = head;
            while (tmp.next != null)
            {
                Node tmp1 = tmp.next;
                tmp.next = tmp.next.next;
                tmp1.next = head;
                head = tmp1;
            }
        }

        //удалить все элементы, равные val
        public void RemoveAll(int val)
        {
            if (head == null) return;

            Node current = head, prev = null;

            while (current != null)
            {
                if (current.value.Equals(val))
                {
                    if (prev != null)
                    {
                        prev.next = current.next;
                    }
                    else
                    {
                        head = head.next;
                    }

                    size--;
                }
                prev = current;
                current = current.next;
            }
        }
    }
}
