using Microsoft.EntityFrameworkCore;

namespace HotelManagement.Infrustructure;

public class HotelManagementDbContext : DbContext
{
    public HotelManagementDbContext(DbContextOptions<HotelManagementDbContext> options) : base(options)
    {
    }
          
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly(typeof(HotelManagementDbContext).Assembly);
    }
   
}


    
    


