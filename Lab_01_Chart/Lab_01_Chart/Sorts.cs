using System;

namespace Lab_01_Chart
{
    enum SORT_TYPE
    {
        SORT,
        QUICKSORT,
        HEAPSORT,
        SHELLSORT
    }

    class Sorts
    {
        static System.Diagnostics.Stopwatch myStopwatch = new System.Diagnostics.Stopwatch();

        public static long getSortTime(SORT_TYPE type, int[] array)
        {
            var attempts = new long[Form1.ATTEMPTS];
            for (var j = 0; j < Form1.ATTEMPTS; j++)
            {
                switch (type)
                {
                    case SORT_TYPE.SORT:
                        myStopwatch.Restart();
                        Array.Sort(array);
                        myStopwatch.Stop();
                        break;
                    case SORT_TYPE.QUICKSORT:
                        Quicksort<int> q = new Quicksort<int>();
                        myStopwatch.Restart();
                        q.QSort(array);
                        myStopwatch.Stop();
                        break;
                    case SORT_TYPE.HEAPSORT:
                        Heapsort h = new Heapsort();
                        myStopwatch.Restart();
                        h.heapSort(array);
                        myStopwatch.Stop();
                        break;
                    case SORT_TYPE.SHELLSORT:
                        ShellSort<int> s = new ShellSort<int>();
                        myStopwatch.Restart();
                        s.Sort(array);
                        myStopwatch.Stop();
                        break;
                    default:
                        throw new Exception("Unknown error");
                }
                attempts[j] = myStopwatch.ElapsedMilliseconds;
            }
            Array.Sort(attempts);
            return attempts[Form1.ATTEMT_NUMBER_TO_USE-1];
        }
    }
}
