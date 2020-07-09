using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DB4_Week2_Exercises
{
    class VowelCountExercise : ConsoleExercise
    {
        public override void Start()
        {
            PrepareConsole(WINDOW_WIDTH, WINDOW_HEIGHT);
            bool loop = true;
            string userInput;
            char[] vowels = { 'A', 'E', 'I', 'O', 'U', 'Y', 'a', 'e', 'i', 'o', 'u', 'y' };

            while (loop)
            {
                int vowelCount = 0;
                userInput = GetValidInput<string>("Enter a sentence: ");

                foreach(char letter in userInput.ToCharArray())
                {
                    if(vowels.Contains(letter))
                    {
                        vowelCount++;
                    }
                }

                Console.WriteLine($"There {(vowelCount == 1 ? "was" : "were")} {(vowelCount > 0 ? vowelCount.ToString() : "no")} vowel{(vowelCount > 1 ? "s" : (vowelCount == 0 ? "s" : ""))}.");

                loop = RunAgain();
            }
        }
    }
}
