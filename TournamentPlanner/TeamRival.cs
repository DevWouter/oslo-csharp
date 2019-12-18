namespace TournamentPlanner
{
    class TeamRival : IRival
    {
        private string Name;
        private int Size;

        public string DisplayName
        {
            get
            {
                return "Team " + Name;
            }
        }

        public TeamRival(string teamName, int teamSize)
        {
            Name = teamName;
            Size = teamSize;
        }

        public override string ToString()
        {
            return string.Format("{0} (Team of {1})", DisplayName, Size);
        }
    }
}
