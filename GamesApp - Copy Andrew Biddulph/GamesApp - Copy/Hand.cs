using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GamesApp
{

    /// <summary>
    /// Stores a Hand of Playing Cards
    /// The attribute it stroes is _Cards and a list of Playing Cards
    /// The Property it stores is Cards and returns a list of Playing Cards
    /// The Method it stores is AddCardToHand which adds cards to the players hand 
    /// </summary>
    class Hand
    {
        public List<PlayingCard> _Cards;

        /// <summary>
        /// read only property to get the name of the cards
        /// </summary>
        private List<PlayingCard> Cards
        { 
         get { return _Cards;}

         }
         /// <summary>
         /// read only property to get the value of the cards
         /// </summary>
        public int Count
        {
            get { return _Cards.Count; }
        }
        public Hand()
        {
            _Cards = new List<PlayingCard>();
        }

        /// <summary>
        /// Adds a card to your hand 
        /// </summary>
        /// <param name="cardsToAddHand"></param>
        public void AddCardToHand(PlayingCard cardsToAddHand)
        {
           
                _Cards.Add(cardsToAddHand);

        }

        /// <summary>
        /// Read only Property to caclculae the value of the hand and return it 
        /// Uses a loop to add value of each card to score
        /// If a face card it gives a value of 10
        /// wile aces get their value changed  depending on the score of the player
        /// </summary>
        public int Score
        {
            get
            {
                int score = 0;
                int aces = 0;
                foreach(PlayingCard card in _Cards)
                {
                    if (card.Name == CardName.Ace)
                        aces += 1;
                    switch (card.Name)
                    {
                        case CardName.Ace:
                            score += 11;
                            break;

                        case CardName.Jack:
                        case CardName.Queen:
                        case CardName.King:
                            score += 10;
                            break;

                        default:
                            score += card.Num;
                            break;
                    }
                    score = card.Num;
                    

                    
                }
                while  ((aces > 0) && (score > 21))
                    {
                    score -= 10;
                    aces -= 1;
                }
                return score;
            }
        }
    }//end of class
}// end of namespace
