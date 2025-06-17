using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvestigationGame
{
    internal static class GameManager
    {
        public static void StartGame()
        {
            Console.WriteLine("Game Started!");
        }
        public static void Beginner()
        {
            Console.WriteLine("Level Beginner!");
            Console.WriteLine("Let's Get Going!");
            FootSoldier agent = new FootSoldier();
            int count = 0;
            while (!agent.Caught)
            {

                AddSensor(agent);
                agent.Uncovered();
                count++;
            }
            Console.WriteLine($"You finished after {count} times.");
                        
        }
        

        public static void AddSensor(Agent agent)
        {
            Console.WriteLine("What type of sensor would you like to put on the agent");
            Console.WriteLine("Please pick a sensor from the list below:\n" +
                "1.Thermal Sensor\n" +
                "2.Audio Sensor");
            string option = Console.ReadLine();
            Sensor sensor;
            switch (option)
            {
                case "1":
                    sensor = new ThermalSensor();
                    break;
                case "2":
                    sensor = new AudioSensor();
                    break;
                default:
                    Console.WriteLine("That was not a valid option.");
                    return;
            }
            if (agent.Weaknesses.ContainsKey(sensor.TypeOfSensor()) && agent.Weaknesses[sensor.TypeOfSensor()] > 0)
            {
                Console.WriteLine("Woo Hoo, you have found a weakness");
                agent.Sensors.Add(sensor);
                sensor.Activate();
                agent.Weaknesses[sensor.TypeOfSensor()]--;
            }
            else
            {
                Console.WriteLine("Not this time, but try again");
            }





        }


        public static void EndGame()
        {
            Console.WriteLine("Game Over!");
        }
        


    }
}
