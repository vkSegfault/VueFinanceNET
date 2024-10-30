using Microsoft.EntityFrameworkCore;
using VueFinanceNET.Models;

namespace VueFinanceNET.Repository;

public class AssetsRepository : DbContext
{
    public AssetsRepository(DbContextOptions<AssetsRepository> options) : base(options)
    {
        
    }
    
    public DbSet<Asset> Assets { get; set; }
}