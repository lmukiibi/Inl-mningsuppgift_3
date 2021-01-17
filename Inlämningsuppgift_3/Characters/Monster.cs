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

    struct FightingMonster
    {
        public string Name { get; set; }
        public int HP { get; set; }
        public int CurrentHP { get; set; }
        public int Damage { get; set; }
        public int Lvl { get; set; }
        public Monster_Type Type { get; set; }
        public int Gold { get; set; }

        public void ShowStats()
        {
            Console.WriteLine(Name);
            Console.WriteLine("Lvl " + Lvl.ToString());
            Console.WriteLine("HP " + CurrentHP.ToString());
            Console.WriteLine("Damage " + Damage.ToString());
            Console.WriteLine("Type " + Type.ToString());
            Console.WriteLine();
        }

    }
    class Monster
    {
        private protected string name;
        private protected int hP;
        private protected int curretHP;
        private protected int damage;
        private protected int lvl;
        private protected Monster_Type type;
        private protected int gold;


        

        public string Name { get => name; }
        public int HP { get => hP * Lvl; }
        public  int CurrentHP { get => curretHP; set => curretHP = value; }
        public int Damage { get => damage; set => damage = value; }
        public int Lvl { get => lvl; set => lvl = value; }
        public Monster_Type Type { get => type; }
        public int Gold { get => gold; set => gold = value; }

        public void ShowStats()
        {
            Console.WriteLine(Name);
            Console.WriteLine("Lvl " + Lvl.ToString());
            Console.WriteLine("HP " + CurrentHP.ToString());
            Console.WriteLine("Damage " + Damage.ToString());
            Console.WriteLine("Type " + Type.ToString());
            Console.WriteLine();
        }

        public FightingMonster SetValues(Monster enemy, Player player)
        {
            Random r = new Random();
            FightingMonster monster = new FightingMonster();
            monster.Name = enemy.Name;
            monster.Type = enemy.Type;
            monster.Lvl = r.Next(player.Lvl / 2, player.Lvl) + 1;
            monster.HP = enemy.HP * monster.Lvl;
            monster.CurrentHP = monster.HP;
            monster.Damage = enemy.Damage * monster.Lvl;
            monster.Gold = enemy.Gold * monster.Lvl / 2 / 3;

            return monster;

        }

    }
}
