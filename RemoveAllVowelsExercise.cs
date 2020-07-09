using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DB4_Week2_Exercises
{
    class RemoveAllVowelsExercise : ConsoleExercise
    {
        public override void Start()
        {
            PrepareConsole(WINDOW_WIDTH, WINDOW_HEIGHT);
            bool loop = true;
            string userInput;
            char[] vowels = { 'A', 'E', 'I', 'O', 'U', 'Y', 'a', 'e', 'i', 'o', 'u', 'y' };
            StringBuilder noVowels;

            while (loop)
            {
                userInput = GetValidInput<string>("Enter a sentence: ");
                noVowels = new StringBuilder();

                foreach (char letter in userInput.ToCharArray())
                {
                    if (!vowels.Contains(letter))
                    {
                        noVowels.Append(letter);
                    }
                }

                Console.WriteLine($"Without vowels: {noVowels}");

                loop = RunAgain();
            }
        }
    }
}
