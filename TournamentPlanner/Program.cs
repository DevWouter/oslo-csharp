using System;

namespace TournamentPlanner
{
    class Program
    {
        static void Main(string[] args)
        {

            Tournament worldTournament = new Tournament(8);
            worldTournament.InvalidSignup += OnInvalidSignup;

            worldTournament.Name = "World";
            worldTournament.OrgAccount.Balance = 2000000;

            var wouter = new IndividualRival("Wouter");
            var rutger = new IndividualRival("Rutger");
            var cheaters = new TeamRival("Cheaters", 10);

            worldTournament.AddPlayers(wouter, rutger, cheaters);

            for (int i = 0; i < 100; ++i)
            {
                worldTournament.AddPlayers(new IndividualRival("Robot " + i));
            }

            Tournament regionalTournament = new TeamTournament("Regional");
            regionalTournament.AddPlayers(wouter, rutger, cheaters);

            worldTournament.IncreaseReward(1000000);
            regionalTournament.IncreaseReward(1000);

            Console.WriteLine(worldTournament);
            worldTournament.PrintPlayers();

            Console.WriteLine(regionalTournament);
            regionalTournament.PrintPlayers();

            DemoStaticMethods();
            DemoOperatorOverloading();
            Console.ReadLine();
        }

        private static void OnInvalidSignup(object sender, InvalidSignupEventArgs e)
        {
            Console.WriteLine("!!! Unable to process signup of {0} for {1} tournament",
                e.Player.DisplayName,
                e.Tournament.Name);
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
