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
        public override void Activate(Agent agent)
        {
            Console.WriteLine("Added a magnetic sensor");
            agent.BreakAttack += 2;

        }
            
    }
    
}
