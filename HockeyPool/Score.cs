using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HockeyPool
{
    class Score
    {
        int winningScore;
        int losingScore;
        
        public Score()
        {
            winningScore = 0;
            losingScore = 0;
        }

        public Score(int w, int l)
        {
            winningScore = w;
            losingScore = l;
        }
    }
}
