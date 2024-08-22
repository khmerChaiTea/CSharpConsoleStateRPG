using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpConsoleStateRPG
{
    class Character
    {
        // Core
        private String name = "";
        private String description = "";
        private int level = 0;
        private int attributePoints = 3;
        private int exp = 0;
        private int expMax = 100;

        // Attributes
        private int vitality = 1;
        private int strength = 1;
        private int dexterity = 1;
        private int agility = 1;
        private int intelligence = 1;

        // Stats
        private int hp = 0;
        private int hpMax = 0;
        private int damage = 0;
        private int damageMax = 0;
        private int accuracy = 0;
        private int defence = 0;

        // General
        private int gold = 100;

        private void CalculateExp()
        {
            this.expMax = this.level * 100;
        }

        private void CalculateStats()
        {
            this.hp = this.vitality * 10;
            this.damageMax = this.strength * 2;
            this.damage = this.strength;
            this.accuracy = this.dexterity * 2;
            this.defence = this.agility * 2;
        }

        public Character(String name, string description)
        {
            this.CalculateStats();

            this.name = name;
            this.description = description;
        }

        public override string ToString()
        {
            return this.name;
        }
    }
}
