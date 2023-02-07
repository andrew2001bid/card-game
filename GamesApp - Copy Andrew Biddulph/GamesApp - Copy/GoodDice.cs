using System;
using System.Collections.Generic;
using System.Text;

/// <summary>
///  this class stores dice 
///  it has 2 properites num and colour 
/// </summary>
    class Dice
    {
        protected int _Num;   //1
        protected string _Colour;
        public virtual int Num      //2
        {
            get { return _Num;  }  //2a
            set     //2b
            {
                if ((value > 0) && (value <= 6))    //2b-1
                {
                    this._Num = value;
                }
                else
                {
                    throw new Exception("Bad number : " + value); //2b-2
                }
            }
        }// end of Num
        public string Colour        //3
        {
            get     //3a
            {
                return _Colour;
            }
            set     //3b
            {
                if ((value.Length > 0) && (value.Length <= 10))     //3b-1
                {
                    this._Colour = value;
                }
                else    //3b-2
                {
                    throw new Exception("Bad number : " + value);
                }
            }
        }// end of colour

    /// <summary>
    /// this is the default dice constructor that populatesa dice objects with Num and colour of black
    /// 
    /// </summary>
        public Dice()   //4
        {
            Num = 1;
            
        }// end of dice constructor

    /// <summary>
    /// populates a dice object with passed inNum and inColour values
    /// </summary>
    /// <param name="inNum"></param>
    /// <param name="inColour"></param>
        public Dice(int inNum, string inColour)     //5
        {
            Num = inNum;
            Colour = inColour;
        }// end of Dice
        protected static Random random = new Random();      //6

    /// <summary>
    /// generates a random number between 1 and 6 
    /// </summary>
        public virtual void GenerateNumber()    //6b
        {
            Num = random.Next(1, 6);    //6c
        }// end of GenerateNumber
        public Dice(string colour)  //8
        {
            GenerateNumber();
            Colour = colour;
        }// end of colour

    /// <summary>
    /// overrides toString Method to sescribe the dice object 
    /// </summary>
    /// <returns></returns>
        public override string ToString()   //9
        {
            return this.Colour + " " + this.Num;
        }// end of ToString
    }// end of class

