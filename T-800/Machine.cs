namespace T_800
{
    public class Machine
    {
        private string Name { get; set; }
        private bool activated = false;

        public Machine(string name)
        {
            Name = name;
        }
        
        public string ActivateMachine(bool activate)
        {
            if (activate = true)
            {
                activated = true;
                return Name + " has been activated!";
            }
            return "something when wrong while trying to activate";
        }
        
        public string DeactivateMachine(bool deactivate)
        {
            if (deactivate = true)
            {
                activated = false;
                return Name + " has been put into maintenance mode";
            }
            return "something when wrong while trying to deactivate";
        }
    }
}