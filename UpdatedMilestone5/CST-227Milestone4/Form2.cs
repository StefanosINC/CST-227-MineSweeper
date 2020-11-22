using Milestone1;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Reflection;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CST_227Milestone4
{
    public partial class Form2 : Form

    {
        // Declare a Btn Board and a Board MyBoard
        // ** Problem is the not everything is in the same Class. I have a GameOperations Class
        public MyButton[,] btnBoard;
        public static Stopwatch watch = new Stopwatch();
        //public Board myBoard;
        public GameOperations myBoard;
        private bool flag;
        private int timerInterval = 1000;
        private int hits = 0;
        private int increasespeed = 900;
        int counter = 0;
        // declare a points variable
        private int points = 0;

        public Form2(uint board)
        {
            // game  contains cells
            // btnBoard  contains buttons
            myBoard = new GameOperations(board);
            btnBoard = new MyButton[board, board];
            //myBoard = OperationsBoard;

            InitializeComponent();
            // Create my Grid
            CreateGrid();

            // Set my Bombs to my Board (game)
            myBoard.SetLiveBombs();

            // Set me Caculations to my neighbors to my Board
            myBoard.CaculateNeighorPosition();
          //  myBoard.floodFill(board, board);
            timer1.Interval = timerInterval;


        }

        private void CreateGrid()
        {

            int row = myBoard.boardcell.GetUpperBound(0) + 1;

            int col = myBoard.boardcell.GetUpperBound(myBoard.boardcell.Rank - 1) + 1;

            // Because I do not create a Object yet, Scale the value of the width and the height
            // Multiply by 40* to create seperation of cells.
            int buttonSize = panel1.Width / panel1.Height * 40;

            // Nested Loop to create buttons on screen
            // Lines 52-71 Come from a very similar Model to the ChessBoard Activity
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    btnBoard[i, j] = new MyButton();
                    btnBoard[i, j].Height = buttonSize;
                    btnBoard[i, j].Width = buttonSize;

                    // add a click event to each button.
                    btnBoard[i, j].MouseClick += new MouseEventHandler(ClickButton);
                    btnBoard[i, j].MouseDown += new MouseEventHandler(ClickRight);



                    // add the new button to the pannel

                    panel1.Controls.Add(btnBoard[i, j]);
                    // set the location of the new button
                    btnBoard[i, j].Location = new Point(i * buttonSize, j * buttonSize);
                    // Create a Panel size for the board.
                    panel1.Size = new Size(1070, 1070);

                    btnBoard[i, j].Tag = new Point(i, j);

                    // initiliaze the board.
                    btnBoard[i, j].ButtonCell = myBoard.boardcell[i, j];

                    // watch.Start();

                }
            }
        }
        // Click Button Method. SEt Location of clickedButton Manipulate values.
        private void ClickButton(object sender, MouseEventArgs e)
        {
            //get the row and column number of the button just clicked.
            MyButton clickedButton = (MyButton)sender;
            Point location = (Point)clickedButton.Tag;
            // unsure if i need these still.
            uint x = (uint)location.X;
            uint y = (uint)location.Y;

            // IF user clicks left.  
            if (e.Button == MouseButtons.Left)
            {
                // base case fomb 
                clickedButton.ButtonCell.getLive();
                if (clickedButton.ButtonCell.getLive() == true)
                {
                    // IMage for bomb
                    clickedButton.BackgroundImage = Image.FromFile(@"C:\Users\stefa\Desktop\Pics\bomb2.png");
                    MessageBox.Show("You hit a bomb");
                    MessageBox.Show("Hey! Here is your time: " + watch.Elapsed.ToString());
                    // message to user about points.
                    MessageBox.Show(points.ToString());

                    


                    // Stop timer Exit app
                    watch.Stop();
                    Form4 newForm1 = new Form4();
                    newForm1.Show();
                    
                    Hide();
                    // Application.Exit();
                }

                // Check for neighbors
                clickedButton.ButtonCell.setVisited(true);
                if (clickedButton.ButtonCell.getVisited() == true)
                {
                    watch.Start();
                    // clickbutton text when a normal cell is clicked
                    clickedButton.Text = clickedButton.ButtonCell.getNeighbors().ToString();

                    // set a hitpoint and give it points.
                    points++;
                    
                   
                    lbl_points.Text = points.ToString();



                }
                if (clickedButton.ButtonCell.getNeighbors() == 0 && clickedButton.ButtonCell.getVisited() == true)
                {
                   
                  
                }

            }
        }

      
        private void ClickRight(object sender, MouseEventArgs e)
        {
            MyButton clickedButton1 = (MyButton)sender;
            Point location = (Point)clickedButton1.Tag;
            if (e.Button == MouseButtons.Right)
            {
                // Right Click
                clickedButton1.BackgroundImage = Image.FromFile(@"C:\Users\stefa\Desktop\Pics\flag.png");
                watch.Start();

            }

        }
        

        private void Board_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lbl_time.Text = watch.Elapsed.ToString();
          

        }

        private void lbl_time_Click(object sender, EventArgs e)
        {

        }



        public void floodFill(uint row, uint col)
        {
            // Catch the cell to make it is safe. Make sure that it is greater than 0 however less than the game board
            // This will avoid out of bounds exceptions.
            if ((parameters(row, col)) && !(myBoard.boardcell[row, col].getVisited()))
            {


                // Set a base value to visited true
                myBoard.boardcell[row, col].setVisited(true);


                // if that base value row col and its neighbors == 0
                // floodfill them. 
                if (myBoard.boardcell[row, col].getNeighbors() == 0)
                {

                    // Neighbors of the cell. Locate the 0's.
                    floodFill(row + 1, col - 1);

                    floodFill(row, col + 1);


                    floodFill(row + 1, col);


                    floodFill(row, col - 1);

                    floodFill(row - 1, col);

                    return;

                }
                else if (myBoard.boardcell[row, col].getVisited() && myBoard.boardcell[row, col].getLive())
                {
                    myBoard.boardcell[row, col].setVisited(true);
                    return;
                }
                else
                    return;
            }


        }

        // This method provides parameters. Makes sure that the row/col is more than one but less then gameboardlength
        private bool parameters(uint row, uint col)
        {
            if (row >= 0 && row < myBoard.boardcell.GetLength(0) && col >= 0 && col < myBoard.boardcell.GetLength(0))
            {
                return true;


            }

            else
            {

                return false;
            }


        }
    }
}



      
