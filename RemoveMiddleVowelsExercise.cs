using System;
using System.Text;
using System.Linq;

namespace DB4_Week2_Exercises
{
    class RemoveMiddleVowelsExercise : ConsoleExercise
    {
        public override void Start()
        {
            PrepareConsole(WINDOW_WIDTH, WINDOW_HEIGHT);
            bool loop = true;
            string userInput;
            char[] inputArray;
            char[] vowels = { 'A', 'E', 'I', 'O', 'U', 'Y', 'a', 'e', 'i', 'o', 'u', 'y' };
            StringBuilder noMiddleVowels;

            while (loop)
            {
                userInput = GetValidInput<string>("Enter a sentence: ");
                inputArray = userInput.ToCharArray();
                noMiddleVowels = new StringBuilder();
                noMiddleVowels.Append(inputArray[0]);
                for (int index = 1; index < inputArray.Length-1; index++)
                {
                    char priorChar = inputArray[index - 1];
                    char thisChar = inputArray[index];
                    char nextChar = inputArray[index + 1];
                    if (!vowels.Contains(thisChar))
                    {
                        noMiddleVowels.Append(thisChar);
                    }
                    else if (vowels.Contains(thisChar) && (char.IsWhiteSpace(priorChar)||char.IsWhiteSpace(nextChar)))
                    {
                        noMiddleVowels.Append(thisChar);
                    }
                }
                noMiddleVowels.Append(inputArray[inputArray.Length-1]);

                Console.WriteLine($"Without middle vowels: {noMiddleVowels}");

                loop = RunAgain();
            }
        }
    }
}
