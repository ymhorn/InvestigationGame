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
        public override void Activate()
        {
            
        }
    }
}
