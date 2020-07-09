using System;

namespace DB4_Week2_Exercises
{
    class SumFromAndToExercise : ConsoleExercise
    {
        public override void Start()
        {
            PrepareConsole(WINDOW_WIDTH, WINDOW_HEIGHT);
            bool loop = true;
            int userNumberOne, userNumberTwo;
            double sum;
            while (loop)
            {
                userNumberOne = GetValidInput<int>("Enter the first number: ");
                userNumberTwo = GetValidInput<int>("Enter the second number: ");

                if (userNumberTwo > userNumberOne)
                {
                    sum = SumBetween(userNumberOne, userNumberTwo, 1);
                }
                else
                {
                    sum = SumBetween(userNumberTwo, userNumberOne, 1);
                }

                Console.WriteLine($"The sum from {userNumberOne} to {userNumberTwo} is: {sum}");
                loop = RunAgain();
            }
        }

        private double SumBetween(int start, int stop, int modifier)
        {
            double sum = 0;
            for (int number = start; number != stop; number += modifier)
            {
                sum += number;
            }
            return sum + stop;
        }
    }
}
