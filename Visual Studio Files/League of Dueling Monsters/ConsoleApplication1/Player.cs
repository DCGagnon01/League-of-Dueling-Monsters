using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application
{
    class Player
    {
        private int health;
        private Card[] deck;     /*THIS WILL NEED TO BE SET TO A SIZE OF 20*/
        private Card[] hand;

        public Player()
        {
            /*INTIALIZE PLAYER VARIABLES AND ASSETS*/
            CreateDeck();
        }


        private void CreateDeck()
        {
            /*Creates an array of type Card*/

            /*This will just fill the array with cards when it comes time just pass a card from the array as a parameter
             * to change the card on the field
             * 
             * ex:      *Search deck for specific card position
             *          GenericFunctionCall(deck[CARD POSITION])
             */

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
