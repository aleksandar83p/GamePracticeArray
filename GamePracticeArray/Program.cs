namespace GamePracticeArray
{
    class Program
    {    
        static void Main()
        {
            HelperIO.PrintDirection();

            var table = HelperMapTable.CreateTableMap();
            bool OK = true;

            while (OK)
            {
                HelperMapTable.PrintTableMap(table);

                PositionMover.Movement(table);
            }
        }           
    }
}

