/* 
 * 
 * Made by Chuck Allen for use as a catch all for the labs related to week 2.
 * 
 */

using System;
using System.Collections.Generic;

namespace DB4_Week2_Exercises
{
    class ExerciseManager : ConsoleExercise
    {
        private readonly List<string> availablePrograms;
        private readonly Dictionary<string, bool> programToggles;

        public ExerciseManager()
        {
            
            programToggles = new Dictionary<string, bool>
            {
                { "Echo Exercise", true },
                { "Increment Exercise", true },
                { "Half Increment Exercise", true },
                { "Add Numbers Exercise", true },
                { "Multiply Numbers Exercise", true },
                { "Do Hello Loop Exercise", true },
                { "Language Exercise", true },
                { "Ascending For Exercise", true },
                { "Descending For Exercise", true },
                { "Count To Zero Exercise", true },
                { "Number Squares Exercise", true },
                { "Number Cubes Exercise", true },
                { "Triangle Output Exercise", true },
                { "Pyramid Output Exercise", true },
                { "Sum All Exercise", true },
                { "Sum From And To Exercise", true },
                { "Product Previous Two Exercise", true },
                { "Word Series Exercise", true },
                { "Range Check Exercise", true},
                { "String Extraction Exercise", true },
                { "String Reverse Extraction Exercise", true },
                { "String Splitting Exercise", true },
                { "Vowel Count Exercise", true },
                { "Consonant Count Exercise", true },
                { "Remove All Vowels Exercise", true },
                { "Remove Middle Vowels Exercise", true },
                { "Reverse Text Exercise", true }
            };

            availablePrograms = new List<string>();

            //add the programs to the available list based on the toggle for them.
            foreach (KeyValuePair<string, bool> app in programToggles)
            {
                if (app.Value)
                {
                    availablePrograms.Add(app.Key);
                }
            }
            
        }
        
        public override void Start()
        {
            bool loop = true;
            int selection;

            while (loop)
            {
                PrepareConsole(WINDOW_WIDTH, WINDOW_HEIGHT);

                DisplayPrograms();
                selection = GetSelection();

                if (selection >= 0 && selection < availablePrograms.Count)
                {
                    RunProgram(selection);
                }
                else
                {
                    loop = false;
                }
            }
            Console.WriteLine("Thenk you for using Chuck's Exercise Manager!");
        }

        private void RunProgram(int selection)
        {
            /* 
             * this method instantiates an object of the type of the selection
             * which matches the class names in the program minus the spaces
             */
            string appType = "DB4_Week2_Exercises.";
            string[] selectionWords = availablePrograms[selection].Split(" ");

            //add each word from the selection to the apps type
            for(int index = 0; index < selectionWords.Length; index++)
            {
                appType += selectionWords[index];
            }

            ConsoleExercise app = Activator.CreateInstance(Type.GetType(appType)) as ConsoleExercise;
            app.Start();
        }

        private void DisplayPrograms()
        {
            Console.WriteLine("Enter a valid selection, anything else quits.\n");
            for (int i = 0; i < availablePrograms.Count; i++)
            {
                Console.WriteLine($"{i+1, 2}: {availablePrograms[i]}");
            }
            Console.Write("\n>");
        }

        private int GetSelection()
        {
            string input = Console.ReadLine();

            if(int.TryParse(input, out int selection))
            {
                return selection - 1;
            }
            else
            {
                return -1;
            }
        }
    }
}
