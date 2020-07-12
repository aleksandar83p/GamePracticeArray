using System;

namespace GamePracticeArray
{
    public static class HelperIO
    {
        public static char ReturnDirectionCharacter()
        {
            bool isCharOK = false;
            char inputChar;

            do
            {
                Console.WriteLine("Please enter command");
                var input = Console.ReadLine().ToLower();

                inputChar = input[0];                

                if (inputChar == 'w' || inputChar == 's' || inputChar == 'a' || inputChar == 'd')
                {
                    isCharOK = true;
                }
                else
                {
                    Console.WriteLine("Please enter W, S, A or D.");
                }
            } while (!isCharOK);

            return inputChar;
        }

        public static void PrintDirection()
        {
            Console.WriteLine("Press W do move UP\nPress S do move DOWN\nPress A to move LEFT\nPress D to move RIGHT\nAfter entering letter press ENTER\n");
        }

        public static void PrintBorderEnd()
        {
            Console.WriteLine("You have reach the edge of table, move on some other side.");
        }
    }
}
