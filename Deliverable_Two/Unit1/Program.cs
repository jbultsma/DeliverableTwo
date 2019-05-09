using System;

namespace Unit1
{
    class Program
    {
        
        // Main
        static void Main(string[] args)
        {
            PrintIntro();
            GetActivity();
            GoodbyeMessage();
        }

        // Prints the intro to the user
        static void PrintIntro()
        {
            Console.WriteLine("Hello, what are you in the mood for today?");
            Console.WriteLine("Here are your options, please input one of the options below exactly as it is represented.");
            Console.WriteLine(" 1) Action\n 2) Chill Times\n 3) Danger\n 4) Good Food");
        }

        // Get the activity chosen by having the user choose what mood they are in.
        static int GetMood()
        {
            string Mood = Console.ReadLine();
            int Decision;
            Int32.TryParse(Mood, out Decision);

            while (Decision == 0 || Decision >= 5)
            {
                Console.WriteLine("Please type in an integer from 1 to 4!");
                Mood = Console.ReadLine();                
                Int32.TryParse(Mood, out Decision);               
            }           
            return Decision;
        }

        //Get the number of people attending
        static int GetPeople()
        {
            Console.WriteLine("Fantastic choice! How many people will you be bringing with you today? Please type in an integer.");
            string NumberOfPeople = Console.ReadLine();
            int Result;
            Int32.TryParse(NumberOfPeople, out Result);

            while (!Int32.TryParse(NumberOfPeople, out Result) || Result < 0)
            {
                Console.WriteLine("Please type in an integer larger or equal to zero!");
                NumberOfPeople = Console.ReadLine();
                Int32.TryParse(NumberOfPeople, out Result);
            }
            return Result;
        }

        // Determind the activity and the method of travel for the user based on the chosen Mood and the Number of People
        static bool GetActivity()
        {
            int Option = GetMood();
            int People = GetPeople();
            int One = 1;
            int Two = 2;
            int Three = 3;
            int Four = 4;

            // Action
            if (Option == One)
            {
                if (People == 0)
                {
                    Console.WriteLine("You should go stock car racing and travel in your sneakers!");
                }

                else if (People >= 1 && People <= 4)
                {
                    Console.WriteLine("You should go stock car racing and travel in a sedan!");
                }

                else if (People >= 5 && People <= 10)
                {
                    Console.WriteLine("You should go stock car racing and travel in a Volkswagen Bus!");
                }

                else if (People >= 11)
                {
                    Console.WriteLine("You should go stock car racing and travel in an airplane!");
                }
            }

            // Chilling
            else if (Option == Two)
            {
                if (People == 0)
                {
                    Console.WriteLine("You should go hiking and travel in your sneakers!");
                }

                else if (People >= 1 && People <= 4)
                {
                    Console.WriteLine("You should go hiking and travel in a sedan!");
                }

                else if (People >= 5 && People <= 10)
                {
                    Console.WriteLine("You should go hiking and travel in a Volkswagen Bus!");
                }

                else if (People >= 11)
                {
                    Console.WriteLine("You should go hiking and travel in an airplane!");
                }                
            }

            // Danger
            else if (Option == Three)
            {
                if (People == 0)
                {
                    Console.WriteLine("You should go skydiving and travel in your sneakers!");
                }

                else if (People >= 1 && People <= 4)
                {
                    Console.WriteLine("You should go skydiving and travel in a sedan!");
                }

                else if (People >= 5 && People <= 10)
                {
                    Console.WriteLine("You should go skydiving and travel in a Volkswagen Bus!");
                }

                else if (People >= 11)
                {
                    Console.WriteLine("You should go skydiving and travel in an airplane!");
                }
            }

            // Good Food
            else if (Option == Four)
            {
                if (People == 0)
                {
                    Console.WriteLine("You should go to Taco Bell and travel in your sneakers!");
                }

                else if (People >= 1 && People <= 4)
                {
                    Console.WriteLine("You should go to Taco Bell and travel in a sedan!");
                }

                else if (People >= 5 && People <= 10)
                {
                    Console.WriteLine("You should go to Taco Bell and travel in a Volkswagen Bus!");
                }

                else if (People >= 11)
                {
                    Console.WriteLine("You should go to Taco Bell and travel in an airplane!");
                }
            }

            else
            {
                Console.WriteLine("Please input one of the options again, be careful it is case sensitive!");
            }
            return true;
        }

        // Messesge displayed right before exiting application
        static void GoodbyeMessage()
        {
           Console.WriteLine("\nGoodbye, thank you for using me to help you with your decision. Have a great time!\n");
        }
        
    }
}
