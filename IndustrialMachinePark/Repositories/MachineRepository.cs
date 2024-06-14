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

        public async Task<Machine> GetMachineByName(string name)
        {
            return await _appDbContext.Machines.FirstOrDefaultAsync(c => c.Name == name);
        }

        public async Task<Machine> EditMachineByName(string name, Machine updatedMachine)
        {
            var machine = await _appDbContext.Machines.FirstOrDefaultAsync(c => c.Name == name);
            if (machine != null)
            {
                machine.Name = updatedMachine.Name;
                machine.IsOnline = updatedMachine.IsOnline;
                machine.LatestData = updatedMachine.LatestData;

                _appDbContext.Machines.Update(machine);
                await _appDbContext.SaveChangesAsync();
            }
            return machine;
        }
        public async Task<Machine> CreateMachine(Machine machine)
        {
            return machine;
        }
    }
}
