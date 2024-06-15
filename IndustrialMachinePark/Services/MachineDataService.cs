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

        public async Task<Machine> GetMachineDetails(Guid id)
        {
            return await _machineRepository.GetMachineById(id);
        }
        public async Task <Machine> AddMachine (Machine machine)
        {
            return await _machineRepository.AddMachine(machine);
        }

        public async Task UpdateMachine(Machine machine)
        {
            await _machineRepository.UpdateMachine(machine);
        }

        public async Task DeleteMachine(Guid Id)
        {
            await _machineRepository.DeleteMachine(Id);
        }
    }
}
