using System;
using System.Collections.Generic;
using System.Text;

namespace DB4_Week2_Exercises
{
    class TriangleOutputExercise : ConsoleExercise
    {
        public override void Start()
        {
            PrepareConsole(WINDOW_WIDTH, WINDOW_HEIGHT);
            bool loop = true;

            while (loop)
            {
                for (int number = 0; number < 10; number++)
                {
                    Console.WriteLine(new string('*',number+1));
                }
                Console.WriteLine("");
                loop = RunAgain();
            }
        }
    }
}
