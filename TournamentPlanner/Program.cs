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
            DemoOperatorOverloading();
            Console.ReadLine();
        }

        private static void DemoOperatorOverloading()
        {
            Console.WriteLine();
            Console.WriteLine("Demo: Operator Overloading");
            Console.WriteLine("---------------------------------------------");
            Rating youtubeScore = new Rating();
            Rating facebookScore = new Rating(18, 3);
            Console.WriteLine("- Youtube {0}", youtubeScore);
            Console.WriteLine("- Facebook {0}", facebookScore);
            Console.WriteLine("- Combined {0}", youtubeScore + facebookScore);
            Console.WriteLine("- Does Youtube score higher than Facebook? {0}", youtubeScore > facebookScore);
            Console.WriteLine();

            // Give 4 perfect 10's to youtube.
            for (int i = 0; i < 4; ++i) youtubeScore += 10;

            Console.WriteLine("After giving Youtube 4 times a perfect 10...");
            Console.WriteLine("- Youtube {0}", youtubeScore);
            Console.WriteLine("- Facebook {0}", facebookScore);
            Console.WriteLine("- Combined {0}", youtubeScore + facebookScore);
            Console.WriteLine("- Does Youtube score higher than Facebook? {0}", youtubeScore > facebookScore);
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
