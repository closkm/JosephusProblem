using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JosephusProblem
{
    internal class Game
    {
        private List<int> positions = new List<int>();
        private List<string> printable = new List<string>();
        private int killingInterval;
        private int numberOfPeople;
        int positionInCircle = 1;
        int roundCounter = 1;

        public Game(int killingInterval, int numberOfPeople)
        {
            this.killingInterval = killingInterval;
            this.numberOfPeople = numberOfPeople;
            for (int i = 0; i <= numberOfPeople -1; i++)
            {
                positions.Add(i + 1);
            }
        }

        public void LastPersonStanding()
        {
            while(positions.Count > 1)
            {
                for (int i = 0; i < positions.Count; i++)
                {
                    if (positionInCircle % killingInterval == 0)
                    {
                        printable.Add($"({positions[i]})");
                        positions.RemoveAt(i);
                        positionInCircle++;
                        i--;
                    }
                    else
                    {
                        printable.Add($"{positions[i]}");
                        positionInCircle++;
                    }
                }
                    Console.WriteLine($"Round {roundCounter}: {string.Join(" ", printable)}");
                    printable.Clear();
                    roundCounter++;
            }
                    Console.WriteLine($"The winner is {string.Join("", positions)} at round {roundCounter}");
        }
    }
}
