using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTacToe
{
    public partial class TicTacToe : Form
    {
        public TicTacToe()
        {
            InitializeComponent();

            buttonList.Add(Button1);
            buttonList.Add(Button2);
            buttonList.Add(Button3);
            buttonList.Add(Button4);
            buttonList.Add(Button5);
            buttonList.Add(Button6);
            buttonList.Add(Button7);
            buttonList.Add(Button8);
            buttonList.Add(Button9);
        }

        int[,] Board = new int[3, 3] 
        {
            {2, 3, 4},
            {5, 6, 7},
            {8, 9, 10}
        };

        int MoveNumber = 0; //stores how many number of moves are made
        int XScore = 0; //score for X
        int OScore = 0; //score for O
        string text = "O";
        public List<Button> buttonList = new List<Button>();

        private void Button1_Click(object sender, EventArgs e)
        {
            WriteToButton(MoveNumber);
            if (text == "X")
            {
                Board[0, 0] = 1;
            } else {
                Board[0, 0] = 0;
            }   
            Button1.Text = text;
            MoveNumber++;
            GameOver(MoveNumber);
            CheckWin();
        }
        private void Button2_Click(object sender, EventArgs e)
        {
            WriteToButton(MoveNumber);
            if (text == "X")
            {
                Board[0, 1] = 1;
            } else {
                Board[0, 1] = 0;
            }
            Button2.Text = text;
            MoveNumber++;
            GameOver(MoveNumber);
            CheckWin();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            WriteToButton(MoveNumber);
            if (text == "X")
            {
                Board[0, 2] = 1;
            } else {
                Board[0, 2] = 0;
            }
            Button3.Text = text;
            MoveNumber++;
            GameOver(MoveNumber);
            CheckWin();
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            WriteToButton(MoveNumber);
            if (text == "X")
            {
                Board[1, 0] = 1;
            } else {
                Board[1, 0] = 0;
            }
            Button4.Text = text;
            MoveNumber++;
            GameOver(MoveNumber);
            CheckWin();
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            WriteToButton(MoveNumber);
            if (text == "X")
            {
                Board[1, 1] = 1;
            } else {
                Board[1, 1] = 0;
            }
            Button5.Text = text;
            MoveNumber++;
            GameOver(MoveNumber);
            CheckWin();
        }

        private void Button6_Click(object sender, EventArgs e)
        {
            WriteToButton(MoveNumber);
            if (text == "X")
            {
                Board[1, 2] = 1;
            } else {
                Board[1, 2] = 0;
            }
            Button6.Text = text;
            MoveNumber++;
            GameOver(MoveNumber);
            CheckWin();
        }

        private void Button7_Click(object sender, EventArgs e)
        {
            WriteToButton(MoveNumber);
            if (text == "X")
            {
                Board[2, 0] = 1;
            } else {
                Board[2, 0] = 0;
            }
            Button7.Text = text;
            MoveNumber++;
            GameOver(MoveNumber);
            CheckWin();
        }

        private void Button8_Click(object sender, EventArgs e)
        {
            WriteToButton(MoveNumber);
            if (text == "X")
            {
                Board[2, 1] = 1;
            } else {
                Board[2, 1] = 0;
            }
            Button8.Text = text;
            MoveNumber++;
            GameOver(MoveNumber);
            CheckWin();
        }

        private void Button9_Click(object sender, EventArgs e)
        {
            WriteToButton(MoveNumber);
            if (text == "X")
            {
                Board[2, 2] = 1;
            } else {
                Board[2, 2] = 0;
            }
            Button9.Text = text;
            MoveNumber++;
            GameOver(MoveNumber);
            CheckWin();
        }
        private void WriteToButton(int moveNumber)
        {
            if(moveNumber %2 == 0)
            {
                text = "X";
            } else
            {
                text = "O";
            }
        }
        private void CheckWin()
        {
            //Rows
            for(int i = 0; i < 3; i++)
            {
                //checks for rows
                if (Board[i, 0] == Board[i, 1] && Board[i, 1]== Board[i, 2])
                {
                    if(Board[i, 0] == 1)
                    {
                        MessageBox.Show("X won");
                        XScore++; //updates Score for X
                        labelX.Text = $"X = {XScore}";
                    } else { 
                        MessageBox.Show("O won");
                        OScore++;   //updates Score for O
                        labelO.Text = $"O = {OScore}";
                    }

                    if (MessageBox.Show("Do you want to play again?", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        Reset();
                    } else
                    {
                        this.Close();
                    }
                }
            }
            //Columns
            for (int j = 0; j < 3; j++)
            {
                //checks for columns
                if (Board[0, j] == Board[1, j] && Board[1, j] == Board[2, j])
                {
                    if (Board[0, j] == 1)
                    {
                        MessageBox.Show("X won");
                        XScore++;   //updates Score for X
                        labelX.Text = $"X = {XScore}";
                    } else { MessageBox.Show("O won");
                        OScore++;   //updates Score for O
                        labelO.Text = $"O = {OScore}";
                    }

                    if (MessageBox.Show("Do you want to play again?", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        Reset();
                    }
                    else
                    {
                        this.Close();
                    }
                }
            }
            //Diagonals
            if((Board[0,0] == Board[1,1] && Board[1,1] == Board[2,2]) || (Board[0, 2] == Board[1, 1] && Board[1, 1] == Board[2, 0]))
            {
                //checks for diagonal lines
                if (Board[0, 0] == 1 && Board[1, 1] == 1 && Board[2, 2] == 1 || 
                    Board[0, 2] == 1 && Board[1, 1] == 1 && Board[2, 0] == 1)
                {
                    MessageBox.Show("X won");
                    XScore++;   //updates Score for X
                    labelX.Text = $"X = {XScore}";
                }
                else { MessageBox.Show("O won");
                    OScore++;   //updates Score for O
                    labelO.Text = $"O = {OScore}";
                }

                if (MessageBox.Show("Do you want to play again?", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    Reset();
                }
                else
                {
                    this.Close();
                }
            }
        }

        private void Reset()
        {
            //resets 2d board array with trivial numbers
            Board = new int[3, 3]
            {
                {2, 3, 4},
                {5, 6, 7},
                {8, 9, 10}
            };
            //buttons' texts are reset
            foreach(var button in buttonList)
            {
                button.Text = "";
            }
            MoveNumber = 0;
        }

        private void GameOver(int moveNumber)
        {
            //number of moves are limited to 9, so in that case game is over
            if(moveNumber == 9)
            {
                if (MessageBox.Show("Game is tied. Do you want to play again?", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    Reset();
                }
                else
                {
                    this.Close();
                }
            }
        }
    }
}