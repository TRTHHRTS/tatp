using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_01_Chart
{
    class Heapsort
    {
        public void heapSort(int[] a)
        {
            int i;
            int temp;

            for (i = a.Length / 2 - 1; i >= 0; i--)
            {
                shiftDown(a, i, a.Length);
            }

            for (i = a.Length - 1; i >= 1; i--)
            {
                temp = a[0];
                a[0] = a[i];
                a[i] = temp;
                shiftDown(a, 0, i);
            }
        }

        private void shiftDown(int[] a, int i, int j)
        {
            bool done = false;
            int maxChild;
            int temp;

            while ((i * 2 + 1 < j) && (!done))
            {
                if (i * 2 + 1 == j - 1)
                    maxChild = i * 2 + 1;
                else if (a[i * 2 + 1] > a[i * 2 + 2])
                    maxChild = i * 2 + 1;
                else
                    maxChild = i * 2 + 2;

                if (a[i] < a[maxChild])
                {
                    temp = a[i];
                    a[i] = a[maxChild];
                    a[maxChild] = temp;
                    i = maxChild;
                }
                else
                {
                    done = true;
                }
            }
        }
    }
}
