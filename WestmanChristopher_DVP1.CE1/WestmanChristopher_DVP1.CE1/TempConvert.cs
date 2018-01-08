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

    }
}
