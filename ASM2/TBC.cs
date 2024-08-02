using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASM2
{
    public class TBC
    {
        public double Tinh_TBC(List<int> numbers)
        {
            if (numbers == null || !numbers.Any())
            {
                throw new ArgumentException("Danh sách không thể rỗng hoặc rỗng.");
            }
            return numbers.Average();
        }
    }
}
