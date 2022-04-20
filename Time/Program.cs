using System;

namespace Time
{
    class Program
    {
        static void Main(string[] args)
        {
            // string MaleMainName = "Main Protagonistson";
            // string FemaleMainName = "Mainie Protagonistia";
            // string male = "boy";
            // string female = "girl";

            string CharacterName = "Main Protagonist";
            
            Console.WriteLine("Welcome to the land of GameTitleHereia!");
            Console.ReadKey();
            Console.WriteLine("Tell me about yourself..");
            Console.ReadKey();
            Console.WriteLine("Like, whats your name? (Write your characters name)");
            CharacterName = Console.ReadLine();
            if (CharacterName == "")
            {
                Console.WriteLine(".. You there? You didn't type a name. For now we'll restart this game so you can try again");
                CharacterName = Console.ReadLine();
            }else{
            Console.WriteLine("...");
            Console.ReadLine();
            Console.WriteLine(CharacterName+"?!" + " That's a very strange name!");
            Console.WriteLine("You must me very special person! :D");
            }


        }
    }
}