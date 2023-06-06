using Microsoft.EntityFrameworkCore;

namespace MVC_02_22.EntityData
{
    public class EntityDB:DbContext
    {
        public EntityDB(DbContextOptions<EntityDB> options) : base(options) { 
        }

        DbSet<Student> Students { get; set; }
        DbSet<TextReader> Teachers { get; set; }

    }
}
