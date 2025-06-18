using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvestigationGame
{
    internal class AudioSensor:Sensor
    {
        public override string TypeOfSensor()
        {
            return "Audio";
        }

        //This method does not do anything special.
        public override void Activate(Agent agent)
        {
            Console.WriteLine("Added a audio sensor.");
        }

    }
}
