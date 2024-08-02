using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASM2
{
    public class ArrayService
    {
        public int GetElementAtIndex(int[] array, int index)
        {
            if (array == null)
            {
                throw new ArgumentException("Không để rỗng");
            }
            if (index < 0 || index >= array.Length)
            {
                throw new IndexOutOfRangeException("Nằm ngoài phạm vi");
            }
            return array[index];
        }
    }
}
