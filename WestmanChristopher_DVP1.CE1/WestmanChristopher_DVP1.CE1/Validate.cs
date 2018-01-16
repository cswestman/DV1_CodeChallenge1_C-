using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WestmanChristopher_DVP1.CE1
{
    /* This class is designed to act as a means to validate user input. Users call Validate.Method(), using user argument to set 
     * the parameter. Some validation methods are overloaded and can receive a second parameter in order to let the method know
     * which kind of validation to run.
     */

    class Validate
    {
        public Validate()
        {
        }

        /* First standard validation method. Used for validating a string, but mostly to check to see if field is left blank
         * This method should be used only for validating empty or blank entries, however, some of the other validation can still
         * run this basic validation.
         */ 
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

        /* Overload Input method in order to select type of validation. This method accepts a second argument "string type".
         * The third parameter is to set the word count minimum that the user wants to set
         */ 
        public static string Input(string input, string type, int wordMin)
        {
            // Declare output for return value
            string output;

            // If second argument == "word", run the Word Count validation 
            if (type == "word")
            {
                output = WordCount(input, wordMin);
            }
            else
            {
                // If other than "word" is entered, defualt to regular validation
                output = Input(input);
            }

            return output;
            
        }

        /* String word count validation method for user input. First paramter takes standard string input, and second 
         * parameter takes in the desired word minimum. The wordMin param was added for flexability
         */ 
        public static string WordCount(string input, int wordMin)
        {
            // Run regualr validation first
            Input(input);
            // Initialize wordCount
            var wordCount = 0;
            
            while (true)
            {
                // Cycle through string and count the number of words
                foreach (var word in input.TrimEnd('.').Split('.'))
                {
                    wordCount = word.Trim().Split(' ').Count();
                    //Console.WriteLine(wordCount);
                }

                // While loop validates number of words in string
                while (wordCount < wordMin)
                {
                    // If less than 6 words, prompt user again, validate for blank space, recount words, store value
                    Console.WriteLine("Please enter at least {0} words.", wordMin);
                    input = Validate.Input(Console.ReadLine());
                    foreach (var word in input.TrimEnd('.').Split('.'))
                    {
                        wordCount = word.Trim().Split(' ').Count();
                        //Console.WriteLine(wordCount);
                    }
                }
                // If all looks good, break out of loop
                if (wordCount >= wordMin)
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
                    // Warn user and allow re-entry of input
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
