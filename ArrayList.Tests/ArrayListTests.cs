using NUnit.Framework;
using MyArrayList;
using System;

namespace MyArrayList.Tests
{
    [TestFixture]
    public class ArrayListTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [TestCase(4, ExpectedResult = new int[] { 1, 2, 3, 4 })]
        [TestCase(10, ExpectedResult = new int[] { 1, 2, 3, 10 })]
        [TestCase(8, ExpectedResult = new int[] { 1, 2, 3, 8 })]
        public int[] AddTest(int val)
        {
            ArrayList myList = new ArrayList(new int[] { 1, 2, 3 });

            myList.Add(val);

            return myList.ToArray();
        }

        [TestCase(0, 4, ExpectedResult = new int[] { 4, 1, 2, 3, 5, 6, 7 })]
        [TestCase(5, 10, ExpectedResult = new int[] { 1, 2, 3, 5, 6, 10, 7 })]
        [TestCase(4, 8, ExpectedResult = new int[] { 1, 2, 3, 5, 8, 6, 7 })]
        public int[] Add2Test(int idx, int val)
        {
            ArrayList myList = new ArrayList(new int[] { 1, 2, 3, 5, 6, 7 });

            myList.Add(idx, val);

            return myList.ToArray();
        }

        [TestCase(3, 4, ExpectedResult = new int[] { 1, 2, 3, 4, 6, 7 })]
        [TestCase(5, 10, ExpectedResult = new int[] { 1, 2, 3, 5, 6, 10 })]
        [TestCase(0, 8, ExpectedResult = new int[] { 8, 2, 3, 5, 6, 7 })]
        public int[] SetTest(int idx, int val)
        {
            ArrayList myList = new ArrayList(new int[] { 1, 2, 3, 5, 6, 7 });

            myList.Set(idx, val);

            return myList.ToArray();
        }

        [TestCase(1, ExpectedResult = 2)]
        [TestCase(6, ExpectedResult = 0)]
        [TestCase(-1, ExpectedResult = 0)]
        [TestCase(2, ExpectedResult = 3)]
        public int GetTest(int index)
        {
            ArrayList myList = new ArrayList(new int[] { 1, 2, 3, 4, 5, 6 });

            try
            {
                return myList.Get(index);
            }
            catch (IndexOutOfRangeException)
            {
                return 0;
            }
        }

        [TestCase(ExpectedResult = 6)]
        public int SizeTest()
        {
            ArrayList myList = new ArrayList(new int[] { 1, 2, 3, 4, 5, 6 });

            return myList.Size();
        }

        [TestCase(8, ExpectedResult = false)]
        [TestCase(4, ExpectedResult = true)]
        public bool ContainsTest(int val)
        {
            ArrayList myList = new ArrayList(new int[] { 1, 2, 3, 4, 5, 6 });

            return myList.Contains(val);
        }

        [TestCase(0, ExpectedResult = new int[] { 2, 3, 4, 5, 6 })]
        [TestCase(-1, ExpectedResult = new int[] { 1, 2, 3, 4, 5, 6 })]
        [TestCase(2, ExpectedResult = new int[] { 1, 2, 4, 5, 6 })]
        public int[] RemoveIndexTest(int idx)
        {
            ArrayList myList = new ArrayList(new int[] { 1, 2, 3, 4, 5, 6 });
            myList.RemoveIndex(idx);

            return myList.ToArray();
        }

        [TestCase(3, ExpectedResult = new int[] { 1, 2, 2, 5, 6 })]
        [TestCase(-1, ExpectedResult = new int[] { 1, 2, 3, 2, 5, 6 })]
        [TestCase(2, ExpectedResult = new int[] { 1, 3, 2, 5, 6 })]
        public int[] RemoveValTest(int val)
        {
            ArrayList myList = new ArrayList(new int[] { 1, 2, 3, 2, 5, 6 });
            myList.RemoveVal(val);

            return myList.ToArray();
        }

        [TestCase(2, ExpectedResult = 2)]
        [TestCase(-1, ExpectedResult = 0)]
        [TestCase(5, ExpectedResult = 1)]
        public int CountOfTest(int val)
        {
            ArrayList myList = new ArrayList(new int[] { 1, 2, 3, 2, 5, 6 });

            return myList.CountOf(val);
        }

        [TestCase(3, ExpectedResult = new int[] { 2, 4, 2, 4, 2, 4 })]
        [TestCase(2, ExpectedResult = new int[] { 3, 4, 3, 4, 3, 4 })]
        [TestCase(10, ExpectedResult = new int[] { 3, 2, 4, 3, 2, 4, 3, 2, 4 })]
        public int[] RemoveALLTest(int val)
        {
            ArrayList myList = new ArrayList(new int[] { 3, 2, 4, 3, 2, 4, 3, 2, 4 });
            myList.RemoveALL(val);

            return myList.ToArray();
        }

        [TestCase(3, ExpectedResult = new int[] { 0, 3, 6 })]
        [TestCase(2, ExpectedResult = new int[] { 1, 4, 7 })]
        [TestCase(4, ExpectedResult = new int[] { 2, 5, 8 })]
        public int[] SearchTest(int val)
        {
            ArrayList myList = new ArrayList(new int[] { 3, 2, 4, 3, 2, 4, 3, 2, 4 });

            return myList.Search(val);
        }

        [TestCase(3, ExpectedResult = 0)]
        [TestCase(10, ExpectedResult = -1)]
        [TestCase(4, ExpectedResult = 2)]
        public int IndexOfTest(int val)
        {
            ArrayList myList = new ArrayList(new int[] { 3, 2, 4, 3, 2, 4, 3, 2, 4 });

            return myList.IndexOf(val);
        }

        [TestCase(1, new int[] { 4, 4, 4, 5, 6, 7, 8, 9, 10 }, ExpectedResult = new int[] { 1, 4, 4, 4, 5, 6, 7, 8, 9, 10, 2, 3 })]
        [TestCase(0, new int[] { 4, 4, 4 }, ExpectedResult = new int[] { 4, 4, 4, 1, 2, 3 })]
        [TestCase(2, new int[] { 0, 1 }, ExpectedResult = new int[] { 1, 2, 0, 1, 3 })]
        public int[] AddAllTest(int idx, int[] val)
        {
            ArrayList myList = new ArrayList(new int[] { 1, 2, 3 });
            myList.AddAll(idx, val);

            return myList.ToArray();
        }

        [TestCase(new int[] { 4, 4, 4, 5, 6, 7, 8, 9, 10 }, ExpectedResult = new int[] { 1, 2, 3, 4, 4, 4, 5, 6, 7, 8, 9, 10 })]
        [TestCase(new int[] { 4, 4, 4 }, ExpectedResult = new int[] { 1, 2, 3, 4, 4, 4 })]
        [TestCase(new int[] { 0, 1 }, ExpectedResult = new int[] { 1, 2, 3, 0, 1 })]
        public int[] AddAll2Test(int[] val)
        {
            ArrayList myList = new ArrayList(new int[] { 1, 2, 3 });
            myList.AddAll(val);

            return myList.ToArray();
        }
    }
}