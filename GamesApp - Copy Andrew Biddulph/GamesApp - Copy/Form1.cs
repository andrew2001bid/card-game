using GamesApp;
using System;
using System.Windows.Forms;
namespace OOP_D_EventDrivenApp
{
    /// <summary>
    /// Form1 inherits from Form class to create a windows for interface
    /// allows the user to play a number of games of chance adn see the feedback they get as well as getting statistics on their performacne using event handlers
    /// </summary>
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        /// <summary>
        /// creates global game variables
        /// </summary>
        string game;
        int playerScore = 0;
        int computerScore = 0;
        string playersName = "";

        /// <summary>
        /// clears interface controls and populates cbxGame with available games and makes buttons unavailble initalilly 
        /// </summary>
        public void ResetInterface()
        {
            TbxPlayersName.Text = "";
            CbxGame.SelectedItem = null;
            LblComputerScore.Text = "0";
            LblPlayerScore.Text = "0";
            CbxGame.Items.Clear();
            CbxGame.Items.Add("Dice");
            CbxGame.Items.Add("Ten Sided Dice");
            CbxGame.Items.Add("High Card");
            CbxGame.Items.Add("Low Card");
            CbxGame.Items.Add("Wild Eights");
            CbxGame.Items.Add("Black Jack");
            LsbResults.Items.Clear();
            CbxGame.Enabled = true;
            BtnPlayGame.Enabled = false;



        } // end resetInterface

        GameStatistics gStatistics;
        private void Form1_Load(object sender, EventArgs e)
        {
            ResetInterface();
            gStatistics = new GameStatistics();
        } // end Form1_Load


