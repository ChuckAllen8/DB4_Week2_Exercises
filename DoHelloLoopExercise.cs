using System;
using System.Collections.Generic;
using System.Text;

namespace DB4_Week2_Exercises
{
    class DoHelloLoopExercise : ConsoleExercise
    {
        public override void Start()
        {
            PrepareConsole(WINDOW_WIDTH, WINDOW_HEIGHT);
            bool loop;
            do
            {
                Console.WriteLine("Hello, World!");
                loop = RunAgain();
            } while (loop);
        }
    }
}
