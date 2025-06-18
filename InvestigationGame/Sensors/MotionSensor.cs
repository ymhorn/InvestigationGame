using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvestigationGame
{
    internal class MotionSensor: Sensor
    {
        public override string TypeOfSensor()
        {
            return "Motion";
        }

        // This method causes the player to lose if he has to add more then 3 motion sensors.
        public override void Activate(Agent agent)
        {
            Console.WriteLine("Added a motion sensor.");
            int count = 0;
            foreach (Sensor sensor in agent.Sensors)
            {
                if (sensor.TypeOfSensor() == "Motion" && !sensor.counted)
                {
                    count++;
                }
            }
            if (count >=3)
            {
                Console.WriteLine("Sorry you now have added 3 motion sensors, try again next time.");
                this.counted = true;                
            }



        }
    }    
}
