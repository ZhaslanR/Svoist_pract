using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Svoistva_pract
{
    public class RangeOfArray
    {
        private int firstBorder;
        private int secondBorder;

        int[] array;

        public RangeOfArray(int firstBorder, int secondBorder)
        {
            this.firstBorder = firstBorder;
            this.secondBorder = secondBorder;

            if (firstBorder > secondBorder) array = new int[firstBorder - secondBorder];
            else array = new int[secondBorder - firstBorder];
        }

        public int this[int index]
        {
            set
            {
                if (firstBorder < secondBorder)
                {
                    if (index < firstBorder || index > secondBorder) throw new IndexOutOfRangeException("Выход из границ массива");
                    array[index - firstBorder] = value;
                }
                else
                {
                    if (index > firstBorder || index < secondBorder) throw new IndexOutOfRangeException("Выход из границ массива");
                    array[index - secondBorder] = value;
                }
            }

            get
            {
                if (firstBorder < secondBorder)
                {
                    if (index < firstBorder || index > secondBorder) throw new IndexOutOfRangeException("Выход из границ массива");
                    return array[index - firstBorder];
                }
                else
                {
                    if (index > firstBorder || index < secondBorder) throw new IndexOutOfRangeException("Выход из границ массива");
                    return array[index - secondBorder];
                }
            }
        }
    }
}
