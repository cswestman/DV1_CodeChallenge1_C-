using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WestmanChristopher_DVP1.CE1
{
    class Validate
    {
        public Validate()
        {
        }

        public static string Input(string input)
        {

            // Check for empty value
            while (string.IsNullOrWhiteSpace(input))
            {
                // If incorrect user input is entered, correct user
                Console.WriteLine("Pleae do not leave blank.");
                // Store input once again from user
                input = Console.ReadLine();
                continue;
            }
            // Return value to variable in main method
            return input;
        }

        // Overload Input method so in order to select type of validation
        public static string Input(string input, string type)
        {
            string output;
            if (type == "word")
            {
                output = WordCount(input);
            }
            else
            {
                output = Input(input);
            }

            return output;
            
        }

        // String word count validation method for user input
        public static string WordCount(string input)
        {
            Input(input);
            var wordCount = 0;
            while (true)
            {
                // Cycle through string and count the number of words
                foreach (var word in input.TrimEnd('.').Split('.'))
                {
                    wordCount = word.Trim().Split(' ').Count();
                    //Console.WriteLine(wordCount);
                }

                while (wordCount < 6)
                {
                    // If less than 6 words, prompt user again, validate for blank space, recount words, store value
                    Console.WriteLine("Please enter at least six words.");
                    input = Validate.Input(Console.ReadLine());
                    foreach (var word in input.TrimEnd('.').Split('.'))
                    {
                        wordCount = word.Trim().Split(' ').Count();
                        //Console.WriteLine(wordCount);
                    }
                }
                if (wordCount >= 6)
                {
                    break;
                }
            }
            // Return value to variable in main method
            return input;
        }

        // Age validation method
        public static double Age(string input)
        {
            // Declare generic variable since this method will be used for multiple questions
            double output;
            // Create while loop that allows for 2 validation loops to run
            while (true)
            {
                // Validate for number < 0
                while (double.TryParse(input, out output) && output < 0)
                {
                    Console.WriteLine("\r\nYou can not type in a value of less than 0. Please try again.");
                    input = Console.ReadLine();
                }
                // Validate for letters and blank
                while (string.IsNullOrWhiteSpace(input) || !double.TryParse(input, out output))
                {
                    // If incorrect user input is entered, correct user
                    Console.WriteLine("Pleae type in a valid entry.");
                    // Store input once again from user
                    input = Console.ReadLine();
                    continue;
                }
                // Break out of while loop if user input is valid
                if (output >= 0)
                {
                    break;
                }
            }
            // Return output to user to be stored for later purposes
            return output;
        }

        //  Temperature validatation method
        public static double Temp(string input)
        {
            // Declare generic variable since this method will be used for multiple questions
            double output;
            // Create while loop that allows for 2 validation loops to run
            while (true)
            {
                // Validate for letters and blank
                while (string.IsNullOrWhiteSpace(input) || !double.TryParse(input, out output))
                {
                    // If incorrect user input is entered, correct user
                    Console.WriteLine("Pleae type in a valid entry.");
                    // Store input once again from user
                    input = Console.ReadLine();
                    continue;
                }
                // Break out of while loop if user input is valid
                if (double.TryParse(input, out output))
                {
                    break;
                }
            }
            // Return output to user to be stored for later purposes
            return output;
        }

        // Menu validation method
        public static double Menu(string input)
        {
            // Declare generic variable since this method will be used for multiple questions
            double output;
            // Create while loop that allows for 2 validation loops to run
            while (true)
            {
                // Validate for number < 0
                while (double.TryParse(input, out output) && (output < 0 || output > 4))
                {
                    Console.WriteLine("\r\nPleae type in a valid entry.");
                    input = Console.ReadLine();
                }
                // Validate for letters and blank
                while (string.IsNullOrWhiteSpace(input) || !double.TryParse(input, out output))
                {
                    // If incorrect user input is entered, correct user
                    Console.WriteLine("Pleae type in a valid entry.");
                    // Store input once again from user
                    input = Console.ReadLine();
                    continue;
                }
                // Break out of while loop if user input is valid
                if (output >= 0)
                {
                    break;
                }
            }
            // Return output to user to be stored for later purposes
            return output;
        }

    }
}
