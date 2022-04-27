using System;



namespace TheTypeOfTime
{
    public class Encounters
    {
        static Random ran = new Random();
        private static string weapon = Program.currentPlayer.equipped;
        private static int health = Program.currentPlayer.health;
        private static int damage = Program.currentPlayer.damage;
        private static int potion = Program.currentPlayer.potion;
        private static int armor = Program.currentPlayer.armor;
        private static int coins = Program.currentPlayer.coins;
        
        public static void FixedCombat(string name, int power, int hp)
        {   
            Console.Clear();
            string n = "";
            int p = 0;
            int h = 0;
            int DCtotal = 0;
            


            // enemy parameters 
            n = name;
            p = power;
            h = hp;

            //loot
            int minC = hp / 6;
            int maxC = hp / 3;
            int rc = coins + ran.Next(minC,maxC);
            
            while (h > 0 && health > 0)
            {  
                int e = p - armor;
                Console.WriteLine($"{n}: hp: {h} power: {p} {n}'s damage: {e}");
                Console.WriteLine($"|Health: {health} [P]ot: {potion} |\n" +
                                  $"|*********************************|\n" +
                                  $"|[A]ttack        [S]pecial Attack |\n" +
                                  $"|[D]efend  | [F]lee  |  [C]ounter |\n" +
                                  $"|*********************************|\n");
                string input = Console.ReadLine();
                if (input.ToLower() == "a" || input.ToLower() == "attack")
                {
                    /*Player attack first, enemy next standard values*/
                    h -= damage;
                    if (h > 0)
                    {
                        Console.WriteLine($"You attacked with your {weapon} and did {damage} damage!");
                        Console.WriteLine($"The {n} attacked you back, dealing {e} damage!");
                        health -= e;
                        Console.WriteLine($"the {n} has {h} health left, whilst you have {health}");
                    }
                    else
                    {
                        Console.WriteLine($"You finished off the {n} with your {weapon}!");
                    }
                }
                else if (input.ToLower() == "d" || input.ToLower() == "defend")
                {
                    /*Player defends for half damage / something else, preparing for either flee or special*/
                    if (armor > 0)
                    {
                        Console.WriteLine($"You've defended the {n}'s attack!");
                        armor--;
                    }
                    else
                    {
                        Console.WriteLine($"You braced for {n}'s damage, reducing damage taken by half!");
                        health -= p / 2;
                    }

                    DCtotal++;
                }

                else if (input.ToLower() == "s" || input.ToLower() == "special" || input.ToLower() == "special attack")
                {
                    /*requires player to have defended x times*/
                    if (DCtotal >= 2)
                    {
                        Console.WriteLine(
                            $"You've dealt DOUBLE damage with your {weapon} whilst ignoring {n}'s attack!");
                        h -= (damage * 2);
                        DCtotal -= 2;
                    }
                    else
                    {
                        Console.WriteLine("you need to defend/countered twice for this to work!" +
                                          $" {n} hit you for {p} damage!");
                        health -= e;
                    }

                }
                else if (input.ToLower() == "f" || input.ToLower() == "flee")
                {
                    /*flees from combat based on luck*/

                }
                else if (input.ToLower() == "c" || input.ToLower() == "counter")
                {
                    /*enemy attacks first, then player attacks with random bonus dmg*/
                }
                else if (input.ToLower() == "p" || input.ToLower() == "potion")
                {
                    if (potion <= 0)
                    {
                        Console.WriteLine("nope, you're all out!");
                    }
                    else
                    {
                        potion--;
                        int potionVal = 10;
                        health += potionVal;
                        if (health > 100)
                        {
                            health = 100;
                        }
                    }
                }
            }
            Console.WriteLine($"You brutally murdered the {n}! and got {rc}coins!");
            Console.ReadKey();

        }

        public static void Combat(bool random, string name, int power, int hp)
        {
            //random and enhanced combat
            if (random)
            {
                
            }
            else
            {
                
            }
        }
    }
}
