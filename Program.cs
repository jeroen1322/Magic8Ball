using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
namespace Magic8Ball
{
    /// <summary>
    /// Begin Macig 8-ball Programma (gemaakt door Jeroen Grooten)
    /// </summary>

    class Program
    {
        static void Main(string[] args)
        {
            //Oude Console Color onthouden
            ConsoleColor oldColor = Console.ForegroundColor;

            // Oude Console Color terug zetten
            Console.ForegroundColor = oldColor;

            ProgrammaIntroductie();

            //Maak een randomizer opject
            Random randomObject = new Random();

            //Loop voor altijd!
            while (true)
            {
                string vraagString = krijgVraagVanUser();
                //Check of de user "quit" heeft geschreven
                if (vraagString.ToLower() == "stop")
                {
                    break;
                }

                int aantalSecondenSlaap = randomObject.Next(5) + 1;
                Console.WriteLine("Even aan het nadenken over je vraag...");
                Thread.Sleep(aantalSecondenSlaap * 1000); //Er staat *1000 want het werkt met mili seconden maar nu 1ms * 1000 = 1sec dus hij wacht een aantal seconden

                if(vraagString.Length == 0)
                {
                    Console.WriteLine("Je hebt nog geen vraag gesteld!");
                    continue;
                }
                
                //Krijg een random nummer
                int randomNummer = randomObject.Next(3);


                //Gebruik randomNummer om antwoord te bepalen
                switch (randomNummer)
                {
                    case 0:
                        {
                            Console.WriteLine("Ja!");
                            break;
                        }
                    case 1:
                        {
                            Console.WriteLine("Nee!");
                            break;
                        }
                    case 2:
                        {
                            Console.WriteLine("Nou.... Nee");
                            break;
                        }
                    case 3:
                        {
                            Console.WriteLine("Eh...Sure...");
                            break;
                        }
                }
            }
        }

        /// <summary>
        /// Dit print de naam van het programma en de programmeur
        /// </summary>
        static void ProgrammaIntroductie()
        {
            //Console tekst color veranderen
            Console.ForegroundColor = ConsoleColor.Green;
            //Naam programma + Naam Programmeur
            Console.WriteLine("Magic 8-Ball (gemaakt door: Jeroen Grooten)");
            Console.WriteLine("Typ 'stop' om het programma af te sluiten");
        }
        //Deze functie slaat de tekst dat de user typt op en displayed het in de console
        static string krijgVraagVanUser()
        {
            //Dit stelt de user een vraag en slaat de vraag tekst op in vraagString variable
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("Stel een vraag: ");
            string vraagString = Console.ReadLine();

            return vraagString;
        }
    }
}
