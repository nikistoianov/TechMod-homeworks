using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeamworkProjects
{
    class Program
    {
        static void Main()
        {
            List<Team> teams = new List<Team>();
            int count = int.Parse(Console.ReadLine());
            for (int i = 0; i < count; i++)
            {
                //string input = Console.ReadLine();                
                Console.WriteLine(CreateTeam(teams, Console.ReadLine()));                
            }

            string input = Console.ReadLine();
            while (input != "end of assignment")
            {
                string errMsg = "";
                if (!AppendMemberToTeam(teams, input, ref errMsg))
                {
                    Console.WriteLine(errMsg);
                }
                input = Console.ReadLine();
            }

            foreach (var team in teams.Where(x => x.Members.Count > 0).OrderByDescending(x => x.Members.Count).ThenBy(x => x.Name))
            {
                Console.WriteLine(team.Name);
                Console.WriteLine($"- {team.teamCreator}");
                foreach (var member in team.Members.OrderBy(x => x))
                {
                    Console.WriteLine($"-- {member}");
                }
            }

            Console.WriteLine("Teams to disband:");
            foreach (var team in teams.Where(x => x.Members.Count == 0).OrderBy(x => x.Name))
            {
                Console.WriteLine(team.Name);
            }

        }

        private static bool AppendMemberToTeam(List<Team> teams, string input, ref string errMsg)
        {
            string[] arr = input.Split(new char[] { '-', '>'}, StringSplitOptions.RemoveEmptyEntries);
            string member = arr[0], teamName = arr[1];
            
            int index = teams.FindIndex(delegate (Team x) { return x.Name == teamName; });
            if (index < 0)
            {
                errMsg = $"Team {teamName} does not exist!";
                return false;
            }
           
            if (
                teams.Exists(delegate (Team x) { return x.Members.IndexOf(member) > -1; }) ||
                teams.Exists(delegate (Team x) { return x.teamCreator == member; })
                )
            {               
                errMsg = $"Member {member} cannot join team {teamName}!";
                return false;
            }

            teams[index].Members.Add(member);
            return true;
        }

        private static string CreateTeam(List<Team> teams, string input)
        {
            string[] arr = input.Split('-');
            string creator = arr[0], teamName = arr[1];
            if (teams.Exists(delegate (Team x) { return x.Name == teamName; }))
            {
                return $"Team {teamName} was already created!";                
            }

            if (teams.Exists(delegate (Team x) { return x.teamCreator == creator; }))
            {
                return $"{creator} cannot create another team!";
            }

            Team team = new Team() {Name = teamName, teamCreator = creator, Members = new List<string>()};
            teams.Add(team);
            return $"Team {teamName} has been created by {creator}!";
        }
    }

    public class Team
    {
        public string Name { get; set; }
        public List<string> Members { get; set; }
        public string teamCreator { get; set; }
    }
}
