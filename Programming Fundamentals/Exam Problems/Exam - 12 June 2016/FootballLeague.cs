using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootballLeague
{
    class FootballLeague
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> teamsByScore = new Dictionary<string, int>();
            Dictionary<string, int> teamsByGoals = new Dictionary<string, int>();

            string decryptionKey = Console.ReadLine();

            string inputLine = Console.ReadLine();

            while (!inputLine.Equals("final"))
            {
                string[] elements = inputLine.Split();

                string firstElement = elements[0];
                string secondElement = elements[1];
                string thirdElement = elements[2];

                int firstTeamStartIndex = firstElement.IndexOf(decryptionKey);
                int offset = firstTeamStartIndex + decryptionKey.Length;
                firstElement = firstElement.Substring(offset, firstElement.Length - offset);
                int firstTeamEndIndex = firstElement.IndexOf(decryptionKey);
                string firstTeamName = firstElement.Substring(0, firstTeamEndIndex);

                int secondTeamStartIndex = secondElement.IndexOf(decryptionKey);
                offset = secondTeamStartIndex + decryptionKey.Length;
                secondElement = secondElement.Substring(offset, secondElement.Length - offset);
                int secondTeamEndIndex = secondElement.IndexOf(decryptionKey);
                string secondTeamName = secondElement.Substring(0, secondTeamEndIndex);

                int[] teamScores = thirdElement.Split(':').Select(int.Parse).ToArray();

                char[] firstReversed = firstTeamName.ToCharArray();
                char[] secondReversed = secondTeamName.ToCharArray();

                Array.Reverse(firstReversed);
                Array.Reverse(secondReversed);

                firstTeamName = string.Join("", firstReversed).ToUpper();
                secondTeamName = string.Join("", secondReversed).ToUpper();

                if (!teamsByScore.ContainsKey(firstTeamName))
                {
                    teamsByScore.Add(firstTeamName, 0);
                    teamsByGoals.Add(firstTeamName, 0);
                }

                if (!teamsByScore.ContainsKey(secondTeamName))
                {
                    teamsByScore.Add(secondTeamName, 0);
                    teamsByGoals.Add(secondTeamName, 0);
                }

                teamsByGoals[firstTeamName] += teamScores[0];
                teamsByGoals[secondTeamName] += teamScores[1];

                if (teamScores[0] > teamScores[1])
                {
                    teamsByScore[firstTeamName] += 3;
                }
                else if (teamScores[0] < teamScores[1])
                {
                    teamsByScore[secondTeamName] += 3;
                }
                else
                {
                    teamsByScore[firstTeamName]++;
                    teamsByScore[secondTeamName]++;
                }

                inputLine = Console.ReadLine();
            }

            Console.WriteLine("League standings:");

            int count = 1;

            var sortedByScore = teamsByScore.OrderByDescending(team => team.Value).ThenBy(team => team.Key);
            var sortedByGoals = teamsByGoals.OrderByDescending(team => team.Value).ThenBy(team => team.Key).Take(3);

            foreach (var team in sortedByScore)
            {
                Console.WriteLine("{0}. {1} {2}", count, team.Key, team.Value);
                count++;
            }

            Console.WriteLine("Top 3 scored goals:");

            foreach (var team in sortedByGoals.OrderByDescending(team => team.Value)
                )
            {
                Console.WriteLine("- {0} -> {1}", team.Key, team.Value);
            }
        }
    }
}