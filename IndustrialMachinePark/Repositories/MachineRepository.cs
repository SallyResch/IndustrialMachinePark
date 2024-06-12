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
    }
}
