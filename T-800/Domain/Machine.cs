using System;
using System.Collections.Generic;

namespace T_800
{
    public class Machine
    {
        public string Name { get; set; }
        
        public Machine(string name)
        {
            Name = name;
        }
        
        public void ActivateMachine(bool activate)
        {
            if (activate)
            {
                activated = true;
                Console.WriteLine(Name + " has been activated!");
            }
            else
            {
                Console.WriteLine( "something when wrong while trying to activate");
            }
        }
        
        public void DeactivateMachine(bool deactivate)
        {
            if (deactivate)
            {
                activated = false;
                Console.WriteLine(Name + " has been put into maintenance mode");
            }
            else
            {
                Console.WriteLine( "something when wrong while trying to deactivate");
            }
        }

        private void AcquireTargets()
        {
            
        }
        
        private bool activated = false;
    }
}