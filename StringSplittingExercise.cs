using System;
using System.Collections.Generic;
using System.Text;

namespace DB4_Week2_Exercises
{
    class StringSplittingExercise : ConsoleExercise
    {
        public override void Start()
        {
            PrepareConsole(WINDOW_WIDTH, WINDOW_HEIGHT);
            bool loop = true;
            string userInput;
            string[] words;

            while (loop)
            {
                userInput = GetValidInput<string>("Enter a sentence: ");

                words = userInput.Split(" ");

                foreach(string word in words)
                {
                    Console.WriteLine(word);
                }

                loop = RunAgain();
            }
        }
    }
}
