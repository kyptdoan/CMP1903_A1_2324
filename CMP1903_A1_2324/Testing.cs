using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903_A1_2324
{
    /// <summary>
    /// Class <c>Testing()</c> provides methods to debug and check valid output for each die value and the sum.
    /// </summary>
    internal class Testing
    {
        /// <summary>
        /// Creating a reference to an object of the <c>Game</c> class.
        /// </summary>
        private Game game;

        /// <summary>
        /// Public method to get reference to the object.
        /// </summary>
        /// <returns>
        /// The reference to the Game object.
        /// </returns>
        public Game GetGame() { return game; }

        /// <summary>
        /// A constructor to initialises a Game object for class <o>Testing</o>.
        /// </summary>
        public Testing()
        {
            game = new Game();
        }

        /// <summary>
        /// Method <c>CheckRange()</c> to check if the value of each die is valid.
        /// </summary>
        public void CheckRange()
        {
            Debug.Assert(game.GetDie1().CurrentValue >= 1 && game.GetDie1().CurrentValue <= 6, "Invalid Die Value");
            Debug.Assert(game.GetDie2().CurrentValue >= 1 && game.GetDie2().CurrentValue <= 6, "Invalid Die Value");
            Debug.Assert(game.GetDie3().CurrentValue >= 1 && game.GetDie3().CurrentValue <= 6, "Invalid Die Value");
        }

        /// <summary>
        /// Method <c>CheckExpectation()</c> to check if the sum of 3 dice is valid.
        /// </summary>
        public void CheckExpectation()
        {
            Debug.Assert(game.FindSum() >= 3 && game.FindSum() <= 18, "Invalid Sum Value");
        }
    }
}
