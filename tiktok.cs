using System;

namespace First_project
{
    class Program
    {
            
        static void XTurn(out int xGuessB, out int yGuessB)
        {
            string xVal;
            string yVal;
            Console.WriteLine("Player X! Are you ready?");
            Console.WriteLine("What is the x coordinate of your guess?");
            xVal = Console.ReadLine();
            xGuessB = Convert.ToInt32(xVal);
            Console.WriteLine("What is the y coordinate of your guess?");
            yVal = Console.ReadLine();
            yGuessB = Convert.ToInt32(yVal);

        }


        static void YTurn(out int xGuessB, out int yGuessB)
        {
            string xVal;
            string yVal;
            Console.WriteLine("Player Y! Are you ready?");
            Console.WriteLine("What is the x coordinate of your guess?");
            xVal = Console.ReadLine();
            xGuessB = Convert.ToInt32(xVal);
            Console.WriteLine("What is the y coordinate of your guess?");
            yVal = Console.ReadLine();
            yGuessB = Convert.ToInt32(yVal);
        }

        static void DrawBoard(int[,] board)
        {
            Console.WriteLine($"{board[1, 3]} {board[2, 3]} {board[3, 3]}");
            Console.WriteLine($"{board[1, 2]} {board[2, 2]} {board[3, 2]}");
            Console.WriteLine($"{board[1, 1]} {board[2, 1]} {board[3, 1]}");
        }

        static bool CheckVictoryX(int[,] board, int xGuess, int yGuess)
        {
            
            int[] victoryArray = new int[] { 0, 0, 0, 0, 0, 0, 0, 0 };
            if(board[xGuess + 1,yGuess + 1] == 1)
            {
                victoryArray[0] = 1;
                Console.WriteLine("it worked!");
                if (board[xGuess + 2, yGuess + 2] == 1)
                {
                    Console.WriteLine("YouWin!!");
                    return true;
                    
                }
                if (board[xGuess - 1, yGuess - 1] == 1)
                {
                    Console.WriteLine("YouWin!!");
                    return true;


                }

            }
            if (board[xGuess + 1, yGuess] == 1)
            {
                if (board[xGuess + 2, yGuess] == 1)
                {
                    Console.WriteLine("YouWin!!");
                    return true;
                }
                if (board[xGuess - 1, yGuess] == 1)
                {
                    Console.WriteLine("YouWin!!");
                    return true;

                }
            }
            if (board[xGuess + 1, yGuess - 1] == 1)
            {
                if (board[xGuess + 2, yGuess - 2] == 1)
                {
                    Console.WriteLine("YouWin!!");
                    return true;
                }
                if (board[xGuess - 1, yGuess + 1] == 1)
                {
                    Console.WriteLine("YouWin!!");
                    return true;

                }
            }
            if (board[xGuess, yGuess - 1] == 1)
            {
                if (board[xGuess, yGuess - 2] == 1)
                {
                    Console.WriteLine("YouWin!!");
                    return true;
                }
                if (board[xGuess, yGuess + 1] == 1)
                {
                    Console.WriteLine("YouWin!!");
                    return true;

                }
            }
            if (board[xGuess - 1, yGuess - 1] == 1)
            {
                if (board[xGuess - 2, yGuess -2] == 1)
                {
                    Console.WriteLine("YouWin!!");
                    return true;
                }
                if (board[xGuess + 1, yGuess + 1] == 1)
                {
                    Console.WriteLine("YouWin!!");
                    return true;

                }
            }
            if (board[xGuess - 1, yGuess] == 1)
            {
                if (board[xGuess - 2, yGuess] == 1)
                {
                    Console.WriteLine("YouWin!!");
                    return true;
                }
                if (board[xGuess + 1, yGuess] == 1)
                {
                    Console.WriteLine("YouWin!!");
                    return true;

                }
            }
            if (board[xGuess - 1, yGuess + 1] == 1)
            {
                if (board[xGuess - 2, yGuess + 2] == 1)
                {
                    Console.WriteLine("YouWin!!");
                    return true;
                }
                if (board[xGuess + 1, yGuess - 1] == 1)
                {
                    Console.WriteLine("YouWin!!");
                    return true;

                }
            }
            if (board[xGuess, yGuess + 1] == 1)
            {
                if (board[xGuess, yGuess + 2] == 1)
                {
                    Console.WriteLine("YouWin!!");
                    return true;
                }
                if (board[xGuess, yGuess - 1] == 1)
                {
                    Console.WriteLine("YouWin!!");
                    return true;

                }
            }
            return false;


        }