        /// <summary>
        /// when a the results are duisplayed this code allows them to be displayed in the corrcet area 
        /// </summary>
        /// <param name="gameStatistics"></param>
        /// <param name="gameFilter"></param>
        private void displayGameResultsInListView(GameStatistics gameStatistics, string gameFilter = "")
        {
            if (gameStatistics.Count > 0)
            {
                LsvGameStatistics.Items.Clear();
                foreach (GameResult result in gameStatistics.GameResults)
                {
                    if (gameFilter == "" || result.GameName == gameFilter)
                    {
                        LsvGameStatistics.Items.Add(new ListViewItem(new[]
                            { result.GameName, result.PlayerScore.ToString(), result.ComputerScore.ToString(), result.Winner
                        }));
                    }
                }
            }

        }
        /// <summary>
        /// this code lets you run the dice game 
        /// </summary>
        /// <param name="playerName"></param>
        /// <returns></returns>
        private string playDiceGame(string playerName)
        {
            string feedback = "";
            GameResult gResult = new GameResult();

            Dice playerDice = new Dice("Blue");
            gResult.PlayerScore = playerDice.Num;
            LblPlayerScore.Text = gResult.PlayerScore.ToString();

            Dice computerDice = new Dice("Red");
            gResult.ComputerScore = computerDice.Num;
            LblComputerScore.Text = gResult.ComputerScore.ToString();
            gResult.GameName = CbxGame.SelectedItem.ToString();

            if (gResult.PlayerScore > gResult.ComputerScore)
            {
                gResult.Winner = playersName;
                feedback = $"{gResult.Winner} wins as {gResult.PlayerScore} is higher than { gResult.ComputerScore}";

            }
            else if (gResult.ComputerScore > gResult.PlayerScore)
            {
                gResult.Winner = "Computer";
                feedback = $"Computer wins as {gResult.ComputerScore} is higher than { gResult.PlayerScore}";
            }
            else if (gResult.PlayerScore == gResult.ComputerScore)
            {
                gResult.Winner = "Draw";
                feedback = $"Draw as {gResult.PlayerScore} matches {gResult.ComputerScore}";
            }

            gStatistics.Add(gResult);
            LsvGameStatistics.Items.Add(new ListViewItem(new[]
                            { gResult.GameName, gResult.PlayerScore.ToString(), gResult.ComputerScore.ToString(), gResult.Winner }));

            return feedback;


        }//end of Dice Game 
        /// <summary>
        /// 
        /// this code lets you run the ten sided dice game 
        /// </summary>
        /// <param name="playerName"></param>
        /// <returns></returns>
        private string playTenSidedDice(string playerName)
        {
            string feedback = "";
            GameResult gResult = new GameResult();

            TenSidedDice playerTenDice = new TenSidedDice("Blue");
            gResult.PlayerScore = playerTenDice.Num;
            LblPlayerScore.Text = playerScore.ToString();

            TenSidedDice computerTenDice = new TenSidedDice("Red");
            gResult.ComputerScore = computerTenDice.Num;
            LblComputerScore.Text = computerScore.ToString();
            gResult.GameName = CbxGame.SelectedItem.ToString();


            if (gResult.PlayerScore > gResult.ComputerScore)
            {
                gResult.Winner = playersName;
                feedback = $"{gResult.Winner} wins as {gResult.PlayerScore} is higher than { gResult.ComputerScore}";

            }
            else if (gResult.ComputerScore > gResult.PlayerScore)
            {
                gResult.Winner = "Computer";
                feedback = $"Computer wins as {gResult.ComputerScore} is higher than { gResult.PlayerScore}";
            }
            else if (gResult.PlayerScore == gResult.ComputerScore)
            {
                gResult.Winner = "Draw";
                feedback = $"Draw as {gResult.PlayerScore} matches {gResult.ComputerScore}";
            }
            gStatistics.Add(gResult);
            LsvGameStatistics.Items.Add(new ListViewItem(new[]
                            { gResult.GameName, gResult.PlayerScore.ToString(), gResult.ComputerScore.ToString(), gResult.Winner }));

            return feedback;
        }
        /// <summary>
        /// 
        /// when yoy click it runs the code wfor whatever game was selected 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnPlayGame_Click(object sender, EventArgs e)
        {
            string feedback = "";
            playersName = TbxPlayersName.Text.TrimEnd();
            switch (game)
            {
                case "Dice":
                    feedback = playDiceGame(playersName);
                    break;

                case "Ten Sided Dice":
                    feedback = playTenSidedDice(playersName);
                    break;
                case "High Card":
                    feedback = playHighCardGame(playersName);
                    break;

                case "Low Card":
                    feedback = playLowCardGame(playersName);
                    break;
                case "Wild Eights":
                    feedback = playWildEights(playersName);
                    break;

                case "Black Jack":
                    feedback = playBlackJack(playersName);
                    break;
            }
            MessageBox.Show(feedback, " Welcome", MessageBoxButtons.OK);
            LsbResults.Items.Add(feedback);
        } // End BtnPlayGame_Click
          /// <summary>
          /// this runs the code for the low card game which is where the highest card wins 
          /// </summary>
        private string playHighCardGame(string playerName)
        {
            string feedback = "";

            GameResult gResult = new GameResult();
            PlayingCard playerCard = new PlayingCard("Red", CardSuit.Diamonds);
            gResult.PlayerScore = playerCard.Num;
            LblPlayerScore.Text = playerScore.ToString();

            PlayingCard computerCard = new PlayingCard("blue", CardSuit.Diamonds);
            gResult.ComputerScore = computerCard.Num;
            LblComputerScore.Text = computerScore.ToString();
            gResult.GameName = CbxGame.SelectedItem.ToString();

            if (gResult.PlayerScore > gResult.ComputerScore)
            {
                gResult.Winner = playersName;
                feedback = $"{gResult.Winner} wins as {gResult.PlayerScore} is higher than { gResult.ComputerScore}";

            }
            else if (gResult.ComputerScore > gResult.PlayerScore)
            {
                gResult.Winner = "Computer";
                feedback = $"Computer wins as {gResult.ComputerScore} is higher than { gResult.PlayerScore}";
            }
            else if (gResult.PlayerScore == gResult.ComputerScore)
            {
                gResult.Winner = "Draw";
                feedback = $"Draw as {gResult.PlayerScore} matches {gResult.ComputerScore}";
            }
            gStatistics.Add(gResult);
            LsvGameStatistics.Items.Add(new ListViewItem(new[]
                            { gResult.GameName, gResult.PlayerScore.ToString(), gResult.ComputerScore.ToString(), gResult.Winner }));

            return feedback;
        }

