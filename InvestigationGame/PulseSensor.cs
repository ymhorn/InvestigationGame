using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace InvestigationGame
{
    internal class PulseSensor : Sensor
    {
        public override string TypeOfSensor()
        {
            return "Pulse";
        }
        public override void Activate(Agent agent)
        {
            Console.WriteLine("Added a pulse sensor.");
            int count = 0;
            foreach (Sensor sensor in agent.Sensors)
            {
                if (sensor.TypeOfSensor() == "Pulse" && !sensor.counted)
                {
                    count++;

                }
            }
            if (count >=3)
            {
                Console.WriteLine("You have now added 3 Pulse sensors, we will now remove 1 of them.");

                Sensor sensor = new PulseSensor();
                agent.Sensors.Remove(sensor);
                agent.Weaknesses[sensor.TypeOfSensor()]++;
                foreach (Sensor s in agent.Sensors)
                {
                    if (s.TypeOfSensor() == "Pulse" && !s.counted)
                    {
                        s.counted = true;
                    }
                }
            }
             
        }
       
    }     
}
