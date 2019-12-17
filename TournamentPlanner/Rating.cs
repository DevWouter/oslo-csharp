using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TournamentPlanner
{
    public class Rating
    {
        public int TotalScore { get; private set; }
        public int NumberOfVotes { get; private set; }

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

        // Operators.
        public static Rating operator +(Rating rating, int score)
        {
            return new Rating(rating.TotalScore + score, rating.NumberOfVotes + 1);
        }

        public static Rating operator +(Rating r1, Rating r2)
        {
            return new Rating(r1.TotalScore + r2.TotalScore, r1.NumberOfVotes + r2.NumberOfVotes);
        }


    }
}
