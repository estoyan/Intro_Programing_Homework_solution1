using System;


namespace PrintSequence
{
    class PrintSequence
    {
        static void Main()
        {
           int x = 2;
           int y = -3;
           Console.WriteLine(x);
           Console.WriteLine(y);
            for (int z = 1; z < 5; z++)
                {
                x = x + 2;
                y = y - 2;
                Console.WriteLine(x);
                Console.WriteLine(y);
                }
        }
    }
}
