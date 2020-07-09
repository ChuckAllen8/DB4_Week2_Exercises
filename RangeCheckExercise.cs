using System;
using System.Collections.Generic;
using System.Text;

namespace DB4_Week2_Exercises
{
    class RangeCheckExercise : ConsoleExercise
    {
        public override void Start()
        {
            PrepareConsole(WINDOW_WIDTH, WINDOW_HEIGHT);
            bool loop = true;
            bool withinBounds;
            int boundOne, boundTwo, userNumber;

            while (loop)
            {
                boundOne = GetValidInput<int>("Enter a number: ");
                boundTwo = GetValidInput<int>("Enter another number: ");

                Console.WriteLine($"Your range is {boundOne} to {boundTwo}");

                do
                {
                    userNumber = GetValidInput<int>("Enter a number to verify it is in the range: ");
                    if (boundOne > boundTwo)
                    {
                        withinBounds = (userNumber <= boundOne && userNumber >=boundTwo);
                    }
                    else
                    {
                        withinBounds = (userNumber <= boundTwo && userNumber >= boundOne);
                    }
                    Console.WriteLine($"{userNumber} {(withinBounds ? "is" : "is not" )} in the range.");
                } while (RunAgain("Would you like to continue (y/n)? "));

                loop = RunAgain();
                Console.Clear();
            }
        }
    }
}
