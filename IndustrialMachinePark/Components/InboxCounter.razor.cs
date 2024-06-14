using IndustrialMachinePark.State;
using Microsoft.AspNetCore.Components;

namespace IndustrialMachinePark.Components
{
    public partial class InboxCounter
    {
        [Inject]
        public ApplicationState ApplicationState { get; set; }

        private int MachineCount;
        protected override void OnInitialized()
        {
            MachineCount = new Random().Next(10);
            ApplicationState.NumberOfMachinesOnline = MachineCount;
        }
    }
}
