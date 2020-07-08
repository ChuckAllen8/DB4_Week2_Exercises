using System;
using System.ComponentModel;

namespace DB4_Week2_Exercises
{
    class ConsoleExercise
    {

        protected const int WINDOW_WIDTH = 75;
        protected const int WINDOW_HEIGHT = 25;

        //virtual method to be overridden in the inherited classes
        public virtual void Start()
        {
        }

        public void PrepareConsole()
        {
            Console.Clear();
        }

        public void PrepareConsole(int width, int height)
        {
            Console.Clear();
            Console.SetWindowSize(width, height);
        }


        //method to determine if the user would like to keep using the app
        public bool RunAgain()
        {
            Console.Write("Continue (y/n): ");
            if (Console.ReadKey().Key == ConsoleKey.Y) //continue on Y, but not anything else
            {
                Console.WriteLine("\n");
                return true;
            }
            else
            {
                Console.WriteLine("\n");
                return false;
            }
        }

        //this allows the user to input any kind of value, and verifies the input is of the desired type
        public T GetValidInput<T>(string prompt)
        {
            //initialize the required variables to store input and assess it's validity.
            bool validEntry = false;
            string input = "";

            //while the input is not valid, keep trying to get a valid input.
            while (!validEntry)
            {
                Console.Write(prompt); //provide user prompt
                input = Console.ReadLine();

                //verify that the input is able to be converted to the desired type
                validEntry = TypeDescriptor.GetConverter(typeof(T)).IsValid(input);
            }

            //return the results of converting the input to the desired type.
            return (T)TypeDescriptor.GetConverter(typeof(T)).ConvertFromString(input);
        }
    }
}
