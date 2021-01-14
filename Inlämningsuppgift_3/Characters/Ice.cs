using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inlämningsuppgift_3
{
    class Ice : Monster
    {
        public Ice(string name, int hP, int damage, int lvl, Monster_Type type, int gold)
        {
            this.name = name;
            this.hP = hP;
            this.damage = damage;
            this.lvl = lvl;
            this.type = type;
            CurrentHP = HP;
            this.gold = gold;
        }

        public void UpdateStats(Player player)
        {

        }
    }
}
