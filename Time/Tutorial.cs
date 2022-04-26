using System;

namespace TheTypeOfTime
{
    public class Tutorial
    {   
        public static void FirstCross()
        { 
            Console.Clear();
            Console.WriteLine("We have two tunnels to chose between.\n" +
                              "I see two paths, but lets explore first as we're in desperate need of supplies\n" +
                              "--[E]xplore surroundings--[N]arra tor--\n");
            while (Console.ReadKey().Key == ConsoleKey.E)
            {
                ExploreTutorial();
            }

            while (Console.ReadKey().Key == ConsoleKey.N)
            {
                Console.WriteLine("Not now, lets get out of this cave first!\n");
            }
            FirstCross();
        }

        public static void FirstCrossExplored()
        {
            Console.Clear();
            Console.WriteLine("" +
                              "We have two paths to chose between.\n" +
                              "One to the left and one to the Right\n" +
                              "--[L]eft--[R]ight--[N]arra Tor--\n");
            while (Console.ReadKey().Key == ConsoleKey.L)
            {
                movement.Direction = "Left";
                FirstCavern();
            }

            while (Console.ReadKey().Key == ConsoleKey.R)
            {
                movement.Direction = "Right";
                FirstCavern();
            }
            while (Console.ReadKey().Key == ConsoleKey.N)
            {
                
                Console.WriteLine("Not now, lets get out of this cave first!\n");
            }

            FirstCrossExplored();

        }

        public static void ExploreTutorial()
        {
            Console.Clear();
            Console.WriteLine("You fumble around in pitch blackness, but you feel as if all of your instincts are partially controlled\n" +
                              "it's a strange feeling, it's like you can sense the presence of an object in front of you\n" +
                              "STOP!... Bend down here!\n");
            Console.WriteLine("As you bend down, your right arm instinctively reach towards the ground, and you feel your hand grab something\n" +
                              "it feels like a flask of some kind\n" +
                              "Yea! You just found a HEALTH POTION!\n");
            Program.currentPlayer.potion++;
            Console.ReadKey();
            Console.Clear(); 
            Console.WriteLine("Don't stop now! I see an some kind of stick here too!\n");
            Console.WriteLine("You move towards the direction your head parasite compels you. HEY that's not a nice thought!\n" +
                              "you bend down, and find...\n");
            Console.WriteLine("a club?\n" +
                              "You feel the weight and width this object and feel it's definitely a +14 club!\n" +
                              "You think it can probably do up to 14 damage, and yes I can read your mind.");
            Program.currentPlayer.equipped = "club";
            Program.currentPlayer.damage = 14;
            FirstCrossExplored();
        }
        
