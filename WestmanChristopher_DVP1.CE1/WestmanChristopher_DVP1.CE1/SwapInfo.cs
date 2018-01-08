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
        // Initiate variables
        string mFirstName;
        string mLastName;
        string mFullName;

        // Constructor method
        public SwapInfo(string _first, string _last)
        {
            mFirstName = _first;
            mLastName = _last;
            mFullName = mFirstName + " " + mLastName;
        }

        // Overloading constructor method 
        public SwapInfo(string _fullName)
        {
            mFullName = _fullName;
        }

        // Setter methods for both variables
        public void SetFirstName(string _first)
        {
            mFirstName = _first;
        }

        public void SetLastName(string _last)
        {
            mLastName = _last;
        }

        // Getter methods to allow user to get variables from main method program file
        public string GetFirstName()
        {
            return mFirstName;
        }

        public string GetLastName()
        {
            return mLastName;
        }

        // Getter and setter method to return full name is desired
        public void SetFullName(string _fullName)
        {
            mFullName = _fullName;
        }

        public string GetFullName()
        {
            return mFullName;
        }

        // This method will reverse the order of the user's name
        public string ReverseName()
        {
            string reverseName = mLastName + " " + mFirstName;
            return reverseName;
        }

    }
}
