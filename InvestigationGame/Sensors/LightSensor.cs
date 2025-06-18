using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvestigationGame
{
    internal class LightSensor:Sensor
    {
        public override string TypeOfSensor()
        {
            return "Light";
        }

        // This method provides the agent's sensor slots and lists the sensors attached to the agent.
        public override void Activate(Agent agent)
        {
            Console.WriteLine("Added a light sensor.");
            Console.WriteLine($"FYO The agent you are playing with has {agent.Rank} sensor slots");
            string sensors = "";
            foreach (Sensor sensor in agent.Sensors)
            {
                sensors += $"{sensor.TypeOfSensor()} sensor, ";
            }
            Console.WriteLine($"AND so far the sensors attached to him are {sensors}.");
        }
    }
  
}
