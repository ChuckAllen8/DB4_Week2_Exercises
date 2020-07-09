using System;
using System.Linq;

namespace DB4_Week2_Exercises
{
    class ConsonantCountExercise : ConsoleExercise
    {
        public override void Start()
        {
            PrepareConsole(WINDOW_WIDTH, WINDOW_HEIGHT);
            bool loop = true;
            string userInput;
            char[] vowels = { 'A', 'E', 'I', 'O', 'U', 'Y', 'a', 'e', 'i', 'o', 'u', 'y' };

            while (loop)
            {
                int consonantCount = 0;
                userInput = GetValidInput<string>("Enter a sentence: ");

                foreach (char letter in userInput.ToCharArray())
                {
                    if (char.IsLetter(letter) && !vowels.Contains(letter))
                    {
                        consonantCount++;
                    }
                }

                Console.WriteLine($"There {(consonantCount == 1 ? "was" : "were")} {(consonantCount > 0 ? consonantCount.ToString() : "no")} consonant{(consonantCount > 1 ? "s" : (consonantCount == 0 ? "s" : ""))}.");

                loop = RunAgain();
            }
        }
    }
}
