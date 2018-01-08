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

    }
}
