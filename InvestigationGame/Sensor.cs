using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvestigationGame
{
    internal abstract class Sensor
    {
        public abstract string TypeOfSensor();
        public abstract void Activate();

    }
}
