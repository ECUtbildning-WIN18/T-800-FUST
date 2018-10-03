using System;
using System.Collections.Generic;
using System.Text;

namespace T_800.Domain
{
    class MachineMenu
    {
        public static void Menu(int selected, MachineList machineList)
        {
            // var machineList = new MachineList();
            Machine selectedMachine = machineList.machines[selected - 1];
            bool menu = true;
            while (menu)
            {
                Console.Clear();
                Console.WriteLine("Welcome to robot: " + selectedMachine.Name + ". Serial Number: " + selectedMachine.SerialNumber);//Lägg till namn från Machine listan
                Console.WriteLine("\t[1]Select your mission");
                Console.WriteLine("\t[2]Self-destruct");
                Console.WriteLine("\t[3]Exit Machine");
                string menuChoice = Console.ReadLine();

                switch (menuChoice)
                {
                    case "1":
                        {
                            bool missionMenu = true;
                            while (missionMenu)
                                
                            if (!selectedMachine.Activated)
                            {
                                Console.Clear();
                                Console.WriteLine($"{selectedMachine.Name} is not activated");
                                Console.WriteLine($"Do you wish to activate it? (y = yes) (n = no)");
                                string choice = Console.ReadLine().ToLower();
                                if (choice == "y")
                                {
                                    selectedMachine.ActivateMachine(true);
                                    break;
                                }
                                else
                                {
                                    break;
                                }
                            }
                            else
                            {
                                
                                {
                                    Console.Clear();
                                    Console.WriteLine("\tSelect Mission");
                                    Console.WriteLine("\t[1]Eliminate target");
                                    Console.WriteLine("\t[2]Save target");
                                    Console.WriteLine("\t[3]Make Coffee");
                                    Console.WriteLine("\t[4]Quit");
                                    string missionSelect = Console.ReadLine();
                                    switch (missionSelect)
                                    {
                                        case "1":
                                        {
                                            Console.Clear();
                                            Console.WriteLine("\tSelect your target:");
                                            Console.WriteLine("\t[1]Sarah Connor.");
                                            Console.WriteLine("\t[2]John Connor.");
                                            Console.WriteLine("\t[3]Innocent civilian.");
                                            string target = Console.ReadLine();
                                            Console.Clear();
                                            if (target == "1")
                                            {
                                                Console.WriteLine("Target aquired, advancing on Sarah Connor.");
                                                Console.ReadKey();
                                                break;
                                            }
                                            Console.Clear();
                                            if (target == "2")
                                            {
                                                Console.WriteLine("Target aquired, advancing on John Connor.");
                                                Console.ReadKey();
                                                break;
                                            }
                                            Console.Clear();
                                            if (target == "3")
                                            {
                                                Console.WriteLine("Harming innocent civilians is prohibited.");
                                                Console.ReadKey();
                                            }
                                            else
                                            {
                                                Console.WriteLine("Please select targets 1-3.");
                                            }

                                            break;
                                        }
                                        case "2":
                                        {
                                            Console.Clear();
                                            Console.WriteLine("\tWho do you want to save?:");
                                            Console.WriteLine("\t[1]Sarah Connor.");
                                            Console.WriteLine("\t[2]John Connor.");
                                            Console.WriteLine("\t[3]Lasse på ica.");
                                            string save = Console.ReadLine();
                                            Console.Clear();
                                            if (save == "1")
                                            {
                                                Console.WriteLine("Target aquired, attempting to save Sarah Connor.");
                                                Console.ReadKey();
                                                break;
                                            }
                                            Console.Clear();
                                            if (save == "2")
                                            {
                                                Console.WriteLine("Target aquired, attempting to save John Connor.");
                                                Console.ReadKey();
                                                break;
                                            }
                                            Console.Clear();
                                            if (save == "3")
                                            {
                                                Console.WriteLine("Attempting to save Lasse.");
                                                Console.ReadKey();
                                                
                                            }
                                            else
                                            {
                                                Console.WriteLine("Please select targets 1-3.");
                                            }
                                            break;
                                        }
                                        case "3":
                                        {
                                            Console.Clear();
                                            Console.WriteLine("\tHow do you want your coffee?:");
                                            Console.WriteLine("\t[1]Regular Coffee");
                                            Console.WriteLine("\t[2]Coffee with sugar");
                                            Console.WriteLine("\t[3]Coffee with milk");
                                            Console.WriteLine("\t[4]Coffee with sugar and milk");
                                            string save = Console.ReadLine();

                                            if (save == "1")
                                            {
                                                Console.Clear();
                                                Console.WriteLine("Regular Coffee coming up!");
                                                Console.ReadKey();
                                                break;
                                            }

                                            if (save == "2")
                                            {
                                                Console.Clear();
                                                Console.WriteLine("Coffee with sugar coming up!");
                                                Console.ReadKey();
                                                break;
                                            }

                                            if (save == "3")
                                            {
                                                Console.Clear();
                                                Console.WriteLine("Coffee with milk coming up!");
                                                Console.ReadKey();
                                                break;
                                            }

                                            if (save == "4")
                                            {
                                                Console.Clear();
                                                Console.WriteLine("Coffee with milk and sugar coming up!");
                                                Console.ReadKey();
                                            }
                                            else
                                            {
                                                Console.WriteLine("Please select targets 1-4");
                                                Console.ReadKey();
                                            }

                                            break;
                                        }
                                        case "4":
                                        {

                                            Console.Clear();
                                            missionMenu = false;
                                            break;
                                        }
                                    }
                                }
                            }
                            break;
                        }
                    case "2":
                        {                           
                            Console.Clear();                            
                            Console.WriteLine("Are you sure? Y/N");
                            string userInput = Console.ReadLine();

                            if (userInput == "Y" || userInput == "y")
                            {
                                machineList.machines.RemoveAt(selected - 1);
                            }                           
                            Console.Clear();
                            menu = false;
                            break;                            
                        }
                    case "3":
                        {
                            Console.Clear();
                            Console.WriteLine("Do you want to return to Main menu? Y/N: ");
                            string exit = Console.ReadLine();
                            if (exit == "Y" || exit == "y")
                            {
                                Console.WriteLine("Goodbye");
                                menu = false;
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
