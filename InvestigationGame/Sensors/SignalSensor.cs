using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvestigationGame
{
    internal class SignalSensor:Sensor
    {
        public override string TypeOfSensor()
        {
            return "Signal";
        }

        // This method provides the agent's sensor slots.
        public override void Activate(Agent agent)
        {
            Console.WriteLine("Added a signal sensor.");
            Console.WriteLine($"FYO The agent you are playing with has {agent.Rank} sensor slots");
        }
    }
}
