using System;
using Sorting;

namespace SortingConsoleInterface
{
    internal class Program
    {
        private static string[] sortings = { "Quicksort", "MergeSort" };
        
        public static void Main(string[] args)
        {
            var sorting = Choice("Choose sorting:", sortings);
            var array = InputIntArray();
            Service.sortWith(array, sorting);
            Console.Out.WriteLine(array);
        }

        public static string Choice(string message, string[] options)
        {
            Console.Out.WriteLine(message);
            var i = 0;
            foreach (var option in options)
            {
                Console.Out.WriteLine("{0}. {1}", ++i, option);
            }

            int chosen = GetIntFromInput(num => num >= 0 && num < options.Length);

            return options[chosen];
        }

        public static int GetIntFromInput(Func<int, bool> validation = null)
        {
            int chosen;
            string answer;
            
            while (true)
            {
                answer = Console.In.ReadLine();
                if (!int.TryParse(answer, out chosen) || (validation != null && !validation(chosen)))
                {
                    Console.Out.WriteLine("Incorrect input!");
                }
                else
                {
                    break;
                }
            }

            return chosen;
        }

        public static int[] InputIntArray()
        {
            Console.Out.WriteLine("How many integers should be in array?");
            int len = GetIntFromInput(num => num > 0);
            int[] result = new int[len];
            for (int i = 0; i < len; i++)
            {
                Console.Out.WriteLine("Enter {0} array element", i+1);
                result[i] = GetIntFromInput();
            }

            return result;
        }
    }
}