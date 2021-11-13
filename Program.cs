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

            //// expect 1, 1, 1, 2, 4, 4, 6, 9, 10, 10
            //var arr1 = new SortedList() { 1, 1, 10 };
            //var arr2 = new SortedList() { 1, 2, 4, 4, 6, 9, 10 };

            // expect 1, 1, 1, 2, 4, 4, 6, 9, 10, 10
            var arr1 = new List<Double>() { 5, 5, 5 };
            var arr2 = new List<Double>() { 1, 2, 5, 10,11 };


            var combined = SortedList.GetCombinedSortedArray(arr1, arr2);
            foreach (Double entry in combined)
            {
                Console.Write(entry + ", ");
            }

            Console.WriteLine();
            Console.WriteLine();

            var combined2 = SortedList.GetCombinedSortedArray(arr1, arr2);
            foreach (Double entry in combined2)
            {
                Console.Write(entry + ", ");
            }

            Console.WriteLine();
            Console.WriteLine();

            var combined3 = SortedList.GetCombinedSortedArray(arr1, arr2);
            foreach (Double entry in combined3)
            {
                Console.Write(entry + ", ");
            }


        }

    }
}