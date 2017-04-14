using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application
{
    class Field
    {
        Player player = new Player();   /*NEED TO ATTACH PROPER ASSETS IN THE PLAYER CLASS FILE*/
        AI ai = new AI();               /*NEED TO ATTACK PROPER ASSETS IN THE AI CLASS FILE*/

        private void StartPhase()
        {

        }

        private void MainPhase()
        {

        }

        private void AttackPhase()
        {

        }

        private void EndPhase()
        {

        }

        private void Sacrifice(Card _selectedCard1, Card _selectedCard2)    /*THE SECOND CARD MAY BE OF NULL VALUE, MEANING ONLY ONE CARD IS SACRIFICED*/
        {

        }

        private void Summon(Card _selectedCard)     /*MAY HAVE A NULL VALUE, MEANING THEY DID NOT WANT TO SUMMON*/
        {

        }
    }
}
