﻿using System;

namespace TournamentPlanner
{
    class Tournament
    {
        private static int MinimalAmountOfPlayers = 0;
        public event EventHandler<InvalidSignupEventArgs> InvalidSignup;

        public int Reward { get; private set; }

        public string Name;
        public BankAccount OrgAccount;

        public IRival[] Players;

        public Tournament(int maxPlayers = 4, int initialFunds = 5000)
        {
            // Increase the amount of players if tournament is too small
            maxPlayers = Math.Max(MinimalAmountOfPlayers, maxPlayers);
            OrgAccount = new BankAccount(initialFunds);
            Players = new IRival[maxPlayers];
        }

        protected virtual void AddPlayer(IRival player)
        {
            bool isIndividual = player is IndividualRival;
            if (!isIndividual)
            {
                // This player is not an individual
                InvalidSignupEventArgs e = new InvalidSignupEventArgs(player, this);
                if (InvalidSignup != null)
                {
                    InvalidSignup.Invoke(this, e);
                }

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

        public void AddPlayers(params IRival[] newPlayers)
        {
            foreach (var player in newPlayers)
            {
                AddPlayer(player);
            }
        }

        public void PrintPlayers()
        {
            for (int i = 0; i < Players.Length; ++i)
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

        public static void SetRequiredPlayers(int playerCount)
        {
            MinimalAmountOfPlayers = playerCount;
        }
    }
}
