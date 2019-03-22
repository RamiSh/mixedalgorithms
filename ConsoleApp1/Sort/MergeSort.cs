using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Sort
{
    public class MergeSort
    {
        public static void Sort(List<int> source)
        {
            var temp = new List<int>(source);

            Sort(0, source.Count - 1, source, temp);
        }
        private static void Sort(int start, int end, List<int> source, List<int> temp)
        {
            if (start == end)
            {
                return;
            }

            var mid = start + ((end - start) >> 1);

            Sort(start, mid, source, temp);
            Sort(mid + 1, end, source, temp);

            Merge(start, mid, end, source, temp);
        }

        private static void Merge(int start, int mid, int end, List<int> source, List<int> temp)
        {
            var indexOfSortedValue = start;
            var indexOfFirstHalf = start;
            var indexOfSecondHalf = mid + 1;

            while (indexOfFirstHalf <= mid && indexOfSecondHalf <= end)
            {
                if (source[indexOfFirstHalf] < source[indexOfSecondHalf])
                {
                    temp[indexOfSortedValue++] = source[indexOfFirstHalf++];
                }
                else
                {
                    temp[indexOfSortedValue++] = source[indexOfSecondHalf++];
                }
            }

            while (indexOfFirstHalf <= mid)
            {
                temp[indexOfSortedValue++] = source[indexOfFirstHalf++];
            }

            for (int i = start; i <= end; i++)
            {
                source[i] = temp[i];
            }
        }
    }
}
