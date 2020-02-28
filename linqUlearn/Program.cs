using System;
using System.Collections.Generic;
using System.Linq;

namespace linqUlearn
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            //List<int> even = nums.Where(x => x % 2 == 0);
            IEnumerable<int> even = nums.Where(x => x % 2 == 0);
            ShowRes(even);
            Console.WriteLine("Linq");
            Console.ReadKey();
        }

        public static void ShowRes(IEnumerable<int> mas)
        {
            foreach(var el in mas)
            {
                Console.WriteLine(el);
            }
        }
       
    }
}
