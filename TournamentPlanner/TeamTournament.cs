namespace TournamentPlanner
{
    class TeamTournament : Tournament
    {
        public TeamTournament(string name) : base(initialFunds: 7500)
        {
            Name = name;
        }

        protected override void AddPlayer(IRival player)
        {
            bool isTeam = player is TeamRival;
            if (!isTeam)
            {
                // This player is not an team
                return;
            }

            for (int i = 0; i < Players.Length; ++i)
            {
                if (Players[i] == null)
                {
                    Players[i] = player;
                    return;
                }
            }
        }

        public override string ToString()
        {
            return "[TT] " + base.ToString();
        }
    }
}
