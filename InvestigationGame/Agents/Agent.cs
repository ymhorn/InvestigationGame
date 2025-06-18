using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvestigationGame
{
    //This is the base class for all the agents.
    internal abstract class Agent
    {
        //A dictionary to hold the weaknesses of the agent.
        public Dictionary<string , int> Weaknesses { get; set; }

        //A list to hold the sensors that are placed on the agent.
        public List<Sensor> Sensors { get; set; }

        //The rank of the agent.
        public int Rank { get; set; }

        //A boolean to check if the agent has been caught.
        public bool Caught { get; set; }

        //This holds the number of times that the agent cannot counter attack.
        public int BreakAttack { get; set; }

        //Agent constructor.
        public Agent(int rank)
        {
            this.BreakAttack = 0;
            this.Rank = rank;
            this.Caught = false;
            this.Weaknesses = GetWeaknesses();
            this.Sensors = new List<Sensor>();
        }

        //A method that checks what the player has uncovered so far.
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

        //The random dictionary of weaknesses builder.
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
