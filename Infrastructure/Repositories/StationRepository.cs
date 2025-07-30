using Application.Repositories;
using Domain.Entities;
using Infrastructure.Data;
using Microsoft.EntityFrameworkCore;


public class StationRepository : BaseRepository<Station>, IStationRepository
{
    public StationRepository(PSDbContext context) : base(context)
    {
    }

    public async Task<IEnumerable<Station>> GetAllOrderedByIndexAsync()
    {
        return await _dbSet.OrderBy(s => s.Index).ToListAsync();
    }

    public Task<IEnumerable<Station>> GetAllStations()
    {
        throw new NotImplementedException();
    }

    public async Task<Station?> GetByIndexAsync(short index)
    {
        return await _dbSet.FirstOrDefaultAsync(s => s.Index == index);
    }

    public Task<Station> GetStation()
    {
        throw new NotImplementedException();
    }
}
