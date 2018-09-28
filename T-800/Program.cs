using System;

namespace T_800
{
    class Program
    {
        static void Main(string[] args)
        {
            var t800 = new Machine("T800");

            t800.ActivateMachine(true);
            t800.DeactivateMachine(true);
        }
    }
}
