
using System;

namespace OOP_D_EventDrivenApp
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.BtnPlayGame = new System.Windows.Forms.Button();
            this.LblPlayerScore = new System.Windows.Forms.Label();
            this.LblComputerScore = new System.Windows.Forms.Label();
            this.TbxPlayersName = new System.Windows.Forms.TextBox();
            this.CbxGame = new System.Windows.Forms.ComboBox();
            this.LsbResults = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.BtnFindWinner = new System.Windows.Forms.Button();
            this.BtnGameStatistics = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.LblPercentageWins = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.LblPlayerWins = new System.Windows.Forms.Label();
            this.LblMinimumScore = new System.Windows.Forms.Label();
            this.LblAverageScore = new System.Windows.Forms.Label();
            this.LblMaximumScore = new System.Windows.Forms.Label();
            this.LsvGameStatistics = new System.Windows.Forms.ListView();
            this.ColGameName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColPlayerScore = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColComputerScore = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColWinner = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.BtnTestListVew = new System.Windows.Forms.Button();
            this.CbxFilterByGameName = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.BtnCalculateStatistics = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.LsvPlayerScoreBlackjack = new System.Windows.Forms.ListView();
            this.CardName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.BlackJackPlayersScore = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.LsvComputerScoreBlackJack = new System.Windows.Forms.ListView();
            this.ComputerCardName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ComputerBlackJackScore = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.BtnHit = new System.Windows.Forms.Button();
            this.BtnStand = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BtnPlayGame
            // 
            this.BtnPlayGame.Location = new System.Drawing.Point(62, 209);
            this.BtnPlayGame.Name = "BtnPlayGame";
            this.BtnPlayGame.Size = new System.Drawing.Size(84, 32);
            this.BtnPlayGame.TabIndex = 0;
            this.BtnPlayGame.Text = "Play Game";
            this.BtnPlayGame.UseVisualStyleBackColor = true;
            this.BtnPlayGame.Click += new System.EventHandler(this.BtnPlayGame_Click);
            // 
            // LblPlayerScore
            // 
            this.LblPlayerScore.AutoSize = true;
            this.LblPlayerScore.Location = new System.Drawing.Point(285, 214);
            this.LblPlayerScore.Name = "LblPlayerScore";
            this.LblPlayerScore.Size = new System.Drawing.Size(13, 13);
            this.LblPlayerScore.TabIndex = 1;
            this.LblPlayerScore.Text = "0";
            // 
            // LblComputerScore
            // 
            this.LblComputerScore.AutoSize = true;
            this.LblComputerScore.Location = new System.Drawing.Point(285, 182);
            this.LblComputerScore.Name = "LblComputerScore";
            this.LblComputerScore.Size = new System.Drawing.Size(13, 13);
            this.LblComputerScore.TabIndex = 2;
            this.LblComputerScore.Text = "0";
            // 
            // TbxPlayersName
            // 
            this.TbxPlayersName.Location = new System.Drawing.Point(147, 58);
            this.TbxPlayersName.Name = "TbxPlayersName";
            this.TbxPlayersName.Size = new System.Drawing.Size(132, 20);
            this.TbxPlayersName.TabIndex = 3;
            // 
            // CbxGame
            // 
            this.CbxGame.AllowDrop = true;
            this.CbxGame.FormattingEnabled = true;
            this.CbxGame.Location = new System.Drawing.Point(147, 136);
            this.CbxGame.Name = "CbxGame";
            this.CbxGame.Size = new System.Drawing.Size(132, 21);
            this.CbxGame.TabIndex = 4;
            this.CbxGame.SelectedIndexChanged += new System.EventHandler(this.CbxGame_SelectedIndexChanged);
            // 
            // LsbResults
            // 
            this.LsbResults.FormattingEnabled = true;
            this.LsbResults.Location = new System.Drawing.Point(1270, 280);
            this.LsbResults.Name = "LsbResults";
            this.LsbResults.Size = new System.Drawing.Size(313, 95);
            this.LsbResults.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Enter Name";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(50, 144);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Pick a game";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(190, 182);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Computer :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(190, 214);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Player :";
            // 
            // BtnFindWinner
            // 
            this.BtnFindWinner.Location = new System.Drawing.Point(62, 585);
            this.BtnFindWinner.Name = "BtnFindWinner";
            this.BtnFindWinner.Size = new System.Drawing.Size(84, 32);
            this.BtnFindWinner.TabIndex = 10;
            this.BtnFindWinner.Text = "Find Winner";
            this.BtnFindWinner.UseVisualStyleBackColor = true;
            this.BtnFindWinner.Click += new System.EventHandler(this.BtnFindWinner_Click);
            // 
            // BtnGameStatistics
            // 
            this.BtnGameStatistics.Location = new System.Drawing.Point(1309, 560);
            this.BtnGameStatistics.Name = "BtnGameStatistics";
            this.BtnGameStatistics.Size = new System.Drawing.Size(84, 40);
            this.BtnGameStatistics.TabIndex = 11;
            this.BtnGameStatistics.Text = "Display Statistics";
            this.BtnGameStatistics.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(1183, 427);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(107, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Percentage of Wins :";
            // 
            // LblPercentageWins
            // 
            this.LblPercentageWins.AutoSize = true;
            this.LblPercentageWins.Location = new System.Drawing.Point(1310, 481);
            this.LblPercentageWins.Name = "LblPercentageWins";
            this.LblPercentageWins.Size = new System.Drawing.Size(13, 13);
            this.LblPercentageWins.TabIndex = 13;
            this.LblPercentageWins.Text = "0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(1167, 446);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(123, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Number Of Player Wins :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(1167, 495);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(89, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Munimum Score :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(1167, 545);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(84, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "Average Score :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(562, 659);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(88, 13);
            this.label9.TabIndex = 17;
            this.label9.Text = "Maximum Score :";
            // 
            // LblPlayerWins
            // 
            this.LblPlayerWins.AutoSize = true;
            this.LblPlayerWins.Location = new System.Drawing.Point(1296, 446);
            this.LblPlayerWins.Name = "LblPlayerWins";
            this.LblPlayerWins.Size = new System.Drawing.Size(13, 13);
            this.LblPlayerWins.TabIndex = 18;
            this.LblPlayerWins.Text = "0";
            // 
            // LblMinimumScore
            // 
            this.LblMinimumScore.AutoSize = true;
            this.LblMinimumScore.Location = new System.Drawing.Point(1261, 495);
            this.LblMinimumScore.Name = "LblMinimumScore";
            this.LblMinimumScore.Size = new System.Drawing.Size(13, 13);
            this.LblMinimumScore.TabIndex = 19;
            this.LblMinimumScore.Text = "0";
            // 
            // LblAverageScore
            // 
            this.LblAverageScore.AutoSize = true;
            this.LblAverageScore.Location = new System.Drawing.Point(1257, 545);
            this.LblAverageScore.Name = "LblAverageScore";
            this.LblAverageScore.Size = new System.Drawing.Size(13, 13);
            this.LblAverageScore.TabIndex = 20;
            this.LblAverageScore.Text = "0";
            // 
            // LblMaximumScore
            // 
            this.LblMaximumScore.AutoSize = true;
            this.LblMaximumScore.Location = new System.Drawing.Point(656, 659);
            this.LblMaximumScore.Name = "LblMaximumScore";
            this.LblMaximumScore.Size = new System.Drawing.Size(13, 13);
            this.LblMaximumScore.TabIndex = 21;
            this.LblMaximumScore.Text = "0";
            // 
            // LsvGameStatistics
            // 
            this.LsvGameStatistics.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ColGameName,
            this.ColPlayerScore,
            this.ColComputerScore,
            this.ColWinner});
            this.LsvGameStatistics.HideSelection = false;
            this.LsvGameStatistics.Location = new System.Drawing.Point(102, 417);
            this.LsvGameStatistics.Name = "LsvGameStatistics";
            this.LsvGameStatistics.Size = new System.Drawing.Size(513, 128);
            this.LsvGameStatistics.TabIndex = 22;
            this.LsvGameStatistics.UseCompatibleStateImageBehavior = false;
            this.LsvGameStatistics.View = System.Windows.Forms.View.Details;
            this.LsvGameStatistics.SelectedIndexChanged += new System.EventHandler(this.LsvGameStatistics_SelectedIndexChanged);
            // 
            // ColGameName
            // 
            this.ColGameName.Text = "Game Name";
            this.ColGameName.Width = 89;
            // 
            // ColPlayerScore
            // 
            this.ColPlayerScore.Text = " Player Score";
            this.ColPlayerScore.Width = 77;
            // 
            // ColComputerScore
            // 
            this.ColComputerScore.Text = "Computer Score";
            this.ColComputerScore.Width = 90;
            // 
            // ColWinner
            // 
            this.ColWinner.Text = "Winner";
            this.ColWinner.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ColWinner.Width = 250;
            // 
            // BtnTestListVew
            // 
            this.BtnTestListVew.Location = new System.Drawing.Point(1261, 497);
            this.BtnTestListVew.Name = "BtnTestListVew";
            this.BtnTestListVew.Size = new System.Drawing.Size(94, 23);
            this.BtnTestListVew.TabIndex = 23;
            this.BtnTestListVew.Text = "Test List View";
            this.BtnTestListVew.UseVisualStyleBackColor = true;
            this.BtnTestListVew.Click += new System.EventHandler(this.BtnTestListVew_Click);
            // 
            // CbxFilterByGameName
            // 
            this.CbxFilterByGameName.FormattingEnabled = true;
            this.CbxFilterByGameName.Location = new System.Drawing.Point(432, 174);
            this.CbxFilterByGameName.Name = "CbxFilterByGameName";
            this.CbxFilterByGameName.Size = new System.Drawing.Size(121, 21);
            this.CbxFilterByGameName.TabIndex = 24;
            this.CbxFilterByGameName.SelectedIndexChanged += new System.EventHandler(this.CbxFilterByGameName_SelectedIndexChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(317, 182);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(109, 13);
            this.label10.TabIndex = 25;
            this.label10.Text = "Filter By Game Name:";
            // 
            // BtnCalculateStatistics
            // 
            this.BtnCalculateStatistics.Location = new System.Drawing.Point(443, 582);
            this.BtnCalculateStatistics.Name = "BtnCalculateStatistics";
            this.BtnCalculateStatistics.Size = new System.Drawing.Size(84, 35);
            this.BtnCalculateStatistics.TabIndex = 26;
            this.BtnCalculateStatistics.Text = "Calculate Statistics";
            this.BtnCalculateStatistics.UseVisualStyleBackColor = true;
            this.BtnCalculateStatistics.Click += new System.EventHandler(this.BtnCalculateStatistics_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(651, 607);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(99, 13);
            this.label11.TabIndex = 27;
            this.label11.Text = "© Andrew Biddulph";
            // 
            // LsvPlayerScoreBlackjack
            // 
            this.LsvPlayerScoreBlackjack.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.CardName,
            this.BlackJackPlayersScore});
            this.LsvPlayerScoreBlackjack.HideSelection = false;
            this.LsvPlayerScoreBlackjack.Location = new System.Drawing.Point(53, 271);
            this.LsvPlayerScoreBlackjack.Name = "LsvPlayerScoreBlackjack";
            this.LsvPlayerScoreBlackjack.Size = new System.Drawing.Size(255, 140);
            this.LsvPlayerScoreBlackjack.TabIndex = 28;
            this.LsvPlayerScoreBlackjack.UseCompatibleStateImageBehavior = false;
            this.LsvPlayerScoreBlackjack.View = System.Windows.Forms.View.Details;
            // 
            // CardName
            // 
            this.CardName.Text = "Card Name";
            this.CardName.Width = 150;
            // 
            // BlackJackPlayersScore
            // 
            this.BlackJackPlayersScore.Text = "Player Score";
            this.BlackJackPlayersScore.Width = 100;
            // 
            // LsvComputerScoreBlackJack
            // 
            this.LsvComputerScoreBlackJack.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ComputerCardName,
            this.ComputerBlackJackScore});
            this.LsvComputerScoreBlackJack.HideSelection = false;
            this.LsvComputerScoreBlackJack.Location = new System.Drawing.Point(404, 271);
            this.LsvComputerScoreBlackJack.Name = "LsvComputerScoreBlackJack";
            this.LsvComputerScoreBlackJack.Size = new System.Drawing.Size(255, 140);
            this.LsvComputerScoreBlackJack.TabIndex = 29;
            this.LsvComputerScoreBlackJack.UseCompatibleStateImageBehavior = false;
            this.LsvComputerScoreBlackJack.View = System.Windows.Forms.View.Details;
            this.LsvComputerScoreBlackJack.SelectedIndexChanged += new System.EventHandler(this.LsvComputerScoreBlackJack_SelectedIndexChanged);
            // 
            // ComputerCardName
            // 
            this.ComputerCardName.Text = "Card Name";
            this.ComputerCardName.Width = 150;
            // 
            // ComputerBlackJackScore
            // 
            this.ComputerBlackJackScore.Text = "Computer Score";
            this.ComputerBlackJackScore.Width = 100;
            // 
            // BtnHit
            // 
            this.BtnHit.Location = new System.Drawing.Point(314, 297);
            this.BtnHit.Name = "BtnHit";
            this.BtnHit.Size = new System.Drawing.Size(84, 32);
            this.BtnHit.TabIndex = 30;
            this.BtnHit.Text = "Hit";
            this.BtnHit.UseVisualStyleBackColor = true;
            this.BtnHit.Click += new System.EventHandler(this.BtnHit_Click);
            // 
            // BtnStand
            // 
            this.BtnStand.Location = new System.Drawing.Point(314, 355);
            this.BtnStand.Name = "BtnStand";
            this.BtnStand.Size = new System.Drawing.Size(84, 32);
            this.BtnStand.TabIndex = 31;
            this.BtnStand.Text = "Stand";
            this.BtnStand.UseVisualStyleBackColor = true;
            this.BtnStand.Click += new System.EventHandler(this.BtnStand_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(502, 252);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(157, 13);
            this.label12.TabIndex = 32;
            this.label12.Text = "Computer Score For Black Jack";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(43, 255);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(141, 13);
            this.label13.TabIndex = 33;
            this.label13.Text = "Player Score For Black Jack";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(762, 629);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.BtnStand);
            this.Controls.Add(this.BtnHit);
            this.Controls.Add(this.LsvComputerScoreBlackJack);
            this.Controls.Add(this.LsvPlayerScoreBlackjack);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.BtnCalculateStatistics);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.CbxFilterByGameName);
            this.Controls.Add(this.BtnTestListVew);
            this.Controls.Add(this.LsvGameStatistics);
            this.Controls.Add(this.LblMaximumScore);
            this.Controls.Add(this.LblAverageScore);
            this.Controls.Add(this.LblMinimumScore);
            this.Controls.Add(this.LblPlayerWins);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.LblPercentageWins);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.BtnGameStatistics);
            this.Controls.Add(this.BtnFindWinner);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LsbResults);
            this.Controls.Add(this.CbxGame);
            this.Controls.Add(this.TbxPlayersName);
            this.Controls.Add(this.LblComputerScore);
            this.Controls.Add(this.LblPlayerScore);
            this.Controls.Add(this.BtnPlayGame);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void label1_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.Button BtnPlayGame;
        private System.Windows.Forms.Label LblPlayerScore;
        private System.Windows.Forms.Label LblComputerScore;
        private System.Windows.Forms.TextBox TbxPlayersName;
        private System.Windows.Forms.ComboBox CbxGame;
        private System.Windows.Forms.ListBox LsbResults;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button BtnFindWinner;
        private System.Windows.Forms.Button BtnGameStatistics;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label LblPercentageWins;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label LblPlayerWins;
        private System.Windows.Forms.Label LblMinimumScore;
        private System.Windows.Forms.Label LblAverageScore;
        private System.Windows.Forms.Label LblMaximumScore;
        private System.Windows.Forms.ListView LsvGameStatistics;
        private System.Windows.Forms.ColumnHeader ColGameName;
        private System.Windows.Forms.ColumnHeader ColPlayerScore;
        private System.Windows.Forms.ColumnHeader ColComputerScore;
        private System.Windows.Forms.ColumnHeader ColWinner;
        private System.Windows.Forms.Button BtnTestListVew;
        private System.Windows.Forms.ComboBox CbxFilterByGameName;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button BtnCalculateStatistics;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ListView LsvPlayerScoreBlackjack;
        private System.Windows.Forms.ColumnHeader CardName;
        private System.Windows.Forms.ColumnHeader BlackJackPlayersScore;
        private System.Windows.Forms.ListView LsvComputerScoreBlackJack;
        private System.Windows.Forms.ColumnHeader ComputerCardName;
        private System.Windows.Forms.ColumnHeader ComputerBlackJackScore;
        private System.Windows.Forms.Button BtnHit;
        private System.Windows.Forms.Button BtnStand;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
    }
}

