using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WestmanChristopher_DVP1.CE1
{
    // This class is for calling a simple menu method that allows the user to select which challenge they want to run
    class MainMenu
    {
        public MainMenu()
        {

        }

        // Method for Challenge 5
        public static void ChallengeFive()
        {
            Console.WriteLine("You are now entering Challenge 5!\r\n");
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
                entry = Validate.Menu(Console.ReadLine());

                // Cycle through if statement to start user menu option
                if (entry == 1)
                {
                    SwapInfo.ChallengeOne();
                }
                else if (entry == 2)
                {
                    Backwards.ChallengeTwo();
                }
                else if (entry == 3)
                {
                    AgeConvert.ChallengeThree();
                }
                else if (entry == 4)
                {
                    TempConvert.ChallengeFour();
                }
                else if (entry == 0)
                {
                    // Break out of while loop if user doesn't want to run program
                    Console.WriteLine("Exiting now! Thanks for using the program!");
                    break;
                }
            }
        }

    }
}
