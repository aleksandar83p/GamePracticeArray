using System;

namespace GamePracticeArray
{
   public static class PositionMover
    {
        public static int[,] Movement (int[,] tableMap)
        {
            char input = HelperIO.ReturnDirectionCharacter();

            int[] position = HelperMapTable.FindPostition(tableMap);

            int numColumn = tableMap.GetLength(1);
            int numRow = tableMap.GetLength(0);

            switch (input)
            {
                case 'w':
                    var currentPosition = HelperMapTable.FindPostition(tableMap);
                    if (currentPosition[0] - 1 >= 0)
                    {
                        Console.WriteLine("Moved UP");
                        tableMap[position[0], position[1]] = 0;
                        tableMap[position[0] - 1, position[1]] = 1;
                    }
                    else
                    {
                        HelperIO.PrintBorderEnd();
                    }
                    return tableMap;

                case 's':
                    
                    if (position[0] + 1 < numRow)
                    {
                        tableMap[position[0], position[1]] = 0;
                        tableMap[position[0] + 1, position[1]] = 1;
                        Console.WriteLine("Moved Down");
                    }
                    else
                    {
                        HelperIO.PrintBorderEnd();
                    }                    

                    return tableMap;

                case 'a':
                    if (position[1] - 1 >= 0)
                    {
                        tableMap[position[0], position[1]] = 0;
                        tableMap[position[0], position[1] - 1] = 1;
                        Console.WriteLine("Moved Left");
                    }
                    else
                    {
                        HelperIO.PrintBorderEnd();
                    }
                    return tableMap;

                case 'd':
                   if(position[1] + 1 < numColumn)                   
                   {
                        tableMap[position[0], position[1]] = 0;
                        tableMap[position[0], position[1] + 1] = 1;
                        Console.WriteLine("Moved Right");
                    }
                   else
                   {
                        HelperIO.PrintBorderEnd();
                    }
                    return tableMap;

                default:
                    return tableMap;
            }
        }
    }
}
