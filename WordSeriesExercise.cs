using System;
using System.Collections.Generic;
using System.Text;

namespace DB4_Week2_Exercises
{
    class WordSeriesExercise : ConsoleExercise
    {
        public override void Start()
        {
            PrepareConsole(WINDOW_WIDTH, WINDOW_HEIGHT);
            bool loop = true;

            while (loop)
            {
                List<string> wordList = new List<string>();
                do
                {
                    Console.Write("Enter a word: ");
                    wordList.Add(Console.ReadLine());
                } while (AnotherWord("Would you like to enter another word (y/n)? "));

                Console.WriteLine("");
                
                foreach(string word in wordList)
                {
                    Console.Write($"{word} ");
                }

                Console.WriteLine("");
                loop = RunAgain();
            }
        }

        private bool AnotherWord(string prompt)
        {
            Console.Write(prompt);
            if(Console.ReadKey().Key == ConsoleKey.Y)
            {
                Console.WriteLine("");
                return true;
            }
            else
            {
                Console.WriteLine("");
                return false;
            }
        }
    }
}
