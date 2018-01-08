using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WestmanChristopher_DVP1.CE1
{
    // This class will take the user's age and convert it into other usable numbers
    class AgeConvert
    {
        double mAge;

        // AgeConvert constructor method
        public AgeConvert(double _age)
        {
            mAge = _age;
        }

        // Getter and Setter methods
        public void SetAge(double _age)
        {
            mAge = _age;
        }

        public double GetAge()
        {
            return mAge;
        }

        // Method to convert age to days
        public double AgeDays()
        {
            double _days = mAge * 365;
            return _days;
        }

        // Method to convert age to hours
        public double AgeHours()
        {
            double _hours = mAge * 8760;
            return _hours;
        }

        // Method to convert age to minutes
        public double AgeMin()
        {
            double _minutes = mAge * 525600;
            return _minutes;
        }

        // Method to convert age to seconds
        public double AgeSec()
        {
            double _seconds = mAge * 31536000;
            return _seconds;
        }

    }
}
