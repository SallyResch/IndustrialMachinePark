using IndustrialMachinePark.Models;
namespace IndustrialMachinePark.Contracts.Repositories
{
    public interface IMachineRepository
    {
        Task<IEnumerable<Machine>> GetAllMachines();
        Task<Machine> GetMachineById(Guid Id);
        Task<Machine> AddMachine (Machine machine);
        Task<Machine> UpdateMachine (Machine machine);
        Task DeleteMachine (int Id);
    }
}
