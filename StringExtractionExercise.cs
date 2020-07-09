using System;
using System.Collections.Generic;
using System.Text;

namespace DB4_Week2_Exercises
{
    class StringExtractionExercise : ConsoleExercise
    {
        public override void Start()
        {
            PrepareConsole(WINDOW_WIDTH, WINDOW_HEIGHT);
            bool loop = true;
            string userInput, firstTen;

            while (loop)
            {
                userInput = GetValidInput<string>("Enter some text: ");

                try
                {
                    firstTen = userInput.Substring(0, 10);
                }
                catch
                {
                    firstTen = userInput;
                }

                Console.WriteLine($"The first {firstTen.Length} character were: {firstTen}");
                loop = RunAgain();
            }
        }
    }
}
