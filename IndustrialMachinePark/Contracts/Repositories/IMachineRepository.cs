using IndustrialMachinePark.Models;
namespace IndustrialMachinePark.Contracts.Repositories
{
    public interface IMachineRepository
    {
        Task<IEnumerable<Machine>> GetAllMachines();
        Task<Machine> GetMachineByName(string name);
    }
}
