using System;


/* String (string): a string of characters
 * Integer (int): a whole number
 * Boolean (bool): true or false
 * Double (double): a large number that can include a decimal
 */

namespace TheTypeOfTime
{


    class Program
    {
        public static Player currentPlayer = new Player();
        public static Interaction action = new Interaction();
        public static Encounters encounter = new Encounters();

        static void Main(string[] args)
        {

            Start();
        }

        static void Start()
        {

            Console.WriteLine("Welcome to the land of GameTitleHereia!");
            Console.WriteLine("     --Press any Key to start--        ");
            Console.ReadKey();
            Console.WriteLine("Tell me about yourself.. ");
            Console.WriteLine("--press a key to tell me about yourself--");
            Console.ReadKey();
            Console.WriteLine("Like, whats your name? (Write your characters name)");
            currentPlayer.name = Console.ReadLine();
            if (currentPlayer.name == "")
            {
                currentPlayer.name = "Blindy";
                Console.WriteLine(
                    "you don't remember huh? that's fine for now, I'l just call you Blindy for now");
                Console.ReadKey();
                Console.WriteLine("you don't really look like anyone I've ever seen before, " +
                                  "you must be a special person! :D" +
                                  "let me introduce myself");
                Narraintro();
            }
            else
            {
                Console.WriteLine("...");
                Console.ReadLine();
                Console.WriteLine(currentPlayer.name + "?!... That's a very strange name!");
                Console.WriteLine("You must me very special person! :D");
                Console.WriteLine("--click any key to confirm that you're a special person--");
                Console.ReadKey();
                Console.WriteLine("cool..");
                Console.WriteLine("Let me introduce myself");
                Narraintro();
            }
        }

        private static void Narraintro()
        {
            
            Console.WriteLine("--do you wish to skip the introduction? /"+"y/"+"n");
            action.Skip = Console.ReadLine();
            if (action.Skip == "y")
            {
                Console.WriteLine("My name is Narra Tor!" +
                                  "Which is a much more normal name in these parts I might add. " +
                                  "I do wonder, with a specially unique name like yours, " +
                                  "where are you even from?" +
                                  "-- type place of birth--");
                currentPlayer.origin = Console.ReadLine();
                Console.WriteLine("gottcha! never heard of it (placeholder) but I'l remember it.");
                Console.WriteLine("Now, I've got some good news and bad news for you," + currentPlayer.name + ".");
                Console.ReadKey();
                Console.WriteLine("The good news is that I'm here for you! and you can forever trust my guidance.");
                Console.ReadKey();
                Console.WriteLine(
                    "The bad news is that you've been cursed by a powerful spell, which has paralyzed your sight!\n" +
                    "and uh...(placeholder inc)\n" +
                    "I'm currently living in your brain!");
                Console.ReadKey();
                Console.WriteLine("But don't worry, I'm a good guide and I'm currently using your eyes for you.\n" +
                                  "so you're pretty much fully reliant upon my guidance.\n" +
                                  "I myself, is facing an issue, and that is, I literally have no agency!\n" +
                                  "so here's the deal, I'l use your eyes FOR you, and you'll make all our choices.\n" +
                                  "We actually don't have much time. so I can't answer any questions at the moment.\n" +
                                  "--type anything to continue--");
                Console.WriteLine("We're currently in a cave of some sort.");
                Tutorial.FirstCross();
            }
            else if (action.Skip == "n")
            {
                Tutorial.FirstCross();
            }
            else
            {
                Narraintro();
            }
        }
    }
}