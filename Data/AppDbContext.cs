namespace CinmaTickets.Data
{
    public class AppDbContext : IdentityDbContext<ApplicationUser>
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Actor_Movie>().HasKey(am => new
            {
                am.ActorId,
                am.MovieId
            });
            builder.Entity<Actor_Movie>().HasOne(m => m.Movie).WithMany(am => am.Actor_Movie)
                .HasForeignKey(m => m.MovieId);
            builder.Entity<Actor_Movie>().HasOne(m => m.Actor).WithMany(am => am.Actor_Movie)
            .HasForeignKey(m => m.ActorId);
            base.OnModelCreating(builder);
        }
        public DbSet<Actor> Actors { get; set; }
        public DbSet<Movie> Movies { get; set; }
        public DbSet<Cinema> Cinemas { get; set; }
        public DbSet<Producer> Producers { get; set; }
        public DbSet<Actor_Movie> Actor_Movies { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderItem> OrderItems { get; set; }
        public DbSet<ShoppingCartItem> ShoppingCartItems { get; set; }

    }
}
