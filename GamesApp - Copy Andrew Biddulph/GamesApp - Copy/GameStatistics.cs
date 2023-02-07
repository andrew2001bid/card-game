using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/// <summary>
/// Class to create GameStatistics. it displays and returns the game results form the game. details like who won a certain amount of games 
/// </summary>
    class GameStatistics
    {
        private List<GameResult> _gameResults;


    /// <summary>
    /// this is a read only property that reutns the game results
    /// </summary>
        public List<GameResult> GameResults
        {
           get { return _gameResults; }
        }
    /// <summary>
    /// this adds the resuults un so it can display things such as percentage of wins 
    /// </summary>
    /// <param name="ResultToAdd"></param>
    public void Add(GameResult ResultToAdd)
    {
        
            _gameResults.Add(ResultToAdd);
    }
        public int Count { get { return _gameResults.Count; } }
        public GameStatistics()
        {
            _gameResults = new List<GameResult>();
        }
    /// <summary>
    /// this calculates the average score statistic
    /// </summary>
    /// <returns></returns>
    public decimal CalculateAverageScore()
        { 
            decimal average;
            int total = 0;
            int numOfResults = _gameResults.Count;

            for (int i = 0; i < numOfResults; i++)
            {
                total = total + _gameResults[i].PlayerScore;
            }

            average = total / numOfResults;
            return average;
        }// end of minimum
         /// <summary>
         /// this calculates the minimum score statistic
         /// </summary>
         /// <returns></returns>
    public int CalculateMinimumScore()
        {
            int minimum = 2000000000;
            int numOfResults = _gameResults.Count;
            for (int i = 0; i < numOfResults; i++)
            {
                if (_gameResults[i].PlayerScore < minimum)
                    minimum = _gameResults[i].PlayerScore;
            }
            return minimum;
        } // end of CalcutlateMinimumScore
    /// <summary>
    /// this calculates the maximum score statistic
    /// </summary>
    /// <returns></returns>
        public int CalculateMaximumScore()
        {
            int maximum = 0;
            int numOfResults = _gameResults.Count;
            for (int i = 0; i < numOfResults; i++)
            {
                if (_gameResults[i].PlayerScore > maximum)
                    maximum = _gameResults[i].PlayerScore;
            }
            return maximum;
        }// end of CalculateMaximum
    /// <summary>
    /// this retrives a list of game names to be used in game results 
    /// </summary>
    /// <returns></returns>
    public IEnumerable<string> GetGameNames()
    {
        List<string> gameNames = new List<string>();
        foreach (GameResult result in _gameResults)
        {
            if (gameNames.Contains(result.GameName) == false)
            {
                gameNames.Add(result.GameName);
            }
        }
        return gameNames;
    }
    /// <summary>
    /// this finds the overall winner and displays the percentage of wins that the player had 
    /// </summary>
    /// <param name="playerName"></param>
    /// <returns></returns>
        public string FindOverallWinner ( string playerName)
    {
       
           
            int playerWins = 0;
            int computerWins = 0;
            string result = "";
            decimal percWins = 0;
            int numOfGames = _gameResults.Count;
            foreach (GameResult element in _gameResults) // 2
            {
                result = element.Winner;
                if (result.StartsWith(playerName))
                {
                    playerWins = playerWins + 1;
                }
                else if (result.StartsWith("Computer"))
                {
                    computerWins = computerWins + 1;
                }
            } // end for
            // To Do- use this for calculaing wins for computer and report 
            if (playerWins > computerWins)
            {
                result = $"{playerName} wins as {playerWins} is higher than { computerWins} ";


            }
            else if (playerWins < computerWins)
            {
                result = $"Computer wins as {playerWins} is higher than { computerWins}";


            }
            if (playerWins == computerWins)
            {
                result = $"Draw as {playerWins} matches {computerWins}";
            }
        percWins = (decimal) 100 * playerWins / numOfGames;
        result += $"\n Percentage wins { percWins.ToString("0.00") }";
        
        return result;
           
        }// FindOverallWinner
} //  end of GameStatistics



