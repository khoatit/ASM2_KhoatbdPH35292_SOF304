using ASM2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject1
{
    [TestFixture]
    public class Test_TBC
    {
        private TBC tbc;
        [SetUp]
        public void SetUp()
        {
            tbc = new TBC();
        }
        [Test]
        public void TBC1()
        {
            List<int> numbers = new List<int> { 1, 2, 3, 4, 5 };
            double result = tbc.Tinh_TBC(numbers);
            Assert.AreEqual(3.0, result);
        }
        [Test]
        public void TBC2()
        {
            List<int> numbers = new List<int> { -1, -2, -3, -4, -5 };
            double result = tbc.Tinh_TBC(numbers);
            Assert.AreEqual(-3.0, result);
        }

        [Test]
        public void TBC3()
        {
            List<int> numbers = new List<int>();
            Assert.Throws<ArgumentException>(() => tbc.Tinh_TBC(numbers));
        }

        [Test]
        public void TBC4()
        {
            List<int> numbers = new List<int> { 5 };
            double result = tbc.Tinh_TBC(numbers);
            Assert.AreEqual(5.0, result);
        }

        [Test]
        public void TBC5()
        {
            List<int> numbers = new List<int> { 0, 0, 0, 0, 0 };
            double result = tbc.Tinh_TBC(numbers);
            Assert.AreEqual(0.0, result);
        }
    }

}
