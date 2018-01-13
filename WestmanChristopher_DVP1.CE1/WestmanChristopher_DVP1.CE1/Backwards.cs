using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WestmanChristopher_DVP1.CE1
{
    // THis class will take in a sentance from a user and then display it in reverse, reversing the letters as well

    class Backwards
    {
        // Initialize class member variable
        string mSentence;

        // Constructor method 
        public Backwards(string _sent)
        {
            mSentence = _sent;
        }

        // Getter and setter methods
        public void SetSent(string _sent)
        {
            mSentence = _sent;
        }

        public string GetSent()
        {
            return mSentence;
        }

        // Reverse method to take in user input and reverse the order of characters and words
        public string ReverseString()
        {
            // Before returning new string, create new string, pass in input as a parameter, then reverse it with the following methods
            return new string(mSentence.ToCharArray().Reverse().ToArray());
        }

        // Method for Challenge 2
        public static void ChallengeTwo()
        {
            Console.WriteLine("You are now entering Challenge 2!\r\n");
            // Initiate variable for validation and storing user input
            string userSentence;

            // Prompt user for a sentence, validate for blank space and that it has at least six words, then store
            Console.WriteLine("Please type in the sentense you would like to be reversed, six words minimum!");

            // Validate user input and ensure user types in at least 6 words
            userSentence = Validate.Input(Console.ReadLine(), "word");

            // Create new Backwards object and pass in userSentence
            var userString = new Backwards(userSentence);

            // Give user feedback
            Console.WriteLine("You typed in : " + userString.GetSent());

            // Reverse string and give as new user feedback by calling the ReverseString method created in the Backwards class
            Console.WriteLine("Your sentence in reverse reads as: {0} \r\n", userString.ReverseString());
        }

    }
}
