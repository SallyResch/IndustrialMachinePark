using IndustrialMachinePark.Contracts.Repositories;
using IndustrialMachinePark.Data;
using IndustrialMachinePark.Models;
using Microsoft.EntityFrameworkCore;

namespace IndustrialMachinePark.Repositories
{
    public class MachineRepository : IMachineRepository, IDisposable
    {
        private readonly AppDbContext _appDbContext;

        public MachineRepository(IDbContextFactory<AppDbContext> DbFactory)
        {
            _appDbContext = DbFactory.CreateDbContext();
        }

        public void Dispose()
        {
            _appDbContext.Dispose();
        }

        public async Task<IEnumerable<Machine>> GetAllMachines()
        {
            return await _appDbContext.Machines.ToListAsync();
        }

        public async Task<Machine> GetMachineById(Guid id)
        {
            return await _appDbContext.Machines.FirstOrDefaultAsync(c => c.Id == id);
        }

        public async Task <Machine> AddMachine (Machine machine)
        {
            var addedEntity = await _appDbContext.Machines.AddAsync(machine);
            await _appDbContext.SaveChangesAsync();
            return addedEntity.Entity;
        }

        public async Task<Machine> UpdateMachine(Machine machine)
        {
            var foundMachine = await _appDbContext.Machines.FirstOrDefaultAsync(e => e.Id == machine.Id);
            if (foundMachine != null)
            {
                foundMachine.Id = machine.Id;
                foundMachine.Name = machine.Name;
                foundMachine.IsOnline = false;
                foundMachine.LatestData = machine.LatestData;

                await _appDbContext.SaveChangesAsync();
                return foundMachine;
            }
            return null;
        }

        public async Task DeleteMachine(Guid machineId)
        {
            var foundMachine = await _appDbContext.Machines.FirstOrDefaultAsync(e => e.Id == machineId);
            if (foundMachine == null) return;

            _appDbContext.Machines.Remove(foundMachine);
            await _appDbContext.SaveChangesAsync();
        }
    }
}
