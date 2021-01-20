using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inlämningsuppgift_3
{
    class ElectricAmulet : AmuletClass, IAmulet
    {

        public ElectricAmulet(string name, Amulet amulet, int points, int cost)
        {
            this.Name = name;
            this.Amulet = amulet;
            this.Points = points;
            this.Cost = cost;
        }

        public void ShowInfo()
        {
            Console.WriteLine(Name);
            Console.WriteLine("Type: " + this.Amulet + " potion.");
            Console.WriteLine("Reduces the loss of your damage by " + Points + " points");
            Console.WriteLine(Cost + " gold");
            Console.WriteLine();
        }

    }
}
