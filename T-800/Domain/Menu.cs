using System;
using System.Collections.Generic;
using System.Text;
using T_800.Domain;

namespace T_800
{
    class Menu
    {
        public void PrintMenu()
        {
            bool menu = true;
            while (menu)
            {
                Console.Clear();
                Console.WriteLine("\t=====Welcome to Slynet 1.7=====");
                Console.WriteLine("\n\tPlease choose your option below.");
                Console.WriteLine("\t[1]Select Terminator");
                Console.WriteLine("\t[2]Selfdestruct Terminators");
                Console.WriteLine("\t[3]Set Mission");
                Console.WriteLine("\t[4]Quit");

                string menuChoice = Console.ReadLine();

                switch (menuChoice)
                {
                    case "1":
                        {
                            var machines = new MachineList();
                            Console.WriteLine("\tPlease select Terminator");
                            machines.ListMachine();
                            Console.WriteLine("\n\tActivate Terminator: ");
                            string select = Console.ReadLine();

                            if (select == "1")
                            {
                                var machineMenu = new MachineMenu();
                                machineMenu.Menu(1);
                            }
                            if (select == "2")
                            {
                                var machineMenu = new MachineMenu();
                                machineMenu.Menu(2);
                            }
                            if (select == "3")
                            {
                                var machineMenu = new MachineMenu();
                                machineMenu.Menu(3);
                            }
                            if (select == "4")
                            {
                                var machineMenu = new MachineMenu();
                                machineMenu.Menu(4);
                            }
                            Console.Clear();
                            break;
                        }
                    case "2":
                        {
                            Console.Clear();
                            break;
                        }
                    case "3":
                        {
                           
                            Console.Clear();
                            break;
                        }
                    case "4":
                        {
                            Console.Clear();
                            Console.Write("\tDo you want to quit? Y/N: ");
                            string quit = Console.ReadLine();
                            if (quit == "Y" || quit == "y")
                            {
                                menu = false;
                            }
                            else
                            {
                            }
                            break;
                        }
                    default:
                        Console.WriteLine("\tChoose a number between 1-4");
                        break;
                }
            }
        }
    }

}
