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

            NarraIntro.Start();
        }


    }
}
