using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvestigationGame
{
    internal abstract class Agent
    {
        public Dictionary<string , int> Weaknesses { get; set; }
        public List<Sensor> Sensors { get; set; }
        public int Rank { get; set; }
        public bool Caught { get; set; }
        public Agent(int rank)
        {
            this.Rank = rank;
            this.Caught = false;
            this.Weaknesses = GetWeaknesses();
            this.Sensors = new List<Sensor>();
        }
        public void Uncovered()
        {
            int uncovered = Sensors.Count;

            Console.WriteLine($"So far {uncovered}/{Rank} uncovered.");

            if (uncovered >= Rank)
            {
                Console.WriteLine("WOW you have uncovered the agent!!");
                this.Caught = true;
            }

        }
        public Dictionary<string, int> GetWeaknesses()
        {
            List<string> weaknessList = new List<string>();
            Random random = new Random();
            for (int i = 0; i < Rank; i++)
            {
                weaknessList.Add(WeaknessOptions.WeaknessList[random.Next(WeaknessOptions.WeaknessList.Count)]);
            }
            Dictionary<string, int> weaknesses = new Dictionary<string, int>();
            foreach (string weakness in weaknessList)
            {
                if (weaknesses.ContainsKey(weakness))
                {
                    weaknesses[weakness]++;
                }
                else
                {
                    weaknesses.Add(weakness, 1);
                }
            }
            return weaknesses;

        }

    }
}
