using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
//using UnityEngine;

/*
 * This class will be used to make all cards from it, just make a new object of this class
 * Have it set the image to defence (sideways) or attack (rightside up)
 * In unity attach a material to the object to set its image
 * 
 */
namespace Application
{
    public class Card
    {
        private string name;
        private int attack;
        private int defence;
        private int stars;
        private int ID;
        private bool position;

        public Card(int _ID, string _Name, int _Attack, int _Defence, int _Stars, bool _Position)
        {
            ID = _ID;
            name = _Name;
            attack = _Attack;
            defence = _Defence;
            stars = _Stars;
            position = _Position;
        }

        public void OnClick()
        {
            /*On click bring up menu - Attack, Switch mode, Sacrifice? */
        }
    }
}
