using System;
using System.Collections.Generic;
using T_800.Domain;

namespace T_800
{
    public class Machine
    {
        public string Name { get; set; }
        public string SerialNumber { get; set; }
        public bool Activated { get; set; }
        private MachineMenu Menu = new MachineMenu();
        
        public Machine(string name, string serialNumber)
        {
            Name = name;
            SerialNumber = serialNumber;
            Activated = false;
        }
        
        public void ActivateMachine(bool activate)
        {
            if (activate)
            {
                Activated = true;
                Console.WriteLine(Name + " has been activated!");
            }
            else
            {
                Console.WriteLine( "something went wrong while trying to activate");
            }
        }
    }
}