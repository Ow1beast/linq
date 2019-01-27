using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq
{
    class Program
    {
        static void Main(string[] args)
        {
            using (LinqContext context = new LinqContext())
            {
                //var team1 = new Team
                //{
                //    Name = "Team 1 name"
                //};
                //context.Teams.Add(team1);

                //var team2 = new Team
                //{
                //    Name = "Team 2 name"
                //};
                //context.Teams.Add(team2);
                //context.SaveChanges();

                //var player1 = new Player
                //{
                //    FullName = "Qwerty",
                //    Number = 9,
                //    Team = team1
                //};
                //context.Players.Add(player1);

                //var player2 = new Player
                //{
                //    FullName = "Asdfg",
                //    Number = 1,
                //    Team = team2
                //};
                //context.Players.Add(player2);

                //context.SaveChanges();


                var players = from Players in context.Players
                              where Players.FullName == "Qwerty"
                              select Players;

                Player playerSearch = players.FirstOrDefault();

                Console.WriteLine(playerSearch.FullName + " " + playerSearch.Number + " " + playerSearch.Team.Name);

                Console.ReadLine(); 
            }
        }
    }
}
