using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Application
{
    class AI
    {
        private int health = 8000;
        private Card[] deck = new Card[20];
        private Card[] hand = new Card[6];
        private Card[] field = new Card[5];

        public AI()
        {
            CreateDeck();
        }

        private void CreateDeck()
        {
            
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
                Random random = new Random();
                for (int i = 0; i < 20; i++)
                {

                    int randomNumber = random.Next(0, 99);
                    Card card = new Card(Convert.ToInt32(listID.ElementAt(randomNumber)), listName.ElementAt(randomNumber), Convert.ToInt32(listAtk.ElementAt(randomNumber)), Convert.ToInt32(listDef.ElementAt(randomNumber)), Convert.ToInt32(listStars.ElementAt(randomNumber)), true);
                    deck[i] = card;
                    Console.WriteLine(Convert.ToInt32(listID.ElementAt(randomNumber))+ listName.ElementAt(randomNumber)+ Convert.ToInt32(listAtk.ElementAt(randomNumber))+ Convert.ToInt32(listDef.ElementAt(randomNumber))+ Convert.ToInt32(listStars.ElementAt(randomNumber))+ true);
                }
            }
            Console.ReadLine();
        }

        private void TakeDamage(Card playerCard, Card aiCard)
        {
            if(aiCard.position == false)
            {
                health = health - playerCard.attack;
            }
        }
    }
}
