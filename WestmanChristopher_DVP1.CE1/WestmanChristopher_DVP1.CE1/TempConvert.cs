using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WestmanChristopher_DVP1.CE1
{
    // Class to convert temperature from F to C and C to F

    class TempConvert
    {
        // Variables for temp
        double mTemp;

        // Constructor method
        public TempConvert(double _temp)
        {
            mTemp = _temp;
        }

        // Getter and setter for temp
        public void SetTemp(double _temp)
        {
            mTemp = _temp;
        }

        public double GetTemp()
        {
            return mTemp;
        }

        // Method to convert temp from F to C
        public double ConTempC()
        {
            double newTempC = (mTemp - 32) * 5/9;
            return newTempC;
        }

        // Method to convert temp from C to F
        public double ConTempF()
        {
            double newTempF = (mTemp * 9/5) + 32;
            return newTempF;
        }

        // Method for Challenge 4
        public static void ChallengeFour()
        {
            Console.WriteLine("You are now entering Challenge 4!\r\n");
            // Variables for user input for temp conversion
            double temp1;
            double temp2;

            // Prompt user for F temp, validate, store, and create new object
            Console.Write("Please enter a temperature in Fahrenheit to be converted: ");
            temp1 = Validate.Temp(Console.ReadLine());
            var newTemp1 = new TempConvert(temp1);
            // Give user feedback, convert tmep to Celsius, and tell user the new temp
            Console.WriteLine("The temperature you entered is {0} degrees Fahrenheit. That's {1} degrees Celsius!\r\n",
                newTemp1.GetTemp(), Math.Round(newTemp1.ConTempC(), 2));

            // Prompt user for C temp, validate, store, and create new object
            Console.Write("Please enter a temperature in Celsius to be converted: ");
            temp2 = Validate.Temp(Console.ReadLine());
            var newTemp2 = new TempConvert(temp2);
            // Give user feedback, convert tmep to Fahrenheit, and tell user the new temp
            Console.WriteLine("The temperature you entered is {0} degrees Celsius. That's {1} degrees Fahrenheit!\r\n",
                newTemp2.GetTemp(), Math.Round(newTemp2.ConTempF(), 2));
        }

    }
}
