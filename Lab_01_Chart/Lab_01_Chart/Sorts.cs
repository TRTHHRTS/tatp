using System;

namespace Lab_01_Chart
{
    enum SORT_TYPE
    {
        SORT,
        QUICKSORT,
        HEAPSORT
    }

    class Sorts
    {
        static System.Diagnostics.Stopwatch myStopwatch = new System.Diagnostics.Stopwatch();

        public static long getSortTime(SORT_TYPE type, int[] array)
        {
            var attempts = new long[5];
            for (var j = 0; j < 5; j++)
            {
                //myStopwatch.Reset();
                switch (type)
                {
                    case SORT_TYPE.SORT:
                        myStopwatch.Restart();
                        Array.Sort(array);
                        myStopwatch.Stop();
                        break;
                    case SORT_TYPE.QUICKSORT:
                        Quicksort q = new Quicksort();
                        myStopwatch.Start();
                        q.quicksort(array, 0, array.Length - 1);
                        myStopwatch.Stop();
                        break;
                    case SORT_TYPE.HEAPSORT:
                        Heapsort h = new Heapsort();
                        myStopwatch.Start();
                        h.heapSort(array);
                        myStopwatch.Stop();
                        break;
                    default:
                        throw new Exception("Unknown error");
                }
                attempts[j] = myStopwatch.ElapsedMilliseconds;
            }
            Array.Sort(attempts);
            return attempts[2];
        }
    }
}
