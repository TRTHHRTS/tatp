using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_01_Chart
{
    public class Quicksort
    {
        public void quicksort(int[] input, int low, int high)
        {
            int pivot_loc = 0;

            if (low < high)
            {
                pivot_loc = partition(input, low, high);
                quicksort(input, low, pivot_loc - 1);
                quicksort(input, pivot_loc + 1, high);
            }
        }

        private int partition(int[] input, int low, int high)
        {
            int pivot = input[high];
            int i = low - 1;

            for (int j = low; j < high - 1; j++)
            {
                if (input[j] <= pivot)
                {
                    i++;
                    swap(input, i, j);
                }
            }
            swap(input, i + 1, high);
            return i + 1;
        }

        private void swap(int[] ar, int a, int b)
        {
            int temp;
            temp = ar[a];
            ar[a] = ar[b];
            ar[b] = temp;
        }
    }
}
