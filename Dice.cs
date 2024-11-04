using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PASS_24_25_OOP {
    internal class Dice {

        // Variables
        public int sides;
        private Random rand;

        // Constructor
        public Dice(int sides) {
            this.sides = sides;
            this.rand = new Random();
        }

        // Function
        public int Roll() {
            return rand.Next(1, sides+1);
        }

    }
}
