using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inlämningsuppgift_3
{
    class Player
    {
        private string name;
        private int hP;
        private int curretHP;
        private int damage;
        private int lvl;
        private int attack;
        private int defence;
        private int xP;
        private int gold;
        private int hPRecovery;
        public Player(string name)
        {
            this.name = name;
            lvl = 6;
            hP = 20 * lvl;
            curretHP = hP;
            damage = 10 * lvl;
            attack = 0;
            defence = 0;
            xP = 0;
            gold = 0;
            hPRecovery = 10;
        }

        public Player(string name, int hP, int damage, int lvl, int currentHP, int attack, int defence, int xP, int gold, int hPRecovery)
        {
            this.name = name;
            this.hP = hP * lvl;
            this.damage = damage * lvl;
            this.lvl = lvl;
            this.curretHP = this.hP;
            this.attack = attack;
            this.defence = defence;
            this.xP = xP;
            this.gold = gold;
            this.hPRecovery = hPRecovery;
        }

        public string Name { get => name; }
        public int HP { get => hP; }
        public int CurretHP { get => curretHP; set => curretHP = value; }
        public int Damage { get => damage; }
        public int Lvl { get => lvl; }        
        public int Attack { get => attack; set => attack = value; }
        public int Defence { get => defence; set => defence = value; }
        public int XP { get => xP; set => xP = value; }
        public int Gold { get => gold; set => gold = value; }
        public int Recovery { get => hPRecovery; set => hPRecovery = value; }

        public void ShowStats()
        {
            Console.WriteLine(Name);
            Console.WriteLine("Lvl " + Lvl.ToString());
            Console.WriteLine("Total HP " + HP.ToString());
            Console.WriteLine("Current HP " + CurretHP.ToString());
            Console.WriteLine("Damage " + Damage.ToString());
            Console.WriteLine("Attack " + Attack.ToString());
            Console.WriteLine("Defence " + defence.ToString());
            Console.WriteLine();
        }

        public void ShowStatsInMenu()
        {
            Console.WriteLine(Name);
            Console.WriteLine("Lvl " + Lvl.ToString());
            Console.WriteLine("Xp " + XP.ToString());
            Console.WriteLine("Gold " + Gold.ToString());
            Console.WriteLine("Total HP " + HP.ToString());
            Console.WriteLine("Current HP " + CurretHP.ToString());
            Console.WriteLine("Damage " + Damage.ToString());
            Console.WriteLine("Attack " + Attack.ToString());
            Console.WriteLine("Defence " + defence.ToString());
            Console.WriteLine();
        }
        public void UpdatePlayerStats(Monster enemy)
        {

        }
    }
}
