using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WestmanChristopher_DVP1.CE1
{
    class Program
    {
        /*
          Name: Christopher Westman
          Date(YYMM): 1801
          Course:​ Project & Portfolio 1
          Synopsis:​ This is the first set of code challenges for Mobile Dev. 
                    Every Challenge will be contained within its own class.cs file, all but Challenge 5.
                    Challenge 5 is created below and it allows for the selection of all previous chellenges.
        */

        static void Main(string[] args)
        {
            // Challenge 1
            Console.WriteLine("You are now entering Challenge 1!\r\n");
            // Call ChallOne method
            ChallOne();

            // Challenge 2
            Console.WriteLine("You are now entering Challenge 2!\r\n");
            // Call ChallTwo method
            ChallTwo();

            // Challenge 3
            Console.WriteLine("You are now entering Challenge 3!\r\n");
            // Call ChallThree method
            ChallThree();

            // Challenge 4
            Console.WriteLine("You are now entering Challenge 4!\r\n");
            // Call ChallFour method
            ChallFour();
            
            // Challenge 5
            Console.WriteLine("You are now entering Challenge 5!\r\n");
            // Call ChallFive method
            ChallFive();

        }
        //---------------------OUTSIDE OF MAIN METHOD----------/////////////////////////////////////////////////////
        //-/////////////////////////////////////////////////////////////////////////////////////////////////////////

        // Method for Challenge 1
        public static void ChallOne()
        {
            // Create variable for SwapInfo object and for validation
            string firstName;
            string lastName;

            // Create user prompts, pass into validation method, then store in variables
            Console.Write("Please type in your first name: ");
            firstName = Validate(Console.ReadLine());
            Console.WriteLine("Your first name is : " + firstName + "\r\n");

            Console.Write("Please type in your last name: ");
            lastName = Validate(Console.ReadLine());
            Console.WriteLine("Your last name is : " + lastName + "\r\n");

            // Instantiate new object of SwapInfo class and pass in user input
            SwapInfo newUser = new SwapInfo(firstName, lastName);

            // Give user feedback by calling GetFullName method 
            Console.WriteLine("Your full name is " + newUser.GetFullName() + ".");
            // Reverse the name order using the ReverseName method and tell user
            Console.WriteLine("Your full name in reverse is " + newUser.ReverseName() + ".\r\n");
        }

        // Method for Challenge 2
        public static void ChallTwo()
        {
            // Initiate variable for validation and storing user input
            string userSentence;

            // Prompt user for a sentence, validate for blank space and that it has at least six words, then store
            Console.WriteLine("Please type in the sentense you would like to be reversed, six words minimum!");

            // Validate user input and ensure user types in at least 6 words
            userSentence = ValWordCount(Console.ReadLine());

            // Create new Backwards object and pass in userSentence
            Backwards userString = new Backwards(userSentence);

            // Give user feedback
            Console.WriteLine("You typed in : " + userString.GetSent());

            // Reverse string and give as new user feedback by calling the ReverseString method created in the Backwards class
            Console.WriteLine("Your sentence in reverse reads as: {0} \r\n", userString.ReverseString());
        }

        // Method for Challenge 3
        public static void ChallThree()
        {
            // Varibales used for name and age
            double age;
            string newName;

            // Prompt user for full name, validate, store, and create new name object with SwapInfo
            Console.Write("Please type in your full name: ");
            newName = Validate(Console.ReadLine());
            SwapInfo newUserName = new SwapInfo(newName);
            // Give user feedback
            Console.WriteLine("The name your entered is: " + newUserName.GetFullName());

            // Promt user for age, validate, store, and create new age object
            Console.Write("Please enter your age: ");
            age = ValAge(Console.ReadLine());
            AgeConvert newAge = new AgeConvert(age);

            // Give user feedback and convert age to  other usable numbers
            Console.WriteLine("{0} has been alive for {1:n0} days!", newUserName.GetFullName(), newAge.AgeDays());
            Console.WriteLine("{0} has been alive for {1:n0} hours!", newUserName.GetFullName(), newAge.AgeHours());
            Console.WriteLine("{0} has been alive for {1:n0} minutes!", newUserName.GetFullName(), newAge.AgeMin());
            Console.WriteLine("{0} has been alive for {1:n0} seconds!\r\n", newUserName.GetFullName(), newAge.AgeSec());
        }

        // Method for Challenge 4
        public static void ChallFour()
        {
            // Variables for user input for temp conversion
            double temp1;
            double temp2;

            // Prompt user for F temp, validate, store, and create new object
            Console.Write("Please enter a temperature in Fahrenheit to be converted: ");
            temp1 = ValTemp(Console.ReadLine());
            TempConvert newTemp1 = new TempConvert(temp1);
            // Give user feedback, convert tmep to Celsius, and tell user the new temp
            Console.WriteLine("The temperature you entered is {0} degrees Fahrenheit. That's {1} degrees Celsius!\r\n",
                newTemp1.GetTemp(), Math.Round(newTemp1.ConTempC(), 2));

            // Prompt user for C temp, validate, store, and create new object
            Console.Write("Please enter a temperature in Celsius to be converted: ");
            temp2 = ValTemp(Console.ReadLine());
            TempConvert newTemp2 = new TempConvert(temp2);
            // Give user feedback, convert tmep to Fahrenheit, and tell user the new temp
            Console.WriteLine("The temperature you entered is {0} degrees Celsius. That's {1} degrees Fahrenheit!\r\n",
                newTemp2.GetTemp(), Math.Round(newTemp2.ConTempF(), 2));
        }

        // Method for Challenge 5
        public static void ChallFive()
        {
            // Use while loop to allow menu prompt
            while (true)
            {
                // Variable for user entry
                double entry;
                // Prompt user to select from menu
                Console.WriteLine("Which challenge would you like to try again?\r\n" +
                    "Enter 1 for SwapInfo\r\n" +
                    "Enter 2 for Backwards\r\n" +
                    "Enter 3 for AgeConvert\r\n" +
                    "Enter 4 for TempConvert\r\n" +
                    "Or enter 0 to quit");
                // Validate and store user entry
                entry = ValMenu(Console.ReadLine());

                // Cycle through if statement to start user menu option
                if (entry == 1)
                {
                    ChallOne();
                }
                else if (entry == 2)
                {
                    ChallTwo();
                }
                else if (entry == 3)
                {
                    ChallThree();
                }
                else if (entry == 4)
                {
                    ChallFour();
                }
                else if (entry == 0)
                {
                    // Break out of while loop if user doesn't want to run program
                    Console.WriteLine("Exiting now! Thanks for using the program!");
                    break;
                }
            }
        }

        //---------------------Validation Methods Below----------///////////////////////////////////////////////////
        //-/////////////////////////////////////////////////////////////////////////////////////////////////////////

        // Create string validation method for user input
        public static string Validate(string input)
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

        // String word count validation method for user input
        public static string ValWordCount(string input)
        {
            Validate(input);
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
                    input = Validate(Console.ReadLine());
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
        public static double ValAge(string input)
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

        public static double ValTemp(string input)
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
        public static double ValMenu(string input)
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
