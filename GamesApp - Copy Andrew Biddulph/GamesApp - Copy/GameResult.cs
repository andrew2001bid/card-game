using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/// <summary>
/// Class to Store the Game Results Class. It holder the detials for finding out the game results such as the player and computer score 
/// there are public so other classes can access them
/// </summary>
    class GameResult
    {
        
        private string _GameName;
        private int _PlayerScore;
        private int _ComputerScore;
        private string _Winner;
    private string _PlayerName;

    /// <summary>
    /// a property that fetches the GameName so it can be used somewhere else
    /// </summary>
        public string GameName
        {
            get { return _GameName; }
            set { this._GameName = value; }
        }
    /// <summary>
    /// a property that fetches the PlayerScore so it can be used somewhere else
    /// </summary>
    public int PlayerScore
        {
            get { return _PlayerScore;}
            set { this._PlayerScore = value; }
        }
    /// <summary>
    /// a property that fetches the ComputerScore so it can be used somewhere else
    /// </summary>
    public int ComputerScore
        {
            get { return _ComputerScore; }
            set { this._ComputerScore = value; }
        }
    /// <summary>
    /// a property that fetches the Winner so it can be used somewhere else
    /// </summary>
    public string Winner
        {
            get { return _Winner; }
            set { this._Winner = value;  }
        }
    /// <summary>
    /// a property that fetches the PlayerName so it can be used somewhere else
    /// </summary>
    public string PlayerName
    {
        get { return _PlayerName; }
        set { this._PlayerName = value; }
    }

    public GameResult()
    {
        


    }// end contstructo
    /// <summary>
    /// this provides a message saying who won and on what game 
    /// </summary>
    public GameResult(string gameName, int playerScore, int comuterScore, string playerName)
        {
            GameName = gameName;
        PlayerScore = playerScore;
        ComputerScore = comuterScore;
        PlayerName = playerName;
        
                
                if (playerScore > ComputerScore)
            {
                Winner = playerName;
            }
                else if (playerScore < comuterScore)
            {
                Winner = "Computer wins";
            }
            else
            {
                Winner = "Draw";
            }

                
        }// end contstructor
    /// <summary>
    /// this provides a message saying who won and on what game 
    /// </summary>
    /// <returns></returns>
        public override string ToString()
        {
            return $" In {GameName}{Winner} wins as they scored as the player scored {PlayerScore} and the computer scored {ComputerScore}";
        }
    }//end of class
   
