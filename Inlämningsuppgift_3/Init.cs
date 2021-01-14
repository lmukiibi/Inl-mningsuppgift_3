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
            listOfMonsters.Add(new Electric("Thunderbird", 11, 3, 1, Monster_Type.Electric, 13));
            listOfMonsters.Add(new Water("Octosquid", 15, 1, 1, Monster_Type.Water, 17));
            listOfMonsters.Add(new Fire("Canomantle", 13, 3, 1, Monster_Type.Fire, 16));
            listOfMonsters.Add(new Ice("Avalancherine", 14, 2, 1, Monster_Type.Ice, 14));
            return listOfMonsters;
        }
    }
}
