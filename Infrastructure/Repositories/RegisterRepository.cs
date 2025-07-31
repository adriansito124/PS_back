using Domain.Entities;
using Domain.Interfaces;
using Infrastructure.Data;

namespace Infrastructure.Repositories;

public class RegisterRepository(PSDbContext context) : BaseRepository<Register>(context), IRegisterRepository
{
}