using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;

namespace CarSharing_Angajati.Models
{
    public class CarSharingDbContext:DbContext
    {

        public CarSharingDbContext(DbContextOptions<CarSharingDbContext> options): base(options) 
        {}

        public DbSet<Employees> Employees { get; set; }

    }
}
