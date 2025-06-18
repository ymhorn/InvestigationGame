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
            //This actually runs the game.
            GameManager.StartGame();
            Console.WriteLine("Pick a level\n" +
                "1.Beginner\n" +
                "2.Intermediate\n" +
                "3.Hard\n" +
                "4.Advanced");
            string level = Console.ReadLine();
            switch (level)
            {
                case "1":
                    GameManager.Beginner();
                    break;
                case "2":
                    GameManager.Intermediate();
                    break;
                case "3":
                    GameManager.Hard();
                    break;
                case "4":
                    GameManager.Advanced();
                    break;
                default:
                    Console.WriteLine("Invalid level selected. Please try again.");
                    break;
            }
            GameManager.EndGame();
        }
    }
}
