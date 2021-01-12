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
        public Console_Monsters()
        {
            running = true;
            Message(Texts.Welcome);
            Thread.Sleep(500);
            Run();
        }

        private void Exploring()
        {
            Console.Clear();
            Random random = new Random();
            if (random.Next(0, 10) > 8)
            {

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
            }
        }

        private void Message(string m)
        {
            Console.WriteLine(m);
        }
    }
}
