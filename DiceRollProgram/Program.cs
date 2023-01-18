// Name: Thomas Smith
// Section 002
// Description: Dice Rolling Program that takes in a number of rolls then prints a histogram of the amount of times
// a certain total was rolled. 
using System;

namespace DiceRollProgram
{
    class Program
    {
        public static void Main(string[] args)
        {
            // I am making the assumption that a 6 sided die has 1-6, therefore there cannot be a total
            // of 1 or 0 rolled.



            // Welcome and roll number request
            Console.WriteLine("Welcome to the dice throwing simulator!\n\n" +
                "How many dice rolls would you like to simulate?");

            // Create iRolls variable to keep track of the amount of rolls requested
            int iRolls = 0;
            int.TryParse(Console.ReadLine(), out iRolls);

            // Check if the number entered is greater than 0
            if (iRolls <= 0)
            {
                //Error Error1 = new Error("int"); Tried to do object stuff, didnt really work out
                //Error1.PrintError();
                Console.WriteLine("Your number should be greater than 0!");
            }
            // If entry is greater than 0, continue
            else
            {
                // Create arrays to keep track of count of times each total was rolled and the percentage of 
                // total rolls that were a certain total.
                int[] totalCountArray = new int[11];
                double[] percentageArray = new double[11];
                string[] histArray = new string[11];

                // Start a loop that goes for the amount of times that the user has 
                // specified for dice rolls. 
                for (int i = 1; i < (iRolls + 1); i++)
                {
                    // Things to do for each roll:
                    // Generate 2 random numbers as the 2 die rolls, then add them together for the total
                    Random rnd = new Random();
                    int die1 = rnd.Next(1, 7);
                    int die2 = rnd.Next(1, 7);
                    int rollTotal = die1 + die2;

                    // Access the array position at 2 less than the number rolled ie. 2 would be pos 0
                    // Increment that position by 1
                    int arrayPos = rollTotal - 2;
                    totalCountArray[arrayPos] += 1;                    
                    
                }
                // Determine the percentage for each position
                for (int i = 0; i < 11; i++)
                {
                    // the position in the percentage array is the value of the corresponding position / total rolls
                    percentageArray[i] = (Math.Round((totalCountArray[i] / (double)iRolls),2)) * 100;

                    // for the number of percentage points there are, put an asterisk
                    for (int a = 0; a < percentageArray[i]; a++)
                    {
                        histArray[i] += "*";
                    }
                    // Console.WriteLine(histArray[i]); Used in testing to see the hist results
                }

                // Print the results
                Console.WriteLine("\n\nDICE ROLLING SIMULATION RESULTS \n\nEach \"*\" represents 1 % of the total number of rolls.\n" +
                    "Total number of rolls = " + iRolls.ToString() + ".\n\n");

                // Print the Histogram and get outta there
                for (int x = 2; x < 13; x++)
                {
                    Console.WriteLine(x.ToString() + ": " + histArray[(x-2)]);
                }

                Console.WriteLine("\n\nThank you for using the dice throwing simulator. Goodbye!");
            }

        }
    }
}
