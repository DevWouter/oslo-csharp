using System;

namespace TournamentPlanner
{
    class InvalidSignupEventArgs : EventArgs
    {
        public IRival Player { get; private set; }
        public Tournament Tournament { get; private set; }

        public InvalidSignupEventArgs(IRival wrongPlayer, Tournament wrongTournament)
        {
            Player = wrongPlayer;
            Tournament = wrongTournament;
        }
    }
}
