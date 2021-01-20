using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inlämningsuppgift_3
{
    class Init
    {
        public Init()
        {

        }

        public List<Monster> LoadMonsters()
        {
            List<Monster> listOfMonsters = new List<Monster>();

            listOfMonsters.Add(new Electric("Thunderbird", 11, 6, 1, Monster_Type.Electric, 13));
            listOfMonsters.Add(new Water("Octosquid", 15, 4, 1, Monster_Type.Water, 17));
            listOfMonsters.Add(new Fire("Canomantle", 13, 6, 1, Monster_Type.Fire, 16));
            listOfMonsters.Add(new Ice("Avalancherine", 14, 4, 1, Monster_Type.Ice, 14));

            return listOfMonsters;
        }

        public List<AmuletClass> LoadAmulets()
        {
            List<AmuletClass> listOfAmulettes = new List<AmuletClass>();
            listOfAmulettes.Add(new ElectricAmulet("Faradays amulet", Amulet.Electric, 10, 20));
            listOfAmulettes.Add(new WaterAmulet("Mermaid amulet", Amulet.Water, 10, 20));
            listOfAmulettes.Add(new FireAmulet("Starlight", Amulet.Fire, 10, 20));
            listOfAmulettes.Add(new IceAmulet("Aang amulet", Amulet.Ice, 10, 20));

            return listOfAmulettes;
        }
    }
}
