using Microsoft.EntityFrameworkCore;
using RestaurantWebOrder.Models.Domain;

namespace RestaurantWebOrder.EntityData
{
    public class EntityDB:DbContext
    {
        public EntityDB(DbContextOptions<EntityDB> options) : base(options)
        {
        }
        public DbSet<Order> Orders { get; set; }

    }

}

