using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Application
{
    class Player
    {
        private int health;
        private Card[] deck;     /*<--THIS WILL NEED TO BE SET TO A SIZE OF 20*/
        private const int deckSize = 20;
        private Card[] hand;
        private int currentCard;
        private System.Random randomNum;
        public int stop;

        public Player()
        {
            /*INTIALIZE PLAYER VARIABLES AND ASSETS*/
            CreateDeck();
        }


        private void CreateDeck()
        {
            /*Creates an array of type Card
             Pulls from external array to be stored in Unity assets, so that hollow lens can find it
             */
            

            /*This will just fill the array with cards when it comes time just pass a card from the array as a parameter
             * to change the card on the field
             * 
             * ex:      *Search deck for specific card position
             *          GenericFunctionCall(deck[CARD POSITION])
             */
            using (var fs = File.OpenRead(@"C:\League of Dueling Monsters Database.csv"))   /*THIS FILE OPENER WILL NOT WORK ON HOLOLENSE, THIS IS FOR TESTING ONLY*/
            using (var reader = new StreamReader(fs))
            {
                List<string> listID = new List<string>();
                List<string> listName = new List<string>();
                List<string> listStars = new List<string>();
                List<string> listAtk = new List<string>();
                List<string> listDef = new List<string>();

                while (!reader.EndOfStream)
                {
                    var line = reader.ReadLine();
                    var values = line.Split(',');

                    listID.Add(values[0]);
                    listName.Add(values[1]);
                    listStars.Add(values[2]);
                    listAtk.Add(values[3]);
                    listDef.Add(values[4]);
                }

                Console.WriteLine("{0,-10}{1,-50}{2,-10}{3,-10}{4,-10}", "ID", "Name", "Stars", "Attack", "Defence" + "\n");
                for (int i = 0; i < 100; i++)
                {
                    Console.WriteLine("{0,-10}{1,-50}{2,-10}{3,-10}{4,-10}", listID[i], listName[i], listStars[i], listAtk[i], listDef[i]);
                }
                Console.ReadLine();
            }
        }

        private void TakeDamage()
        {
            /*Get attacking monsters attack damage and subtract it from the total health*/
        }

        private void DrawCard()
        {
            /*Pull a random card out of the deck and insert it into the players hand and then remove it from the deck that it was taken from*/
        }


    }


}
