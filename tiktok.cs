using System;

namespace First_project
{
    class Program
    {
            
        static void Turn(out int xGuessB, out int yGuessB, int playerToken)
        {
            string xVal;
            string yVal;
            string player = playerToken == 1 ? "X" : "Y";

            Console.WriteLine($"Player {player}! Are you ready?");
            Console.WriteLine("What is the x coordinate of your guess?");
            xVal = Console.ReadLine();
            xGuessB = Convert.ToInt32(xVal);
            xGuessB--;
            Console.WriteLine("What is the y coordinate of your guess?");
            yVal = Console.ReadLine();
            yGuessB = Convert.ToInt32(yVal);
            yGuessB--;
        }

        static void DrawBoard(int[,] board)
        {
            Console.WriteLine();
            Console.WriteLine($"{board[0, 2]} {board[1, 2]} {board[2, 2]}");
            Console.WriteLine($"{board[0, 1]} {board[1, 1]} {board[2, 1]}");
            Console.WriteLine($"{board[0, 0]} {board[1, 0]} {board[2, 0]}");
            Console.WriteLine();
        }

        static bool CheckVictory(int[,] board, int pt)
        {
            return board[0, 0] == pt && board[0, 1] == pt && board[0, 2] == pt || 
                   board[0, 1] == pt && board[1, 1] == pt && board[2, 1] == pt ||
                   board[0, 2] == pt && board[1, 2] == pt && board[2, 2] == pt ||
                   board[0, 0] == pt && board[1, 0] == pt && board[2, 0] == pt ||
                   board[1, 0] == pt && board[1, 1] == pt && board[1, 2] == pt ||
                   board[2, 0] == pt && board[2, 1] == pt && board[2, 2] == pt ||
                   board[0, 0] == pt && board[1, 1] == pt && board[2, 2] == pt ||
                   board[0, 2] == pt && board[1, 1] == pt && board[2, 0] == pt;
        }

        static void Main(string[] args)
        {
            bool play = true;
            while (play)
            {

                int xGuess;
                int yGuess;
                int[,] newBoard = new int[,] { {0, 0, 0}, {0, 0, 0}, { 0, 0, 0} };
                int[,] board = newBoard;
                int turnCounter = 0;
                bool invalidTurn = false;
                bool draw = true;
                DrawBoard(board);
                while (turnCounter <= 8)
                {
                    int playerToken = turnCounter % 2 + 1;

                    do{
                      Turn(out xGuess, out yGuess, playerToken);
                      if (xGuess > 2 || xGuess < 0 || yGuess > 2 || yGuess < 0) 
                      {
                         Console.WriteLine("That's not a square! Try again.");
                         invalidTurn = true;
                      }
                      else if(board[xGuess, yGuess] != 0){
                        Console.WriteLine("Already used this square! Pick another.");
                        invalidTurn = true;
                      }
                      else{
                        invalidTurn = false;
                      }
                    }while(invalidTurn);

                    board[xGuess, yGuess] = playerToken;
                    DrawBoard(board);

                    if (CheckVictory(board, playerToken))
                    {
                      Console.WriteLine("You Won!");
                      draw = false;
                      break;
                    }
                    turnCounter++;
                }

              if(draw){
                  Console.WriteLine("Cat Game! Woof.");
              }

              Console.WriteLine("play again? true/false");
              string playString = Console.ReadLine();
              if (playString == "false")
              {
                  play = false;

              }
              else{
                play = true;
              }
           }
        }
    }
}
