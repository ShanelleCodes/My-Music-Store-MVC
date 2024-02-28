using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using MusicStore.Models;

namespace MusicStore.DataAccess.Data
{
    public class ApplicationDbContext : IdentityDbContext<IdentityUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) 
        { 

        }
            
        public DbSet<Category> Categories {  get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<ShoppingCart> ShoppingCarts { get; set; }
        public DbSet<ApplicationUser> ApplicationUsers { get; set; }
        public DbSet<OrderHeader> OrderHeaders { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Category>().HasData(
                new Category { Id = 1, Name = "RnB", DisplayOrder = 1 },
                new Category { Id = 2, Name = "Pop", DisplayOrder = 2 },
                new Category { Id = 3, Name = "Hip-Hop", DisplayOrder = 3 },
                new Category { Id = 4, Name = "Dance", DisplayOrder = 4 }
                );

            modelBuilder.Entity<Product>().HasData(
                new Product
                {
                    Id = 1,
                    SongName = "Yeah",
                    Artist = "Usher",
                    Album = "Confessions",
                    Price = 0.99,
                    CategoryId = 3,
                    ImageUrl = ""
                },
                new Product
                {
                    Id = 2,
                    SongName = "Water",
                    Artist = "Tyla",
                    Album = "Tyla",
                    Price = 1.99,
                    CategoryId = 1,
                    ImageUrl = ""
                },
                new Product
                {
                    Id = 3,
                    SongName = "I miss you",
                    Artist = "Adele",
                    Album = "25",
                    Price = 0.99,
                    CategoryId = 2,
                    ImageUrl = ""
                },
                new Product
                {
                    Id = 4,
                    SongName = "Prada",
                    Artist = "Raye",
                    Album = "N/A",
                    Price = 0.99,
                    CategoryId = 4,
                    ImageUrl = ""
                },
                new Product
                {
                    Id = 5,
                    SongName = "On & On",
                    Artist = "Erykah Badu",
                    Album = "Baduizm",
                    Price = 0.99,
                    CategoryId = 1,
                    ImageUrl = ""
                },
                new Product
                {
                    Id = 6,
                    SongName = "Who told you",
                    Artist = "JHus ft Drake",
                    Album = "Beautiful And Brutal Yard",
                    Price = 1.99,
                    CategoryId = 3,
                    ImageUrl = ""
                }

                );
        }

        public static implicit operator ApplicationException(ApplicationDbContext v)
        {
            throw new NotImplementedException();
        }
    }

}