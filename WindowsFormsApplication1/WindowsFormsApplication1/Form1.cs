/*
 * NQueens Program written by Christopher Cunningham
 * This program is for an extra credit project for my Algorithms Class
 * and Ajinkya Kulkarni
 * 
 * This program uses a backtracking algorithm that was not fully written by me, after researching different ways
 * and looking through different sets of code on GitHub and CodeProject, I zombied something together and learned a lot from it.
 * 
 * This program does not run extremely fast, as there are plenty of algorithms that run it way faster, but I am still learning the
 * process of backtracking this problem. 
 * 
 * There is a method named UpdateFields(); that updates the GUI while the program is running, if you comment this call out, it will
 * decrease the amount of time it takes to find all solutions (~almost %50 decrease in time).
 * 
 * There are still a lot of small tweaks I could make to make this program faster, but I feel extremely good about the work that was created
 * 
 * */



using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class NQueensGUI : Form
    {
        //initialize global variables
        TimeSpan tsRunningTime;
        int iQueens;
        int iCount = 0;
        int[,] iChessBoard;
        int iAttempts;
        int[] iPlaceHolder;


        public NQueensGUI()
        {
            InitializeComponent();

        }

        private void button1_Click(object sender, EventArgs e)
        {

            //get start time
            DateTime dtStart = DateTime.Now;

            //clear form data 
            ClearTextBoxes();
            ResetVariables();
            UpdateFields();

            //get user input of queens for NXN use
            String strQueens = tbNumOfQueens.Text;
            iQueens = Convert.ToInt32(strQueens);

            
            //check if user inputted a 0 as this is not a valid size
            if(iQueens == 0)
            {
                rbGUIOutput.AppendText("Enter a number greater than 0.");
                return;
            }


            //create a new chess board
            iChessBoard = new int[iQueens, iQueens];
            iAttempts = 0;

            //Update so user knows what is happening
            tbStatus.Text = "Calculating..Please Wait.";
            UpdateFields();


            //Create Chess board
            CreateBoard();

            //take the number of queens so that we can parse through the board
            iPlaceHolder = new int[iQueens];

            //decrement the placeholder so that we can make sure we have the correct size board
            for (int i = 0; i < iQueens; i++)
            {
                iPlaceHolder[i] = -1;
            }


            //Call BackTracking Algorithm
            nQueensBackTrack();


            //Calculate total running time of calculation
            DateTime dtEnd = DateTime.Now;
            tsRunningTime = dtEnd - dtStart;
            tbRunningTime.Text = Convert.ToString(tsRunningTime);
        }


        public void CreateBoard()
        {
            //Create the board and set all [x,y] positions to 0
            for (int x = 0; x < iQueens; x++)
            {
                for (int y = 0; y < iQueens; y++)
                {
                    iChessBoard[x, y] = 0;
                }
            }
        }

        public void nQueensBackTrack()
        {
            //Start backtrack
            for (int position = 0; ; )
            {
                iPlaceHolder[position]++;
                //Move a back a column
                if (iPlaceHolder[position] == iQueens)
                {
                    //get position
                    iChessBoard[iPlaceHolder[position] - 1, position] = 0;
                    iPlaceHolder[position] = -1;
                    position--;
                    //if the position of solution is not on the board, there was no solutions found, prompt user and end
                    if (position == -1)
                    {
                        if (iCount == 0)
                        {
                            tbSolutions.Text = "No Solutions Found.";
                            rbGUIOutput.AppendText("No Solutions Found.");
                        }
                        tbStatus.Text = "Finished checking board.";

                        break;
                    }
                }
                else
                {
                    //get position
                    iChessBoard[iPlaceHolder[position], position] = 1;
                    if (iPlaceHolder[position] != 0)
                    {
                        iChessBoard[iPlaceHolder[position] - 1, position] = 0;
                    }
                    if (CheckAllPositions(iChessBoard, iQueens))
                    {
                        //increment to the next column to begin
                        position++;
                        if (position == iQueens)
                        {
                            position--;
                            iCount++;

                            //update how many solutions are found
                            tbSolutions.Text = Convert.ToString(iCount);
                            UpdateFields();


                            //if there is a valid solution, print a 1 on the board, else print a 0; all of this is in the correct [x,y] coordinate
                            rbGUIOutput.AppendText("Board" + iCount.ToString() + ":\n");
                            for (int xCord = 0; xCord < iQueens; xCord++)
                            {
                                for (int yCord = 0; yCord < iQueens; yCord++)
                                {
                                    rbGUIOutput.AppendText(iChessBoard[xCord, yCord] + " ");
                                }
                                rbGUIOutput.AppendText("\n");
                            }
                            rbGUIOutput.AppendText("\n");
                        }
                    }
                    //increment attempts to find a solution and dynamically show to user
                    iAttempts++;
                    tbAttempts.Text = Convert.ToString(iAttempts);
                    UpdateFields();
                }
            }

        }
        public static bool CheckAllPositions(int[,] board, int N)
        {
            //Check the rows for a valid position
            for (int l = 0; l < N; l++)
            {
                int iValidSolutionSum = 0;
                for (int r = 0; r < N; r++)
                {
                    iValidSolutionSum = iValidSolutionSum + board[l, r];
                }
                if (iValidSolutionSum > 1)
                {
                    return false;
                }
            }
            //Check the diagonals for a valid position
            //check the diagonal above the current position
            for (int l = 0, r = N - 2; r >= 0; r--)
            {
                int iValidSolutionSum = 0;
                for (int xCord = l, yCord = r; yCord < N; xCord++, yCord++)
                {
                    iValidSolutionSum = iValidSolutionSum + board[xCord, yCord];
                }
                if (iValidSolutionSum > 1)
                {
                    return false;
                }
            }
            //check the diagonal below current position
            for (int l = 1, r = 0; l < N - 1; l++)
            {
                int iValidSolutionSum = 0;
                for (int xCord = l, yCord = r; xCord < N; xCord++, yCord++)
                {
                    iValidSolutionSum = iValidSolutionSum + board[xCord, yCord];
                }
                if (iValidSolutionSum > 1)
                {
                    return false;
                }
            }
            //Check the other diagonals
            //check diagonal to the left
            for (int l = 0, r = 1; r < N; r++)
            {
                int iValidSolutionSum = 0;
                for (int xCord = l, yCord = r; yCord >= 0; xCord++, yCord--)
                {
                    iValidSolutionSum = iValidSolutionSum + board[xCord, yCord];
                }
                if (iValidSolutionSum > 1)
                {
                    return false;
                }
            }
            //check diagonals below and to the left
            for (int l = 1, r = N - 1; l < N - 1; l++)
            {
                int iValidSolutionSum = 0;
                for (int xCord = l, yCord = r; xCord < N; xCord++, yCord--)
                {
                    iValidSolutionSum = iValidSolutionSum + board[xCord, yCord];
                }
                if (iValidSolutionSum > 1)
                {
                    return false;
                }
            }
            return true;

        }

        public void ResetVariables()
        {
            iQueens = 0;
            iCount = 0;
            iChessBoard = null;
            iAttempts = 0;
            iPlaceHolder = null;

        }

        public void ClearTextBoxes()
        {
            tbStatus.Text = "";
            tbSolutions.Text = "";
            tbAttempts.Text = "";
            tbRunningTime.Text = "";
            rbGUIOutput.Clear();

        }

        public void UpdateFields()
        {
            Application.DoEvents();
        }


    }
}
