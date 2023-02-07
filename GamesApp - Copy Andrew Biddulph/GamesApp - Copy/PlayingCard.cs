using System;
using System.Collections.Generic;
using System.Text;

/// <summary>
/// this contains the Suit for the Cards used in games such as BlackJack
/// </summary>
    public enum CardSuit
    {
        Spades, Clubs, Diamonds, Hearts,
    }
/// <summary>
/// This contains the Value and name for the cards and can be used in things such as Wild Eight
/// </summary>
    enum CardName
    {
        Ace = 1, Two = 2, Three = 3, Four = 4, Five = 5, Six = 6, Seven = 7, Eight = 8, Nine = 9, Ten = 10, Jack = 11, Queen = 12, King = 13,
    }

/// <summary>
/// This is the playing card, it inherits some properties from the dice class such as num property.
/// It contains the properties to play the High and Low Cards Games
/// </summary>
class PlayingCard : Dice
    {
        public CardSuit Suit { get; set; }
        public CardName Name { get; set; }

        public override int Num 
        { 
            get { return _Num; }
            set
            {
                if((value > 0 ) && (value <= 13))
                {
                    _Num = value;
                }
                else
                {
                    throw new Exception("Bad number : " + value);
                }
            }
        }

    /// <summary>
    /// this generates a number between 1 and 13
    /// </summary>
        public override void GenerateNumber()
        {
            Num = random.Next(1, 13);
        }

    /// <summary>
    /// this stores properites about the dice and cards to know things such as how much it is worth
    /// </summary>
    /// <returns></returns>
        public override string ToString()
        {
            return this.Colour + " " + this.Name + " worth " + this.Num + " points";
        }

    /// <summary>
    /// these classes below store infomation about the cards such as the value of the card and what suit it is in 
    /// </summary>
    /// <param name="inNum"></param>
    /// <param name="inColour"></param>
    /// <param name="inSuit"></param>
    /// <param name="inName"></param>
        public PlayingCard(int inNum, string inColour, CardSuit inSuit, CardName inName) : base(inNum, inColour)
        {
            Suit = inSuit;
            Name = inName;
    } /// <summary>
      /// these classes below store infomation about the cards such as the value of the card and what suit it is in 
      /// </summary>
    public PlayingCard(int inNum, string inColour, CardSuit inSuit) : base(inNum, inColour)
        {
            Suit = inSuit;
            Name = (CardName)inNum;
        }

    /// <summary>
    /// these classes below store infomation about the cards such as the value of the card and what suit it is in 
    /// </summary>
    public PlayingCard(string inColour, CardSuit inSuit) : base(inColour)
        {
            GenerateNumber();
            Suit = inSuit;
            Name = (CardName)base.Num;
        }

    /// <summary>
    /// these classes below store infomation about the cards such as the value of the card and what suit it is in 
    /// </summary>
    public PlayingCard(CardSuit suit, int value)
    {
        Suit = suit;
        Num = value;
        Name = (CardName)value;
    }

    /// <summary>
    /// these classes below store infomation about the cards such as the value of the card and what suit it is in 
    /// </summary>
    public PlayingCard(CardSuit suit, CardName name)
    {
        Suit = suit;
        Name = name;
        Num = (int)name;
    }
        
}

