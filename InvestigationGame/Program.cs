using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvestigationGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            FootSoldier soldier = new FootSoldier();
            foreach(string abc in soldier.Weaknesses.Keys)
            {
                Console.WriteLine(abc);
            }
        }
    }
}
