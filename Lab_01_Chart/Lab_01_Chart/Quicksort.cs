using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_01_Chart
{
    public class Quicksort<T> where T : IComparable
    {
        public void QSort(T[] a)
        {
            QuickSort1(a, 0, a.Length - 1);
        }

        //Быстрая сортировка с выбором опороного элемента по медиане из 3 элементов 
        //и с контролем переполнения стека.
        private void QuickSort1(T[] keys, int left, int right)
        {
            do
            {
                int a = left;
                int b = right;
                int m = a + ((b - a) >> 1);
                CompareSwap(keys, a, m);
                CompareSwap(keys, a, b);
                CompareSwap(keys, m, b);
                T p = keys[m];

                do
                {
                    while (keys[a].CompareTo(p) < 0) ++a;
                    while (p.CompareTo(keys[b]) < 0) --b;
                    if (a > b) break;
                    if (a < b)
                    {
                        T t = keys[a];
                        keys[a] = keys[b];
                        keys[b] = t;
                    }
                    a++;
                    b--;
                } while (a <= b);
                if (b - left <= right - a)
                {
                    if (left < b)
                    {
                        QuickSort1(keys, left, b);
                    }
                    left = a;
                }
                else
                {
                    if (a < right)
                    {
                        QuickSort1(keys, a, right);
                    }
                    right = b;
                }
            } while (left < right);
        }

        private static void CompareSwap(T[] keys, int a, int b)
        {
            if ((a != b) && (keys[a].CompareTo(keys[b])) > 0)
            {
                T t = keys[a]; keys[a] = keys[b]; keys[b] = t;
            }
        }
    }
}
