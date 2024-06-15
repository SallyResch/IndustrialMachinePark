using IndustrialMachinePark.Models;
using Microsoft.AspNetCore.Components;

namespace IndustrialMachinePark.Components.Pages
{
    public partial class AddMachine
    {
        [SupplyParameterFromForm]
        public Machine Machine { get; set; }
    }
}
