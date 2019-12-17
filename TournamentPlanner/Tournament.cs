using System;
using System.Collections.Generic;

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

        public List<string> Players = new List<string>();

        public Tournament()
        {
            OrgAccount = new BankAccount(5000);
        }

        public void AddPlayer(string player)
        {
            Players.Add(player);
        }

        public void PrintPlayers()
        {
            for(int i = 0; i< Players.Count; ++i)
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
