using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvestigationGame
{
    internal abstract class Sensor
    {
        protected string Type { get; set;}
        public abstract void Activate();

    }
}
