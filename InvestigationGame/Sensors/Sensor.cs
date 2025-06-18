using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvestigationGame
{
    //This is the base class for all the sensors.
    internal abstract class Sensor
    {

        //The type of sensor.
        public abstract string TypeOfSensor();

        //The method that the sensor activates.
        public abstract void Activate(Agent agent);

        //A boolean to help keep track of the sensors for certain methods.
        public bool counted = false;

    }
}
