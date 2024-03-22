using System;
using System.Collections.Generic;
using System.IO;

namespace ExceptionHandlingExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] arr = new char[9] { '6', '5', 'c', '1', '2', '3', '4', 'a', 'b' };

            List<int> numbers = new List<int>();

            string str;

            foreach (char c in arr)
            {
                try
                {
                    str = c.ToString();
                    numbers.Add(int.Parse(str));
                }

                catch (Exception ex)
                {
                    Console.WriteLine($"Unable to Parse '{c}'");
                }
            }

            foreach (var num in numbers)
            {
                Console.WriteLine(num);
            }
        }
    }
}
