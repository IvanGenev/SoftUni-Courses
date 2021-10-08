using System;

namespace KnightGame
{
    class Program
    {
        static void Main(string[] args)
        {
            int rows = int.Parse(Console.ReadLine());

            char[,] chessBoard = new char[rows, rows];

            for (int row = 0; row < chessBoard.GetLength(0); row++)
            {
                string input = Console.ReadLine();

                for (int col = 0; col < chessBoard.GetLength(1); col++)
                {
                    chessBoard[row, col] = input[col];
                }
            }

            int removedKnights = 0;

            while (true)
            {
                int maxAttacks = 0;
                int knightRow = 0;
                int knightCol = 0;

                for (int row = 0; row < chessBoard.GetLength(0); row++)
                {
                    for (int col = 0; col < chessBoard.GetLength(1); col++)
                    {
                        int currentAtacks = 0;

                        if (chessBoard[row, col] != 'K')
                        {
                            continue;
                        }

                        if (IsInside(chessBoard, row - 2, col + 1) && chessBoard[row - 2, col + 1] == 'K')
                        {
                            currentAtacks++;
                        }

                        if (IsInside(chessBoard, row - 1, col + 2) && chessBoard[row - 1, col + 2] == 'K')
                        {
                            currentAtacks++;
                        }

                        if (IsInside(chessBoard, row + 1, col + 2) && chessBoard[row + 1, col + 2] == 'K')
                        {
                            currentAtacks++;
                        }

                        if (IsInside(chessBoard, row + 2, col + 1) && chessBoard[row + 2, col + 1] == 'K')
                        {
                            currentAtacks++;
                        }

                        if (IsInside(chessBoard, row + 2, col - 1) && chessBoard[row + 2, col - 1] == 'K')
                        {
                            currentAtacks++;
                        }

                        if (IsInside(chessBoard, row + 1, col - 2) && chessBoard[row + 1, col - 2] == 'K')
                        {
                            currentAtacks++;
                        }

                        if (IsInside(chessBoard, row - 1, col - 2) && chessBoard[row - 1, col - 2] == 'K')
                        {
                            currentAtacks++;
                        }

                        if (IsInside(chessBoard, row - 2, col - 1) && chessBoard[row - 2, col - 1] == 'K')
                        {
                            currentAtacks++;
                        }

                        if (currentAtacks > maxAttacks)
                        {
                            maxAttacks = currentAtacks;
                            knightRow = row;
                            knightCol = col;
                        }
                    }
                }

                if (maxAttacks == 0)
                {
                    Console.WriteLine(removedKnights);
                    break;
                }
                else
                {
                    chessBoard[knightRow, knightCol] = '0';

                    removedKnights++;
                }
            }
        }

        private static bool IsInside(char[,] chessBoard, int row, int col)
        {
            return row >= 0 && row < chessBoard.GetLength(0) &&
                col >= 0 && col < chessBoard.GetLength(1);
        }
    }
}
