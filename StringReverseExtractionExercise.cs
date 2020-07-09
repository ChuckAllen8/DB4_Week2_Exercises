using System;
using System.Collections.Generic;
using System.Text;

namespace DB4_Week2_Exercises
{
    class StringReverseExtractionExercise : ConsoleExercise
    {
        public override void Start()
        {
            PrepareConsole(WINDOW_WIDTH, WINDOW_HEIGHT);
            bool loop = true;
            string userInput, lastTen;

            while (loop)
            {
                userInput = GetValidInput<string>("Enter some text: ");

                try
                {
                    lastTen = userInput.Substring(userInput.Length - 10);
                }
                catch
                {
                    lastTen = userInput;
                }

                Console.WriteLine($"The last {lastTen.Length} character were: {lastTen}");
                loop = RunAgain();
            }
        }
    }
}
