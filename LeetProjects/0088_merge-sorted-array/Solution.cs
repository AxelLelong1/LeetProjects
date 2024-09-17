using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Xml.Linq;
using LeetProjects.Helper;

namespace LeetProjects._0088_merge_sorted_array
{
    /// <summary>
    /// Level: Easy
    /// </summary>
    public class Solution88 : Tools
    {
        /// <summary>
        /// Concat m element of nums1 and n elements of nums2 into nums1
        /// </summary>
        /// <param name="nums1"></param>
        /// <param name="m"></param>
        /// <param name="nums2"></param>
        /// <param name="n"></param>
        public void Merge(int[] nums1, int m, int[] nums2, int n)
        {
            int i = 0;
            while (n != 0)
            {
                nums1[m + i] = nums2[i];
                i++;
                n--;
            }
            Array.Sort(nums1);
        }

        public void print(int[] nums1, int m, int[] nums2, int n)
        {
            Console.Write("Trying to concat " + m + " elements of ");
            print_array(nums1);
            Console.Write(" and " + n + " elements of ");
            print_array(nums2);
            Merge(nums1, m, nums2, n);

            Console.WriteLine();
            Console.Write(" resulting in ");
            print_array(nums1);
            Console.WriteLine();
        }
    }
}
