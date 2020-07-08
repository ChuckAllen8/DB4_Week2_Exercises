using System;
using System.Collections.Generic;
using System.Text;

namespace DB4_Week2_Exercises
{
    class AddNumbersExercise : ConsoleExercise
    {
        public override void Start()
        {
            PrepareConsole(WINDOW_WIDTH, WINDOW_HEIGHT);
            bool loop = true;
            double userNumberOne, userNumberTwo, sum;
            while (loop)
            {
                userNumberOne = GetValidInput<double>("Enter the first number: ");
                userNumberTwo = GetValidInput<double>("Enter the second number: ");
                sum = userNumberOne + userNumberTwo;
                Console.WriteLine($"{sum:N2}");
                loop = RunAgain();
            }
        }
    }
}
