using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetProjects._0005_longest_palindromic_substring
{
    /// <summary>
    /// Contains the 5th Leet Code Solution
    /// Level: Medium
    /// </summary>
    public class Solution5
    {
        /// <summary>
        /// Find the longest palindromic substring in a given string.
        /// </summary>
        /// <param name="s">The string to find the longest palindrome in...</param>
        /// <returns>the longest palindromic substring in s</returns>
        public string LongestPalindrome(string s)
        {
            if (s.Length == 0)
                return "";

            int a = 0, b = 0;
            int first = 0, last = s.Length - 1;

            while (first < last)
            {
                while (first < last)
                {
                    // maybe a palindromic sub !
                    if (s[first] == s[last])
                    {
                        bool palindromic = true;
                        for (int i = 0; i < last - first; i++)
                        {
                            if (s[first + i] != s[last - i])
                            { palindromic = false; break; }
                        }
                        
                        if (palindromic && b - a < last - first)
                        {
                            a = first;
                            b = last;
                        }
                    }

                    last--;
                }

                last = s.Length - 1;
                first++;
            }

            if (a == 0 & b == s.Length - 1)
                return s;

            return s.Substring(a, b - a + 1);
        }

        public void print(string s)
        {
            Console.WriteLine("Longest Palindrome of " + s + " is " + LongestPalindrome(s));
        }
    }
}
