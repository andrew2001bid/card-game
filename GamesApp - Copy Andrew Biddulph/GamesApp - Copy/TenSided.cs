using System;
using System.Collections.Generic;
using System.Text;
/// <summary>
///  Class to store the Ten Sided class. it inherits the properties num and colour from the dice class and a base constructor method
/// </summary>

    class TenSidedDice  : Dice
    {
    /// <summary>
    /// overrides numproperty to allow numbers between 1 and 10
    /// </summary>
        public override int Num //2
        { 
            get { return _Num;  }   //2b
            set     //2c
            { 
                if((value > 0) && (value <= 10))    //2c - 1
                {
                    _Num = value;
                }
                else        //2c - 2
                {
                    throw new Exception("Bad number : " + value);
                }
            }
        }// end of Num

    /// <summary>
    /// overrides a base method to generate a random number between 1 and 10
    /// </summary>
        public override void GenerateNumber()
        {
            Num = random.Next(1, 10);   //changes array from 1, 6 to 1, 10 increasing the die by 4
        }// end of GenerateNumber
    /// <summary>
    /// Constructor to make tensidedDice it uses Dice method to create a base object and generate a new number between 1 and 10
    /// </summary>
    /// <param name="inColour"></param>
        public TenSidedDice(string inColour) : base(inColour)
        {
            GenerateNumber();
        }
    }// end of class
