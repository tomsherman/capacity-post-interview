using System;
using System.Collections;
using System.Collections.Generic;

namespace CapacityPostInterview
{
    internal class SortedList : IEnumerable<Double>
    {
        List<Double> backingList;

        // constructor
        private SortedList(List<Double> list)
        {
            backingList = new List<double>(list);
        }


        public static List<Double> GetCombinedSortedArray(List<Double> inputArr1, List<Double> inputArr2)
        {
            if (inputArr1.Count == 0 || inputArr2.Count == 0) throw new ArgumentException();

            var sortedArr = new List<Double>();
            var arr1 = new SortedList(inputArr1);
            var arr2 = new SortedList(inputArr2);

            foreach (Double entry in arr1)
            {
                sortedArr.AddRange(arr2.pluckNumbersLessThanOrEqualTo(entry));
                sortedArr.Add(entry);
            }

            // leftovers
            sortedArr.AddRange(inputArr2);

            return sortedArr;
        }

        public IEnumerator<double> GetEnumerator()
        {
            return ((IEnumerable<double>)backingList).GetEnumerator();
        }

        public List<Double> pluckNumbersLessThanOrEqualTo(Double n)
        {
            var list = new List<Double>();

            while (backingList.Count > 0 && backingList[0] <= n)
            {
                list.Add(backingList[0]);
                 backingList.RemoveAt(0);
            }

            return list;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return ((IEnumerable)backingList).GetEnumerator();
        }
    }
}
