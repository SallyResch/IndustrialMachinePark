using IndustrialMachinePark.Contracts.Services;
using IndustrialMachinePark.Models;
using Microsoft.AspNetCore.Components;

namespace IndustrialMachinePark.Components.Pages
{
    public partial class AddMachine
    {
        [SupplyParameterFromForm]
        private Machine Machine {  get; set; }
        [Inject]
        public IMachineDataService MachineDataService { get; set; }

        protected override void OnInitialized()
        {
            Machine = new Machine();
        }

        private async Task OnSubmit()
        {

        }
    }
}
