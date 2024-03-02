using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903_A1_2324
{
    /// <summary>
    /// Class <o>Program</o> represents the main entry point for the game.
    /// </summary>
    internal class Program
    {
        /// <summary>
        /// The main method provides entry point for the program
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {   
            int user_input;
            int expectation;

            /// <summary>
            /// Create an object of Testing class.
            /// </summary>
            Testing testing = new Testing();
            
            /// <summary>
            /// Create a reference to the object of Game created in <c>Testing</c> class.
            /// </summary>
            Game game = testing.GetGame;

            Console.WriteLine("Welcome to the Dice Rolling game.");
            
            // exceptions handling and continuous roll execution.
            while (true)
            {
                Console.WriteLine("Choose a function:");
                Console.WriteLine("1. Type '1' if you want to roll the dice and check if the sum is as your expectation.");
                Console.WriteLine("2. Type '2' if you want to quit the game.");

                // check if the user inputs an integer to choose an option.
                try
                {
                    user_input = int.Parse(Console.ReadLine());
                }
                catch (FormatException) 
                {
                    Console.WriteLine("Please only input '1' or '2'.");
                    continue;
                }

                // check if the user inputs '1' or '2' for valid options.
                if (user_input == 1 || user_input == 2)
                {
                    // option 1 is to roll 3 dice and find their sum.
                    if (user_input == 1)
                    {
                        // validate user's input for expectation.
                        while (true)
                        {
                            Console.WriteLine("Please type in your expectation for the sum. It must be between 3 and 18 (inclusive)");

                            // check if the user input an integer for expectation
                            try
                            {
                                expectation = int.Parse(Console.ReadLine());
                            }
                            catch (FormatException)
                            {
                                Console.WriteLine("Please only input an integer from 3 to 18.");
                                continue;
                            }
                            // check if user's expecation is in the valid range of the sum (3 to 18)
                            if (expectation >= 3 && expectation <= 18)
                            {
                                // Access the method of class Game via class Testing
                                // instead of create a new object of class Game
                                // to avoid Program and Testing runs 2 different class
                                // because a Game object has been created in class Testing.
                                game.RollThreeDice();

                                // Check if the dice values are valid.
                                testing.CheckRange();

                                // Check if the sum of 3 dice values is valid.
                                testing.CheckSum();

                                // Print out the sum of the 3 dice values.
                                Console.WriteLine(game.FindSum());

                                // Check if the sum is as user's expectation.
                                testing.CheckExpectation(expectation);
                                break;
                            }
                            else
                            {
                                Console.WriteLine("Please only input an integer from 3 to 18.");
                                continue;
                            }
                        }                 
                    }
                    // option 2 is to quit the game.
                    else
                    {
                        Console.WriteLine("The game ends.");
                        break;
                    }
                }
                else
                {
                    Console.WriteLine("Please only input '1' or '2'");
                    continue;
                }
            }

            // For the results to stay longer on the screen.
            Console.ReadKey();     
        }
    }
}
