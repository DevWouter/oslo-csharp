namespace TournamentPlanner
{
    class TeamTournament : Tournament
    {
        public TeamTournament(string name) : base(initialFunds: 7500)
        {
            Name = name;
        }

        public override string ToString()
        {
            return "[TT] " + base.ToString();
        }
    }
}
