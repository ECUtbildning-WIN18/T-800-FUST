using System;
using System.Collections.Generic;
using System.Text;

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
                Console.WriteLine("\t[1]");
                Console.WriteLine("\t[2]");
                Console.WriteLine("\t[3]");
                Console.WriteLine("\t[4]Quit");

                string menuChoise = Console.ReadLine();

                switch (menuChoise)
                {
                    case "1":
                        {
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
