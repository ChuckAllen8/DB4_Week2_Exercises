using System;
using System.Collections.Generic;
using System.Text;

namespace DB4_Week2_Exercises
{
    class ReverseTextExercise : ConsoleExercise
    {
        public override void Start()
        {
            PrepareConsole(WINDOW_WIDTH, WINDOW_HEIGHT);
            bool loop = true;
            char[] inputArray;
            StringBuilder reverseString;

            while (loop)
            {
                reverseString = new StringBuilder();
                inputArray = GetValidInput<string>("Enter a sentence: ").ToCharArray();

                for(int index = inputArray.Length-1; index >= 0; index--)
                {
                    reverseString.Append(inputArray[index]);
                }
                Console.WriteLine($"The reverse is: {reverseString}");

                loop = RunAgain();
            }
        }
    }
}
