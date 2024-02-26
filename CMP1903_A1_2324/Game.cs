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
    /// Class <o>Game</o> models a game with 3 dice (made from 3 objects of class <o>Die</o>).
    /// with 2 methods to roll 3 dice and calculate the sum.
    /// </summary>
    internal class Game
    {
        /// <summary>
        /// Value of the 1st die.
        /// </summary>
        private int _die1Value;

        /// <summary>
        /// Value of the 2nd die.
        /// </summary>
        private int _die2Value;

        /// <summary>
        /// Value of the 3rd die.
        /// </summary>
        private int _die3Value;
        
        /// <summary>
        /// Object of the 1st die.
        /// </summary>
        private Die die1;

        /// <summary>
        /// Object of the 2nd die.
        /// </summary>
        private Die die2;

        /// <summary>
        /// Object of the 3rd die.
        /// </summary>
        private Die die3;

        /// <summary>
        /// Property <o>Die1Value</o> to get the value of the 1st die.
        /// </summary>
        public int Die1Value {  get { return _die1Value; } }

        /// <summary>
        /// Property <o>Die2Value</o> to get the value of the 2nd die.
        /// </summary>
        public int Die2Value {  get { return _die2Value; } }

        /// <summary>
        /// Property <o>Die3Value</o> to get the value of the 3rd die.
        /// </summary>
        public int Die3Value {  get { return _die3Value; } }

        /// <summary>
        /// This constructor initialises 3 dice objects for the game.
        /// </summary>
        public Game()
        {
            die1 = new Die();
            die2 = new Die();
            die3 = new Die();
        }
        
        /// <summary>
        /// Method <o>RollThreeDice</o> rolls all 3 dice and report their values.
        /// </summary>
        public void RollThreeDice()
        {   
            _die1Value = die1.Roll();

            _die2Value = die2.Roll();

            _die3Value = die3.Roll();

            Console.WriteLine($"Die1 value is: {_die1Value}");
            Console.WriteLine($"Die2 value is: {_die2Value}");
            Console.WriteLine($"Die3 value is: {_die3Value}");
        }

        /// <summary>
        /// Method <o>FindSum</o> calculates the sum of 3 dice values.
        /// </summary>
        /// <returns>
        /// An integer represents the sum of 3 dice values.
        /// </returns>
        public int FindSum()
        {
            int sum = _die1Value + _die2Value + _die3Value;
            return sum;
        }
    }
}
