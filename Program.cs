using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PASS_24_25_OOP {

    internal class Program {

        static void Main(string[] args) {
            //DiceStuff();
            //Console.ReadKey();


            Monster monster = new Monster("Manticore", 38, 18);

            Console.WriteLine(monster.GetName() + " has attacked!");

            Dice d8 = new Dice(8);

            int roll = d8.Roll();

            while (!monster.Damage(roll)) {
                Console.WriteLine("You have dealt " + roll + " damage.");
                Console.WriteLine(monster.GetName() + " has " + monster.GetHealth() + " health left.");
                roll = d8.Roll();
            }
            Console.WriteLine(monster.GetName() + " has died.");
            Console.ReadKey();
        }

        private static void DiceStuff() {
            int first = RollDice(6);
            int second = RollDice(20);

            Console.WriteLine(first);
            Console.WriteLine(second);

            // Swap values based on size
            if (second > first) {
                int temp = second;
                second = first;
                first = temp;
            }
            Console.WriteLine("Results: ");
            int result1 = first - second;
            Console.WriteLine("Swap Method: " + result1);

            // Absolutes
            int result2 = Math.Abs(second - first);
            Console.WriteLine("Absolute Method:" + result2);

        }

        private static int RollDice(int sides) {
            Dice d6 = new Dice(6);
            return d6.Roll();
        }
    }

}
