using System.Collections.Generic;

namespace RazorTemplatEngine.Models
{
    public sealed class JobStart
    {
        public bool Critical { get; set; }
        public string Title { get; set; }
        public string EnterpriseSystem { get; }
        public string Application { get; }
        public IEnumerable<VirtualMachine> VirtualMachines { get; set; }

        public JobStart(bool critical, string title, string enterpriseSystem, string application, IEnumerable<VirtualMachine> virtualMachines)
        {
            Critical = critical;
            Title = title;
            EnterpriseSystem = enterpriseSystem;
            Application = application;
            VirtualMachines = virtualMachines;
        }
    }

    public sealed class VirtualMachine
    {
        public string Name { get; }
        public double Cpu { get; }
        public double Memory { get; }

        public VirtualMachine(string name, double cpu, double memory)
        {
            Name = name;
            Cpu = cpu;
            Memory = memory;
        }
    }
}
