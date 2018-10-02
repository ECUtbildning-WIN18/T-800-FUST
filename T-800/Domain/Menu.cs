using System;
using T_800.Domain;

namespace T_800
{
    class Menu
    {
        public static void PrintMenu()
        {
            var machines = new MachineList();

            bool menu = true;
            while (menu)
            {
                Console.Clear();
                Console.WriteLine("\t=====Welcome to Slynet 1.7=====");
                Console.WriteLine("\n\tPlease choose your option below.");
                Console.WriteLine("\t[1]Select Terminator");
                Console.WriteLine("\t[2]Self-destruct Terminators");
                Console.WriteLine("\t[3]Set Mission");
                Console.WriteLine("\t[4]Quit");

                string menuChoice = Console.ReadLine();

                switch (menuChoice)
                {
                    case "1":
                        {
                            Console.Clear();
                            Console.WriteLine("\tPlease select Terminator");
                            machines.ListMachine();
                            Console.WriteLine("\n\tActivate Terminator: ");
                            string select = Console.ReadLine();

                            if (select == "1")
                            {
                                MachineMenu.Menu(1, machines);
                            }
                            if (select == "2")
                            {
                                MachineMenu.Menu(2, machines);
                            }
                            if (select == "3")
                            {
                                MachineMenu.Menu(3, machines);
                            }
                            if (select == "4")
                            {
                                MachineMenu.Menu(4, machines);
                            }
                            Console.Clear();
                            break;
                        }
                    case "2":
                        {
                            Console.Clear();
                            Console.WriteLine("\tPlease select Terminator");
                            machines.ListMachine();
                            string select = Console.ReadLine();

                            if (select == "1")
                            {
                                machines.RemoveMachine(0);
                            }
                            if (select == "2")
                            {
                                MachineMenu.Menu(2, machines);
                            }
                            if (select == "3")
                            {
                                MachineMenu.Menu(3, machines);
                            }
                            if (select == "4")
                            {
                                MachineMenu.Menu(4, machines);
                            }
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
