using System;

namespace Pair_Programming
{
    public class Program
    {

        //This is the method that runs our User Interface
        public void Run()
        {
            DisplayMenu();
        }

        public void DisplayMenu()
        {
            bool isRunning = true;
            while (isRunning)
            {
                Console.Clear();
                //Writes to the Console
                Console.WriteLine(
                    "Enter the number of the Mad Libs Game you would like to Play: \n" +
                    //Mad Libs Missing Adjective
                    "1. Game 1 \n" +
                    //Mad Libs Missing Adjective
                    "2. Game 2 \n" +
                    //Mad Libs Missing Adjective
                    "3. Game 3 \n" +
                    //Mad Libs Missing noun
                    "4. Game 4 \n" +
                    //Mad Libs Missing Adjective
                    "5. Game 5 \n" +
                    //Exit
                    "6. Exit \n");

                //Reading user input
                string userInput = Console.ReadLine();

                switch (userInput)
                {
                    case "1":
                        GameOne();
                        //Mad Libs Missing Adjective
                        //GameOne 
                        break;
                    case "2":
                        //Mad Libs Missing Adjective
                        //GameTwo
                        GameTwo();
                        break;
                    case "3":
                        //Game3
                        //Mad Libs Missing Adjective
                        GameThree();
                        break;
                    case "4":
                        //Game4
                        //Mad Libs Missing noun
                        GameFour();
                        break;
                    case "5":
                        //Game5
                        //Mad Libs Missing Adjective
                        GameFive();
                        break;
                    case "6":
                        // Exit
                        isRunning = false;
                        break;
                    default:
                        Console.WriteLine("Please enter a valid number between 1 and 6 \n" +
                            "PressKeyToCountinue();");
                        Console.ReadKey();
                        break;
                }
            }
        }



        public void GameOne()
        {
            Console.Clear();

            Console.WriteLine("");

            Console.WriteLine("Enter an adjective.");
            string adjectiveOne = Console.ReadLine();   
        
            Console.WriteLine("Enter an adjective.");
            string adjectiveTwo = Console.ReadLine();
          
            Console.WriteLine("Enter an adjective.");
            string adjectiveThree = Console.ReadLine();
          
            Console.WriteLine("Enter a noun.");
            string nounOne = Console.ReadLine();
       
            Console.WriteLine("Enter an adjective.");
            string adjectiveFour = Console.ReadLine();
 
            Console.WriteLine("Enter an adjective.");
            string adjectiveFive = Console.ReadLine();

            Console.WriteLine("Enter a noun.");
            string nounTwo = Console.ReadLine();

            Console.WriteLine("Enter a verb.");
            string verbOne = Console.ReadLine();

            Console.WriteLine("Enter a verb.");
            string verbTwo = Console.ReadLine();

            Console.WriteLine("Enter an adjective.");
            string adjectiveSix = Console.ReadLine();

            Console.WriteLine("Enter a noun.");
            string nounThree = Console.ReadLine();

            Console.WriteLine("Enter a verb.");
            string verbThree = Console.ReadLine();

            Console.WriteLine("Enter a noun.");
            string nounFour = Console.ReadLine();

            Console.WriteLine("Enter a verb.");
            string verbFour = Console.ReadLine();

            Console.WriteLine("Enter an adjective.");
            string adjectiveSeven = Console.ReadLine();

            string template = $"I walk through the color jungle. I take out my {adjectiveOne} canteen.There's a {adjectiveTwo} parrot with a {adjectiveThree} {nounOne} in his mouth right there in front of me in the {adjectiveFour} trees! I gaze at his {adjectiveFive} {nounTwo}. A sudden sound awakes me from my daydream! A panther’s {verbOne} in front of my head! I {verbTwo} his {adjectiveSix} breath.I remember I have a packet of {nounThree} that makes go into a deep slumber! I {verbThree} it away from me in front of the {nounFour}. Yes he's eating it! I {verbFour} away through the {adjectiveSeven} jungle.I meet my parents at the tent.Phew! It’s been an exciting day in the jungle.";
        }

        public void GameTwo()
        { }

        public void GameThree()
        { }

        public void GameFour()
        { }

        public void GameFive()
        { }
    }   
}