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
        public override void Activate(Agent agent)
        {
            Console.WriteLine("Added a thermal sensor.");
            Random random = new Random();
            string weakness = agent.Weaknesses.Keys.ElementAt(random.Next(agent.Weaknesses.Count));
            Console.WriteLine($"Hint: 1 of the weaknesses are {weakness}");    
        }
    }
}
