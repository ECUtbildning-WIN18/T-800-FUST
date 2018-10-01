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

            machines.Add(new Machine("T800", "T-800-001"));
            machines.Add(new Machine("T800", "T-800-002"));
            machines.Add(new Machine("T800", "T-800-003"));
            machines.Add(new Machine("T800", "T-800-004"));

            foreach (var machine in machines)
            {
                Console.WriteLine(machine);
            }
        }
    }
}
