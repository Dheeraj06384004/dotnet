using AWSDBConnect.Models;
using Microsoft.EntityFrameworkCore;

namespace test.Data
{
    public class ApplicationDBContest : DbContext
    {
        public ApplicationDBContest(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Webdbtemp> Webdbtemp { get; set; }
    }   
}
