using System;
namespace TicTacToeEXE
{
    public class Board
    {
        public Program program = new Program();

        public string[,] Tiles = {
                {"1", "2", "3"},
                {"4", "5", "6"},
                {"7", "8", "9"}
        };

        public string[,] newTiles = {
                {"1", "2", "3"},
                {"4", "5", "6"},
                {"7", "8", "9"}
        };

        public bool ChangeTiles(string input, string player)
        {
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (newTiles[i, j].Equals(input))
                    {
                        if (Tiles[i, j].Equals("X") || Tiles[i, j].Equals("O"))
                        {
                            Console.WriteLine("Cannot choose slot already taken");
                            return false;
                        }
                        else
                        {
                            Tiles[i, j] = player;
                            return true;
                        }
                    }
                }
            }
            return false;
        }

        public bool isWinner()
        {
            if (Tiles[0, 0].Equals("X") && Tiles[0, 1].Equals("X") && Tiles[0, 2].Equals("X"))
                return true;
            else if (Tiles[1, 0].Equals("X") && Tiles[1, 1].Equals("X") && Tiles[1, 2].Equals("X"))
                return true;
            else if (Tiles[2, 0].Equals("X") && Tiles[2, 1].Equals("X") && Tiles[2, 2].Equals("X"))
                return true;
            else if (Tiles[0, 0].Equals("X") && Tiles[1, 0].Equals("X") && Tiles[2, 0].Equals("X"))
                return true;
            else if (Tiles[0, 1].Equals("X") && Tiles[1, 1].Equals("X") && Tiles[2, 1].Equals("X"))
                return true;
            else if (Tiles[0, 2].Equals("X") && Tiles[1, 2].Equals("X") && Tiles[2, 2].Equals("X"))
                return true;
            else if (Tiles[0, 0].Equals("X") && Tiles[1, 1].Equals("X") && Tiles[2, 2].Equals("X"))
                return true;
            else if (Tiles[0, 2].Equals("X") && Tiles[1, 1].Equals("O") && Tiles[0, 2].Equals("O"))
                return true;
            else if (Tiles[0, 0].Equals("O") && Tiles[0, 1].Equals("O") && Tiles[0, 2].Equals("O"))
                return true;
            else if (Tiles[1, 0].Equals("O") && Tiles[1, 1].Equals("O") && Tiles[1, 2].Equals("O"))
                return true;
            else if (Tiles[2, 0].Equals("O") && Tiles[2, 1].Equals("O") && Tiles[2, 2].Equals("O"))
                return true;
            else if (Tiles[0, 0].Equals("O") && Tiles[1, 0].Equals("O") && Tiles[2, 0].Equals("O"))
                return true;
            else if (Tiles[0, 1].Equals("O") && Tiles[1, 1].Equals("O") && Tiles[2, 1].Equals("O"))
                return true;
            else if (Tiles[0, 2].Equals("O") && Tiles[1, 2].Equals("O") && Tiles[2, 2].Equals("O"))
                return true;
            else if (Tiles[0, 0].Equals("O") && Tiles[1, 1].Equals("O") && Tiles[2, 2].Equals("O"))
                return true;
            else if (Tiles[0, 2].Equals("O") && Tiles[1, 1].Equals("O") && Tiles[0, 2].Equals("O"))
                return true;
            else
                return false;
        }
    }
}
