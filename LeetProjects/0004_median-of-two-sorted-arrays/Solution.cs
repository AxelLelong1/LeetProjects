using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetProjects._0004_median_of_two_sorted_arrays
{
    /// <summary>
    /// Class containing the 4th solution of LeetCode problems
    /// <para>level: Hard</para>
    /// </summary>
    public class Solution4
    {
        /// <summary>
        /// Given two sorted arrays nums1 and nums2 of size m and n respectively.
        /// </summary>
        /// <param name="nums1"> The first array</param>
        /// <param name="nums2"> The second array</param>
        /// <returns>the median of the two sorted arrays</returns>
        public double FindMedianSortedArrays(int[] nums1, int[] nums2)
        {
            int[] full = nums1.Concat(nums2).ToArray();
            Array.Sort(full);

            int size = full.Length;

            if (size % 2 == 1)
                return full[size / 2];
            else
                return (full[size / 2] + full[(size / 2) - 1]) / 2.0;
        }

        public void print(int[] a, int[] b)
        {
            Console.Write("Median array of ");
            print_array(a);
            Console.Write(" and ");
            print_array(b);
            Console.WriteLine(" is " + FindMedianSortedArrays(a, b));

        }
        private void print_array(int[] array)
        {
            Console.Write("[ ");
            foreach (var item in array)
            {
                Console.Write(item + " ");
            }
            Console.Write("]");
        }
    }
}
