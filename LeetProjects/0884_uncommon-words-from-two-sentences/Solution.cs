using LeetProjects.Helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetProjects._0884_uncommon_words_from_two_sentences
{
    public class Solution884 : Tools
    { 
        public string[] UncommonFromSentences(string s1, string s2)
        {
            return [""];
        }

        public void print(string s1, string s2)
        {
            Console.Write("Uncommon Words From Sentences " + s1 + " and " + s2 + " are ");
            print_array<string>(UncommonFromSentences(s1, s2));
        }
    }
}
