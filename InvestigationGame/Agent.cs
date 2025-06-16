using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvestigationGame
{
    internal class Agent
    {
        public Dictionary<string , int> Weaknesses { get; set; }
        public List<Sensors> Sensors { get; set; }

        public Agent(List<string> weaknesses)
        {
            Weaknesses = new Dictionary<string, int>();
            foreach (string weakness in weaknesses)
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
            Sensors = new List<Sensors>();
        }

    }
}
