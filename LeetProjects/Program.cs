// See https://aka.ms/new-console-template for more information

using LeetProjects._0004_median_of_two_sorted_arrays;
using LeetProjects._0005_longest_palindromic_substring;
using LeetProjects._0088_merge_sorted_array;
using LeetProjects.Helper;

/*---- 0004 ----*/

Console.WriteLine("4. Median Of Two Sorted Array");

Solution4 solution4 = new Solution4();

solution4.print([1, 3], [2]);
solution4.print([1, 3], [2, 4]);
Console.WriteLine();

/*---- 0005 ----*/

Console.WriteLine("5. Longest Palindromic Substring");

Solution5 solution5 = new Solution5();

solution5.print("babad");
solution5.print("cbbd");
solution5.print("caba");
solution5.print("aaaa");
Console.WriteLine();

/*---- 0088 ----*/

Console.WriteLine("88. Merge Sorted Array");

Solution88 solution88 = new Solution88();

solution88.print([1, 2, 3, 0, 0, 0], 3, [2, 5, 6], 3);
solution88.print([1], 1, [], 0);