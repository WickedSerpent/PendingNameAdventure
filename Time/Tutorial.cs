using System;

namespace TheTypeOfTime
{
    public class Tutorial
    {
        public static void FirstCross()
        {
            Console.Clear();
            Console.WriteLine("We have two tunnels to chose between.\n" +
                              "One to the left and one to the Right\n" +
                              "--[L]eft--[R]ight--[E]xplore surroundings--[N]arra tor--\n");
            while (Console.ReadKey().Key == ConsoleKey.L)
            {
                Program.encounter.FirstFight();
            }

            while (Console.ReadKey().Key == ConsoleKey.R)
            {
                Program.encounter.FirstFight();
            }

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

        private static void FirstCrossExplored()
        {
            Console.Clear();
            Console.WriteLine("We have two paths to chose between.\n" +
                              "One to the left and one to the Right\n" +
                              "--[L]eft--[R]ight--[N]arra Tor--\n");
            while (Console.ReadKey().Key == ConsoleKey.L)
            {
                Program.encounter.FirstFight();
            }

            while (Console.ReadKey().Key == ConsoleKey.R)
            {
                Program.encounter.FirstFight();
            }
            while (Console.ReadKey().Key == ConsoleKey.N)
            {
                Console.WriteLine("Not now, lets get out of this cave first!");
            }

            FirstCrossExplored();

        }

        public static void ExploreTutorial()
        {
            Console.WriteLine("*You fumble around in pitch blackness, but you feel as if all of your instincts are partially controlled*\n" +
                              "*it's a strange feeling, it's like you can sense the presence of an object in front of you*\n" +
                              "Narra Tor: Bend down here!\n");
            Console.ReadKey();
            Console.WriteLine("*As you bend down, your right arm instinctively reach towards the ground, and you feel your hand grab something*\n" +
                              "*it feels like a flask of some kind*\n" +
                              "Narra Tor: Yea! we just found a HEALTH POTION!\n");
            Program.currentPlayer.potion++;
            Console.Clear(); 
            Console.WriteLine("Narra Tor: Don't stop now! I see an some kind of stick here too!\n");
            Console.ReadKey();
            Console.WriteLine("*You move towards the direction your parasite headpet compells you, bend down, and find...*\n");
            Console.WriteLine("Narra Tor: Nice stick!\n" +
                              "*You feel the weight and width this object to indicate that this is definitely a club!*");
            Program.currentPlayer.weapon = "club";
            Program.currentPlayer.damage = 5;
            FirstCrossExplored();
        }
    }
    
}