using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inlämningsuppgift_3
{
    enum Monster_Type
    {
        Electric,
        Water,
        Fire,
        Ice
    }
    class Monster
    {
        private protected string name;
        private protected int hP;
        private protected int curretHP;
        private protected int damage;
        private protected int atqBonusReduction;
        private protected int lvl;
        private protected Monster_Type type;
        private protected int gold;


        

        public string Name { get => name; }
        public int HP { get => hP * Lvl; }
        public  int CurrentHP { get => curretHP; set => curretHP = value; }
        public int Damage { get => damage; set => damage = value; }
        public int AtqBonusReduction { get => atqBonusReduction; set => atqBonusReduction = value; }
        public int Lvl { get => lvl; set => lvl = value; }
        public Monster_Type Type { get => type; }
        public int Gold { get => gold; set => gold = value; }

        public void ShowStats()
        {
            Console.WriteLine(Name);
            Console.WriteLine("Lvl " + Lvl.ToString());
            Console.WriteLine("HP " + CurrentHP.ToString());
            Console.WriteLine("Damage " + Damage.ToString());
            Console.WriteLine("Type " + type.ToString());
            Console.WriteLine();
        }

        public Monster AdjustLevel(Monster enemy, Player player)
        {
            Random r = new Random();

            enemy.Lvl = r.Next(player.Lvl / 2 + 1, player.Lvl);
            this.Damage = enemy.Damage * enemy.Lvl;
            this.CurrentHP = enemy.HP * enemy.Lvl;
            this.Gold = enemy.Gold * enemy.Lvl / 2;

            return enemy;
        }
    }
}
