using System;
using System.Collections.Generic;
using System.Text;

namespace DB4_Week2_Exercises
{
    class MultiplyNumbersExercise : ConsoleExercise
    {
        public override void Start()
        {
            PrepareConsole(WINDOW_WIDTH, WINDOW_HEIGHT);
            bool loop = true;
            double userNumberOne, userNumberTwo, product;
            while (loop)
            {
                userNumberOne = GetValidInput<double>("Enter the first number: ");
                userNumberTwo = GetValidInput<double>("Enter the second number: ");
                product = userNumberOne * userNumberTwo;
                Console.WriteLine($"{product:N2}");
                loop = RunAgain();
            }
        }
    }
}
