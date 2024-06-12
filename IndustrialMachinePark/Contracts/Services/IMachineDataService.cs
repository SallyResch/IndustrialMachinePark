using IndustrialMachinePark.Models;

namespace IndustrialMachinePark.Contracts.Services
{
    public interface IMachineDataService
    {
        Task<IEnumerable<Machine>> GetAllMachines();
        Task<Machine> GetMachineDetails (string name);
    }
}
