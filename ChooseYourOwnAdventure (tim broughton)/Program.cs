using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChooseYourOwnAdventure__tim_broughton_
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Welcome to looper! The time travel game where you need to put things in order to break the loop!\n" +
                                  "You are the genius inventor of the time machine! WAY TO GO!!\nOnly it's malfunctioning and you need to fix it! BUMMER!!\n" +
                                  "The machine has made 3 stops, and at each you need to recollect the correct parts to fix it\nOR ELSE THE LOOP WILL NEVER BREAK!!\n" +
                                  "The game will move through each spot, and allow tyou to decide what part is needed!\nPicking the wrong parts might lead to.. problems..\n" +
                                  "SO press any key to begin, and we will take this from the begining!\n");

                Console.ReadKey();
                Console.Clear();



                if (TimeEygpt() == true)
                {
                    Console.Clear();
                    if (TimeRome() == true)
                    {
                        Console.Clear();
                        if (TimePrehistory() == true)
                        {
                            Console.Clear();
                            Console.WriteLine("The modern day fades back into view!\nBut you have to wonder if you affected anything in the past...\nAs you see the monkeys with jetpcks" +
                                              "you're sure things are just fine!\n >>>>>> YOU WIN!!!! <<<<<<");
                            Console.ReadKey();
                            break;
                        }
                        else
                        {
                            Console.Clear();
                            Console.WriteLine("You've met with a terrible fate...\nType 'y' to continue looping!");
                            char mydecision = Console.ReadKey(true).KeyChar;

                            if (mydecision != 'y' && mydecision != 'Y')
                            {
                                Console.WriteLine("Goodbye!!");
                                Console.ReadKey();
                                break;
                            }

                        }

                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("You've met with a terrible fate...\nType 'y' to continue looping!");
                        char mydecision = Console.ReadKey(true).KeyChar;

                        if (mydecision != 'y' && mydecision != 'Y')
                        {
                            Console.WriteLine("Goodbye!!");
                            Console.ReadKey();
                            break;
                        }
                    }

                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("You've met with a terrible fate...\nType 'y' to continue looping!");
                    char mydecision = Console.ReadKey(true).KeyChar;

                    if (mydecision != 'y' && mydecision != 'Y')
                    {
                        Console.WriteLine("Goodbye!!");
                        Console.ReadKey();
                        break;
                    }
                }



            }




        }
        //---------------------------------------------------------------------------------------------------EYGPT
        static bool TimeEygpt()
        {
            Console.WriteLine("The vast sand stretches for miles in every direction.\nNext to you the time machine sits missing several important pieces.\n" +
                              "You could have sworn when you were here the first time... \nthere was a clear blue tube sticking out of the bits of wire behind the seat...");
            string choice = "";
            string part = "";
            int counter = 0;


            while (part.Length == 0 && counter < 4)
            {

                while (true)
                {
                    Console.WriteLine("\n\nWould you like to investigate....\n1. The Sphinx\n2. The Pyramids\n3. The Pharoh's Swimming Pool\ntype the number of your choice!\n" +
                                ">>> WARNING: you only have time to try checking 2 of the 3 locations\n After that the time rifts take you back to the start! <<<\n" +
                                "You CAN visit the same location more than once!");

                    choice = Console.ReadLine();


                    if (choice == "1" || choice == "2" || choice == "3")
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine("please pick, 1, 2, or 3!");
                    }
                }


                switch (choice)
                {
                    case "1":
                        counter++;
                        Console.WriteLine("You decide to check out this Sphinx dude.\nHe's pretty huge and looking kind of upset that you crashed your machine near him.\n" +
                                           "You approach the Sphinx slowly. Beneath his gaze he offers you a riddle...\n\n'What is the answer to life the universe and everything?'");
                        string answer = Console.ReadLine().ToLower();

                        if (answer == "42" || answer == "forty two" || answer == "fortytwo")
                        {
                            Console.WriteLine("The Sphinx seems to like your answer.\nIt offers you a round green jewel of likely significant importance.\n" +
                                              "Do you want to try and use the green jewel to fix the time machine?\n'y' to take it!");

                            char decide = Console.ReadKey(true).KeyChar;

                            if (decide == 'y' || decide == 'Y')
                            {
                                part = "green jewel";
                            }
                        }
                        else
                        {
                            Console.WriteLine("That does not seem like the right answer.\nThe Sphinx is getting pretty peeved.\nLet's retreat and think again...");
                            Console.ReadKey();
                        }
                        break;


                    case "2":
                        counter++;
                        Console.WriteLine("Let's check out these crazy pyramids! There's a TON so you run into the largest one in town.\nIt seems like a lot of dudes are" +
                                          " worshipping around a blue slate.\nIt's a pretty big square made of pretty blue rock.\nHey, maybe that's what we need?\n" +
                                          "Would you like to steal the big blue slate while everyone has their eyes closed?\n'y' to take it!");

                        char mydecision = Console.ReadKey(true).KeyChar;

                        if (mydecision == 'y' || mydecision == 'Y')
                        {
                            Console.WriteLine("This seems pretty shady, but ok!\nYou swipe the tablet and make your way huffing back to the time machine!\nAn angry mob may" +
                                            " or may not be right behind you!");

                            part = "blue slate";
                        }
                        break;



                    case "3":
                        counter++;
                        Console.WriteLine("The Pharoh seems like a cool dude.\nJust over some dunes he is having a rager of a party and you just invited yourself!\n" +
                                          "He is decked out in some radical jewelry, but thinks you look pretty cool too!\nHe send one of his wards your way to ask" +
                                          " if you would trade one of the buttons on your suit\n He offers his round blue jewel on his sceptor.\n'y' to take that trade!");

                        mydecision = Console.ReadKey(true).KeyChar;

                        if (mydecision == 'y' || mydecision == 'Y')
                        {
                            Console.WriteLine("Seems like a good deal to me! You give the Pharoh a button and he gives you a round blue jewel!\n It looks more like a tube up close!\n" +
                                              "\nNo problem though, you make your way back to the time machine with the blue jewel!");

                            part = "blue jewel";
                        }
                        break;
                }
            }

            if (counter > 2)
            {
                Console.WriteLine("You tried finding the right object, but you just didn't have enough time!\nThe time machine starts beeping at you, and everything starts to" +
                                  " shimmer and turn blue!\nNext time, try and rememmber just what we need!\n");
                Console.ReadKey();
                return false;
            }

            if (part == "blue jewel")
            {
                Console.WriteLine("This has to be it! You take the Pharohs 'blue jewel' and screw it into the time machine. It lights up!\n" +
                                   "Everything starts to get all shimmery and blue!\nAs the heat of the desert fades away you wonder where you'll be next!\n");
                Console.ReadKey();
                return true;
            }
            else
            {
                Console.WriteLine("This has to be it! You take the {0} and try screwing it in. It doesn't really fit...\n" +
                                  "You try jamming it in and smashing it in sideways, but it's no use.\n" +
                                  "As the blue shimmering light covers everything, you're sure you'll get it this time!", part);

                Console.WriteLine("Enter anything to continue!");
                Console.ReadKey();
                return false;
            }

        }

        //--------------------------------------------------------------------------------------------------ROME
        static bool TimeRome()
        {
            Console.WriteLine("The sand is gone, but not from your shoes!\nThere are great stone buildings and statues, oh and Ceasar is here!\n" +
                              "You could have sworn when you were here the first time...\nthat there was a red round piece sticking out of the front of the machine...");
            string choice = "";
            string part = "";
            int counter = 0;


            while (part.Length == 0 && counter < 3)
            {

                while (true)
                {
                    Console.WriteLine("\n\nWould you like to investigate....\n1. The Aquaduct\n2. Caeser\n3. Colluseum\ntype the number of your choice!\n" +
                                ">>> WARNING: you only have time to try checking 2 of the 3 locations\n After that the time rifts take you back to the start! <<<\n" +
                                "You CAN visit the same location more than once!");

                    choice = Console.ReadLine();


                    if (choice == "1" || choice == "2" || choice == "3")
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine("please pick, 1, 2, or 3!");
                    }
                }


                switch (choice)
                {
                    case "1":
                        counter++;
                        Console.WriteLine("All that time in the sand has made you thirsty.\nYou head for the Aquaducts with dreams of ice cold water!\n" +
                                          "You reach the Aquaduct and notice a round red piece of metal below the water" +
                                          "Would you like to try and take this?\n'y' for yes!");

                        char mydecision = Console.ReadKey(true).KeyChar;

                        if (mydecision == 'y' || mydecision == 'Y')
                        {
                            Console.WriteLine("You stick your head in 'bobbing for apples style' and grab that sucker and a gulp of water!");

                            part = "red circle";
                        }
                        break;



                    case "2":
                        counter++;
                        Console.WriteLine("'YO DUDE!' you shout as you head up to the man himself! He does not seem pleased though. Just back from war and bad dreams, etc\n" +
                                          "In an effort to never hear you speak again he stuffs a red sock in your mouth and leaves via chariot.\n" +
                                          "Would you like to take this back to the time machine?\n'y' to take it!");

                        mydecision = Console.ReadKey(true).KeyChar;

                        if (mydecision == 'y' || mydecision == 'Y')
                        {
                            Console.WriteLine("Weird choice but ok........");

                            part = "red sock";
                        }
                        break;



                    case "3":
                        counter++;
                        Console.WriteLine("You head to the Colloseum!\nThis place is huge and awesome, and two dudes are fighting a bull with swords!\n" +
                                          "You notice one of them has a red square piece of cloth, do you want to try taking this?\n'y' for yes!");

                        mydecision = Console.ReadKey(true).KeyChar;

                        if (mydecision == 'y' || mydecision == 'Y')
                        {
                            Console.WriteLine("What a crazy idea!! You run in there full tilt and nab the thing to a thousand booing Romans!");

                            part = "red cloth";
                        }
                        break;
                }
            }

            if (counter > 2)
            {
                Console.WriteLine("You tried finding the right object, but you just didn't have enough time!\nThe time machine starts beeping at you, and everything starts to" +
                                  " shimmer and turn blue!\nNext time, try and rememmber just what we need!\n");
                Console.ReadKey();
                return false;
            }

            if (part == "red circle")
            {
                Console.WriteLine("This has to be it! You slide the metal circle thing into the front and it fits perfectly!\n" +
                                   "Everything starts to get all shimmery and blue!\nAs Rome fades away you wonder where you'll be next!\n");
                Console.ReadKey();
                return true;
            }
            else
            {
                Console.WriteLine("This has to be it! You take the {0} and try screwing it in!. It doesn't really fit...\n" +
                                   "You try jamming it in and smashing it in sideways, but it's no use.\n" +
                                   "As the blue shimmering light covers everything, you're sure you'll get it this time!", part);

                Console.WriteLine("Enter anything to continue!");
                Console.ReadKey();
                return false;
            }

        }



        //-------------------------------------------------------------------------------------------PREHISTORY
        static bool TimePrehistory()
        {
            Console.WriteLine("The walls of Rome are gone, replaced by lush jungles!!\nVines grow everywhere, and ferns sprout between the trees!\n" +
                              "You could have sworn when you were here the first time...\nthat there was a purple stick sticking out of the back of the machine...");
            string choice = "";
            string part = "";
            int counter = 0;


            while (part == "" && counter < 3)
            {

                while (true)
                {
                    Console.WriteLine("\n\nWould you like to investigate....\n1. The Sleeping T-Rex\n2. The Hollow Log\n3. The Lake\ntype the number of your choice!\n" +
                                ">>> WARNING: you only have time to try checking 2 of the 3 locations\n After that the time rifts take you back to the start! <<<\n" +
                                "You CAN visit the same location more than once!");

                    choice = Console.ReadLine();


                    if (choice == "1" || choice == "2" || choice == "3")
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine("please pick, 1, 2, or 3!");
                    }
                }


                switch (choice)
                {
                    case "1":
                        counter++;
                        Console.WriteLine("Never a better time to see one up close, except maybe next time!\nYou sneak up on the T-Rex and notice something...\n" +
                                          "It seems to be sleeping next to a bright purple twig?\n" +
                                          "Would you like to try and take this?\n'y' for yes!");

                        char mydecision = Console.ReadKey(true).KeyChar;

                        if (mydecision == 'y' || mydecision == 'Y')
                        {
                            Console.WriteLine("Hey this is more metalic than wood! You creep away from the T-Rex very carefuly!");

                            part = "purple stick";
                        }
                        break;



                    case "2":
                        counter++;
                        Console.WriteLine("\nLogs are so FUN!!!!\n\nLet's check this one out!\nInside the massive log that you could live in is a round purple thing.\n" +
                                          "It seems to be more shaped like a sphere but.. longer?\nWhat do they call those things? Anyway...\n" +
                                          "Would you like to take this back to the time machine?\n'y' to take it!");

                        mydecision = Console.ReadKey(true).KeyChar;

                        if (mydecision == 'y' || mydecision == 'Y')
                        {
                            Console.WriteLine("EGG!!!\n\nThat's what it is!\nAnd as you run back the hundreds of raptors behind you don't seem happy!");

                            part = "purple egg";
                        }
                        break;



                    case "3":
                        counter++;
                        Console.WriteLine("Now that's a lake! Not like those wimpy lakes back home!\nAs you survey the lake, some shark type monster offers you a pearl!\n" +
                                          "Do you want to try taking this?\n'y' for yes!");

                        mydecision = Console.ReadKey(true).KeyChar;

                        if (mydecision == 'y' || mydecision == 'Y')
                        {
                            Console.WriteLine("Wow this is definitley a good luck pearl, let's see if it works for you!!");

                            part = "pearl";
                        }
                        break;
                }
            }

            if (counter > 2)
            {
                Console.WriteLine("You tried finding the right object, but you just didn't have enough time!\nThe time machine starts beeping at you, and everything starts to" +
                                  " shimmer and turn blue!\nNext time, try and rememmber just what we need!\n");
                Console.ReadKey();
                return false;
            }

            if (part == "purple stick")
            {
                Console.WriteLine("This has to be it! You jam the purple stick into the back and it fits perfectly!\n" +
                                   "Everything starts to get all shimmery and blue, and the jungle begins to fade away!!\n");
                Console.ReadKey();
                return true;
            }
            else
            {
                Console.WriteLine("This has to be it! You take the {0} and try screwing it in!. It doesn't really fit...\n" +
                                   "You try jamming it in and smashing it in sideways, but it's no use.\n" +
                                   "As the blue shimmering light covers everything, you're sure you'll get it this time!", part);

                Console.WriteLine("Enter anything to continue!");
                Console.ReadKey();
                return false;
            }
        }
    }
}
