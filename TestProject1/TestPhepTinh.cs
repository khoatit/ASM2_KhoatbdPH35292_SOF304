using ASM2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject1
{
    [TestFixture]
    public class Test_Tong
    {
        private PhepTinh phepTinh;
        [SetUp]
        public void SetUp()
        {
            phepTinh = new PhepTinh();
        }
        [Test]
        public void Tong1()
        {
            int result = phepTinh.Tong(10, 20);
            Assert.AreEqual(30, result);
        }
        [Test]
        public void Tong2()
        {
            int result = phepTinh.Tong(-10, -20);
            Assert.AreEqual(-30, result);
        }
        [Test]
        public void Tong3()
        {
            int result = phepTinh.Tong(10, -5);
            Assert.AreEqual(5, result);
        }
        [Test]
        public void Tong4()
        {
            int result = phepTinh.Tong(10, 0);
            Assert.AreEqual(10, result);
        }
        [Test]
        public void Tong5()
        {
            int result = phepTinh.Tong(0, 0);
            Assert.AreEqual(0, result);
        }
        [Test]
        public void Tong6()
        {
            int result = phepTinh.Tong(int.MaxValue, 1);
            Assert.AreEqual(int.MinValue, result);
        }
        [Test]
        public void Tong7()
        {
            int result = phepTinh.Tong(int.MinValue, -1);
            Assert.AreEqual(int.MaxValue, result);
        }
        [Test]
        public void Tong8()
        {
            int result = phepTinh.Tong(int.MaxValue, int.MaxValue);
            Assert.AreEqual(-2, result);
        }
        [Test]
        public void Tong9()
        {
            int result = phepTinh.Tong(int.MinValue, int.MinValue);
            Assert.AreEqual(0, result);
        }
        [Test]
        public void Tong10()
        {
            int result = phepTinh.Tong(int.MaxValue - 1, 2);
            Assert.AreEqual(int.MinValue, result);
        }
    }
    public class Test_Hieu
    {
        private PhepTinh phepTinh;
        [SetUp]
        public void SetUp()
        {
            phepTinh = new PhepTinh();
        }
        [Test]
        public void Hieu1()
        {
            int result = phepTinh.Hieu(20, 10);
            Assert.AreEqual(10, result);
        }
        [Test]
        public void Hieu2()
        {
            int result = phepTinh.Hieu(-10, -20);
            Assert.AreEqual(10, result);
        }
        [Test]
        public void Hieu3()
        {
            int result = phepTinh.Hieu(10, -5);
            Assert.AreEqual(15, result);
        }
        [Test]
        public void Hieu4()
        {
            int result = phepTinh.Hieu(10, 0);
            Assert.AreEqual(10, result);
        }
        [Test]
        public void Hieu5()
        {
            int result = phepTinh.Hieu(0, 0);
            Assert.AreEqual(0, result);
        }
        [Test]
        public void Hieu6()
        {
            int result = phepTinh.Hieu(int.MaxValue, 1);
            Assert.AreEqual(int.MaxValue - 1, result);
        }
        [Test]
        public void Hieu7()
        {
            int result = phepTinh.Hieu(int.MinValue, -1);
            Assert.AreEqual(int.MaxValue, result);        
        }
        [Test]
        public void Hieu8()
        {
            int result = phepTinh.Hieu(int.MaxValue, int.MaxValue);
            Assert.AreEqual(0, result);
        }
        [Test]
        public void Hieu9()
        {
            int result = phepTinh.Hieu(int.MinValue, int.MinValue);
            Assert.AreEqual(0, result);
        }
        [Test]
        public void Hieu10()
        {
            int result = phepTinh.Hieu(int.MaxValue - 1, 2);
            Assert.AreEqual(int.MaxValue - 3, result);
        }

    }
    public class Test_Tich
    {
        private PhepTinh phepTinh;
        [SetUp]
        public void SetUp()
        {
            phepTinh = new PhepTinh();
        }
        [Test]
        public void Tich1()
        {
            int result = phepTinh.Tich(10, 20);
            Assert.AreEqual(200, result);
        }
        [Test]
        public void Tich2()
        {
            int result = phepTinh.Tich(-10, -20);
            Assert.AreEqual(200, result);
        }

        [Test]
        public void Tich3()
        {
            int result = phepTinh.Tich(10, -5);
            Assert.AreEqual(-50, result);
        }

        [Test]
        public void Tich4()
        {
            int result = phepTinh.Tich(10, 0);
            Assert.AreEqual(0, result);
        }

        [Test]
        public void Tich5()
        {
            int result = phepTinh.Tich(0, 0);
            Assert.AreEqual(0, result);
        }

        [Test]
        public void Tich6()
        {
            int result = phepTinh.Tich(int.MaxValue, 1);
            Assert.AreEqual(int.MaxValue, result);
        }

        [Test]
        public void Tich7()
        {
            int result = phepTinh.Tich(int.MinValue, -1);
            Assert.AreEqual(int.MaxValue, result);
        }

        [Test]
        public void Tich8()
        {
            int result = phepTinh.Tich(int.MaxValue, int.MaxValue);
            Assert.AreEqual(1, result);
        }

        [Test]
        public void Tich9()
        {
            int result = phepTinh.Tich(int.MinValue, int.MinValue);
            Assert.AreEqual(0, result);
        }

        [Test]
        public void Tich10()
        {
            int result = phepTinh.Tich(int.MaxValue - 1, 2);
            Assert.AreEqual(-4, result);
        }
    }
}
