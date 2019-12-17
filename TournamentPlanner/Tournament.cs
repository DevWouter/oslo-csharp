using System;

namespace TournamentPlanner
{
    class Tournament
    {
        public int Reward { 
            get; 
            private set; 
        }

        public string Name;
        public BankAccount OrgAccount;

        public string[] Players;

        public Tournament(int maxPlayers)
        {
            OrgAccount = new BankAccount(5000);
            Players = new string[maxPlayers];
        }

        public void AddPlayer(string player)
        {
            for(int i = 0; i < Players.Length; ++i)
            {
                if (Players[i] == null)
                {
                    Players[i] = player;
                    return;
                }
            }
        }

        public void PrintPlayers()
        {
            for(int i = 0; i< Players.Length; ++i)
            {
                Console.WriteLine("{0} - {1}", i, Players[i]);
            }
        }

        public void IncreaseReward(int amount)
        {
            int newReward = Reward + amount;
            if (OrgAccount.Balance >= newReward)
            {
                Reward = newReward;
            }
        }

        public override string ToString()
        {
            return 
                "Name: " + Name + 
                " Reward: " + Reward + 
                " Balance: " + OrgAccount.Balance;
        }
    }
}
