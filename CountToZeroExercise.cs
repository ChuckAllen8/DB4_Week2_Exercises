using System;
using System.Collections.Generic;
using System.Text;

namespace DB4_Week2_Exercises
{
    class CountToZeroExercise : ConsoleExercise
    {
        public override void Start()
        {
            PrepareConsole(WINDOW_WIDTH, WINDOW_HEIGHT);
            bool loop = true;
            int userNumber;
            while (loop)
            {
                userNumber = GetValidInput<int>("Enter a whole number: ");

                if (userNumber > 0)
                {
                    CountTo(userNumber, 0, -1);
                }
                else
                {
                    CountTo(userNumber, 0, 1);
                }

                loop = RunAgain();
            }
        }

        private void CountTo(int start, int stop, int modifier)
        {
            for (int number = start; number != stop; number += modifier)
            {
                Console.Write($"{number} ");
            }
            Console.WriteLine(stop);
        }
    }
}
