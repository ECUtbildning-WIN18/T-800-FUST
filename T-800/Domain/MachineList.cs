using System;
using System.Collections.Generic;
using System.Text;

namespace T_800.Domain
{
    class MachineList
    {
        public List<Machine> machines = new List<Machine>
        {
            new Machine("Arnuld", "T-800-001"),
            new Machine("Lasse", "T-800-002"),
            new Machine("Bosse", "T-800-003"),
            new Machine("Torbjörn", "T-800-004")
        };

        public void ListMachine()
        {
            for (int i = 0; i < machines.Count; i++)
            {
                Console.WriteLine($"[{i+1}]{machines[i].Name} {machines[i].SerialNumber} Activated: {machines[i].Activated}");
            }
        }
    }
}
