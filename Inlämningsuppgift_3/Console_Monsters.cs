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

        List<Monster> monsters;
        Monster enemy;

        Player player;
        public Console_Monsters()
        {
            Init init = new Init();
            monsters = init.LoadMonsters();
            running = true;
            Message(Texts.Welcome);
            Message(Texts.EnterName);
            player = new Player(Console.ReadLine());
            Thread.Sleep(500);

            init = null;
            Run();
        }

        private bool Battle()
        {
            enemy.CurretHP -= player.Damage + player.Attack;

            Message(Texts.YouHit + enemy.Name + " dealing " + (player.Damage + player.Attack).ToString() + " damage");
            if (enemy.CurretHP > 0)
            {
                Message(enemy.Name + Texts.ItHit + " dealing " + enemy.Damage.ToString() + " damage");

            }
            else
            {
                Message(Texts.ItDied);
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
                enemy = monsters[random.Next(0, monsters.Count)];
                Message(Texts.Encounter + enemy.Name + "\n");
                enemy.ShowStats();
                player.ShowStats();
                Message(Texts.BeginBattle);
                Message(Texts.AnyKey);
                Console.ReadKey();
                Console.Clear();
                while (batteling)
                {
                    player.UpdatePlayerStats(enemy);
                    batteling = Battle();
                    Console.ReadKey();
                }
            }
            else
            {
                Message(Texts.FoundNothing);
            }
        }

        private void Run()
        {
            while (running)
            {
                int choise;
                Message(Texts.StartMenu);
                try
                {
                    choise = Convert.ToInt32(Console.ReadLine());

                    switch (choise)
                    {
                        case 1:
                            Exploring();
                            break;
                        case 2:

                            break;
                        case 3:

                            break;
                        case 4:

                            break;
                        case 5:
                            running = false;
                            Message(Texts.Exit);
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

                Message(Texts.AnyKey);
                Console.ReadKey();
                Console.Clear();
            }
        }

        private void Message(string m)
        {
            Console.WriteLine(m);
        }
    }
}
