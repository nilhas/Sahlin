using RatingAppApi.Data.Entities;
using System.Data.Entity;

namespace RatingAppApi.Data
{
    public class RatingAppApiDbContext : DbContext
    {
        public RatingAppApiDbContext() : base("RatingAppApiDb")
        {
        }
        public DbSet<Skill> Skills { get; set; }
    }
    
}
