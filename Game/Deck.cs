using System;

namespace Game
{
    public class Deck
    {
        List<int> cards = new List<int>();
       

        public Deck()
        {
            GenerateDeck();
        }

        public void GenerateDeck()
        {
            for (int i = 0; i < 4; i++)
            {
                for (int j = 1; j <= 13; j++)
                {
                    cards.Add(j);
                }
            }
      
        }

        public void AddCard(int card)
        {        
            cards.Add(card);
        }
        
        public void RemoveCard(int i)
        {
            cards.RemoveAt(i);
        }

        // public void Shuffle()
        // {
        // }

        public void Reset()
        {
            cards.Clear();
            GenerateDeck();
        }
    }

}