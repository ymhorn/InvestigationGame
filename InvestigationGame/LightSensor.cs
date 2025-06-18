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
        public override void Activate(Agent agent)
        {
            
        }
    }
  
}
