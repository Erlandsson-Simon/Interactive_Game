using System;

namespace Interactive_Game
{
    class Program
    {
        static void Main(string[] args)
        {
            string character;

            Boolean boolRace = true;
            Boolean boolPriest = false;
            Boolean boolMaffiaboss = false;
            Boolean boolRacist = false;

            while (boolRace)
            {
                boolRace = false;
                Console.WriteLine("Hello Player! Please choose a character. Whould you like to be: priest, maffiaboss or racist");

                character = Console.ReadLine();

                if (character == "priest" || character == "Priest")
                {
                    boolPriest = true;
                    Console.WriteLine("test");
                }
                else if (character == "maffiaboss" || character == "Maffiaboss")
                {
                    boolMaffiaboss = true;
                }
                else if (character == "racist" || character == "Racist")
                {
                    boolRacist = true;
                }
                else
                {
                    Console.WriteLine("You have to choose between the three above");
                    boolRace = true;
                }

                if (boolPriest) {

                }
            }
        }
    }
}
