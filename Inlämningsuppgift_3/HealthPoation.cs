using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inlämningsuppgift_3
{
    class HealthPoation : PotionClass, IShopitems
    {
        public Potion_Type Potion { get; set; }

        public HealthPoation(string name, Potion_Type potion, int points)
        {
            this.Name = name;
            this.Potion = potion;
            this.Points = points;
        }

        public void ShowInfo()
        {
            Console.WriteLine(Name);
            Console.WriteLine(this.Potion + " amulet.");
            Console.WriteLine(Points);

        }
    }
}
