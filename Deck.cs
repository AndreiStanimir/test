using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack
{
    class Deck
    {
        public List<int> groupsOfCards;
        int nrPacks;
        public int numberOfCards=0;
        Deck(int packs)
        {
            groupsOfCards.Add(0);
            for (int i = 1; i <= 9; i++)
            {
                groupsOfCards.Add(packs * 4);
            }
            // Add 10s 
            groupsOfCards.Add(packs * 4 * 4);
            numberOfCards = packs * 52;
        }

        void Shuffle()
        {

        }
    }
}
