using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Channels;

namespace cSharpLerner
{
   public class Character
   {
       private readonly int Speed = 10;
        public int Health { get;private set;} = 100;
        public string Race{ get; private set; }
        public int Armor { get; private set; }
        public void Hit(int damage)
        {
            if (damage > Health)
            {
                damage = Health;
            }
            Health = Health+ Armor - damage;
        }

        public void PrintSpeed()
        {
            Console.WriteLine($"Speed={Speed}");
        }


        public Character(string race, int armor = 30)//Optional Parameter
        {
            this.Race = race;
            this.Armor = armor;
        }
        public Character(string race, int speed, int armor = 30)//Optional Parameter
        {
            this.Race = race;
            this.Armor = armor;
            this.Speed = speed;
        }
    }
}
