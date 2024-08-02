using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASM2
{
    public class SinhVien
    {
        public string Id { get; set; }
        public string Hoten { get; set; }
        public string Malop { get; set; }
        public string Tenlop { get; set; }
        public string Masv { get; set; }
        public SinhVien()
        {
            
        }

        public SinhVien(string id, string hoten, string malop, string tenlop, string masv)
        {
            Id = id;
            Hoten = hoten;
            Malop = malop;
            Tenlop = tenlop;
            Masv = masv;
        }
    }
}
