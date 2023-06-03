using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using TryCatch_API.Model.Domain;

namespace TryCatch_API.DATA
{
    public class StudentDBContext : DbContext
    {
        public StudentDBContext(DbContextOptions dbContextOptions) : base(dbContextOptions)
        {

        }

        public DbSet<Department> departments {get;set;}
        public DbSet<Student> students { get;set;}
    }
}
