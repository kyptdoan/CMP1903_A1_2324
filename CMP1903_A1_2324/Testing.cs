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
    /// Class <o>Testing</o> provides methods to debug and check valid output for each die value and the sum.
    /// </summary>
    internal class Testing
    {
        /// <summary>
        /// A public Game object creation to be used by both class <o>Testing</o> and class <o>Program</o>
        /// allows class <o>Testing</o> to test the right game that class <o>Program</o> is running.
        /// </summary>
        public Game game;

        /// <summary>
        /// A constructor to initialises a Game object for class <o>Testing</o>.
        /// </summary>
        public Testing()
        {
            game = new Game();
        }

        /// <summary>
        /// Method <o>CheckRange</o> to check if the value of each die is valid.
        /// </summary>
        public void CheckRange()
        {
            Debug.Assert(game.Die1Value >= 1 && game.Die1Value <= 6, "Invalid Die Value");
            Debug.Assert(game.Die2Value >= 1 && game.Die2Value <= 6, "Invalid Die Value");
            Debug.Assert(game.Die3Value >= 1 && game.Die3Value <= 6, "Invalid Die Value");
        }

        /// <summary>
        /// Method <o>CheckExpectation</o> to check if the sum of 3 dice is valid.
        /// </summary>
        public void CheckExpectation()
        {
            Debug.Assert(game.FindSum() >= 3 && game.FindSum() <= 18, "Invalid Sum Value");
        }
    }
}