        /// <summary>
        /// this runs the code for the low card game which is where the lowest card wins 
        /// </summary>
        /// <param name="playerName"></param>
        /// <returns></returns>
        private string playLowCardGame(string playerName)
        {
            string feedback = "";

            GameResult gResult = new GameResult();
            PlayingCard playerCard = new PlayingCard("Red", CardSuit.Diamonds);
            gResult.PlayerScore = playerCard.Num;
            LblPlayerScore.Text = playerScore.ToString();

            PlayingCard computerCard = new PlayingCard("blue", CardSuit.Spades);
            gResult.ComputerScore = computerCard.Num;
            LblComputerScore.Text = computerScore.ToString();
            gResult.GameName = CbxGame.SelectedItem.ToString();


            if (gResult.PlayerScore < gResult.ComputerScore)
            {
                gResult.Winner = playersName;
                feedback = $"{gResult.Winner} wins as {gResult.PlayerScore} is lower than { gResult.ComputerScore}";

            }
            else if (gResult.ComputerScore < gResult.PlayerScore)
            {
                gResult.Winner = "Computer";
                feedback = $"Computer wins as {gResult.ComputerScore} is lower than { gResult.PlayerScore}";
            }
            else if (gResult.PlayerScore == gResult.ComputerScore)
            {
                gResult.Winner = "Draw";
                feedback = $"Draw as {gResult.PlayerScore} matches {gResult.ComputerScore}";
            }
            gStatistics.Add(gResult);
            LsvGameStatistics.Items.Add(new ListViewItem(new[]
                            { gResult.GameName, gResult.PlayerScore.ToString(), gResult.ComputerScore.ToString(), gResult.Winner }));

            return feedback;
        }

        /// <summary>
        /// this code lets the play and computer draw 2 cards and whoever gets an 8 wins 
        /// </summary>
        /// <param name="playerName"></param>
        /// <returns></returns>
        private string playWildEights(string playerName)
        {
            string feedback = "";

            GameResult gResult = new GameResult();
            PlayingCard playerCard = new PlayingCard("Red", CardSuit.Diamonds);
            gResult.PlayerScore = playerCard.Num;
            LblPlayerScore.Text = playerScore.ToString();

            PlayingCard computerCard = new PlayingCard("blue", CardSuit.Spades);
            gResult.ComputerScore = computerCard.Num;
            LblComputerScore.Text = computerScore.ToString();
            gResult.GameName = CbxGame.SelectedItem.ToString();


            if (gResult.PlayerScore == 8)
            {
                gResult.Winner = playersName;
                feedback = $"{gResult.Winner} wins as {gResult.PlayerScore} is a Wild Eight";

            }
            else if (gResult.ComputerScore == 8)
            {
                gResult.Winner = "Computer";
                feedback = $"Computer wins as {gResult.ComputerScore} is a Wild Eight";
            }
            else 
            {
                gResult.Winner = "Draw";
                feedback = $"Both players did not manage to get 8";
            }
            gStatistics.Add(gResult);
            LsvGameStatistics.Items.Add(new ListViewItem(new[]
                            { gResult.GameName, gResult.PlayerScore.ToString(), gResult.ComputerScore.ToString(), gResult.Winner }));

            return feedback;
        }

        // Declare Blackjack objects 
        Deck deck = null;
        Hand playersHand = null;
        Hand computersHand = null;

        /// <summary>
        /// 1. Declares local feedback variable 
        /// 2.Create a Deck
        /// 3. Create players Hand 
        /// 4. Deal player two cards from Deck and display in LsvPlayersCards
        /// 5. Dispaly players hand score in matching label
        /// 6. Return feedback telling them do they want to Hit or Stand
        /// </summary>
        /// <returns></returns>
        private string playBlackJack(string playersName)
        {
            string feedback = "Welcome to Blackjack , Please Use the Buttons 'Hit' and 'Stand' in order to play.";
            deck = new Deck();
            playersHand = new Hand();
            computersHand = new Hand();
            playerScore = playersHand.Score;
            LblPlayerScore.Text = playersHand.Score.ToString();
            return feedback;
        }

        /// <summary>
        /// 
        /// this lets you actuvate the play game button once someone enters a charcter into the name field
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TbxPlayersName_KeyDown(object sender, KeyEventArgs e)
        {
            if ((e.KeyCode == Keys.Enter) && (TbxPlayersName.Text.Length > 0))
            {
                BtnPlayGame.Enabled = true;
            }
        } // end TbxPlayersName_KeyDown

