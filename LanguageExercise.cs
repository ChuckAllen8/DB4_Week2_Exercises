using System;
using System.Collections.Generic;
using System.Text;

namespace DB4_Week2_Exercises
{
    class LanguageExercise : ConsoleExercise
    {
        public override void Start()
        {
            PrepareConsole(WINDOW_WIDTH, WINDOW_HEIGHT);
            bool loop = true;

            while (loop)
            {
                DisplayLanguage(GetValidInput<string>("Enter a language: ").ToUpper());
                loop = RunAgain();
            }
        }

        private void DisplayLanguage(string language)
        {
            switch (language)
            {
                case "SPANISH":
                    Console.WriteLine("Hola Mundo!");
                    break;

                case "GERMAN":
                    Console.WriteLine("Hallo Welt!");
                    break;

                case "PIG LATIN":
                    Console.WriteLine("Ellohay Orldway!");
                    break;

                case "DUTCH":
                    Console.WriteLine("Hallo Wereld!");
                    break;

                case "LATIN":
                    Console.WriteLine("Salve Mundi!");
                    break;

                case "JAPANESE":
                    Console.WriteLine("Kon'nichiwa Sekai!");
                    break;

                case "ENGLISH":
                    Console.WriteLine("Hello World!");
                    break;

                default:
                    Console.WriteLine("I don't know that language!");
                    break;
            }
        }
    }
}
