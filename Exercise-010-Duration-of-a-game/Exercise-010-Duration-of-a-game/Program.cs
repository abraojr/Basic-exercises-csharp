using System;

namespace Exercise_010_Duration_of_a_game
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Read the start and end time of a game. Then calculate the duration of the game, knowing that it can 
             * start on one day and end on another, having a minimum duration of 1 hour and maximum of 24 hours.*/

            string[] vet = Console.ReadLine().Split(' ');
            int A = int.Parse(vet[0]);
            int B = int.Parse(vet[1]);

            int totDuration;

            if (A > B)
            {
                totDuration = 24 - A + B;
                Console.WriteLine("THE GAME LASTED {0} HOURS", totDuration);
            }
            else if (B > A)
            {
                totDuration = B - A;
                Console.WriteLine("THE GAME LASTED {0} HOURS", totDuration);
            }
            else
            {
                Console.WriteLine("THE GAME LASTED 24 HOURS");
            }
        }
    }
}
