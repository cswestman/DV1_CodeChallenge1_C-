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
          Synopsis:​ This is a code challenge for Development. This challenge contains five sub-challenges.
                    Every Challenge will be contained within its own class file.
                    Each challenge solves a unique problem that must be solved. All challenges use the Validate class which 
                    contains several different types of validations. The validations can validate for word counts, single string inputs,
                    and numbers within a certain range or above -1. This main program file is simplified to only show the calling of 
                    each challenge. To see the challenge code, simply open the class file with the name that mirrors the method call,
                    for example, ChallengeOne can be found in the SwapInfo class file. 
        */

        static void Main(string[] args)
        {
           
            // Challenge 1
            SwapInfo.ChallengeOne();

            // Challenge 2
            Backwards.ChallengeTwo();

            // Challenge 3
            AgeConvert.ChallengeThree();

            // Challenge 4
            TempConvert.ChallengeFour();
            
            // Challenge 5
            MainMenu.ChallengeFive();

        }
    }
}
