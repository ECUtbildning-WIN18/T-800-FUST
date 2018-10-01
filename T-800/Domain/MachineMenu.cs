using System;
using System.Collections.Generic;
using System.Text;

namespace T_800.Domain
{
    class MachineMenu
    {
        public static void Menu(int selected)
        {
            var machineList = new MachineList();
            bool menu = true;
            while (menu)
            {
                Console.WriteLine("Welcome to robot" + " " + machineList.machines[selected-1].Name
                    );//Lägg till namn från Machine listan
                Console.WriteLine("\n[1]Select your mission");
                Console.WriteLine("[2]");
                Console.WriteLine("[3]Exit Machine");

                string menuChoice = Console.ReadLine();

                switch (menuChoice)
                {
                    case "1":
                        {
                            bool missionMenu = true;
                            while (missionMenu)

                            Console.WriteLine("\tSelect Mission");
                            Console.WriteLine("\t[1]Eliminate target");
                            Console.WriteLine("\t[2]Save target");
                            string missionSelect = Console.ReadLine();
                            switch (missionSelect)
                            {
                                case "1":
                                    {
                                        Console.WriteLine("\tSelect your target:");
                                        Console.WriteLine("\t[1]Sarah Connor");
                                        Console.WriteLine("\t[2]John Connor");
                                        Console.WriteLine("\t[3]Innocent civilian");
                                        string target = Console.ReadLine();
                                        if (target == "1")
                                        {
                                            Console.WriteLine("Target aquired, advancing on Sarah Connor.");
                                        }
                                        if (target == "2")
                                        {
                                            Console.WriteLine("Target aquired, advancing on John Connor.");
                                        }
                                        if (target == "3")
                                        {
                                            Console.WriteLine("Harming innocent civilians is prohibited.");
                                        }
                                        else
                                        {
                                            Console.WriteLine("Please select targets 1-3");
                                            break;
                                        }
                                        break;
                                    }
                                case "2":
                                    {
                                        Console.WriteLine("\tWho do you want to save?:");
                                        Console.WriteLine("\t[1]Sarah Connor");
                                        Console.WriteLine("\t[2]John Connor");
                                        Console.WriteLine("\t[3]Snubben på ica");
                                        string save = Console.ReadLine();
                                        if (save == "1")
                                        {
                                            Console.WriteLine("Target aquired, attempting to save Sarah Connor");
                                        }
                                        if (save == "2")
                                        {
                                            Console.WriteLine("Target aquired, attempting to save John Connor");
                                        }
                                        if (save == "3")
                                        {
                                            Console.WriteLine("Attempting to save the innocent civilian");
                                        }
                                        else
                                        {
                                            Console.WriteLine("Please select targets 1-3");
                                            break;
                                        }
                                        break;
                                    }
                                default:
                                    break;
                            }
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
                                menu = false;
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
