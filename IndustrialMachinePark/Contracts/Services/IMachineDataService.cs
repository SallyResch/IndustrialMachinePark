using IndustrialMachinePark.Models;

namespace IndustrialMachinePark.Contracts.Services
{
    public interface IMachineDataService
    {
        Task<IEnumerable<Machine>> GetAllMachines();
        Task<Machine> GetMachineDetails (Guid Id);
        Task<Machine> AddMachine (Machine machine);
        Task<Machine> UpdateMachine (Machine machine);
        Task<Machine> DeleteMachine (Guid Id);


        
    }
}
