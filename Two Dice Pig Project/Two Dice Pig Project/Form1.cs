using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            //Display a dice face.
            pbDiceOne.BackgroundImage = Image.FromFile("Face1.png");
            pbDiceTwo.BackgroundImage = Image.FromFile("Face1.png");

            //Disable all player buttons so that they must start a new game.
            btnP1Hold.Enabled = false;
            btnP1Roll.Enabled = false;
            btnP2Hold.Enabled = false;
            btnP2Roll.Enabled = false;

             
        }

        //Declare Random Number Generator
        Random randomGenerator = new Random();

        public struct Player
        {
            public int TurnTotal;
            public int TotalScore;
            public int Roll1;
            public int Roll2; 
        }

        //Declare Global Player variables. 
        Player P1, P2;

        public void UpdatePicBox1(int DiceOne)
        {

            
            //Display the dice face in picturebox1 based off of the number that is fed into the method.
            if (DiceOne==1)
            {
                pbDiceOne.BackgroundImage = Image.FromFile("Face1.png");
            }
            else if(DiceOne == 2)
            {
                pbDiceOne.BackgroundImage = Image.FromFile("Face2.png");
            }
            else if (DiceOne == 3)
            {
                pbDiceOne.BackgroundImage = Image.FromFile("Face3.png");
            }
            else if (DiceOne == 4)
            {
                pbDiceOne.BackgroundImage = Image.FromFile("Face4.png");
            }
            else if (DiceOne == 5)
            {
                pbDiceOne.BackgroundImage = Image.FromFile("Face5.png");
            }
            else if (DiceOne == 6)
            {
                pbDiceOne.BackgroundImage = Image.FromFile("Face6.png");
            }
            

        }

        public void UpdatePicBox2(int DiceTwo)
        {
            //Display the dice face in picturebox2 based off of the number that is fed into the method. 
            if (DiceTwo == 1)
            {
                pbDiceTwo.BackgroundImage = Image.FromFile("Face1.png");
            }
            else if (DiceTwo == 2)
            {
                pbDiceTwo.BackgroundImage = Image.FromFile("Face2.png");
            }
            else if (DiceTwo == 3)
            {
                pbDiceTwo.BackgroundImage = Image.FromFile("Face3.png");
            }
            else if (DiceTwo == 4)
            {
                pbDiceTwo.BackgroundImage = Image.FromFile("Face4.png");
            }
            else if (DiceTwo == 5)
            {
                pbDiceTwo.BackgroundImage = Image.FromFile("Face5.png");
            }
            else if (DiceTwo == 6)
            {
                pbDiceTwo.BackgroundImage = Image.FromFile("Face6.png");
            }
        }

        public void UpdateScoreBoard()
        {
            
            //Update all text boxes with their respective global variables.
            txtP1TurnTotal.Text = P1.TurnTotal.ToString();
            txtP1TotalScore.Text = P1.TotalScore.ToString();
            txtP2TurnTotal.Text = P2.TurnTotal.ToString();
            txtP2TotalScore.Text = P2.TotalScore.ToString();

        }

        public void NewGame()
        {
            //Reset structure variables
            P1.TurnTotal = 0;
            P1.TotalScore = 0;
            P1.Roll1 = 0;
            P1.Roll2 = 0;

            P2.TurnTotal = 0;
            P2.TotalScore = 0;
            P2.Roll1 = 0;
            P2.Roll2 = 0;

            //Clear all text boxes
            txtP1TotalScore.Clear();
            txtP1TurnTotal.Clear();
            txtP2TotalScore.Clear();
            txtP2TurnTotal.Clear();

            //Restrict buttons to player 1 use only. 
            btnP1Hold.Enabled = true;
            btnP1Roll.Enabled = true;
            btnP2Roll.Enabled = false;
            btnP2Hold.Enabled = false;

        }

        private void btnNewGame_Click(object sender, EventArgs e)
        {
            try
            {
                //Run the new game function.
                NewGame();
            }
            catch
            {
                MessageBox.Show("Error");
            }
        }



        private void btnP1Hold_Click(object sender, EventArgs e)
        {
            try
            {
                //Update the scoreboard and total game score.
                P1.TotalScore = P1.TotalScore + P1.TurnTotal;
                P1.TurnTotal = 0;
                UpdateScoreBoard();

                //Check if the player has reached 100.
                if (P1.TotalScore >= 100)
                {
                    //If the player reached 100, display a winning message.
                    MessageBox.Show("Player One Wins!");

                    //Disable all buttons except new game. 
                    btnP1Hold.Enabled = false;
                    btnP1Roll.Enabled = false;
                    btnP2Hold.Enabled = false;
                    btnP2Roll.Enabled = false;
                    return;
                }
                else
                {
                    /*If Player 1 has not reached 100, disable player 1's buttons  
                      and enable player 2's buttons in preperation for the next turn.*/
                    btnP1Hold.Enabled = false;
                    btnP1Roll.Enabled = false;
                    btnP2Hold.Enabled = true;
                    btnP2Roll.Enabled = true;
                }
                
            }
            catch
            {
                MessageBox.Show("Error");
            }
        }

        private void btnP2Roll_Click(object sender, EventArgs e)
        {
            try
            {
                //Enable Player 2 hold button in case a double was rolled and it was disabled in the previous Player 2 roll.
                btnP2Hold.Enabled = true;

                //Generate Dice Rolls and update picture boxes.
                P2.Roll1 = randomGenerator.Next(1, 7);
                UpdatePicBox1(P2.Roll1);
                P2.Roll2 = randomGenerator.Next(1, 7);
                UpdatePicBox2(P2.Roll2);

                //Check if a one was rolled
                if (P2.Roll1 == 1 || P2.Roll2 == 1)
                {
                    //If a one was rolled, check if "snake eyes" were rolled.
                    if (P2.Roll1 == P2.Roll2)
                    {
                        //If snake eyes were rolled, reset Player 2's score to 0 and end their turn. 
                        P2.TurnTotal = 0;
                        P2.TotalScore = 0;
                        UpdateScoreBoard();

                        //Disable P2 buttons and enable P1 buttons. 
                        btnP2Hold.Enabled = false;
                        btnP2Roll.Enabled = false;
                        btnP1Hold.Enabled = true;
                        btnP1Roll.Enabled = true;

                        //Display end turn message.
                        MessageBox.Show("You rolled double 1s, your total game score has been set to 0 and your turn has ended. It is now Player 1's turn.");
                        return;
                    }
                    else
                    {
                        //if a single 1 was rolled, set Player 2's turn score to 0 and end their turn;
                        P2.TurnTotal = 0;
                        UpdateScoreBoard();

                        //Disable P2 buttons and enable P1 buttons. 
                        btnP2Hold.Enabled = false;
                        btnP2Roll.Enabled = false;
                        btnP1Hold.Enabled = true;
                        btnP1Roll.Enabled = true;

                        //Display end turn message.
                        MessageBox.Show("You Rolled a 1, your turn score has been set to 0 and your turn has ended. It is now Player 1's turn. ");
                        return;
                    }
                }
                //check if doubles were rolled
                else if (P2.Roll1 == P2.Roll2)
                {
                    /*If doubles were rolled, add the roll to the turn total,
                     * display the score, and force the player to roll again.*/

                    P2.TurnTotal = P2.TurnTotal + P2.Roll1 + P2.Roll2;
                    UpdateScoreBoard();

                    //disable Player 1's hold button to ensure that they must roll again.
                    btnP2Hold.Enabled = false;

                    MessageBox.Show("You rolled doubles! Roll again.");
                    return;
                }
                else
                {
                    //if it was a normal roll, add the rolls to the turn total and display it.
                    P2.TurnTotal = P2.TurnTotal + P2.Roll1 + P2.Roll2;
                    UpdateScoreBoard();
                }
            }
            catch
            {
                MessageBox.Show("Error");
            }
        }

        private void btnP2Hold_Click(object sender, EventArgs e)
        {
            try
            {
                //Update the scores and scoreboard
                P2.TotalScore = P2.TotalScore + P2.TurnTotal;
                P2.TurnTotal = 0;
                UpdateScoreBoard();

                //Check if the player has reached 100. 
                if (P2.TotalScore >= 100)
                {
                    //If the player reached 100, display a winning message.
                    MessageBox.Show("Player Two Wins!");

                    //Disable all buttons except new game. 
                    btnP1Hold.Enabled = false;
                    btnP1Roll.Enabled = false;
                    btnP2Hold.Enabled = false;
                    btnP2Roll.Enabled = false;

                    return;
                }
                else
                {
                    //If Player 1 has not reached 100, Disable P1 buttons and enable P2 buttons in preperation for the next turn. 
                    btnP2Hold.Enabled = false;
                    btnP2Roll.Enabled = false;
                    btnP1Hold.Enabled = true;
                    btnP1Roll.Enabled = true;
                }

            }
            catch
            {
                MessageBox.Show("Error");
            }
        }

        private void linkLblHowToPlay_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                //Change the colour of the link to indicate that it has been visited.
                linkLblHowToPlay.LinkVisited = true;

                //Open the link in the default browser. The link will lead to a google document containing instructions and rules for the game.
                System.Diagnostics.Process.Start("https://docs.google.com/document/d/1sJ38_XOnZzJ-tvjQmZeuM26vwI7P-_gDZLX36qiC9ZM/edit?usp=sharing");
            }
            catch
            {
            
               MessageBox.Show("Error, unable to open the linked website");
            }

        }



        private void btnP1Roll_Click(object sender, EventArgs e)
        {
            try
            {
                //Enable Player 1 hold button in case a double was rolled and it was disabled in the previous Player 1 roll.
                btnP1Hold.Enabled = true;
                
                //Generate Dice Rolls and update picture boxes.
                P1.Roll1 = randomGenerator.Next(1, 7);
                UpdatePicBox1(P1.Roll1);
                P1.Roll2 = randomGenerator.Next(1, 7);
                UpdatePicBox2(P1.Roll2);

                //Check if a one was rolled
                if (P1.Roll1 == 1 || P1.Roll2 == 1)
                {
                    //Check if "snake eyes" were rolled.
                    if (P1.Roll1 == P1.Roll2)
                    {
                        //If snake eyes were rolled, reset Player 1's score to 0, display this and end their turn. 
                        P1.TurnTotal = 0;
                        P1.TotalScore = 0;
                        UpdateScoreBoard();

                        //Disable P1 buttons and enable P2 buttons. 
                        btnP1Hold.Enabled = false;
                        btnP1Roll.Enabled = false;
                        btnP2Hold.Enabled = true;
                        btnP2Roll.Enabled = true;

                        //Display end turn message.
                        MessageBox.Show("You rolled double 1s, your total game score has been set to 0 and your turn has ended. It is now player 2's turn.");
                        return;
                    }
                    else
                    {
                        //if a single 1 was rolled, set Player 1's turn score to 0, display this, and end their turn;
                        P1.TurnTotal = 0;
                        UpdateScoreBoard();

                        //Disable P1 buttons and enable P2 buttons. 
                        btnP1Hold.Enabled = false;
                        btnP1Roll.Enabled = false;
                        btnP2Hold.Enabled = true;
                        btnP2Roll.Enabled = true;

                        //Display end turn message.
                        MessageBox.Show("You Rolled a 1, your turn score has been set to 0 and your turn has ended. It is now player 2's turn. ");
                        return;
                    }
                }
                //check if doubles were rolled
                else if (P1.Roll1 == P1.Roll2)
                {
                    //If doubles were rolled, add the roll to the turn total, display it, and force the player to roll again.
                    P1.TurnTotal = P1.TurnTotal + P1.Roll1 + P1.Roll2;
                    UpdateScoreBoard();

                    //disable Player 1's hold button to ensure that they must roll again.
                    btnP1Hold.Enabled = false;

                    MessageBox.Show("You rolled doubles! Roll again.");
                    return;
                }
                else
                {
                    //if it was a normal roll, add the rolls to the turn total and display it.
                    P1.TurnTotal = P1.TurnTotal + P1.Roll1 + P1.Roll2;
                    UpdateScoreBoard();
                }


            }
            catch
            {
                
                MessageBox.Show("Error");
            }
        }
    }
}
