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
        public Agent(int rank)
        {
            Rank = rank;
            List<string> weaknessList = new List<string>();
            Random random = new Random();
            for (int i = 0; i < Rank; i++)
            {
                weaknessList.Add(WeaknessOptions.WeaknessList[random.Next(WeaknessOptions.WeaknessList.Count)]);            
            }

            Weaknesses = new Dictionary<string, int>();

            foreach (string weakness in weaknessList)
            {
                if (Weaknesses.ContainsKey(weakness))
                {
                    Weaknesses[weakness] ++;
                }
                else
                {
                    Weaknesses.Add(weakness, 1);
                }
            }
            Sensors = new List<Sensor>();
        }

    }
}
