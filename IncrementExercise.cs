using System;
using System.Collections.Generic;
using System.Text;

namespace DB4_Week2_Exercises
{
    class IncrementExercise : ConsoleExercise
    {
        public override void Start()
        {
            PrepareConsole(WINDOW_WIDTH, WINDOW_HEIGHT);
            bool loop = true;
            int userInput;
            while (loop)
            {
                userInput = GetValidInput<int>("Enter a number: ");
                Console.WriteLine(++userInput);
                loop = RunAgain();
            }
        }
    }
}
