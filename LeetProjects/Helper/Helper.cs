using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetProjects.Helper
{
    public class Tools
    {
        protected void print_array<T>(T[] array)
        {
            Console.Write("[ ");
            foreach (var item in array)
            {
                Console.Write(item.ToString() + " ");
            }
            Console.Write("]");
        }
    }
}
