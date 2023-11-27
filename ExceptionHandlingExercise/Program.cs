using System;
using System.Collections.Generic;
using System.IO;

namespace ExceptionHandlingExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            // -----------------------------------------------------------------------------
            // Objective: Iterate through a character array. Try to parse each character into an integer.
            // If you attempt to parse a letter into an integer, an exception will occur. 
            // Use a try-catch statement to avoid a run-time exception.
            // Below we will set this up.
            // ------------------------------------------------------------------------------



            //TODO START HERE:

            // 1) Create an char[], it must contain 6 numbers and 3 letters - name it arr
            char[] arr = new char[9] { '6', '5', 'c', '1', '2', '3', '4', 'a', 'b' };

            // 2) Create a list called numbers that will hold integers
            List<int> numbers = new List<int>();

            // 3) Create an string variable with an empty string initializer - name it str
            string str;

            // 4) Make a foreach loop to iterate through your character array
            foreach (char c in arr)
            {
                // 5) Create a try-catch inide of your foreach loop
                // 6) Inside the try block: 
                // 7) Set your string variable to each array element in your char[] to .ToString()
                // 8) Now, using int.Parse, parse your string variable and store in an int variable
                // 9) Then add each int to your list
                try
                {
                    str = c.ToString();
                    numbers.Add(int.Parse(str));
                }
                // 10) Inside the catch block:
                // 11) In the scope of your catch you can use the following code:                  
                // Console.WriteLine($"Unable to Parse '{character}'"); //character will be the name of each item in your collection
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
