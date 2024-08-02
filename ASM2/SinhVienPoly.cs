using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASM2
{
    public class SinhVienPoly
    {
        public List<SinhVien> sinhViens = new List<SinhVien>();
        public void ThemSV(SinhVien sv)
        {
            if (sv.Tenlop.Any(ch => !char.IsLetterOrDigit(ch) && !char.IsWhiteSpace(ch)))
            {
                throw new ArgumentException("Tên lớp không chứa ký tự đặc biệt.");
            }
            sinhViens.Add(sv);
        }
        public List<SinhVien> TimTheoTen(string ten)
        {
            return sinhViens.Where(sv => sv.Hoten.Contains(ten)).ToList();
        }
        public List<SinhVien> TimTheoMaLop(string malop)
        {
            return sinhViens.Where(sv => sv.Malop.Equals(malop)).ToList();
        }

        public SinhVien TimTheoMasv(string masv)
        {
            return sinhViens.FirstOrDefault(sv => sv.Masv.Equals(masv));
        }
    }
}
