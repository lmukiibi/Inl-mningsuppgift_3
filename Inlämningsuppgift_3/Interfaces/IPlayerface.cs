using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inlämningsuppgift_3
{
    interface IPlayerface
    {
        void ShowStatsInMenu();
        bool LevelUp();
        void UpdateAttHp();

        void ChangePlayerAttributes(FightingMonster enemy);

    }
}