        static bool CheckVictoryY(int[,] board, int xGuess, int yGuess)
        {

            int[] victoryArray = new int[] { 0, 0, 0, 0, 0, 0, 0, 0 };
            if (board[xGuess + 1, yGuess + 1] == 2)
            {
                victoryArray[0] = 1;
                Console.WriteLine("it worked!");
                if (board[xGuess + 2, yGuess + 2] == 2)
                {
                    Console.WriteLine("YouWin!!");
                    return true;

                }
                if (board[xGuess - 1, yGuess - 1] == 2)
                {
                    Console.WriteLine("YouWin!!");
                    return true;


                }

            }
            if (board[xGuess + 1, yGuess] == 2)
            {
                if (board[xGuess + 2, yGuess] == 2)
                {
                    Console.WriteLine("YouWin!!");
                    return true;
                }
                if (board[xGuess - 1, yGuess] == 2)
                {
                    Console.WriteLine("YouWin!!");
                    return true;

                }
            }
            if (board[xGuess + 1, yGuess - 1] == 2)
            {
                if (board[xGuess + 2, yGuess - 2] == 2)
                {
                    Console.WriteLine("YouWin!!");
                    return true;
                }
                if (board[xGuess - 1, yGuess + 1] == 2)
                {
                    Console.WriteLine("YouWin!!");
                    return true;

                }
            }
            if (board[xGuess, yGuess - 1] == 2)
            {
                if (board[xGuess, yGuess - 2] == 2)
                {
                    Console.WriteLine("YouWin!!");
                    return true;
                }
                if (board[xGuess, yGuess + 1] == 2)
                {
                    Console.WriteLine("YouWin!!");
                    return true;

                }
            }
            if (board[xGuess - 1, yGuess - 1] == 2)
            {
                if (board[xGuess - 2, yGuess - 2] == 2)
                {
                    Console.WriteLine("YouWin!!");
                    return true;
                }
                if (board[xGuess + 1, yGuess + 1] == 2)
                {
                    Console.WriteLine("YouWin!!");
                    return true;

                }
            }
            if (board[xGuess - 1, yGuess] == 2)
            {
                if (board[xGuess - 2, yGuess] == 2)
                {
                    Console.WriteLine("YouWin!!");
                    return true;
                }
                if (board[xGuess + 1, yGuess] == 2)
                {
                    Console.WriteLine("YouWin!!");
                    return true;

                }
            }
            if (board[xGuess - 1, yGuess + 1] == 2)
            {
                if (board[xGuess - 2, yGuess + 2] == 2)
                {
                    Console.WriteLine("YouWin!!");
                    return true;
                }
                if (board[xGuess + 1, yGuess - 1] == 2)
                {
                    Console.WriteLine("YouWin!!");
                    return true;

                }
            }
            if (board[xGuess, yGuess + 1] == 2)
            {
                if (board[xGuess, yGuess + 2] == 2)
                {
                    Console.WriteLine("YouWin!!");
                    return true;
                }
                if (board[xGuess, yGuess - 1] == 2)
                {
                    Console.WriteLine("YouWin!!");
                    return true;

                }
            }
            return false;
        }

            static void Main(string[] args)
        {

            
            bool play = true;
            string playString;
            while (play == true)
            {

                int xGuess;
                int yGuess;
                int[,] newBoard = new int[,] { { 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0 } };
                int[,] board = newBoard;
                int turnCounter = 1;
                while (turnCounter <= 9)
                {
                    
                    //XTurn
                    XTurn(out xGuess, out yGuess);

                    if (xGuess > 3)
                    {
                        Console.WriteLine("That's not a square! Try again.");
                        XTurn(out xGuess, out yGuess);
                    }
                    if (xGuess < 1)
                    {
                        Console.WriteLine("That's not a square! Try again.");
                        XTurn(out xGuess, out yGuess);
                    }
                    else
                    {

                        if (board[xGuess, yGuess] != 0)
                        {
                            Console.WriteLine("Already used this square! Pick another.");
                            XTurn(out xGuess, out yGuess);
                        }
                        else
                        {
                            board[xGuess, yGuess] = 1;
                            DrawBoard(board);
                            if (CheckVictoryX(board, xGuess, yGuess) == true)
                                {
                                goto End;
                            }


                        }
                    }
                    turnCounter += 1;
                    //YTurn
                    YTurn(out xGuess, out yGuess);

                    if (xGuess > 3)
                    {
                        Console.WriteLine("That's not a square! Try again.");
                        YTurn(out xGuess, out yGuess);
                    }
                    if (xGuess < 1)
                    {
                        Console.WriteLine("That's not a square! Try again.");
                        YTurn(out xGuess, out yGuess);
                    }
                    else
                    {

                        if (board[xGuess, yGuess] != 0)
                        {
                            Console.WriteLine("Already used this square! Pick another.");
                            YTurn(out xGuess, out yGuess);
                        }
                        else
                        {
                            board[xGuess, yGuess] = 2;
                            DrawBoard(board);
                            if (CheckVictoryY(board, xGuess, yGuess) == true)
                            { goto End; }
                        }
                    }
                    turnCounter += 1;

                }

                Console.WriteLine("Cat Game! Woof.");


               
                
                
                End:
                Console.WriteLine("play again? true/false");
                playString = Console.ReadLine();
                if (playString == "false")
                {
                    play = false;

                }
            }




        }
    }
}
