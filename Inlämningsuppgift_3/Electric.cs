using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inlämningsuppgift_3
{
    class Electric : Monster
    {
        public Electric(string name, int hP, int damage, int lvl, Monster_Type type)
        {
            this.name = name;
            this.hP = hP;
            this.damage = damage;
            this.lvl = lvl;
            this.type = type;
            CurretHP = HP;
        }
    }
}
