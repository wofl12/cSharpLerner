using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Channels;

namespace cSharpLerner
{
   public class Character
   {
       private static int Speed = 10;
        private int health=100;
       public void Hit(int damage)
        {
            if (damage > health)
            {
                damage = health;
            }
            Health -= damage;
        }

       public int Health { get; private set; } = 100;


       public void PrintSpeed()
        {
            Console.WriteLine($"Speed={Speed}");
        }

        public void IncreseSpeed()
        {
            Speed += 10;
        }
    }
}
