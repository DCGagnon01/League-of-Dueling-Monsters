using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
//using UnityEngine;
using System.IO;

public class Deck
{
    private int currentCard;
    private const int deckSize = 20;
    private System.Random randomNum;
    public int stop;

    public Deck()
    {
        //read in ethan database info
        using (var fs = File.OpenRead(@"C:\League of Dueling Monsters Database.csv"))
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
                for (int i=0; i < 100; i++)
                {
                    Console.WriteLine("{0,-10}{1,-50}{2,-10}{3,-10}{4,-10}", listID[i], listName[i], listStars[i], listAtk[i], listDef[i]);
                }
            Console.ReadLine();
        }
        





    }
}
