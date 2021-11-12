using System;
using System.Collections.Generic;

namespace CapacityPostInterview
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            // Write a function that accepts two sorted arrays and returns a sorted array containing all elements from both inputs.

            //var arr1 = new List<Double>() { 1, 3, 5 };
            //var arr2 = new List<Double>() { 2, 4, 6 };

            // expect 1, 1, 1, 2, 4, 4, 6, 9, 10, 10
            var arr1 = new SortedList() { 1, 1, 10 };
            var arr2 = new SortedList() { 1, 2, 4, 4, 6, 9, 10 };

            var combined = getCombinedSortedArray(arr1, arr2);
            foreach (Double entry in combined)
            {
                Console.Write(entry + ", ");
            }


        }

        static List<Double> getCombinedSortedArray(SortedList arr1, SortedList arr2) {
            if (arr1.Count == 0 || arr2.Count == 0) throw new ArgumentException();

            var sortedArr = new List<Double>();
            
            foreach(Double entry in arr1)
            {
                sortedArr.AddRange(arr2.pluckNumbersLessThanOrEqualTo(entry));
                sortedArr.Add(entry);
            }

            // leftovers
            sortedArr.AddRange(arr2);

            return sortedArr;
        }
    }
}