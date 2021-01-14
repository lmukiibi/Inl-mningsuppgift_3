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
        public Player(string name)
        {
            this.name = name;
            hP = 50;
            curretHP = hP;
            damage = 10;
            lvl = 6;
            attack = 0;
            defence = 0;
            xP = 0;
        }

        public Player(string name, int hP, int damage, int lvl, int currentHP, int attack, int defence, int xP)
        {
            this.name = name;
            this.hP = hP;
            this.damage = damage;
            this.lvl = lvl;
            this.curretHP = hP;
            this.attack = attack;
            this.defence = defence;
            this.xP = xP;
        }

        public string Name { get => name; }
        public int HP { get => hP * Lvl; }
        public int CurretHP { get => curretHP * Lvl; set => curretHP = value; }
        public int Damage { get => damage * Lvl; }
        public int Lvl { get => lvl; }        
        public int Attack { get => attack; set => attack = value; }
        public int Defence { get => defence; set => defence = value; }
        public int XP { get => xP; set => xP = value; }

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
        public void UpdatePlayerStats(Monster enemy)
        {

        }
    }
}
