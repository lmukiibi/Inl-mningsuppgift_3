using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inlämningsuppgift_3
{
    enum Monster_Type
    {
        Regular,
        Electric,
        Fire,
        Ice,
        Psychic
    }
    class Monster
    {
        private protected string name;
        private protected int hP;
        private protected int curretHP;
        private protected int damage;
        private protected int lvl;
        private protected Monster_Type type;


        

        public string Name { get => name; }
        public int HP { get => hP * Lvl; }
        public  int CurretHP { get => curretHP; set => curretHP = value; }
        public int Damage { get => damage * Lvl; }
        public int Lvl { get => lvl; }
        public Monster_Type Type { get => type; }

        public void ShowStats()
        {
            Console.WriteLine(Name);
            Console.WriteLine("Lvl " + Lvl.ToString());
            Console.WriteLine("HP " + HP.ToString());
            Console.WriteLine("Damage " + Damage.ToString());
            Console.WriteLine("Type " + type.ToString());
            Console.WriteLine();
        }

    }
}
