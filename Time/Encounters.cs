using System;

namespace TheTypeOfTime
{
    public class Encounters
    {
        private string direct = movement.Direction;
        private string weapon = Program.currentPlayer.equipped;
        private int health = Program.currentPlayer.health;
        private int damage = Program.currentPlayer.damage;
        private int potion = Program.currentPlayer.potion;
        private int armor = Program.currentPlayer.armor;
        private int coins = Program.currentPlayer.coins;




        public static void StagedCombat(string name, int power, int hp)
        {
            //prefixed combat
        }

        public void combat(bool random, string name, int power, int hp)
        {
            string n = "";
            int p = 0;
            int h = 0;
            int defended = 0;
            //random check
            if (random)
            {
            }
            else
            {
                n = name;
                p = power;
                h = hp;
            }

            while (h > 0 && health > 0)
            {
                Console.WriteLine($"|Health: {health} [P]ot: {potion} |" +
                                  $"|*********************************|" +
                                  $"|[A]ttack        [S]pecial Attack |" +
                                  $"|[D]efend  | [F]lee  |  [C]ounter |" +
                                  $"|*********************************|");
                string input = Console.ReadLine();
                if (input.ToLower() == "a" || input.ToLower() == "attack")
                {
                    /*Player attack first, enemy next standard values*/
                    int enemyDamage = p - Program.currentPlayer.armor;

                    h -= damage;
                    while (h > 0)
                    {
                        Console.WriteLine($"You attacked with your {weapon} and did {damage} damage!");
                        Console.WriteLine($"The {n} attacked you back, dealing {enemyDamage} damage!");
                        health -= enemyDamage;
                        Console.WriteLine($"the {n} has {h} health left, whilst you have {health}");
                    }

                    Console.WriteLine($"You finished off the {n} with your {weapon}!");
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
                    defended++;
                }

                else if (input.ToLower() == "s" || input.ToLower() == "special" || input.ToLower() == "special attack")
                {
                    /*requires player to have defended x times*/

                }
                else if (input.ToLower() == "f" || input.ToLower() == "flee")
                {
                    /*flees from combat based on luck*/

                }
                else if (input.ToLower() == "c" || input.ToLower() == "counter")
                {
                    /*enemy attacks first, then player attacks with random bonus dmg*/

                }


            }

        }
    }
}