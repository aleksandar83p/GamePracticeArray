using System;

namespace GamePracticeArray
{
    public static class HelperMapTable
    {
        public static int[,] CreateTableMap ()
        {
            Random randomNum = new Random();

            int numOfRows = randomNum.Next(5, 15);
            int numOfColumns = randomNum.Next(5, 15);

            int[,] game = new int[numOfRows, numOfColumns];

            for (int i = 0; i < game.GetLength(0); i++)
            {
                for (int j = 0; j < game.GetLength(1); j++)
                {
                    game[i, j] = 0;
                }
            }

            int numI = randomNum.Next(0, game.GetLength(0));
            int numJ = randomNum.Next(0, game.GetLength(1));

            game[numI, numJ] = 1;

            return game;
        }

        public static int[] FindPostition(int[,] tableMap)
        {
            int[] position = new int[] { 0, 0 };

            for (int i = 0; i < tableMap.GetLength(0); i++)
            {
                for (int j = 0; j < tableMap.GetLength(1); j++)
                {
                    if (tableMap[i, j] == 1)
                    {
                        position[0] = i;
                        position[1] = j;
                    }
                }
            }
            return position;
        }

        public static void PrintTableMap(int[,] game)
        {
            for (int i = 0; i < game.GetLength(0); i++)
            {
                for (int j = 0; j < game.GetLength(1); j++)
                {
                    Console.Write(game[i, j] + "\t");
                }
                Console.WriteLine();
            }
        }       
    }
}
