using System;
using System.Collections.Generic;
using System.Text;

namespace T_800.Domain
{
    class MachineMenu : Machine
    {
        public MachineMenu(string name) : base(name)
        {

        }

        public void RobotMenu()
        {
            bool menu = true;
            while (menu)
            {
                Console.WriteLine("Welcome to robot" + " " + "**Lägg till namn här**");//Lägg till namn från Machine listan
                Console.WriteLine("\n[1]");
                Console.WriteLine("[2]");
                Console.WriteLine("[3]Exit Machine");

                string menuChoice = Console.ReadLine();

                switch (menuChoice)
                {
                    case "1":
                        {
                            break;
                        }
                    case "2":
                        {
                            break;
                        }
                    case "3":
                        {
                            Console.WriteLine("Do you want to return to Main menu? Y/N: ");
                            string exit = Console.ReadLine();
                            if (exit == "Y" || exit == "y")
                            {
                                Console.WriteLine("Goodbye");
                                break;
                            }
                            break;
                        }
                    default:
                        break;
                }
            }
        }
    }
}
