using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903_A1_2324
{
    /// <summary>
    /// Class <c>Game</c> models a game with 3 dice (made from 3 objects of class <o>Die</o>).
    /// with 2 methods to roll 3 dice and calculate the sum.
    /// </summary>
    internal class Game
    {       
        /// <summary>
        /// Represent the first die of the game.
        /// </summary>
        private readonly Die die1;

        /// <summary>
        /// Represent the second die of the game.
        /// </summary>
        private readonly Die die2;

        /// <summary>
        /// Represent the third die of the game.
        /// </summary>
        private readonly Die die3;

        /// <summary>
        /// Public method to get reference to the first die object.
        /// </summary>
        /// <returns>
        /// The reference to the first die object.
        /// </returns>
        public Die GetDie1() { return die1; }

        /// <summary>
        /// Public method to get reference to the second die object.
        /// </summary>
        /// <returns>
        /// The reference to the second die object.
        /// </returns>
        public Die GetDie2() { return die2; }

        /// <summary>
        /// Public method to get reference to the third object.
        /// </summary>
        /// <returns>
        /// The reference to the third die object.
        /// </returns>
        public Die GetDie3() { return die3; }

        /// <summary>
        /// Constructor to create 3 instances of Die class and assign to 3 readonly fields.
        /// </summary>
        public Game()
        {
            die1 = new Die();
            die2 = new Die();
            die3 = new Die();
        }
        
        /// <summary>
        /// Method <c>RollThreeDice()</c> rolls all 3 dice and report their values.
        /// </summary>
        public void RollThreeDice()
        {
            die1.Roll();
            die2.Roll();
            die3.Roll();

            Console.WriteLine($"Die1 value is: {die1.CurrentValue}");
            Console.WriteLine($"Die2 value is: {die2.CurrentValue}");
            Console.WriteLine($"Die3 value is: {die3.CurrentValue}");
        }

        /// <summary>
        /// Method <c>FindSum()</c> calculates the sum of 3 dice values.
        /// </summary>
        /// <returns>
        /// An integer represents the sum of 3 dice values.
        /// </returns>
        public int FindSum()
        {
            int sum = die1.CurrentValue + die2.CurrentValue + die3.CurrentValue;
            return sum;
        }
    }
}