        private static void FirstCavern()
        {
            
            Console.Clear();
            Console.WriteLine($" You take the {movement.Direction}most path\n" +
                              $"The tunnel gets tighter and tighter.\n " +
                              $"suddenly you're in-front of a wooden, makeshift door, fastened to what seems like rotten planks\n" +
                              $"stuck in the walls of the cave. The smell of moldy wood engulfs your nose\n" +
                              $"what do you want to do to the door?\n" +
                              $"--[O]pen--[B]reak Door--[T]urn around--\n");
            string input = Console.ReadLine();
            if (input != null && (input.ToLower() == "t" || input.ToLower() == "Turn" || input.ToLower() == "Turn around"))
            {
                Tutorial.FirstCrossExplored();
            }
            else if (input != null && (input.ToLower() == "o" || input.ToLower() == "open" || input.ToLower() == "open door"))
            {
                Console.WriteLine("you opened the door without much fuzz\n");
            }
            else if (input != null && (input.ToLower() == "b" || input.ToLower() == "break" || input.ToLower() == "break door"))
            {
                Console.WriteLine("you kicked the door, attempting to break it...\n");
                Console.ReadKey();
                Console.WriteLine("But the door seems magically enhanced and won't budge...");
                Console.ReadKey();
                Console.WriteLine("also you're not wearing any shoes at the moment and hurt your foot somewhat\n" +
                                  "[ -2 health  ]");
                Program.currentPlayer.health -= 2;
                Console.WriteLine($"your total health is now {Program.currentPlayer.health}");
                Console.ReadKey();
                Console.WriteLine("Before you try any other radical solutions, you decide to try the door-handle.\n" +
                                  "You opened the door normally");
            }
            Console.WriteLine("The door led to a bigger cavern like space, and there's a lit fire-pit in the middle of it\n" +
                              "Above the fire-pit there's leaning sticks, skewered with all kinds of critters from rabbits to the more unappetising rats.\n" +
                              "Between you and the fire, stands a crookedly posed creature, staring at you with big glaring.");
            Console.WriteLine("creature: \"Grahl'ak tung outh Nargarl! Ounth auggkkr vi kank?!\"");
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("It's a Goblin!\n" +
                              "trust me, I've posses.. I mean I've met allot of goblins. This seems to be a Hexer, judging from it's robe.\n" +
                              "It seems to await for some response to it's question. What shall we do?\n" +
                              "*dialogue*\n" +
                              "--[A]ttempt answering the goblin \"question\"--[N]arra Tor--");
            if(input != null && input.ToLower() == "a")
            {
                Console.WriteLine("You don't know any Goblish, and stammer some unrecognizable gibberish.\n" +
                                  "This seems to offend the Goblin Hexer as it screetches out something whilst channeling a spell\n" +
                                  "[Goblin Hexer Summons a Fierce Rat!]\n");
            }
            else if (input != null && input.ToLower() == "n")
            {   Console.Clear();
                Console.WriteLine("--\"You [u]nderstand this thing?\"--\"why do you [d]escribe everything I do?\"--\"" +
                                  "[W]hat did it ask?\"--");
                if (input.ToLower() is "U" or "understand")
                {
                    Console.WriteLine("Yes I do, do you want to translate it for you?");
                    Console.WriteLine("--\"well [Y]EAH! why do I even have to tell you to?!\"--");
                    if (input.ToLower() == "y")
                    {
                        Console.WriteLine("I did mention I do not have any agency right? I only describe things, \n " +
                                          "that's the vary nature of us Tors. \n" +
                                          "To answer your question, it said...\n" +
                                          "the goblin got impatient and ordered it's Fierce rat to attack\n" +
                                          "--\"You [S]topped translating to tell me that?!\"--[P]repare for combat--");
                        if (input.ToLower() == "S")
                        {
                            Console.WriteLine("Before you could ask that question..\n " +
                                              "the rat managed to charge your knee and bit you hard, the pain was excruciating\n" +
                                              " [ - 8 health ]");
                            Program.currentPlayer.health -= 8;
                            Console.WriteLine($"your current health is: {Program.currentPlayer.health}");
                        }
                        else if (input.ToLower() == "p")
                        {
                            Encounters.FixedCombat("Fierce Rat", 8, 20);
                        }
                    }
                }
                else if (input.ToLower() is "d" or "describe")
                {
                    Console.WriteLine("[Goblin Hexer Summons a Fierce Rat!]\n");
                    Console.WriteLine("That's what we Tors do, we describe stuff so our hosts... \n" +
                                      "I mean friends, know what choice to pick in different situations.\n" +
                                      "[The rat comes charging]");
                    Encounters.FixedCombat("Fierce Rat", 8, 20);
                }
                else if (input.ToLower() is "w" or "what")
                {
                    Console.WriteLine("It want's to know if you enjoy the parasite it planted in your brain.\n" +
                                      "I would guess it's referring to me, then again, I have no agency \n" +
                                      "so speculation is entirely on your part.\n" +
                                      "The goblin seems impatient, as it starts to channel a spell\n" +
                                      "[Goblin Hexer Summons a Fierce Rat!]");
                    Encounters.FixedCombat("Fierce Rat", 8, 20);
                }
            }
            
        }

        public static void SkipToFirstFight()
        {
            Console.WriteLine("the Goblin Hexer's Fierce Rat plunges as you!");
            Encounters.FixedCombat("Fierce Rat", 8, 20);
        }
    }
    
}