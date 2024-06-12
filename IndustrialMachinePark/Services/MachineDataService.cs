using IndustrialMachinePark.Contracts.Repositories;
using IndustrialMachinePark.Contracts.Services;
using IndustrialMachinePark.Models;

namespace IndustrialMachinePark.Services
{
    public class MachineDataService : IMachineDataService
    {
        private readonly IMachineRepository _machineRepository;

        public MachineDataService(IMachineRepository machineRepository)
        {
            _machineRepository = machineRepository;
        }

        public async Task<IEnumerable<Machine>> GetAllMachines()
        {
            return await _machineRepository.GetAllMachines();
        }

        public async Task<Machine> GetMachineDetails(string name)
        {
            return await _machineRepository.GetMachineByName(name);
        }
    }
}
