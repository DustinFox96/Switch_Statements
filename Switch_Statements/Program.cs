using System;

namespace Switch_Statements
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Format 1 pre Switch statement 


            //Console.WriteLine("How many years of experience do you have? ");

            //// int.Parse converts strings to ints. you would get errors without it since we have if statements claiming years is an int but it is declared as a string as it's variable 
            //var years = int.Parse(Console.ReadLine());


            //if(years == 0)
            //    Console.WriteLine("Inexperienced");

            //else if (years == 1)
            //    Console.WriteLine("Junior");

            //else if (years == 2)
            //    Console.WriteLine("Intermediate");

            //else if (years == 3)
            //    Console.WriteLine("Advance");

            //// In an final check, else can just be used instead of "else if"
            //else
            //    Console.WriteLine("Senior");

            #endregion

            #region Format 2 with Switch statement

            Console.WriteLine("How many years of experience do you have? ");

            // int.Parse converts strings to ints. you would get errors without it since we have if statements claiming years is an int but it is declared as a string as it's variable 
            var years = int.Parse(Console.ReadLine());

            switch (years)
            {
                // the case being set to zero is as equal as saying if(years == 0)
                case 0:
                    Console.WriteLine("Inexperienced");
                    break;

                case 1:
                    Console.WriteLine("Junior");
                    break;

                case 2:
                    Console.WriteLine("Intermediate");
                    break;

                case 3:
                    Console.WriteLine("Advance");
                    break;
                    
                    // default is the same as an else, it's the final statement in a switch.
                default:
                    Console.WriteLine("Senior");
                    break;

            }

            #endregion

        }
    }
}
