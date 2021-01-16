using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _4._Teamwork_Projects
{
    class Program
    {
        static void Main(string[] args)
        {
            int teamCount = int.Parse(Console.ReadLine());

            List<Team> teams = new List<Team>();

            for (int i = 0; i < teamCount; i++)
            {
                string[] newTeam = Console.ReadLine().Split("-");

                string creatorName = newTeam[0];
                string teamName = newTeam[1];

                Team team = new Team(teamName, creatorName);

                bool isNameTeamExist = teams.Select(a => a.TeamName).Contains(teamName);
                bool isCreatorNameExist = teams.Select(a => a.CratorName).Contains(teamName);

                if (!isNameTeamExist)
                {
                    if (!isCreatorNameExist)
                    {
                        teams.Add(team);
                        Console.WriteLine($"Team {teamName} has been created by {creatorName}!");
                    }
                    else
                    {
                        Console.WriteLine($"{creatorName} cannot create another team!");
                    }

                }
                else
                {
                    Console.WriteLine($"Team {teamName} was already created!");
                }
            }

            string teamMembers = Console.ReadLine();

            while (teamMembers != "end of assignment")
            {
                string[] cmdArg = teamMembers.Split(new char[] { '-', '>' });
                string newUser = cmdArg[0];
                string teamNames = cmdArg[1];

                bool isTeamExist = teams.Select(a => a.TeamName).Contains(teamNames);
                bool isCreatorExist = teams.Select(a => a.CratorName).Contains(newUser);
                bool isMemberExist = teams.Select(a => a.Member).Any(a => a.Contains(newUser));

                if (!isTeamExist)
                {
                    Console.WriteLine($"Team {teamNames} does not exist!");
                }
                else if (isCreatorExist || isMemberExist)
                {
                    Console.WriteLine($"Member {newUser} cannot join team {teamNames}!");
                }
                else
                {
                    int index = teams.FindIndex(a => a.TeamName == teamNames);
                    teams[index].Member.Add(newUser);
                }

                teamMembers = Console.ReadLine();
            }

            Team[] teamsToDisbaunt = teams.OrderBy(a => a.TeamName).Where(a => a.Member.Count == 0).ToArray();

            Team[] fullTeam = teams.OrderByDescending(a => a.Member.Count).ThenBy(a => a.TeamName).Where(a => a.Member.Count > 0).ToArray();

            StringBuilder sb = new StringBuilder();

            foreach (Team team in fullTeam)
            {
                sb.AppendLine($"{team.TeamName}");

                 sb.AppendLine($"{team.CratorName}");

                foreach (var member in team.Member.OrderBy(a=>a))
                {
                    sb.AppendLine($"-- {member}…");
                }

                sb.AppendLine("Teams to disband:");

                foreach (Team item in teamsToDisbaunt)
                {
                    sb.AppendLine(item.TeamName);
                }
            }

            Console.WriteLine(sb.ToString());
        }
    }

    class Team
    {
        public Team(string teamName, string cratorName)
        {
            TeamName = teamName;
            CratorName = cratorName;
            Member = new List<string>();
        }

        public string TeamName { get; set; }
        public string CratorName { get; set; }
        public List<string> Member { get; set; }


    }
}
