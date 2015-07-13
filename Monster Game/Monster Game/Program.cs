using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monster_Game
{
    class Program
    {



        static void Main(string[] args)
        {
            int PlayerHealth = 100;
            int MonsterHealth = 100;
            String PlayerName, Action;
            string[] Monsters = "Big|Scary|Ugly".Split('|');



            Console.WriteLine("Please enter your name:");
            PlayerName = Console.ReadLine();

            int choice = new Random().Next(Monsters.Length);

            Console.WriteLine("Hello " + PlayerName + ", You will be battling " + Monsters[choice] + " monster today, are you ready? ");
            Console.WriteLine("Type an action, /(Attack or Defend/): ");


            while (PlayerHealth > 0 && MonsterHealth > 0)
            {

                Action = Console.ReadLine();
                Action = Action.ToUpper();


                if (Action == "ATTACK")
                {
                    MonsterHealth -= 20;
                    Console.WriteLine("You Attacked !. The monster health is now " + MonsterHealth + " Your Health is now" + PlayerHealth);
                    PlayerHealth -= 10;
                }

                if (Action == "DEFEND")
                {
                    MonsterHealth -= 20;
                    PlayerHealth -= 30;
                    Console.WriteLine("You Defended !. The Monsters Health is now " + MonsterHealth + " Your Health is now" + PlayerHealth);
                }

                //else Console.WriteLine("Gameover!!");
            }

            if (PlayerHealth < MonsterHealth)
            {
                Console.WriteLine("Gameover !!. " + Monsters[choice] + " won!");
            }

            else
            {
                Console.WriteLine("Gameover !!. " + PlayerName + " won!");
            }

        }

    }
}


