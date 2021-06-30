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

            //Console.WriteLine("I walk through the color jungle. I take out my __adjective__ canteen. There's a(n) __adjective__ parrot with a(n) __adjective__ __noun__ in his mouth right there in front of me in the __adjective__ trees! I gaze at his __adjective__ __noun__. A sudden sound awakes me from my daydream! A panther’s __verb__ in front of my head! I __verb__ his __adjective__ breath. I remember I have a packet of __noun__ that makes go into a deep slumber! I __verb__ it away from me in front of the __noun__. Yes he's eating it! I __verb__ away through the __adjective__ jungle. I meet my parents at the tent. Phew! It’s been an exciting day in the jungle.");

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

            Congratualtions();

            Console.WriteLine($"I walk through the color jungle. I take out my {adjectiveOne} canteen.There's a {adjectiveTwo} parrot with a {adjectiveThree} {nounOne} in his mouth right there in front of me in the {adjectiveFour} trees! I gaze at his {adjectiveFive} {nounTwo}. A sudden sound awakes me from my daydream! A panther’s {verbOne} in front of my head! I {verbTwo} his {adjectiveSix} breath.I remember I have a packet of {nounThree} that makes it go into a deep slumber! I {verbThree} it away from me in front of the {nounFour}. Yes he's eating it! I {verbFour} away through the {adjectiveSeven} jungle.I meet my parents at the tent.Phew! It’s been an exciting day in the jungle.");

            PressKeyToCountinue();




        }

        public void GameTwo()
        {
            Console.Clear();

            //Console.WriteLine("When I go to the arcade with my __noun__ there are lots of games to play. I spend lots of time there with my friends. In the game X - Men you can be different __noun__. The point of the game is to __verb__ every robot. You also need to save people. Then you can go to the next level. In the game Star Wars you are Luke Skywalker and you try to destroy every __noun__. In a car racing/ motorcycle racing game you need to beat every computerized vehicle that you are __verb__ against.There are a whole lot of other cool games.When you play some games you win __noun__ for certain scores. Once you're done you can cash in your tickets to get a big __noun__. You can save your __noun__ for another time. When I went to this arcade I didn't believe how much fun it would be. So far I have had a lot of fun every time I've been to this great arcade!");

            Console.WriteLine("Enter a plural noun.");
            string nounOne = Console.ReadLine();
            Console.WriteLine("Enter a plural noun.");
            string nounTwo = Console.ReadLine();
            Console.WriteLine("Enter a verb.");
            string verbOne = Console.ReadLine();
            Console.WriteLine("Enter a plural noun.");
            string nounThree = Console.ReadLine();
            Console.WriteLine("Enter a verb ending in (ing).");
            string verbTwo = Console.ReadLine();
            Console.WriteLine("Enter a plural noun.");
            string nounFour = Console.ReadLine();
            Console.WriteLine("Enter a noun.");
            string nounFive = Console.ReadLine();
            Console.WriteLine("Enter a noun.");
            string nounSix = Console.ReadLine();

            Congratualtions();

            Console.WriteLine($"When I go to the arcade with my {nounOne} there are lots of games to play. I spend lots of time there with my friends. In the game X - Men you can be different {nounTwo}. The point of the game is to {verbOne} every robot. You also need to save people. Then you can go to the next level. In the game Star Wars you are Luke Skywalker and you try to destroy every {nounThree}. In a car racing/ motorcycle racing game you need to beat every computerized vehicle that you are {verbTwo} against.There are a whole lot of other cool games.When you play some games you win {nounFour} for certain scores. Once you're done you can cash in your tickets to get a big {nounFive}. You can save your {nounSix} for another time. When I went to this arcade I didn't believe how much fun it would be. So far I have had a lot of fun every time I've been to this great arcade!");

            PressKeyToCountinue();
        }

        public void GameThree()
        {
            Console.Clear();

            //Console.WriteLine("Today I went to the zoo. I saw a(n) __adjectiveOne__ __nounOne__ jumping up and down in its tree.He __verbPastTenseOne__ __adverbOne__ through the large tunnel that led to its __adjectiveTwo__ __nounTwo__. I got some peanuts and passed them through the cage to a gigantic gray { nounThree} towering above my head. Feeding that animal mademe hungry.I went to get a __adjectiveThree__ scoop of ice cream. It filled my stomach. Afterwards I had to __verbOne__ __adverbTwo__ to catch our bus.When I got home I __verbPastTenseTwo__ my mom for a {} day at the zoo.");

            Console.WriteLine("Enter an adjective.");
            string adjectiveOne = Console.ReadLine();

            Console.WriteLine("Enter an adjective.");
            string nounOne = Console.ReadLine();

            Console.WriteLine("Enter an adjective.");
            string verbPastTenseOne = Console.ReadLine();

            Console.WriteLine("Enter a noun.");
            string adverbOne = Console.ReadLine();

            Console.WriteLine("Enter an adjective.");
            string adjectiveTwo = Console.ReadLine();

            Console.WriteLine("Enter an adjective.");
            string nounTwo = Console.ReadLine();

            Console.WriteLine("Enter a noun.");
            string nounThree = Console.ReadLine();

            Console.WriteLine("Enter a verb.");
            string adjectiveThree = Console.ReadLine();

            Console.WriteLine("Enter a verb.");
            string verbOne = Console.ReadLine();

            Console.WriteLine("Enter an adjective.");
            string adverbTwo = Console.ReadLine();

            Console.WriteLine("Enter a noun.");
            string verbPastTenseTwo = Console.ReadLine();

            Console.WriteLine("Enter a verb.");
            string adjective = Console.ReadLine();

            Congratualtions();

            Console.WriteLine($"Today I went to the zoo. I saw a(n) {adjectiveOne} {nounOne} jumping up and down in its tree.He {verbPastTenseOne} {adverbOne} through the large tunnel that led to its {adjectiveTwo} {nounTwo}. I got some peanuts and passed them through the cage to a gigantic gray { nounThree} towering above my head. Feeding that animal mademe hungry.I went to get a {adjectiveThree} scoop of ice cream. It filled my stomach. Afterwards I had to {verbOne}{adverbTwo} to catch our bus.When I got home I {verbPastTenseTwo} my mom for a {adjective} day at the zoo.");

            PressKeyToCountinue();

        }

        public void GameFour()
        {
            Console.Clear();

            Console.WriteLine("Enter an adjective.");
            string adjectiveOne = Console.ReadLine();

            Console.WriteLine("Enter a noun.");
            string nounOne = Console.ReadLine();

            
            Console.WriteLine("Enter a plural noun.");
            string pluralNounTwo = Console.ReadLine();

            Console.WriteLine("Enter an adverb.");
            string adverbOne = Console.ReadLine();

            Console.WriteLine("Enter a number.");
            //int numberOne = int.Parse(Console.ReadLine());
            string one = Console.ReadLine();

            //  int NumberInput = int.Parse(Console.ReadLine());
            //Did I get valid input

            int numberOne;
            while (!int.TryParse(one, out numberOne))
            {
                Console.WriteLine("Invalid selection, please enter a Number.");
                one = Console.ReadLine();
            }


            Console.WriteLine("Enter a past tense verb.");
            string pastTenseVerbOne = Console.ReadLine();

            Console.WriteLine("Enter an adjective.");
            string adjectiveTwo = Console.ReadLine();

            
            Console.WriteLine("Enter a past tense verb ending in est.");
            string pastTenseVerbTwo = Console.ReadLine();

            Console.WriteLine("Enter an adverb.");
            string adverbTwo = Console.ReadLine();

            Console.WriteLine("Enter an adjective.");
            string adjectiveThree = Console.ReadLine();

            Congratualtions();

            Console.WriteLine($"Today, my fabulous camp group went to a(an) {adjectiveOne} amusement park. It was a fun park with lots of cool {nounOne} and enjoyable play structures. When we got there, my kind counselor shouted loudly, 'Everybody off the {pluralNounTwo}.' We all pushed out in a terrible hurry. My counselor handed out yellow tickets, and we scurried in. I was so excited! I couldn't figure out what exciting thing to do first. I saw a scary roller coaster I really liked so, I {adverbOne} ran over to get in the long line that had about {numberOne} people in it. When I finally got on the roller coaster I was {pastTenseVerbOne}. In fact I was so nervous my two knees were knocking together. This was the {adjectiveTwo} ride I had ever been on! In about two minutes I heard the crank and grinding of the gears. That’s when the ride began! When I got to the bottom, I was a little {pastTenseVerbTwo} but I was proud of myself. The rest of the day went {adverbTwo}. It was a(n) {adjectiveThree} day at the fun park.");

            PressKeyToCountinue();


        }

        public void GameFive()
        {
            Console.Clear();

            Console.WriteLine("Enter an adjective.");
            string nounOne = Console.ReadLine();

            Console.WriteLine("Enter an adjective.");
            string adjectiveOne = Console.ReadLine();

            Console.WriteLine("Enter a noun.");
            string numberOne = Console.ReadLine();

            Console.WriteLine("Enter an adjective.");
            string adjectiveTwo = Console.ReadLine();

            Console.WriteLine("Enter an adjective.");
            string nounTwo = Console.ReadLine();

            Console.WriteLine("Enter a noun.");
            string properNounOne = Console.ReadLine();

            Console.WriteLine("Enter a verb.");
            string properNounTwo = Console.ReadLine();

            Console.WriteLine("Enter a verb.");
            string pluralNounOne = Console.ReadLine();

            Console.WriteLine("Enter an adjective.");
            string ingVerbOne = Console.ReadLine();

            Console.WriteLine("Enter a noun.");
            string pluralNounTwo = Console.ReadLine();

            Console.WriteLine("Enter a Adverb.");
            string adjectiveThree = Console.ReadLine();

            Console.WriteLine("Enter a adverb");
            string adverbOne = Console.ReadLine();

            Congratualtions();

            Console.WriteLine($"One very nice morning near the end of summer, my mother woke me up at 4:00 A.M. and said, Wake up and smell the grass, sleepy head! Today is your first day of school and you can't be late. I groaned in my bed for twenty seconds, but eventually I got dressed.I wore a blue and white striped, long sleeve {nounOne} with a collar on it, a red tie, dark gray pants, white socks, black shoes, and a(n) {adjectiveOne} hat.In ten minutes I madelunch and ate my breakfast.{numberOne} minutes later, the bus came.A few minutes later, Iwas at school.In school, I met two really {adjectiveTwo} kids.All of us became friends very fast.That day we had Science, and luckily my friends and I were at the same {nounTwo} .My friends' names are {properNounOne} and {properNounTwo}. In Math we weren't together, and that really bugged me.We learned what {pluralNounOne} were, and when to use them.At snack and recess, we played a game together.It was extremely fun.At P.E., we were {ingVerbOne} off of the ropes onto {pluralNounTwo} .I thought it was a very {adjectiveThree} idea.In swimming class, we needed to swim extremely {adverbOne}, or else we would have to swim longer.Before I knew it, school was over.I grabbed all my belongings and put them into my backpack.In two minutes, the bus came.As I stepped into the bus I shouted, Goodbye, adios amigos, and shalom, to my friends.Then I went into the bus. In a flash, I was back home. This day was an extremely exciting day!");

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
    }
}