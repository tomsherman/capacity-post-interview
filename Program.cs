using System;
using System.Collections.Generic;

namespace CapacityPostInterview
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            // write a function that accepts 2 arrays that are sorted and produce and output array is the merge of the two
            // Write a function that accepts two sorted arrays and returns a sorted array containing all elements from both inputs.

            //var arr1 = new List<Double>() { 1, 3, 5 };
            //var arr2 = new List<Double>() { 2, 4, 6 };

            // expect 1, 1, 1, 2, 4, 4, 6, 9, 10, 10
            var arr1 = new List<Double>() { 1, 1, 10 };
            var arr2 = new List<Double>() { 1, 2, 4, 4, 6, 9, 10 };


            var combined = getCombinedSortedArray(arr1, arr2);
            foreach (Double entry in combined)
            {
                Console.Write(entry + ", ");
            }


        }

        static List<Double> getCombinedSortedArray(List<Double> startArray, List<Double> otherArray) {
            if (startArray.Count == 0 || otherArray.Count == 0) throw new ArgumentException();

            var sortedArr = new List<Double>();

            // walk through the first array, keeping track of the index in the other array,
            // knowing that both arrays are pre-sorted and I can keep the foreach/for loop
            // "in step" 
            var otherIdx = 0;
            foreach(Double entry in startArray)
            {               
                for (var i=otherIdx; i<otherArray.Count; i++)
                {
                    var otherEntry = otherArray[i];
                    if (otherArray[i] <= entry)
                    {
                        sortedArr.Add(otherEntry);
                        otherIdx = i;
                    }
                    else
                    {
                        sortedArr.Add(entry);
                        break;
                    }
                }
            }

            // add in any remaining values from the other array that we didn't get to 
            // because of the highest number in the first array being less than a number
            // in the second array
            for (var i = otherIdx; i < otherArray.Count; i++)
            {
                var otherEntry = otherArray[i];
                sortedArr.Add(otherEntry);
            }

            return sortedArr;
        }
    }
}


/*
 *             //List<Double> startArray;
            //List<Double> otherArray;


            //// start with the array with the smallest first number
            //if (arr1[0] < arr2[1]) {
            //    startArray = arr1;
            //    otherArray = arr2;
            //} 
            //else
            //{
            //    startArray = arr2;
            //    otherArray = arr1;
            //}


*/