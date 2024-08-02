using ASM2;

namespace TestProject1
{
    [TestFixture]
    public class Test_Them_SinhVien
    {
        private SinhVienPoly svPoly;
        [SetUp]
        public void Setup()
        {
            svPoly = new SinhVienPoly();
        } 
        [Test]
        public void Test_Add1()
        {
            var sv = new SinhVien("1", "Nguyen Van A", "L01", "CNTT", "SV01");
            Assert.DoesNotThrow(() => svPoly.ThemSV(sv));
        }
        [Test]
        public void Test_Add2()
        {
            var sv = new SinhVien("2", "Nguyen Van B", "L02", "CNTT@", "SV02");
            Assert.Throws<ArgumentException>(() => svPoly.ThemSV(sv));
        }
        [Test]
        public void Test_Add3()
        {
            var sv = new SinhVien("3", "Nguyen Van C", "L03", "", "SV03");
            Assert.Throws<ArgumentException>(() => svPoly.ThemSV(sv));
        }
        [Test]
        public void Test_Add4()
        {
            var sv = new SinhVien("4", "Nguyen Van D", "L04", "CNTT", "SV04");
            Assert.DoesNotThrow(() => svPoly.ThemSV(sv));
        }
        [Test]
        public void Test_Add5()
        {
            var sv = new SinhVien("5", "Nguyen Van E", "L05", "12345", "SV05");
            Assert.DoesNotThrow(() => svPoly.ThemSV(sv));
        }
        [Test]
        public void Test_Add6()
        {
            var sv = new SinhVien("6", "Nguyen Van F", "L06", "CNTT 01", "SV06");
            Assert.DoesNotThrow(() => svPoly.ThemSV(sv));
        }
        [Test]
        public void Test_Add7()
        {
            var sv = new SinhVien("8", "Nguyen Van H", "L08", "CNTT#01", "SV08");
            Assert.Throws<ArgumentException>(() => svPoly.ThemSV(sv));
        }
        [Test]
        public void Test_Add8()
        {
            var sv = new SinhVien("7", "Nguyen Van G", "L07", "CNTT_01", "SV07");
            Assert.DoesNotThrow(() => svPoly.ThemSV(sv));
        }
        [Test]
        public void Test_Add9()
        {
            var sv = new SinhVien("9", "Nguyen Van I", "L09", "CNTT!01", "SV09");
            Assert.Throws<ArgumentException>(() => svPoly.ThemSV(sv));
        }
        [Test]
        public void Test_Add10()
        {
            var sv = new SinhVien("10", "Nguyen Van J", "L10", "CNTT?01", "SV10");
            Assert.Throws<ArgumentException>(() => svPoly.ThemSV(sv));
        }

    }
    public class Test_Tim_maSV()
    {
        private SinhVienPoly svPoly;
        [SetUp]
        public void Setup()
        {
            svPoly = new SinhVienPoly();
        }
        [Test]
        public void Tim_theo_maSV1()
        {
            var sv = new SinhVien("11", "Nguyen Van K", "L11", "CNTT", "SV11");
           svPoly.ThemSV(sv);
            var result = svPoly.TimTheoMasv("SV11");
            Assert.AreEqual(sv, result);
        }
        [Test]
        public void Tim_theo_maSV2()
        {
            var result = svPoly.TimTheoMasv("SV12");
            Assert.IsNull(result);
        }
        [Test]
        public void Tim_theo_maSV3()
        {
            var result = svPoly.TimTheoMasv("");
            Assert.IsNull(result);
        }
        [Test]
        public void Tim_theo_maSV4()
        {
            var result = svPoly.TimTheoMasv(null);
            Assert.IsNull(result);
        }
        [Test]
        public void Tim_theo_maSV5()
        {
            var result = svPoly.TimTheoMasv("INVALID_MASV");
            Assert.IsNull(result);
        }
    }
}