using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WestmanChristopher_DVP1.CE1
{
    // This class will prompt, store, and rpesent a user's full name.

    class SwapInfo
    {
        // Initiate auto-implimented properties
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string FullName { get; set; }

        // Constructor method
        public SwapInfo(string first, string last)
        {
            FirstName = first;
            LastName = last;
            FullName = FirstName + " " + LastName;
        }

        // Overloading constructor method  if user types in full name
        public SwapInfo(string fullName)
        {
            FullName = fullName;
        }
        
        // This method will reverse the order of the user's name
        public string ReverseName()
        {
            string reverseName = LastName + " " + FirstName;
            return reverseName;
        }

        // Method for Challenge 1
        public static void ChallengeOne()
        {
            Console.WriteLine("You are now entering Challenge 1!\r\n");

            // Create variable for SwapInfo object and for validation
            string firstName;
            string lastName;

            // Create user prompts, pass into validation method, then store in variables
            Console.Write("Please type in your first name: ");
            firstName = Validate.Input(Console.ReadLine());
            Console.WriteLine("Your first name is : " + firstName + "\r\n");

            Console.Write("Please type in your last name: ");
            lastName = Validate.Input(Console.ReadLine());
            Console.WriteLine("Your last name is : " + lastName + "\r\n");

            // Instantiate new object of SwapInfo class and pass in user input
            var newUser = new SwapInfo(firstName, lastName);

            // Give user feedback by calling GetFullName method 
            Console.WriteLine("Your full name is " + newUser.FullName + ".");
            // Reverse the name order using the ReverseName method and tell user
            Console.WriteLine("Your full name in reverse is " + newUser.ReverseName() + ".\r\n");
        }

    }
}
