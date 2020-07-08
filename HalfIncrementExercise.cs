using System;
using System.Collections.Generic;
using System.Text;

namespace DB4_Week2_Exercises
{
    class HalfIncrementExercise : ConsoleExercise
    {
        public override void Start()
        {
            PrepareConsole(WINDOW_WIDTH, WINDOW_HEIGHT);
            bool loop = true;
            double userInput;
            while (loop)
            {
                userInput = GetValidInput<double>("Enter a number: ") + 0.5;
                Console.WriteLine(userInput);
                loop = RunAgain();
            }
        }
    }
}