        /// <summary>
        /// this button actuvates the play game button once the player selects a game 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void CbxGame_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CbxGame.SelectedIndex != -1)
            {
                BtnPlayGame.Enabled = true;
                game = CbxGame.SelectedItem.ToString();
                LsvGameStatistics.Items.Clear();
            }
        } // end CbxGame_SelectedIndexChanged

        /// <summary>
        /// This button dertermines the winner when clicked 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnFindWinner_Click(object sender, EventArgs e)
        {
            int count; // 1
            int playerWins = 0;
            int computerWins = 0;
            string result = "";
            int numOfGames = LsbResults.Items.Count;
            for (count = 0; count < numOfGames; count++) // 2
            {
                result = LsbResults.Items.ToString();
                if (result.StartsWith(playersName))
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
                result = $"{playersName} wins as {playerWins} is higher than { computerWins} ";


            }
            else if (playerWins > computerWins)
            {
                result = $"Computer wins as {playerWins} is higher than { computerWins}";


            }
            if (playerWins > computerWins)
            {
                result = $"Draw as {playerWins} matches {computerWins}";
            }
            MessageBox.Show(result);
            ResetInterface();
        } // end BtnFindWinner_Click


        /// <summary>
        /// this was to test the list view and add certian data to see if the data was working 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnTestListVew_Click(object sender, EventArgs e)
        {
            gStatistics.Add(new GameResult("Dice", 6, 3, "Andrew"));
            gStatistics.Add(new GameResult("Dice", 4, 5, "Computer"));
            gStatistics.Add(new GameResult("Ten Sided Dice", 8, 3, "Andrew"));
            gStatistics.Add(new GameResult("Ten Sided Dice", 5, 3, "Andrew"));

            displayGameResultsInListView(gStatistics);
            fillCbxFilterbyGameName(gStatistics);
        }
        /// <summary>
        ///  this filters the games depend on which type of game they are
        /// </summary>
        /// <param name="gStatistics"></param>
        private void fillCbxFilterbyGameName(GameStatistics gStatistics)
        {
            if (gStatistics.Count > 0)
            {
                CbxFilterByGameName.Items.Clear();
                foreach (string gameName in gStatistics.GetGameNames())
                {
                    CbxFilterByGameName.Items.Add(gameName);
                }
            }
        }// fillCbxFilterbyGameName
        /// <summary>
        /// this filters the games depend on which type of game they are
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CbxFilterByGameName_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CbxFilterByGameName.SelectedIndex > -1)
            {
                displayGameResultsInListView(gStatistics, CbxFilterByGameName.SelectedItem.ToString());
            }
        }
        /// <summary>
        /// this calculates things such as the Acverage player score and the maximum score found after playing a game 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnCalculateStatistics_Click(object sender, EventArgs e)
        {
            string result = gStatistics.FindOverallWinner(TbxPlayersName.Text);
            result += $"\n average Player Score { gStatistics.CalculateAverageScore()}";
            result += $"\n Calculate Maximum Score{ gStatistics.CalculateMaximumScore()}";
            result += $"\n Calculate Minimum Score { gStatistics.CalculateMinimumScore()}";
            MessageBox.Show(result, "Satistics");
        }
        /// <summary>
        /// this allows the player, when playing blackjack to be able to draw another card from the deck
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnHit_Click(object sender, EventArgs e)
        {
            PlayingCard cardDealt = deck.Deal();
            playersHand.AddCardToHand(cardDealt);
            playerScore += playersHand.Score;
            LsvPlayerScoreBlackjack.Items.Add(new ListViewItem(new[] { cardDealt.Name.ToString(), cardDealt.Num.ToString(), computerScore.ToString() }));

            if (playerScore > 21)
                BtnStand_Click(sender, e);
        }

        /// <summary>
        /// This generates the rules for the stand button by making the computer a new deck and running until it reaches a certain value 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnStand_Click(object sender, EventArgs e)
        {
            
             computersHand = new Hand();
            GameResult gResult = new GameResult();

           
      


            while (computerScore < 16)
            {
                 PlayingCard cardDealt = deck.Deal();
                computersHand.AddCardToHand(cardDealt);
                computerScore += computersHand.Score;
               
                LsvComputerScoreBlackJack.Items.Add(new ListViewItem(new[] { cardDealt.Name.ToString(), cardDealt.Num.ToString() }));

                
            }

            gResult.GameName = "Black Jack";
            gResult.PlayerScore = playerScore;
            gResult.ComputerScore = computerScore;
            gResult.Winner = gResult.Winner;
  
            gStatistics.Add(gResult);
            
            if (playerScore > 21)
            {
                gResult.Winner = "Computer Wins because player is bust";
            }
             else if (computerScore > 21)
            {
                gResult.Winner = "Player wins as Computer Bust ";
            }

            else if (computerScore > playerScore)
            {
                gResult.Winner = "Computer Wins";
            }

            else if (computerScore < playerScore)
            {
                gResult.Winner = "Player wins as they have a higher score";
            }
            LsvGameStatistics.Items.Add(new ListViewItem(new[]
                        { gResult.GameName, gResult.PlayerScore.ToString(), gResult.ComputerScore.ToString(), gResult.Winner.ToString() }));

        } // End Form1

        private void LsvGameStatistics_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void LsvComputerScoreBlackJack_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
