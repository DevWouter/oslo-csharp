using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TournamentPlanner
{
    public class Rating
    {
        private int TotalScore = 0;
        private int NumberOfVotes = 0;

        public Rating(int initialScore = 0, int initialVotes = 0)
        {
            TotalScore = initialScore;
            NumberOfVotes = initialVotes;
        }

        private float AverageScore
        {
            get { return TotalScore / (float)NumberOfVotes; }
        }

        public override string ToString()
        {
            return string.Format("score {0} with {1} votes (avg: {2})", TotalScore, NumberOfVotes, AverageScore);
        }

        

    }
}
