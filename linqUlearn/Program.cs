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
            var people =  new[]{ "Pavel Egorov", "Yuriy Okulovskiy",
    "Alexandr Denisov", "Ivan Sorokin",
    "Dasha Zubova", "Irina Gess"};

            var names = people.Select(fn => fn.Split(' ')[0]);

            var girls = names.Where(name => name[name.Length - 1] == 'a');

            ShowRes(names);
            ShowRes(girls);
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
        public static void ShowRes(IEnumerable<string> mas)
        {
            foreach (var el in mas)
            {
                Console.WriteLine(el);
            }
        }


    }
}
