using System;
using System.Collections.Generic;
using System.Text;

namespace DB4_Week2_Exercises
{
    class NumberCubesExercise : ConsoleExercise
    {
        public override void Start()
        {
            PrepareConsole(WINDOW_WIDTH, WINDOW_HEIGHT);
            bool loop = true;

            while (loop)
            {
                DisplaySquares(GetNumber());
                Console.WriteLine("");
                loop = RunAgain();
            }
        }

        private void DisplaySquares(int stop)
        {
            for (int number = 1; number <= stop; number++)
            {
                Console.Write($"{number * number * number:#,#.##} ");
            }
        }

        private int GetNumber()
        {
            int userNumber;
            do
            {
                userNumber = GetValidInput<int>("Enter a whole, positive, number: ");
            } while (userNumber <= 0);

            return userNumber;
        }
    }
}
