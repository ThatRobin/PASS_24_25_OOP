using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PASS_24_25_OOP {
    internal class Monster {

        private string name;

        private int maxHealth;
        private int currentHealth;
        private int armourClass;

        public Monster(string name, int maxHealth, int armourClass) {
            this.name = name;
            this.maxHealth = maxHealth;
            this.currentHealth = maxHealth;
            this.armourClass = armourClass;
        }

        public string GetName() {
            return name;
        }

        public bool Damage(int amount) {
            this.currentHealth -= amount;
            return this.currentHealth <= 0;
        }

        public int GetHealth() {
            return this.currentHealth;
        }

    }
}
