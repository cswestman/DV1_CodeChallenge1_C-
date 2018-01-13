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
        public double Age { get; set; }

        // AgeConvert constructor method
        public AgeConvert(double age)
        {
            Age = age;
        }
        
        // Method to convert age to days
        public double AgeDays()
        {
            double days = Age * 365;
            return days;
        }

        // Method to convert age to hours
        public double AgeHours()
        {
            double hours = Age * 8760;
            return hours;
        }

        // Method to convert age to minutes
        public double AgeMin()
        {
            double minutes = Age * 525600;
            return minutes;
        }

        // Method to convert age to seconds
        public double AgeSec()
        {
            double seconds = Age * 31536000;
            return seconds;
        }

        // Method for Challenge 3
        public static void ChallengeThree()
        {
            Console.WriteLine("You are now entering Challenge 3!\r\n");
            // Varibales used for name and age
            double age;
            string newName;

            // Prompt user for full name, validate, store, and create new name object with SwapInfo
            Console.Write("Please type in your full name: ");
            newName = Validate.Input(Console.ReadLine());
            var newUserName = new SwapInfo(newName);

            // Give user feedback
            Console.WriteLine("The name your entered is: " + newUserName.FullName);

            // Promt user for age, validate, store, and create new age object
            Console.Write("Please enter your age: ");
            age = Validate.Age(Console.ReadLine());
            var newAge = new AgeConvert(age);

            // Give user feedback and convert age to  other usable numbers
            Console.WriteLine("{0} has been alive for {1:n0} days!", newUserName.FullName, newAge.AgeDays());
            Console.WriteLine("{0} has been alive for {1:n0} hours!", newUserName.FullName, newAge.AgeHours());
            Console.WriteLine("{0} has been alive for {1:n0} minutes!", newUserName.FullName, newAge.AgeMin());
            Console.WriteLine("{0} has been alive for {1:n0} seconds!\r\n", newUserName.FullName, newAge.AgeSec());
        }

    }
}
