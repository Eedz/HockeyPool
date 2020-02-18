using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HockeyPool
{


    public class BettingSquares
    {
        public UserBet[,] Squares { get; set; }

        public BettingSquares()
        {
            Squares = new UserBet[10,10];

            

        }

        public int BuySquare (UserBet bet, int home, int away)
        {
            if (home == away)
            {
                // cannot buy 'tie' squares
                return 1;
            }

            // check if square is available, if it is, set its value to the user's id
            if (IsSquareAvailable(home,away))
                Squares[home, away] = bet;
            else
                return 1; // square not available

            return 0;
        }

        /// <summary>
        /// Checks if the square at the specified co-ordinates is null.
        /// </summary>
        /// <param name="home"></param>
        /// <param name="away"></param>
        /// <returns>True if square at [home,away] is null.</returns>
        public bool IsSquareAvailable(int home, int away)
        {
            try
            {
                return Squares[home, away] == null && home != away;
            }catch (IndexOutOfRangeException)
            {
                return false;
            }
        }

        /// <summary>
        /// Check if there are any empty squares.
        /// </summary>
        /// <returns>True if there is at least one null square</returns>
        public bool SquaresFull()
        {
            
            foreach (var item in Squares)
            {
                if (item == null)
                    return false;
            }

            return true;
        }

        public int GetSquareUser(int home, int away)
        {
            if (Squares[home, away] == null)
                return 0;

            return Squares[home, away].userid;
        }
    }
}
