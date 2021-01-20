using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inlämningsuppgift_3
{
    class Player : IShowable, IPlayerface
    {
        private string name;
        private int hP;
        private int curretHP;
        private int damage;
        private int currentDmg;
        private int lvl;
        private int attack;
        private int defence;
        private int xP;
        private int gold;
        private int hPRecovery;

        Dictionary<int, bool> amPocket;
        public Player(string name)
        {
            this.name = name;
            lvl = 1;
            hP = 20 * lvl;
            curretHP = hP;
            damage = 10 * lvl;
            currentDmg = damage;
            attack = 0;
            defence = 0;
            xP = 0;
            gold = 0;
            hPRecovery = 10;

            amPocket = new Dictionary<int, bool>();
            for (int i = 0; i < 4; i++)
            {
                amPocket.Add(i, false);
            }
                    
        }

        public Player(string name, int hP, int damage, int lvl, int currentHP, int attack, int defence, int xP, int gold, int hPRecovery)
        {
            this.name = name;
            this.lvl = lvl;
            this.hP = hP * lvl;
            this.damage = damage * lvl;
            this.curretHP = this.hP;
            this.currentDmg = damage;
            this.attack = attack;
            this.defence = defence;
            this.xP = xP;
            this.gold = gold;
            this.hPRecovery = hPRecovery;
        }

        public string Name { get => name; }
        public int HP { get => hP; set => hP = value; }
        public int CurretHP { get => curretHP; set => curretHP = value; }
        public int Damage { get => damage; }
        public int CurrentDmg { get => currentDmg; set => currentDmg = value; }
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
            Console.WriteLine("Maximum damage " + Damage.ToString());
            Console.WriteLine("Current damage " + CurrentDmg.ToString());
            Console.WriteLine("Attack " + Attack.ToString());
            Console.WriteLine("Defence " + defence.ToString());
            Console.WriteLine();
        }

        public void ShowStatsInMenu()
        {
            Console.Clear();
            Console.WriteLine("\n" + Name);
            Console.WriteLine("Lvl " + Lvl.ToString());
            Console.WriteLine("Xp " + XP.ToString());
            Console.WriteLine("Gold " + Gold.ToString());
            Console.WriteLine("Total HP " + HP.ToString());
            Console.WriteLine("Current HP " + CurretHP.ToString());
            Console.WriteLine("Maximum damage " + Damage.ToString());
            Console.WriteLine("Current damage " + CurrentDmg.ToString());
            Console.WriteLine("Attack " + Attack.ToString());
            Console.WriteLine("Defence " + defence.ToString());

            foreach (KeyValuePair<int, bool> list in amPocket)
            {
                Console.WriteLine($"{(Amulet)list.Key}amulet {list.Value}");
            }
            Console.WriteLine();
        }
        public void UpdatePlayerStats(Monster enemy)
        {

        }

        public void UpdateAttHp()
        {
            hP = 20 * lvl;
            damage = 10 * lvl;
        }

        public bool LevelUp()
        {
            int levStep = 5;
            int lev = 1;
            int x = XP;
            while (x >= 0)
            {
                if (x >= lev * levStep)
                {
                    lev++;
                    x -= (lev * levStep);
                    levStep *= 2;
                }
                else
                {
                    break;
                }
            }

            if (lev > lvl)
            {
                lvl = lev;
                UpdateAttHp();
                return true;
            }
            return false;
        }

        public void ChangePlayerAttributes(FightingMonster enemy, List<AmuletClass> list)
        {
            Random r = new Random();
            attack = 0;
            defence = 0;
            hPRecovery = 10;
            currentDmg = damage;

            switch (enemy.Type)
            {
                case Monster_Type.Electric:
                    currentDmg -= r.Next(enemy.Damage/2, enemy.Damage + 1);
                    break;
                case Monster_Type.Fire:
                    defence -= 5 * r.Next(enemy.Lvl / 2, enemy.Lvl) +1 ;
                    break;
                case Monster_Type.Water:
                    attack -= 5 * r.Next(enemy.Lvl / 2, enemy.Lvl) + 1;
                    break;
                case Monster_Type.Ice:
                    hPRecovery -= r.Next(5, 10);
                    break;
            }
            for (int i = 0; i < amPocket.Count; i++)
            {
                if (amPocket[i] == true)
                {
                    for (int j = 0; j < list.Count; j++)
                    {
                        if (list[j].Amulet == (Amulet)amPocket[i].)
                        {

                        }
                    }
                }
            }

        }

        public void BuyAmulet(Amulet amulet)
        {
            int am = (int)amulet;


            if (amPocket[am] == false)
            {
                amPocket[am] = true;
            }
            else
            {
                amPocket[am] = false;
            }
        }
    }
}
