using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvestigationGame
{
    internal class ThermalSensor:Sensor
    {
        public override string TypeOfSensor()
        {
            return "Thermal";
        }

        // This method provides a hint about one of the agent's weaknesses.
        public override void Activate(Agent agent)
        {
            Console.WriteLine("Added a thermal sensor.");
            Random random = new Random();
            List<string> weaknesses = new List<string>();
            foreach (var weakness in agent.Weaknesses)
            {
                if (weakness.Value > 0)
                {
                    weaknesses.Add(weakness.Key);
                }
            }
            string weak = weaknesses[random.Next(weaknesses.Count)];
            Console.WriteLine($"Hint: 1 of the weaknesses are {weak}");    
        }
    }
}
