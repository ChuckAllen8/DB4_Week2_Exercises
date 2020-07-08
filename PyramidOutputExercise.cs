using System;
using System.Collections.Generic;
using System.Text;

namespace DB4_Week2_Exercises
{
    class PyramidOutputExercise : ConsoleExercise
    {
        public override void Start()
        {
            PrepareConsole(WINDOW_WIDTH, WINDOW_HEIGHT);
            bool loop = true;

            while (loop)
            {
                for (int row = 1; row <= 10; row++)
                {
                    //write the leading spaces
                    Console.Write(new string(' ', 10 - row));

                    //write the stars
                    for (int stars = 1; stars <= row; stars++)
                    {
                        Console.Write("* ");
                    }
                    //move to the next line
                    Console.WriteLine("");
                }
                Console.WriteLine("");
                loop = RunAgain();
            }
        }
    }
}
