using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvestigationGame
{
    internal class MagneticSensor: Sensor
    {
        public override string TypeOfSensor()
        {
            return "Magnetic";
        }

        //This method breaks 2 counter attacks every time a magnetic sensor is added to the agent.
        public override void Activate(Agent agent)
        {
            Console.WriteLine("Added a magnetic sensor");
            agent.BreakAttack += 2;

        }
            
    }
    
}
