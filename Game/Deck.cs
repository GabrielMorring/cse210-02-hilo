using System;

namespace Game
{
    public class Deck
    {
        public List<int> cards;
       

        public Deck()
        {
            cards = new List<int>();
            GenerateDeck();
            Shuffle();
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

        public void Shuffle()
        {
            Random rnd = new Random();
            for (int i = 0; i < cards.Count(); i++)
            {
                int item = cards[0];
                cards.RemoveAt(0);
                int spot = rnd.Next(0, cards.Count());
                cards.Insert(spot, item); 
            }
        }

        public void Reset()
        {
            cards.Clear();
            GenerateDeck();
        }
    }

}