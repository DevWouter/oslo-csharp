namespace TournamentPlanner
{
    class IndividualRival : IRival
    {
        string Name;
        public string DisplayName
        {
            get
            {
                return Name;
            }
        }

        public IndividualRival(string name)
        {
            Name = name;
        }

        public override string ToString()
        {
            return DisplayName + " (Individual)";
        }
    }
}
