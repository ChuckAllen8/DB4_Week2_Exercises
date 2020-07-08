using System;
using System.Collections.Generic;
using System.Text;

namespace DB4_Week2_Exercises
{
    class SumAllExercise : ConsoleExercise
    {
        public override void Start()
        {
            PrepareConsole(WINDOW_WIDTH, WINDOW_HEIGHT);
            bool loop = true;
            int userNumber;
            while (loop)
            {
                userNumber = GetValidInput<int>("Enter a whole number: ");

                if (userNumber > 1)
                {
                    AddAll(userNumber);
                }
                else
                {
                    Console.WriteLine("Number must be greater than 1.");
                }

                loop = RunAgain();
            }
        }

        private void AddAll(int stop)
        {
            int sum = 0;
            for (int number = 1; number <= stop; number++)
            {
                sum += number;
            }
            Console.WriteLine($"The sum is: {sum}");
        }
    }
}
