using System;
using System.Linq;

namespace Pair_Programming
{
    public class Program
    {
        //This is the method that runs our User Interface
        public void Run()
        {
            DisplayMenu();
        }

        //This is the method to display the menu
        private void DisplayMenu()
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
                        //GameOne 
                        break;
                    case "2":
                        //GameTwo
                        GameTwo();
                        break;
                    case "3":
                        //Game3
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

        //Games
        public void GameOne()
        {
            Console.Clear();

            Console.WriteLine("Enter an adjective.");
            string adjectiveOne = CheckIfLetter(Console.ReadLine());

            Console.WriteLine("Enter an adjective.");
            string adjectiveTwo = CheckIfLetter(Console.ReadLine());

            Console.WriteLine("Enter an adjective.");
            string adjectiveThree = CheckIfLetter(Console.ReadLine());

            Console.WriteLine("Enter a noun.");
            string nounOne = CheckIfLetter(Console.ReadLine());

            Console.WriteLine("Enter an adjective.");
            string adjectiveFour = CheckIfLetter(Console.ReadLine());

            Console.WriteLine("Enter an adjective.");
            string adjectiveFive = CheckIfLetter(Console.ReadLine());

            Console.WriteLine("Enter a noun.");
            string nounTwo = CheckIfLetter(Console.ReadLine());

            Console.WriteLine("Enter a verb.");
            string verbOne = CheckIfLetter(Console.ReadLine());

            Console.WriteLine("Enter a verb.");
            string verbTwo = CheckIfLetter(Console.ReadLine());

            Console.WriteLine("Enter an adjective.");
            string adjectiveSix = CheckIfLetter(Console.ReadLine());

            Console.WriteLine("Enter a noun.");
            string nounThree = CheckIfLetter(Console.ReadLine());

            Console.WriteLine("Enter a verb.");
            string verbThree = CheckIfLetter(Console.ReadLine());

            Console.WriteLine("Enter a noun.");
            string nounFour = CheckIfLetter(Console.ReadLine());

            Console.WriteLine("Enter a verb.");
            string verbFour = CheckIfLetter(Console.ReadLine());

            Console.WriteLine("Enter an adjective.");
            string adjectiveSeven = CheckIfLetter(Console.ReadLine());

            Congratualtions();

            Console.WriteLine($"I walk through the color jungle. I take out my {adjectiveOne} canteen.There's a {adjectiveTwo} parrot with a {adjectiveThree} {nounOne} in his mouth right there in front of me in the {adjectiveFour} trees! I gaze at his {adjectiveFive} {nounTwo}. A sudden sound awakes me from my daydream! A panther’s {verbOne} in front of my head! I {verbTwo} his {adjectiveSix} breath.I remember I have a packet of {nounThree} that makes it go into a deep slumber! I {verbThree} it away from me in front of the {nounFour}. Yes he's eating it! I {verbFour} away through the {adjectiveSeven} jungle.I meet my parents at the tent.Phew! It’s been an exciting day in the jungle.");

            PressKeyToCountinue();
        }     
        public void GameTwo()
        {
            Console.Clear();

            Console.WriteLine("Enter a plural noun.");
            string nounOne = CheckIfLetter(Console.ReadLine());

            Console.WriteLine("Enter a plural noun.");
            string nounTwo = CheckIfLetter(Console.ReadLine());

            Console.WriteLine("Enter a verb.");
            string verbOne = CheckIfLetter(Console.ReadLine());

            Console.WriteLine("Enter a plural noun.");
            string nounThree = CheckIfLetter(Console.ReadLine());

            Console.WriteLine("Enter a verb ending in (ing).");
            string verbTwo = CheckIfLetter(Console.ReadLine());

            Console.WriteLine("Enter a plural noun.");
            string nounFour = CheckIfLetter(Console.ReadLine());

            Console.WriteLine("Enter a noun.");
            string nounFive = CheckIfLetter(Console.ReadLine());

            Console.WriteLine("Enter a noun.");
            string nounSix = CheckIfLetter(Console.ReadLine());

            Congratualtions();

            Console.WriteLine($"When I go to the arcade with my {nounOne} there are lots of games to play. I spend lots of time there with my friends. In the game X - Men you can be different {nounTwo}. The point of the game is to {verbOne} every robot. You also need to save people. Then you can go to the next level. In the game Star Wars you are Luke Skywalker and you try to destroy every {nounThree}. In a car racing/ motorcycle racing game you need to beat every computerized vehicle that you are {verbTwo} against.There are a whole lot of other cool games.When you play some games you win {nounFour} for certain scores. Once you're done you can cash in your tickets to get a big {nounFive}. You can save your {nounSix} for another time. When I went to this arcade I didn't believe how much fun it would be. So far I have had a lot of fun every time I've been to this great arcade!");

            PressKeyToCountinue();
        }       
        public void GameThree()
        {
            Console.Clear();

            Console.WriteLine("Enter an adjective.");
            string adjectiveOne = CheckIfLetter(Console.ReadLine());

            Console.WriteLine("Enter an noun.");
            string nounOne = CheckIfLetter(Console.ReadLine());

            Console.WriteLine("Enter an past tense verb.");
            string verbPastTenseOne = CheckIfLetter(Console.ReadLine());

            Console.WriteLine("Enter a adverb.");
            string adverbOne = CheckIfLetter(Console.ReadLine());

            Console.WriteLine("Enter an adjective.");
            string adjectiveTwo = CheckIfLetter(Console.ReadLine());

            Console.WriteLine("Enter an noun.");
            string nounTwo = CheckIfLetter(Console.ReadLine());

            Console.WriteLine("Enter a noun.");
            string nounThree = CheckIfLetter(Console.ReadLine());

            Console.WriteLine("Enter a adjective.");
            string adjectiveThree = CheckIfLetter(Console.ReadLine());

            Console.WriteLine("Enter a verb.");
            string verbOne = CheckIfLetter(Console.ReadLine());

            Console.WriteLine("Enter an adverb.");
            string adverbTwo = CheckIfLetter(Console.ReadLine());

            Console.WriteLine("Enter a past tense verb.");
            string verbPastTenseTwo = CheckIfLetter(Console.ReadLine());

            Console.WriteLine("Enter a adjective.");
            string adjective = CheckIfLetter(Console.ReadLine());

            Congratualtions();

            Console.WriteLine($"Today I went to the zoo. I saw a(n) {adjectiveOne} {nounOne} jumping up and down in its tree.He {verbPastTenseOne} {adverbOne} through the large tunnel that led to its {adjectiveTwo} {nounTwo}. I got some peanuts and passed them through the cage to a gigantic gray { nounThree} towering above my head. Feeding that animal mademe hungry.I went to get a {adjectiveThree} scoop of ice cream. It filled my stomach. Afterwards I had to {verbOne}{adverbTwo} to catch our bus.When I got home I {verbPastTenseTwo} my mom for a {adjective} day at the zoo.");

            PressKeyToCountinue();
        }       
        public void GameFour()
        {
            Console.Clear();

            Console.WriteLine("Enter an adjective.");
            string adjectiveOne = CheckIfLetter(Console.ReadLine());

            Console.WriteLine("Enter a noun.");
            string nounOne = CheckIfLetter(Console.ReadLine());


            Console.WriteLine("Enter a plural noun.");
            string pluralNounTwo = CheckIfLetter(Console.ReadLine());

            Console.WriteLine("Enter an adverb.");
            string adverbOne = CheckIfLetter(Console.ReadLine());

            Console.WriteLine("Enter a number.");
            string number = Console.ReadLine();
            //Did I get valid input
            int numberOne;
            while (!int.TryParse(number, out numberOne))
            {
                Console.WriteLine("Invalid selection, please enter a Number.");
                number = Console.ReadLine();
            }

            Console.WriteLine("Enter a past tense verb.");
            string pastTenseVerbOne = CheckIfLetter(Console.ReadLine());

            Console.WriteLine("Enter an adjective.");
            string adjectiveTwo = CheckIfLetter(Console.ReadLine());

            Console.WriteLine("Enter a past tense verb ending in est.");
            string pastTenseVerbTwo = CheckIfLetter(Console.ReadLine());

            Console.WriteLine("Enter an adverb.");
            string adverbTwo = CheckIfLetter(Console.ReadLine());

            Console.WriteLine("Enter an adjective.");
            string adjectiveThree = CheckIfLetter(Console.ReadLine());

            Congratualtions();

            Console.WriteLine($"Today, my fabulous camp group went to a(an) {adjectiveOne} amusement park. It was a fun park with lots of cool {nounOne} and enjoyable play structures. When we got there, my kind counselor shouted loudly, 'Everybody off the {pluralNounTwo}.' We all pushed out in a terrible hurry. My counselor handed out yellow tickets, and we scurried in. I was so excited! I couldn't figure out what exciting thing to do first. I saw a scary roller coaster I really liked so, I {adverbOne} ran over to get in the long line that had about {numberOne} people in it. When I finally got on the roller coaster I was {pastTenseVerbOne}. In fact I was so nervous my two knees were knocking together. This was the {adjectiveTwo} ride I had ever been on! In about two minutes I heard the crank and grinding of the gears. That’s when the ride began! When I got to the bottom, I was a little {pastTenseVerbTwo} but I was proud of myself. The rest of the day went {adverbTwo}. It was a(n) {adjectiveThree} day at the fun park.");

            PressKeyToCountinue();
        }
        public void GameFive()
        {
            Console.Clear();

            Console.WriteLine("Enter an noun.");
            string nounOne = CheckIfLetter(Console.ReadLine());

            Console.WriteLine("Enter an adjective.");
            string adjectiveOne = CheckIfLetter(Console.ReadLine());

            Console.WriteLine("Enter a number.");
            string one = Console.ReadLine();
            //Did I get valid input
            int numberOne;
            while (!int.TryParse(one, out numberOne))
            {
                Console.WriteLine("Invalid selection, please enter a Number.");
                one = Console.ReadLine();
            }

            Console.WriteLine("Enter an adjective.");
            string adjectiveTwo = CheckIfLetter(Console.ReadLine());

            Console.WriteLine("Enter an noun.");
            string nounTwo = CheckIfLetter(Console.ReadLine());

            Console.WriteLine("Enter a proper noun.");
            string properNounOne = CheckIfLetter(Console.ReadLine());

            Console.WriteLine("Enter a proper noun.");
            string properNounTwo = CheckIfLetter(Console.ReadLine());

            Console.WriteLine("Enter a plural noun.");
            string pluralNounOne = CheckIfLetter(Console.ReadLine());

            Console.WriteLine("Enter a verb ending in -ing.");
            string ingVerbOne = CheckIfLetter(Console.ReadLine());

            Console.WriteLine("Enter a plural noun.");
            string pluralNounTwo = CheckIfLetter(Console.ReadLine());

            Console.WriteLine("Enter a adjective.");
            string adjectiveThree = CheckIfLetter(Console.ReadLine());

            Console.WriteLine("Enter a adverb");
            string adverbOne = CheckIfLetter(Console.ReadLine());

            Congratualtions();

            Console.WriteLine($"One very nice morning near the end of summer, my mother woke me up at 4:00 A.M. and said, Wake up and smell the grass, sleepy head! Today is your first day of school and you can't be late. I groaned in my bed for twenty seconds, but eventually I got dressed.I wore a blue and white striped, long sleeve {nounOne} with a collar on it, a red tie, dark gray pants, white socks, black shoes, and a(n) {adjectiveOne} hat.In ten minutes I madelunch and ate my breakfast.{numberOne} minutes later, the bus came. A few minutes later, Iwas at school.In school, I met two really {adjectiveTwo} kids.All of us became friends very fast.That day we had Science, and luckily my friends and I were at the same {nounTwo} . My friends' names are {properNounOne} and {properNounTwo}. In Math we weren't together, and that really bugged me.We learned what {pluralNounOne} were, and when to use them.At snack and recess, we played a game together.It was extremely fun.At P.E., we were {ingVerbOne} off of the ropes onto {pluralNounTwo} .I thought it was a very {adjectiveThree} idea.In swimming class, we needed to swim extremely {adverbOne}, or else we would have to swim longer.Before I knew it, school was over.I grabbed all my belongings and put them into my backpack.In two minutes, the bus came.As I stepped into the bus I shouted, Goodbye, adios amigos, and shalom, to my friends.Then I went into the bus. In a flash, I was back home. This day was an extremely exciting day!");

            PressKeyToCountinue();
        }

        //Helper Methods
        private void PressKeyToCountinue()
        {
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }

        private void Congratualtions()
        {
            Console.Write("Congratulations! You have filled in all the blanks! Press any key to see the finished product!");
            Console.ReadKey();
            Console.Clear();
        }

        public string CheckIfLetter(string Letter)
        {
            while (!Letter.All(Char.IsLetter))
            {
            Console.WriteLine("Invalid selection, please enter a letter");
            Console.ReadLine();   
            }
            return Letter;
        }
    }
}