using System;
using System.Collections.Generic;
using System.Text;

namespace T_800.Domain
{
    class MachineList
    {
        public void ListMachine()
        {
            List<Machine> machines = new List<Machine>();

            machines.Add(new Machine("Arnuld", "T-800-001"));
            machines.Add(new Machine("Lasse", "T-800-002"));
            machines.Add(new Machine("Bosse", "T-800-003"));
            machines.Add(new Machine("Torbjörn", "T-800-004"));

            for (int i = 0; i < machines.Count; i++)
            {
                Console.WriteLine($"[{i+1}]{machines[i].Name} {machines[i].SerialNumber} Activated: {machines[i].Activated}");
            }
        }
    }
}
