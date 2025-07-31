using Domain.Entities;
using Domain.Interfaces;
using Infrastructure.Data;
using Microsoft.EntityFrameworkCore;


public class PartRepository : BaseRepository<Part>, IPartRepository
{
    public PartRepository(PSDbContext context) : base(context)
    {
    }

    public Task<IEnumerable<Part>> GetAllParts()
    {
        throw new NotImplementedException();
    }

    public Task<Part> GetPart()
    {
        throw new NotImplementedException();
    }

    public async Task<Part?> GetByIndexAsync(string code)
    {
        return await _dbSet.FirstOrDefaultAsync(s => s.SerialNumber == code);
    }

}

