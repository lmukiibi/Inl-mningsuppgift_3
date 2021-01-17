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

        Player player;
        public Console_Monsters()
        {
            Init init = new Init();
            listOfMonsters = init.LoadMonsters();
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
            monster.CurrentHP -= player.Damage + player.Attack;

            Message(Texts.YouHit + monster.Name + " dealing " + (player.Damage + player.Attack).ToString() + " damage");
            if (monster.CurrentHP > 0)
            {
                player.CurretHP -= monster.Damage;
                Message(monster.Name + Texts.ItHit + " dealing " + monster.Damage.ToString() + " damage\n");
                if (player.CurretHP > 0)
                {
                    monster.ShowStats();
                    player.ShowStats();
                }
                else
                {
                    Message(Texts.YouDied);
                    running = false;
                    return false;
                }
            }
            else
            {
                Message(Texts.ItDied);
                player.CurretHP += player.Recovery;
                if (player.CurretHP > player.HP)
                {
                    player.CurretHP = player.HP;
                }
                Message(player.Recovery.ToString() + Texts.Recovery);
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
                randomMonster = listOfMonsters[random.Next(0, listOfMonsters.Count)];
                monster = randomMonster.SetValues(randomMonster, player);

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
            }
        }

        public void Run()
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

                PlayerAlive();

                Message(Texts.AnyKey);
                Console.ReadKey();
                Console.Clear();
            }
        }

        private void PlayerAlive()
        {
            if (player.CurretHP <= 0)
            {
                running = false;
                Message(Texts.GameOver);
            }
        }

        private void Message(string m)
        {
            Console.WriteLine(m);
        }
    }
}
