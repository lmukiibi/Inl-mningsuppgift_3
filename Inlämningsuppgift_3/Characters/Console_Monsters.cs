using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;


namespace Inlämningsuppgift_3
{
    class Console_Monsters
    {
        private bool running;

        List<Monster> listOfMonsters;
        Monster randomMonster;
        FightingMonster monster;

        List<AmuletClass> listOfAmulettes;

        Player player;
        public Console_Monsters()
        {
            Init init = new Init();
            listOfMonsters = init.LoadMonsters();
            listOfAmulettes = init.LoadAmulets();
            randomMonster = new Monster();
            monster = new FightingMonster();
            running = true;
            Message(Texts.Welcome);
            Message(Texts.EnterName);
            player = new Player(Console.ReadLine());
            Thread.Sleep(500);

            init = null;
        }

        private bool Battle()
        {
            Console.Clear();
            monster.CurrentHP -= player.CurrentDmg + player.Attack;

            Message(Texts.YouHit + monster.Name + " dealing " + (player.CurrentDmg + player.Attack) + " damage");
            if (monster.CurrentHP > 0)
            {
                player.CurretHP -= monster.Damage - player.Defence;
                Message(monster.Name + Texts.ItHit + " dealing " + (monster.Damage - player.Defence) + " damage\n");
                if (player.CurretHP > 0)
                {
                    ShowStats(monster);
                    ShowStats(player);
                }
                else
                {
                    Message(Texts.YouDied);
                    return false;
                }
            }
            else
            {
                Message(Texts.ItDied + "\n");

                player.XP += monster.XP;
                Message(monster.XP + Texts.Experience);

                LevelUp(player, player);


                if (player.CurretHP < player.HP)
                {
                    player.CurretHP += player.Recovery;
                    Message(player.Recovery.ToString() + Texts.Recovery);
                    if (player.CurretHP > player.HP)
                    {
                        player.CurretHP = player.HP;
                    }
                }
                
                player.Gold += monster.Gold;
                Message(monster.Gold + Texts.GoldGained);

                


                return false;
            }
            return true;
        }

        

        private void Exploring()
        {
            Console.Clear();
            Random random = new Random();
            bool batteling = true;

            if (random.Next(0, 10) > 0)
            {
                monster = randomMonster.SetValues(listOfMonsters[random.Next(0, listOfMonsters.Count)], player);
                SetUpForBattle(player, monster);

                Message(Texts.Encounter + monster.Name + "\n");
                monster.ShowStats();
                player.ShowStats();
                Message(Texts.BeginBattle);
                Message(Texts.AnyKey);
                Console.ReadKey();
                Console.Clear();

                while (batteling)
                {
                    batteling = Battle();
                    Console.ReadKey();
                }
            }
            else
            {
                Message(Texts.FoundNothing);
                if (player.CurretHP < player.HP)
                {
                    player.CurretHP += player.Recovery;
                    Message(player.Recovery.ToString() + Texts.Recovery);
                    if (player.CurretHP > player.HP)
                    {
                        player.CurretHP = player.HP;
                    }
                }
                Console.ReadKey();
            }


        }

        private void ShowTheInfo(List<AmuletClass> items)
        {
            int count = 1;
            Console.Clear();
            foreach (IAmulet item in items)
            {
                Console.Write(count + ". ");
                item.ShowInfo();
                count++;
            }
            Message(Texts.ChooseItem);
            try
            {
                int choise = int.Parse(Console.ReadLine());
                if (choise > 0 && choise < items.Count + 1)
                {
                    player.BuyAmulet(listOfAmulettes[choise - 1].Amulet);
                }
            }
            catch (Exception e)
            { }

        }

        private void ShopMenu()
        {
            bool shopping = true;
            while (shopping)
            {
                Console.Clear();
                Message(Texts.AmuletOrPotion);
                string choise = Console.ReadLine();
                switch (choise)
                {
                    case "1":
                        ShowTheInfo(listOfAmulettes);
                        break;
                    case "2":

                        break;
                    case "B":
                        shopping = false;
                        break;
                    case "b":
                        shopping = false;
                        break;
                    default:

                        break;
                }
            }
        }

        public void Run()
        {
            while (running)
            {
                string choise;
                Message(Texts.StartMenu);
                try
                {
                    choise = Console.ReadLine();

                    switch (choise)
                    {
                        case "1":
                            Exploring();
                            break;
                        case "2":
                            ShowPlayerStats(player);
                            Console.ReadKey();
                            break;
                        case "3":
                            ShopMenu();
                            break;
                        case "4":

                            break;
                        case "5":
                            running = false;
                            Message(Texts.Exit);
                            break;
                        case "":
                            Exploring();
                            break;
                        default:
                            Message(Texts.WrongInput);
                            break;
                    }
                }
                catch (Exception e)
                {
                    Message(Texts.WrongInput);
                }

                PlayerAlive();

                //Message(Texts.AnyKey);
                //Console.ReadKey();
                Console.Clear();
            }
        }
        private void SetUpForBattle(IPlayerface setting, FightingMonster enemy)
        {
            setting.ChangePlayerAttributes(enemy);
        }

        private void ShowStats(IShowable show)
        {
            show.ShowStats();
        }

        private void ShowPlayerStats(IPlayerface show)
        {
            show.ShowStatsInMenu();
        }

        private void LevelUp(IPlayerface lvl, Player player)
        {
            if (lvl.LevelUp())
            {
                Message(Texts.LevelUp + player.Lvl);
            }
        }
        private void PlayerAlive()
        {
            if (player.CurretHP <= 0)
            {
                //running = false;
                Message(Texts.GameOver);
                Console.ReadKey();
                player = new Player(player.Name);
            }
        }

        private void Message(string m)
        {
            Console.WriteLine(m);
        }
    }
}
