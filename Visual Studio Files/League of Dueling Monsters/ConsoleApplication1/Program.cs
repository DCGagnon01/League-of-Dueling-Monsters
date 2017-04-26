using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Application;

namespace Application
{
    class Program
    {
        static void Main(string[] args)
        {
            AI ai = new AI();
        }
        static void Start()
        {
            Console.WriteLine("Player Turn");
            Draw();
        }
        static void Draw()
        {
            Console.WriteLine("Draw Phase");

            //Add card on top of deck to hand
            MainPhase();
        }
        static void MainPhase()
        {
            var tributeChoice = "";
            var tributeChoice2 = "";
            var summonChoice = "";
            var tribute = 0;

            Console.WriteLine("Main Phase");

            Console.WriteLine("Would you like to tribute a monster(y/n)?");
            tributeChoice = Console.ReadLine();

            if(tributeChoice == "y")
            {
                //choose a monster
                tribute = 1;
            }
            else
            {
                tribute = 0;
            }

            if(tributeChoice == "n")
            {
                goto summon;
            }
            Console.WriteLine("Would you like to tribute another monster(y/n)?");
            tributeChoice2 = Console.ReadLine();

            if(tributeChoice2 == "y")
            {
                //choose a monster
                tribute = 2;
            }
            else
            {
                tribute = 1;
            }

    summon:
            Console.WriteLine("Would you like to summon a monster(y/n)?");
            summonChoice = Console.ReadLine();

            if(summonChoice == "y")
            {
                Console.WriteLine("Please choose a monster to summon");

                if(tribute == 0)
                {
                    Console.WriteLine("You may summon a monster up to 4 stars");
                }
                if (tribute == 1)
                {
                    Console.WriteLine("You may summon a monster up to 6 stars");
                }
                if (tribute == 2)
                {
                    Console.WriteLine("You may summon any monster");
                }
                //Summon a monster
            }

            attackPhase();

        }
        static void attackPhase()
        {
            var attackChoice = "";
            Console.WriteLine("Would you like to attack this turn(y/n)?");
            attackChoice = Console.ReadLine();

            if(attackChoice ==  "y")
            {
                Console.WriteLine("Please select a target");
                //target acquisition

                endPhase();
            }

            else
            {
                endPhase();
            }
        }
        static void endPhase()
        {
            var autoKillAI = "";
            var AILP = 8000;

            Console.WriteLine("Would you like to auto kill the AI for testing purposes(y/N)?");
            autoKillAI = Console.ReadLine();

            if(autoKillAI == "y")
            {
                AILP = 0;
            }
            if(AILP <= 0)
            {
                gameoverPlayerW();
            }

            //call AI Turn
            if (AILP > 0)
            {
                Console.WriteLine("AI Turn");
            }

            Console.Read();
        }

        static void gameoverPlayerW()
        {
            Console.WriteLine("Congratulations Player, you have won!");
            Console.ReadLine();
        }
    }
}
