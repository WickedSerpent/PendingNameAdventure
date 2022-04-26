using System;

namespace TheTypeOfTime
{
    class NarraIntro
    {
        public static void Start()
        {
           
            Console.WriteLine("Welcome to the land of GameTitleHereia!");
            Console.WriteLine("     --Press any Key to start--        ");
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("Tell me about yourself.. ");
            Console.WriteLine("--Enter--");
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("Like, whats your name? (Write your characters name)");
            Program.currentPlayer.name = Console.ReadLine();
            if (Program.currentPlayer.name == "")
            {
                Program.currentPlayer.name = "Nameless";
                Console.WriteLine("you don't remember huh? that's fine for now, I'l just call you " +
                                  "Nameless for now. I find that fitting.");
                Console.ReadKey();
                Console.Clear();
                Console.WriteLine("Il assume you don't remember your origin either so lets figure that out together \n" +
                                  "you must be a special person! :D\n" +
                                  "let me introduce myself\n");
                NarraIntro();
            }
            else
            {
                Console.WriteLine("...");
                Console.Clear();
                Console.ReadLine();
                Console.WriteLine(Program.currentPlayer.name + "?!... That's a very strange name!");
                Console.WriteLine("You must me very special person! :D");
                Console.WriteLine("--press enter to confirm that you're a special person--");
                Console.ReadKey();
                Console.Clear();
                Console.WriteLine("cool..");
                Console.ReadKey();
                Console.Clear();
                Console.WriteLine("Let me introduce myself");
                NarraIntro();
            }

            static void NarraIntro()
            {
                if(Program.currentPlayer.name != "Nameless"){                
                    Console.WriteLine($"I do wonder, do you remember where you're from {Program.currentPlayer.name}? \n" +
                                      $"-- type place of birth--\n");
                    Program.currentPlayer.origin = Console.ReadLine();
                    Console.WriteLine($"gottcha! {Program.currentPlayer.name} of {Program.currentPlayer.origin} \n");
                }
                Console.WriteLine("--do you wish \"[H]ear\" my introduction? or \"[S]kip\"");
                
                while (Console.ReadKey().Key == ConsoleKey.H)
                {   Console.Clear();
                    Console.WriteLine("My name is Narra Tor!\n" +
                                      "Which is a much more normal name in these parts I might add.\n " +
                                      "I'm part of an ancient race called Tor. We're quite descriptive" +
                                      "and love to describe what we see when we see it. there are oddballs like\n" +
                                      "Answer Tor, which loves answering questions. I don't know what I feel about him" +
                                      "as the Tor's has no agency.\n" +
                                      "Now I've got some good news and some bad news:");
                    Console.Clear();
                    Console.ReadKey();
                    Console.WriteLine(
                        "The good news is that I'm here for you! and you can forever trust my guidance, completely.");
                    Console.ReadKey();
                    Console.WriteLine(
                        "The bad news is that you've been cursed by a powerful spell, which has paralyzed your sight!\n" +
                        "and uh...(placeholder inc)\n" +
                        "Also, I'm currently living in your brain! but that' neither here nor there\n" +
                        "--press space--\n");
                    Console.Clear();
                    Console.ReadKey();
                    Console.WriteLine("But don't worry, I'm a good guide and I'm currently using your eyes for you.\n" +
                                      "so you're pretty much fully reliant upon my guidance.\n" +
                                      "I myself, is facing an issue, and that is, I literally have no agency!\n" +
                                      "so here's the deal, I'l use your eyes FOR you, and you'll make all our choices.\n" +
                                      "We actually don't have much time. so I can't answer any questions at the moment.\n" +
                                      "--press space--\n");
                    Console.Clear();
                    Console.WriteLine("We're currently in a cave of some sort.");
                    
                }
                while (Console.ReadKey().Key == ConsoleKey.S)
                {   
                    Console.WriteLine("We're currently in a cave of some sort.");
                }

            }
        }
    }
}
