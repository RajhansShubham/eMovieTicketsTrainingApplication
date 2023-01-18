using eMovieTickets.Models;
using Microsoft.EntityFrameworkCore;

namespace eMovieTickets.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) :base(options) 
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Actors_Movie>().HasKey(am => new
            {
                am.ActorId,
                am.MovieId
            });
            modelBuilder.Entity<Actors_Movie>().HasOne(m => m.Movies).WithMany(am => am.Actors_Movies).HasForeignKey(m => m.MovieId);
            modelBuilder.Entity<Actors_Movie>().HasOne(a => a.Actors).WithMany(am => am.Actors_Movies).HasForeignKey(a => a.ActorId);
           
            base.OnModelCreating(modelBuilder);

        }

        public DbSet<Actor> Actors { get; set; }

        public DbSet<Movie> Movies { get; set; } 



        public DbSet<Actors_Movie> Actors_Movies { get; set; }

        public DbSet<Cinemas> Cinemas { get; set; }
        public DbSet<Producer> Producer { get; set; }

    }
}
