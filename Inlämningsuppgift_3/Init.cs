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
            listOfMonsters.Add(new Electric("Thunder Bird", 10, 1, 1, Monster_Type.Electric));
            return listOfMonsters;
        }
    }
}
