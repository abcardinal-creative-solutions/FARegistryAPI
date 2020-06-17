using FARegistryAPI.Models;
using Microsoft.EntityFrameworkCore;
using System.Security.Cryptography.X509Certificates;

namespace FARegistryAPI.Data
{
    public class RegistryContext : DbContext
    {
        public RegistryContext(DbContextOptions<RegistryContext> opt ) : base(opt)
        {
            
        }
        public DbSet<RegistryRecord> RegistryRecords { get; set; }
    }
}
