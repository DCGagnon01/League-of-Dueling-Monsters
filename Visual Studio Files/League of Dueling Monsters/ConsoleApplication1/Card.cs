using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
//using UnityEngine;



public class Card
{
    private string name;
    private string type;
    private int atk;
    private int def;
    private int summonCost;
    private int ID;

    public Card(string cardName, string cardType, int cardAtk, int cardDef, int cardCost, int cardID)
        {
        name = cardName;
        type = cardType;
        atk = cardAtk;
        def = cardDef;
        summonCost = cardCost;
        ID = cardID;

    }



    public override string ToString()
    {
        return name + " a " + type + " card.";
    }





}

