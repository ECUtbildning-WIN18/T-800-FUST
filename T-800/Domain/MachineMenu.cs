using System;
using System.Collections.Generic;
using System.Text;

namespace T_800.Domain
{
    class MachineMenu
    {
        public void Menu(int selected)
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
                            Console.WriteLine("\t[1]Kill!!!");
                            Console.WriteLine("\t[2]Save Target");
                            Console.WriteLine("\t[3]Quit");
                            string missionSelect = Console.ReadLine();
                            switch (missionSelect)
                            {
                                case "1":
                                    {
                                        Console.WriteLine("\tSelect your target:");
                                        Console.WriteLine("\t[1]Sarah Connor");
                                        Console.WriteLine("\t[2]Joahn Connor");
                                        Console.WriteLine("\t[3]Snubben på ica");
                                        string target = Console.ReadLine();
                                        if (target == "1")
                                        {
                                            Console.WriteLine("Sarah Connor is goning die!");
                                        }
                                        if (target == "2")
                                        {
                                            Console.WriteLine("John Connor is going to die!");
                                        }
                                        if (target == "3")
                                        {
                                            Console.WriteLine("Noo! not Snubben på ica, I like him");
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
                                        Console.WriteLine("\t[2]Joahn Connor");
                                        Console.WriteLine("\t[3]Snubben på ica");
                                        string save = Console.ReadLine();
                                        if (save == "1")
                                        {
                                            Console.WriteLine("Sarah Connor is goning die!");
                                        }
                                        if (save == "2")
                                        {
                                            Console.WriteLine("John Connor is going to die!");
                                        }
                                        if (save == "3")
                                        {
                                            Console.WriteLine("Noo! not Snubben på ica, I like him");
                                        }
                                        else
                                        {
                                            Console.WriteLine("Please select targets 1-3");
                                            break;
                                        }
                                        break;
                                    }
                                case "3":
                                    {
                                        missionMenu = false;
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
