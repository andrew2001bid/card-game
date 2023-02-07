using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GamesApp
{

    /// <summary>
    /// this class stores the properties such as _Cards and the shuffle method allowing the cards to be in a random order to allow for games to be played such as blackjack 
    /// </summary>
    class Deck
    {
        
        public List<PlayingCard> _Cards;
        private Random randomiser = new Random();


        /// <summary>
        /// read only properly to rerunt the cards
        /// </summary>
        public List<PlayingCard> Cards
        { get { return _Cards; } 
        }
        /// <summary>
        /// this puts the card into a deck so they can be shuffled and dealt into hands
        /// </summary>
        public Deck()
        {
           

            
             _Cards = new List<PlayingCard>();

                for (CardSuit suit = CardSuit.Spades; suit <= CardSuit.Hearts; suit++)
                    for (CardName name = CardName.Ace; name <= CardName.King; name++)
                    {
                        _Cards.Add(new PlayingCard(suit, name));
                    }
                this.Shuffle();
            

        }//end constructor

        public PlayingCard Deal()
        {
            int index = _Cards.Count - 1;
            PlayingCard CardsToDeal = _Cards[index];
            _Cards.RemoveAt(index);
            return CardsToDeal;
        }
        /// <summary>
        /// 
        /// this adds the cards value together
        /// </summary>
        /// <param name="cardsToAdd"></param>
        public void Add(PlayingCard cardsToAdd)
        {
            if (_Cards.Contains(cardsToAdd) == false)
                _Cards.Add(cardsToAdd);

        }
        /// <summary>
        /// 
        /// this counts the amount of cards and takes one away evrey time it is drawn from the deck 
        /// </summary>
        public int Count
        {
            get { return _Cards.Count; }
        }
        /// <summary>
        /// shuffle randomises the cards so that the games can be played such as blackjack
        /// </summary>
        public void Shuffle()
        {
            List<PlayingCard> newCards = new List<PlayingCard>();
            int numItems = _Cards.Count;
            while (_Cards.Count> 0) // use this for breakpoints pass criteras ochange to = 0 for proof
            {
                int CardToMove = randomiser.Next(_Cards.Count);
                newCards.Add(_Cards[CardToMove]);
                _Cards.RemoveAt(CardToMove);
            }
            _Cards = newCards;

        }
        /// <summary>
        /// This takes cards from the deck and places them in your hand 
        /// </summary>
        /// <param name="cardsToAddHand"></param>
        public void AddCardToHand(PlayingCard cardsToAddHand)
        {

            _Cards.Add(cardsToAddHand);

        }

    }// end of class
}// end of namespace
