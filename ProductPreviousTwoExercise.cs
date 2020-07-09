using System;
using System.Collections.Generic;
using System.Text;

namespace DB4_Week2_Exercises
{
    class ProductPreviousTwoExercise : ConsoleExercise
    {
        public override void Start()
        {
            PrepareConsole(WINDOW_WIDTH, WINDOW_HEIGHT);
            bool loop = true;
            int userNumber, product;
            while (loop)
            {
                userNumber = GetValidInput<int>("Enter the first number: ");
                product = userNumber;
                for (int number = userNumber-1; number >= userNumber - 2; number--)
                {
                    product *= number;
                }
                Console.WriteLine($"The product of {userNumber} and the two previous numbers is: {product}");
                loop = RunAgain();
            }
        }
    }
}
