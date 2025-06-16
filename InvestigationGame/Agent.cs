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
            Sensors = new List<Sensor>();
        }

    }
}
