using System;
using System.Collections.Generic;
using System.Text;

namespace DB4_Week2_Exercises
{
    class EchoExercise : ConsoleExercise
    {
        public override void Start()
        {
            PrepareConsole(WINDOW_WIDTH, WINDOW_HEIGHT);
            bool loop = true;
            string userInput;
            while(loop)
            {
                userInput = GetValidInput<string>("Enter some text: ");
                Console.WriteLine(userInput);
                loop = RunAgain();
            }
        }
    }
}
