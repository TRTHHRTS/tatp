using System;

namespace Lab_01_Chart
{
    class ShellSort<T> where T : IComparable
    {
        public void Sort(T[] a)
        {
            int h;
            for (h = 1; h <= a.Length / 9; h = 3 * h + 1) ;
            for (; h > 0; h /= 3)
            {
                for (int i = h; i < a.Length; ++i)
                {
                    T t = a[i];
                    int j = i;
                    while (j >= h && a[j - h].CompareTo(t) > 0)
                    {
                        a[j] = a[j - h];
                        j -= h;
                    }
                    a[j] = t;
                }
            }
        }
    }
}
