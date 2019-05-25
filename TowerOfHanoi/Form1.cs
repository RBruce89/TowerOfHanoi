using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace TowerOfHanoi
{

    public partial class Form1 : Form
    {
        int pieceNumber = 3;
        int moveCounter = 0;
        int returnTop;
        int returnLeft;
        Boolean activeGame = false;
        Boolean movable = false;

        Stopwatch gameTimer = new Stopwatch();
        Point mouseDownLocation;
        Label[] pieceLabel = new Label[7];


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            NewGame();
        }

        // menustrip items
        private void NewGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewGame();
        }
        private void ThreePiecesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pieceNumber = 3;
            NewGame();
        }
        private void FourPiecesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pieceNumber = 4;
            NewGame();
        }
        private void FivePiecesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pieceNumber = 5;
            NewGame();
        }
        private void SixPiecesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pieceNumber = 6;
            NewGame();
        }
        private void SevenPiecesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pieceNumber = 7;
            NewGame();
        }
        private void RulesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("\u2022 Only the top piece can be moved \n\u2022 Pieces must be moved one at a time \n" +
                "\u2022 A piece cannot be placed on top of a smaller piece \n\u2022 All pieces must be moved to" +
                " the right hand side \nHave fun!", "Rules");
        }

        // starts or restarts a game
        public void NewGame()
        {
            pieceLabel[0] = this.piece1Label;
            pieceLabel[1] = this.piece2Label;
            pieceLabel[2] = this.piece3Label;
            pieceLabel[3] = this.piece4Label;
            pieceLabel[4] = this.piece5Label;
            pieceLabel[5] = this.piece6Label;
            pieceLabel[6] = this.piece7Label;

            for (int i = 0; i <= 6; i++)
            {
                pieceLabel[i].Top = 300;
                pieceLabel[i].Left = 800;
            }

            int height = 0;
            int width = 200;
            int top = 0;
            int left = 50;
            int red = 255;
            int blue = 0;

            activeGame = true;
            moveCounter = 0;
            movesLabel.Text = moveCounter.ToString();
            movesLabel.BackColor = Color.GhostWhite;
            timerLabel.BackColor = Color.GhostWhite;
            gameTimer.Reset();

            // sets up the appropriate number of pieces' locations, sizes, and colors
            switch (pieceNumber)
            {
                case 3:
                    height = 40;
                    top = 300;
                    for (int i = 0; i < pieceNumber; i++)
                    {
                        pieceLabel[i].Size = new System.Drawing.Size(width, height);
                        pieceLabel[i].Location = new Point(left, top);
                        pieceLabel[i].BackColor = Color.FromArgb(red, 50, blue);
                        width -= 40;
                        left += 20;
                        top -= 40;
                        red -= 85;
                        blue += 85;
                    }
                    break;
                case 4:
                    height = 35;
                    top = 305;
                    for (int i = 0; i < pieceNumber; i++)
                    {
                        pieceLabel[i].Size = new System.Drawing.Size(width, height);
                        pieceLabel[i].Location = new Point(left, top);
                        pieceLabel[i].BackColor = Color.FromArgb(red, 50, blue);
                        width -= 40;
                        left += 20;
                        top -= 35;
                        red -= 63;
                        blue += 63;
                    }
                    break;
                case 5:
                    height = 30;
                    top = 310;
                    for (int i = 0; i < pieceNumber; i++)
                    {
                        pieceLabel[i].Size = new System.Drawing.Size(width, height);
                        pieceLabel[i].Location = new Point(left, top);
                        pieceLabel[i].BackColor = Color.FromArgb(red, 50, blue);
                        width -= 30;
                        left += 15;
                        top -= 30;
                        red -= 51;
                        blue += 51;
                    }
                    break;
                case 6:
                    height = 25;
                    top = 315;
                    for (int i = 0; i < pieceNumber; i++)
                    {
                        pieceLabel[i].Size = new System.Drawing.Size(width, height);
                        pieceLabel[i].Location = new Point(left, top);
                        pieceLabel[i].BackColor = Color.FromArgb(red, 50, blue);
                        width -= 26;
                        left += 13;
                        top -= 25;
                        red -= 42;
                        blue += 42;
                    }
                    break;
                case 7:
                    height = 20;
                    top = 320;
                    for (int i = 0; i < pieceNumber; i++)
                    {
                        pieceLabel[i].Size = new System.Drawing.Size(width, height);
                        pieceLabel[i].Location = new Point(left, top);
                        pieceLabel[i].BackColor = Color.FromArgb(red, 50, blue);
                        width -= 20;
                        left += 10;
                        top -= 20;
                        red -= 36;
                        blue += 36;
                    }
                    break;
            }
        }

        // remembers pick-up location and determines if the pickup is legal, on click
        private void Pieces_MouseDown(object sender, MouseEventArgs e)
        {
            var piece = sender as Label;
            pieceLabel[0] = this.piece1Label;
            pieceLabel[1] = this.piece2Label;
            pieceLabel[2] = this.piece3Label;
            pieceLabel[3] = this.piece4Label;
            pieceLabel[4] = this.piece5Label;
            pieceLabel[5] = this.piece6Label;
            pieceLabel[6] = this.piece7Label;

            if (gameTimer.ElapsedTicks == 0)
            {
                gameTimer.Start();
                timer1.Start();
            }

            returnTop = piece.Top;
            returnLeft = piece.Left;
            mouseDownLocation = e.Location;
            movable = true;

            for (int i = 0; i < pieceNumber; i++)
            {
                if (pieceLabel[i].Top < piece.Top)
                {
                    if (pieceLabel[i].Left > piece.Left && pieceLabel[i].Left <= piece.Left + 90)
                    {
                        movable = false;
                    }
                }
            }
        }

        // moves piece being held
        private void Pieces_MouseMove(object sender, MouseEventArgs e)
        {
            var piece = sender as Label;
            if (movable == true && activeGame == true)
            {
                if (e.Button == System.Windows.Forms.MouseButtons.Left)
                {
                    piece.Left = e.X + piece.Left - mouseDownLocation.X;
                    piece.Top = e.Y + piece.Top - mouseDownLocation.Y;
                }
            }
        }

        // zone for each pole determines if drop is legal, and sets drop position or returns piece accordingly
        private void Pieces_MouseUp(object sender, MouseEventArgs e)
        {
            var piece = sender as Label;
            bool legalMove = true;
            int leftStack = 0;
            int stackHeight = 0;

            pieceLabel[0] = this.piece1Label;
            pieceLabel[1] = this.piece2Label;
            pieceLabel[2] = this.piece3Label;
            pieceLabel[3] = this.piece4Label;
            pieceLabel[4] = this.piece5Label;
            pieceLabel[5] = this.piece6Label;
            pieceLabel[6] = this.piece7Label;

            // left pole
            if (piece.Left + (piece.Width / 2) > 70 && piece.Left + (piece.Width / 2) < 230 && piece.Top > 80 && piece.Top < 330)
            {
                for (int i = 0; i < pieceNumber; i++)
                {
                    if (pieceLabel[i].Left + (pieceLabel[i].Width / 2) > 70 && pieceLabel[i].Left + (pieceLabel[i].Width / 2) < 230 && pieceLabel[i].Width < piece.Width)
                    {
                        legalMove = false;
                    }
                }
                if (legalMove == true)
                {
                    for (int i = 0; i < pieceNumber; i++)
                    {
                        if (pieceLabel[i].Left + (pieceLabel[i].Width / 2) > 70 && pieceLabel[i].Left + (pieceLabel[i].Width / 2) < 230)
                        {
                            stackHeight += pieceLabel[i].Height;
                        }
                    }
                    if (piece.Left - returnLeft > 100 || returnLeft - piece.Left > 100)
                    {
                        moveCounter += 1;
                        movesLabel.Text = moveCounter.ToString();
                    }
                    piece.Left = 150 - piece.Width / 2;
                    piece.Top = 340 - stackHeight;
                }
                else
                {
                    piece.Top = returnTop;
                    piece.Left = returnLeft;
                }
            }
            // middle pole
            else if (piece.Left + (piece.Width / 2) > 310 && piece.Left + (piece.Width / 2) < 470 && piece.Top > 80 && piece.Top < 330)
            {
                for (int i = 0; i < pieceNumber; i++)
                {
                    if (pieceLabel[i].Left + (pieceLabel[i].Width / 2) > 310 && pieceLabel[i].Left + (pieceLabel[i].Width / 2) < 470 && pieceLabel[i].Width < piece.Width)
                    {
                        legalMove = false;
                    }
                }
                if (legalMove == true)
                {
                    for (int i = 0; i < pieceNumber; i++)
                    {
                        if (pieceLabel[i].Left + (pieceLabel[i].Width / 2) > 310 && pieceLabel[i].Left + (pieceLabel[i].Width / 2) < 470)
                        {
                            stackHeight += pieceLabel[i].Height;
                        }
                    }
                    if (piece.Left - returnLeft > 100 || returnLeft - piece.Left > 100)
                    {
                        moveCounter += 1;
                        movesLabel.Text = moveCounter.ToString();
                    }
                    piece.Left = 390 - piece.Width / 2;
                    piece.Top = 340 - stackHeight;
                }
                else
                {
                    piece.Top = returnTop;
                    piece.Left = returnLeft;
                }
            }
            // right pole
            else if (piece.Left + (piece.Width / 2) > 550 && piece.Left + (piece.Width / 2) < 710 && piece.Top > 80 && piece.Top < 330)
            {
                for (int i = 0; i < pieceNumber; i++)
                {
                    if (pieceLabel[i].Left + (pieceLabel[i].Width / 2) > 550 && pieceLabel[i].Left + (pieceLabel[i].Width / 2) < 710 && pieceLabel[i].Width < piece.Width)
                    {
                        legalMove = false;
                    }
                }
                if (legalMove == true)
                {
                    for (int i = 0; i < pieceNumber; i++)
                    {
                        if (pieceLabel[i].Left + (pieceLabel[i].Width / 2) > 550 && pieceLabel[i].Left + (pieceLabel[i].Width / 2) < 710)
                        {
                            stackHeight += pieceLabel[i].Height;
                        }
                    }
                    if (piece.Left - returnLeft > 100 || returnLeft - piece.Left > 100)
                    {
                        moveCounter += 1;
                        movesLabel.Text = moveCounter.ToString();
                    }
                    piece.Left = 630 - piece.Width / 2;
                    piece.Top = 340 - stackHeight;
                }
                else
                {
                    piece.Top = returnTop;
                    piece.Left = returnLeft;
                }
            }
            // returns piece if it's not dropped in a zone
            else
            {
                piece.Top = returnTop;
                piece.Left = returnLeft;
            }

            // checks for the game winning move
            for (int i = 0; i < pieceNumber; i++)
            {
                if (pieceLabel[i].Left + (pieceLabel[i].Width / 2) > 550 && pieceLabel[i].Left + (pieceLabel[i].Width / 2) < 710 && pieceLabel[i].Top > 80 && pieceLabel[i].Top < 330)
                {
                    leftStack += 1;
                }
                if (leftStack == pieceNumber)
                {
                    movesLabel.BackColor = Color.SpringGreen;
                    timerLabel.BackColor = Color.SpringGreen;
                    activeGame = false;
                    gameTimer.Stop();
                }
            }
        }

        // updates timer every second
        private void Timer1_Tick(object sender, EventArgs e)
        {
            if (activeGame == true)
            {
                timerLabel.Text = gameTimer.Elapsed.ToString("mm\\:ss");
            }
        }
    }
}
