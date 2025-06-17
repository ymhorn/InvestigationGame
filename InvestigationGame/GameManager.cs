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
        public static void Intermediate()
        {
            Console.WriteLine("Level Intermediate!");
            Console.WriteLine("Let's Get Going!");
            SquadLeader agent = new SquadLeader();
            int count = 0;
            while (!agent.Caught)
            {
                AddSensor(agent);
                agent.Uncovered();
                count++;
                if (count % 3 == 0)
                {
                    Console.WriteLine("You have reached 3 turns, we now undo a sensor");
                    UndoTurn(agent);
                }
            }
            Console.WriteLine($"You finished after {count} times.");
        }

        public static void Hard()
        {
            Console.WriteLine("Level Hard!");
            Console.WriteLine("Let's Get Going!");
            SeniorCommander agent = new SeniorCommander();
            int count = 0;
            while (!agent.Caught)
            {
                AddSensor(agent);
                agent.Uncovered();
                count++;
                if (count % 3 == 0)
                {
                    Console.WriteLine("You have reached 3 turns, we now undo 2 sensors");
                    UndoTurn(agent);
                    UndoTurn(agent);
                }
            }
            Console.WriteLine($"You finished after {count} times.");
        }

        public static void Advanced()
        {
            Console.WriteLine("Level Advanced!");
            Console.WriteLine("Let's Get Going!");
            OrganizationLeader agent = new OrganizationLeader();
            int count = 0;
            while (!agent.Caught)
            {
                AddSensor(agent);
                agent.Uncovered();
                count++;
                if (count % 3 == 0)
                {
                    Console.WriteLine("You have reached 3 turns, we now undo a sensor");
                    UndoTurn(agent);
                }
                if (count % 10 == 0)
                {
                    agent.Sensors.Clear();
                    agent.Weaknesses.Clear();
                    agent.Weaknesses = agent.GetWeaknesses();
                }
            }
            Console.WriteLine($"You finished after {count} times.");

        }

        public static void AddSensor(Agent agent)
        {
            Console.WriteLine("What type of sensor would you like to put on the agent");
            Console.WriteLine("Please pick a sensor from the list below:\n" +
                "1.Thermal Sensor\n" +
                "2.Audio Sensor\n" +
                "3.Pulse Sensor\n" +
                "4.Motion Sensor\n" +
                "5.Magnetic Sensor\n" +
                "6.Signal Sensor\n" +
                "7.Light Sensor");
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
                case "3":
                    sensor = new PulseSensor();
                    break;
                case "4":
                    sensor = new MotionSensor();
                    break;
                case "5":
                    sensor = new MagneticSensor();
                    break;
                case "6":
                    sensor = new SignalSensor();
                    break;
                case "7":
                    sensor = new LightSensor();
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

        public static void UndoTurn(Agent agent)
        {
            if (agent.Sensors.Count > 0)
            {
                Random random = new Random();
                Sensor sensor = agent.Sensors[random.Next(agent.Sensors.Count)];
                agent.Sensors.Remove(sensor);                
                agent.Weaknesses[sensor.TypeOfSensor()]++;
            }
            else
            {
                Console.WriteLine("There are no sensors to remove.");
            }
        }


        public static void EndGame()
        {
            Console.WriteLine("Game Over!");
        }
        


    }
}
