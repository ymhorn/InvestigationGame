using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvestigationGame
{
    internal class Player
    {
        public string Name { get;}
        public string UserName { get; }
        public int Age { get; }
        public string Password { get; }

        public Player(string name, string userName, int age,string password)
        {
            this.Name = name;
            this.UserName = userName;
            this.Age = age;
            this.Password = password;
        }


    }
}
