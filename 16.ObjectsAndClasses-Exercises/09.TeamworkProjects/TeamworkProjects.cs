using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.TeamworkProjects
{
    class Team
    {
        public string TeamName { get; set; }
        public List<string> Members { get; set; }
        public string CreatorName { get; set; }
    }

    class TeamworkProjects
    {
        static void Main()
        {
            int count = int.Parse(Console.ReadLine());

            List<Team> teams = new List<Team>();

            CreateTeams(count, teams);
            
            string input = Console.ReadLine();

            while (input != "end of assignment")
            {
                string[] tokens = input.Split(new string[] { "->" }, StringSplitOptions.RemoveEmptyEntries);

                string teammateToJoin = tokens[0];
                string desiredTeamToJoin = tokens[1];

                if (teams.All(t => t.TeamName != desiredTeamToJoin))
                {
                    Console.WriteLine($"Team {desiredTeamToJoin} does not exist!");
                }
                else if (teams.Any(t => t.Members.Contains(teammateToJoin)) || teams.Any(t => t.CreatorName == teammateToJoin))
                {
                    Console.WriteLine($"Member {teammateToJoin} cannot join team {desiredTeamToJoin}!");
                }
                else
                {
                    AddMembers(teams, desiredTeamToJoin, teammateToJoin);
                }
                input = Console.ReadLine();
            }

            PrintOutput(teams);
            
        }

        private static void PrintOutput(List<Team> teams)
        {
            List<Team> validTeams =
                teams
                .Where(t => t.Members.Count > 0)
                .OrderByDescending(t => t.Members.Count)
                .ThenBy(n => n.TeamName)
                .ToList();

            List<Team> noMemberTeams =
                teams
                .Where(t => t.Members.Count == 0)
                .OrderBy(n => n.TeamName)
                .ToList();

            foreach (Team team in validTeams)
            {
                string creator = team.CreatorName;
                string teamName = team.TeamName;
                List<string> members = team.Members;

                Console.WriteLine(teamName);
                Console.WriteLine($"- {creator}");

                foreach (string member in members.OrderBy(n => n))
                {
                    Console.WriteLine($"-- {member}");
                }
            }

            Console.WriteLine("Teams to disband:");

            foreach (Team team in noMemberTeams)
            {
                Console.WriteLine(team.TeamName);
            }
        }

        private static void AddMembers(List<Team> teams, string desiredTeamToJoin, string teammateToJoin)
        {
            foreach (Team team in teams)
            {
                if (team.TeamName == desiredTeamToJoin)
                {
                    team.Members.Add(teammateToJoin);
                }
            }
        }

        private static void CreateTeams(int count, List<Team> teams)
        {
            for (int i = 0; i < count; i++)
            {
                string[] tokens = Console.ReadLine().Split(new char[] { '-' }, StringSplitOptions.RemoveEmptyEntries);

                string creatorName = tokens[0];
                string teamToCreate = tokens[1];

                Team team = new Team();

                team.CreatorName = creatorName;
                team.TeamName = teamToCreate;
                team.Members = new List<string>();

                if (teams.Any(t => t.TeamName == teamToCreate))
                {
                    Console.WriteLine($"Team {team.TeamName} was already created!");
                }
                else if (teams.Any(t => t.CreatorName == creatorName))
                {
                    Console.WriteLine($"{creatorName} cannot create another team!");
                }
                else
                {
                    teams.Add(team);
                    Console.WriteLine($"Team {team.TeamName} has been created by {team.CreatorName}!");
                }
            }
        }
    }
}
