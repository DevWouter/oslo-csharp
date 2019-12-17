using System;

namespace TournamentPlanner
{
    class Program
    {
        static void Main(string[] args)
        {
            Tournament worldTournament = new Tournament(8);
            worldTournament.Name = "World";
            worldTournament.OrgAccount.Balance = 2000000;
            worldTournament.AddPlayer("Wouter");
            worldTournament.AddPlayer("Rutger");

            for (int i = 0; i < 100; ++i)
            {
                worldTournament.AddPlayer("Robot " + i);
            }

            Tournament regionalTournament = new Tournament(initialFunds: 7500);
            regionalTournament.Name = "Regional";

            worldTournament.IncreaseReward(1000000);
            regionalTournament.IncreaseReward(1000);

            Console.WriteLine(worldTournament);
            worldTournament.PrintPlayers();

            Console.WriteLine(regionalTournament);

            DemoStaticMethods();

            Console.ReadLine();
        }

        private static void DemoStaticMethods()
        {
            int citySpots = 10;
            Tournament.SetRequiredPlayers(100);
            Tournament cityTournament = new Tournament(citySpots);

            Console.WriteLine();
            Console.WriteLine("Demo: Static Methods");
            Console.WriteLine("---------------------------------------------");
            Console.WriteLine(
                "City Tournament has {0} spots even though we asked {1}",
                cityTournament.Players.Length,
                citySpots
                );
        }
    }
}
