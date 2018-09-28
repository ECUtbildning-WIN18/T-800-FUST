using System;
using System.Collections.Generic;

namespace T_800
{
    public class Machine
    {
        public string Name { get; set; }
        public bool Activated { get; set; }
        
        public Machine(string name)
        {
            Name = name;
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
        
        public void DeactivateMachine(bool deactivate)
        {

            if (deactivate)
            {
                Activated = false;
                Console.WriteLine(Name + " has been put into maintenance mode");
            }
            else
            {
                Console.WriteLine( "something went wrong while trying to deactivate");
            }
        }
    }
}