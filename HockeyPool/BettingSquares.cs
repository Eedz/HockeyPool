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

        public bool IsSquareAvailable(int home, int away)
        {
            return Squares[home, away] == null;
        }

        /// <summary>
        /// Check if there are any empty squares.
        /// </summary>
        /// <returns></returns>
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
