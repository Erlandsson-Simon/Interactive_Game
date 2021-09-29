using System;

namespace Interactive_Game
{
    class Program
    {
        static void Main(string[] args)
        {
            Boolean startGame = true;
            
            string character;

            Boolean ifChoicePriest = false;
            string priestWeapon;
            Boolean priestWeaponChoice = false;

            Boolean ifChoiceMaffiaBoss = false;
            string maffiaBossWeapon;
            Boolean maffiaBossWeaponChoice = false;

            Boolean ifChoiceRacist = false;

            Boolean endGame = false;
            string restartGame;

            while (startGame)
            {
                startGame = false;
                Console.WriteLine("Hello Player! Please choose a character. Whould you like to be: priest, maffiaboss or racist");

                character = Console.ReadLine();

                if (character == "priest" || character == "Priest")
                {
                    ifChoicePriest = true;
                }
                else if (character == "maffiaboss" || character == "Maffiaboss")
                {
                    ifChoiceMaffiaBoss = true;
                }
                else if (character == "racist" || character == "Racist")
                {
                    ifChoiceRacist = true;
                }
                else
                {
                    Console.WriteLine("You have to choose between the three above");
                    startGame = true;
                }

                if (ifChoicePriest)
                {
                    ifChoicePriest = false;
                    Console.WriteLine("You chose priest");
                    Console.WriteLine("You then walk along a long road. At the end of the road you meet a demon.");
                    priestWeaponChoice = true;
                }



                while (priestWeaponChoice)
                {
                    priestWeaponChoice = false;

                    Console.WriteLine("Choose a weapon: Water or a sword");

                    priestWeapon = Console.ReadLine();

                    if (priestWeapon == "water" || priestWeapon == "Water")
                    {
                        Console.WriteLine("You realize that the water is holy water and you banish the demon. You win!");
                        endGame = true;
                    }
                    else if (priestWeapon == "sword" || priestWeapon == "Sword" || priestWeapon == "a sword" || priestWeapon == "a Sword" || priestWeapon == "A sword" || priestWeapon == "A Sword")
                    {
                        Console.WriteLine("The demon can't be killed by a sword, bad luck you died.");
                        endGame = true;
                    }
                    else
                    {
                        Console.WriteLine("You need to choose between the two weapons above!");
                        priestWeaponChoice = true;
                    }
                }

                while (ifChoiceMaffiaBoss)
                {
                    ifChoiceMaffiaBoss = false;
                    Console.WriteLine("You chose maffiaboss.");
                    Console.WriteLine("You then see 50 police men at your door. You need a weapon do defend your cocainestash.");
                    maffiaBossWeaponChoice = true;
                }

                if (maffiaBossWeaponChoice)
                {
                    Console.WriteLine("Choose a weapon: a machine gun or a knife.");
                    maffiaBossWeapon = Console.ReadLine();

                    if (maffiaBossWeapon == "knife" || maffiaBossWeapon == "Knife" || maffiaBossWeapon == "a knife" || maffiaBossWeapon == "a Knife" || maffiaBossWeapon == "A knife" || maffiaBossWeapon == "A Knife")
                    {
                        Console.WriteLine("Never bring a knife to a gun fight. You get shot down and die.");
                        endGame = true;
                    }
                    else if (maffiaBossWeapon == "machine gun" || maffiaBossWeapon == "Machine gun" || maffiaBossWeapon == "machine Gun" || maffiaBossWeapon == "Machine Gun" || maffiaBossWeapon == "a machine gun" || maffiaBossWeapon == "a Machine gun" || maffiaBossWeapon == "a machine Gun" || maffiaBossWeapon == "a Machine Gun" || maffiaBossWeapon == "A machine gun" || maffiaBossWeapon == "A Machine gun" || maffiaBossWeapon == "A machine Gun" || maffiaBossWeapon == "A Machine Gun")
                    {
                        Console.WriteLine("You successfully defend your house. You win!");
                        endGame = true;
                    }
                }

                if (ifChoiceRacist)
                {
                    ifChoiceRacist = false;
                    Console.WriteLine("As soon as you choose to be a racist you get a heartattack and die. Guess you got what you deserve.");
                    endGame = true;
                }

                if (endGame)
                {
                    endGame = false;
                    restartGame = Console.ReadLine();

                    if (restartGame == "restart")
                    {
                        startGame = true;
                    }
                }
            }
        }
    }
}
