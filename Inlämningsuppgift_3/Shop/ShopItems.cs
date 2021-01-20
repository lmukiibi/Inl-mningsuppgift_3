using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inlämningsuppgift_3
{
    enum Amulet
    {
        Water,
        Fire,
        Ice,
        Electric
    }

    enum Potion_Type
    {
        AttackPotion,
        DefencePotion,
        RegainStrength,
        RegainHealth
    }

    abstract class ShopItem
    {
        protected string Name { get; set; }
        protected int Points { get; set; }
        protected int Cost { get; set; }
    }

}
