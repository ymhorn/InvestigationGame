using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvestigationGame
{
    //A class that holds the weakness options for the agents.
    internal static class WeaknessOptions
    {
        //A list of weakness options that can be had by the agents.
        public static List<string> WeaknessList = new List<string>
        {
            "Thermal",
            "Audio",
            "Pulse",
            "Motion",
            "Signal",
            "Magnetic",
            "Light"
        };
    }
}
