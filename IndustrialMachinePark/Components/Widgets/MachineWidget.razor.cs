using IndustrialMachinePark.State;
using Microsoft.AspNetCore.Components;

namespace IndustrialMachinePark.Components.Widgets
{
    public partial class MachineWidget
    {
        [Inject]
        public ApplicationState ApplicationState { get; set; }

        public int MachineCount { get; set; } = 0;

        protected override void OnInitialized()
        {
            MachineCount = ApplicationState.NumberOfMachinesOnline;
        }
    }
}
