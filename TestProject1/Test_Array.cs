using ASM2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject1
{
    [TestFixture]
    public class Test_Array
    {
        private ArrayService mang;
        [SetUp]
        public void SetUp()
        {
            mang = new ArrayService(); 
        }
        [Test]
        public void Test1()
        {
            int[] array = { 1, 2, 3, 4, 5 };
            int result = mang.GetElementAtIndex(array, 2);
            Assert.AreEqual(3, result);
        }

        [Test]
        public void Test2()
        {
            int[] array = { 1, 2, 3, 4, 5 };
            Assert.Throws<IndexOutOfRangeException>(() => mang.GetElementAtIndex(array, -1));
        }

        [Test]
        public void Test3()
        {
            int[] array = { 1, 2, 3, 4, 5 };
            Assert.Throws<IndexOutOfRangeException>(() => mang.GetElementAtIndex(array, 5));
        }

        [Test]
        public void Test4()
        {
            int[] array = { };
            Assert.Throws<IndexOutOfRangeException>(() => mang.GetElementAtIndex(array, 0));
        }

        [Test]
        public void Test5()
        {
            int[] array = null;
            Assert.Throws<ArgumentException>(() => mang.GetElementAtIndex(array, 0));
        }
    }
}
