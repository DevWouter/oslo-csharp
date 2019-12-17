using System;

namespace TournamentPlanner
{
    class Program
    {
        static void Main(string[] args)
        {
            Tournament worldTournament = new Tournament();
            worldTournament.Name = "World";
            worldTournament.OrgAccount.Balance = 2000000;
            worldTournament.AddPlayer("Wouter");
            worldTournament.AddPlayer("Rutger");

            for (int i = 0; i < 100; ++i)
            {
                worldTournament.AddPlayer("Robot " + i);
            }

            Tournament regionalTournament = new Tournament();
            regionalTournament.Name = "Regional";

            worldTournament.IncreaseReward(1000000);
            regionalTournament.IncreaseReward(1000);

            Console.WriteLine(worldTournament);
            worldTournament.PrintPlayers();

            Console.WriteLine(regionalTournament);

            Console.ReadLine();
        }
    }
}
