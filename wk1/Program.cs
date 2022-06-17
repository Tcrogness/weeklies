using System;

namespace challenges
{
    class Program
    {
        static void Main(string[] args)
        {
            //set up for 1
            int[] nums1 = new int[]{ 1, 3 };
            int[] nums2 = new int[] { 2 };
            int[] nums3 = new int[] { 1, 2 };
            int[] nums4 = new int[] { 3, 4 };
            string medi1 = problem1.medianFinder(nums1, nums2).ToString("N5");
            string medi2 = problem1.medianFinder(nums3, nums4).ToString("N5");
            Console.WriteLine("The output of the examples of problem one:\n"+medi1+"\n"+medi2);
            //set up for 2
            List<int> list1 = new List<int>() { 1, 4 ,5 };
            List<int> list2 = new List<int>() { 1, 3, 4 };
            List<int> list3 = new List<int>() { 2, 6 };
            List<int>[] input = new List<int>[] { list1, list2, list3 };
            Console.WriteLine("\n\n\n\nThe output for the example of problem two:\n");
            string result = "[";
            foreach(int i in problem2.mergeSort(input))
            {
                result = result + i + ",";
            }
            result = result.Substring(0, result.Length-1);
            Console.WriteLine(result+"]");
        }
    }
    public class problem1
    {
        public static double medianFinder(int[] arr1, int[] arr2)
        {
            List<int> arrayList = new List<int>();
            double median = 0;
            for (int i = 0; i < arr1.Count(); i++)
            {
                arrayList.Add(arr1[i]);
            }
            for (int j = 0; j < arr2.Count(); j++)
            {
                arrayList.Add(arr2[j]);
            }
            arrayList.Sort();
            do
            {
                arrayList = arrayList.GetRange(1, arrayList.Count - 2);
            }
            while (arrayList.Count > 2);
            median = arrayList.Average();
            return median;
        }
    }
    public class problem2
    { 
        public static List<int> mergeSort(List<int>[] listArray)
        {
            List<int> sortedList = new List<int>();
            foreach (List<int> l in listArray)
            {
                foreach (int i in l)
                {
                    sortedList.Add(i);
                }
            }
            sortedList.Sort();
            return sortedList;
        }
    }
}
/*
Weekly Coding Challenge:
Pls mention the link to your solution in the comments section not later than Friday morning.

1) Median of Two Sorted Arrays
Given two sorted arrays nums1 and nums2 of size m and n respectively, return the median of the two sorted arrays.
The overall run time complexity should be O(log (m+n)).

Example1:
Input:nums1 = [1,3], nums2 = [2]
Output:2.00000
Explanation: merged array = [1,2,3] and median is 2.

Example2:
Input:nums1 = [1,2], nums2 = [3,4]
Output:2.50000
Explanation: merged array = [1,2,3,4] and median is (2 + 3) / 2 = 2.5.

Constraints:
nums1.length == m
nums2.length == n
0 <= m <= 1000
0 <= n <= 1000
1 <= m + n <= 2000
-106 <= nums1[i], nums2[i] <= 106

2) Mergek Sorted Lists
You are given an array of k linked-lists lists, each linked-list is sorted in ascending order.
Merge all the linked-lists into one sorted linked-list and return it.

Example1:
Input: lists = [[1,4,5],[1,3,4],[2,6]]
Output:[1,1,2,3,4,4,5,6]
Explanation: The linked-lists are:
[
1->4->5,
1->3->4,
2->6
]
merging them into one sorted list:
1->1->2->3->4->4->5->6

Example2:
Input: lists= []
Output: []

Example3:
Input: lists = [[]]
Output: []

Constraints:
k == lists.length
0 <= k <= 104
0 <= lists[i].length <= 500
-104 <= lists[i][j] <= 104
lists[i] is sorted in ascending order.
The sum of lists[i].length will not exceed 104.
*/