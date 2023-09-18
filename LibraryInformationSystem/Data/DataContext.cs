using LibraryInformationSystem.Models;
using Microsoft.EntityFrameworkCore;

namespace LibraryInformationSystem.Data
{
    public class DataContext : DbContext 
    {
        public DataContext(DbContextOptions<DataContext> options) :base(options)  
        { 
        
        }

        public DbSet<Author> Authors { get; set; }
        public DbSet<Book> Books { get; set; }
        public DbSet<Category> Categories { get; set; } 
        public DbSet<Direction> Directions { get; set; }
        public DbSet<Faculty> Faculty { get; set;}
        public DbSet<Fl> Files { get; set; }
        public DbSet<Genre> Genres { get; set; }    
        public DbSet<Role> Roles { get; set; }  
        public DbSet<User> Users { get; set; }
        public DbSet<BookAuthor> BookAuthors { get; set; }
        public DbSet<BookCategory> BookCategories { get; set; }
        public DbSet<BookGenre> BookGenres { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<BookAuthor>()
                .HasKey(ba => new { ba.BookId, ba.AuthorId });
            modelBuilder.Entity<BookAuthor>()
                .HasOne(b => b.Book)
                .WithMany(ba => ba.BookAuthors)
                .HasForeignKey(b => b.BookId);
            modelBuilder.Entity<BookAuthor>()
                .HasOne(a => a.Author)
                .WithMany(ba => ba.BookAuthors)
                .HasForeignKey(a => a.AuthorId);

            modelBuilder.Entity<BookCategory>()
                .HasKey(bc => new { bc.BookId, bc.CategoryId});
            modelBuilder.Entity<BookCategory>()
                .HasOne(b => b.Book)
                .WithMany(bc => bc.BookCategories)
                .HasForeignKey(b => b.BookId);
            modelBuilder.Entity<BookCategory>()
                .HasOne(c => c.Category)
                .WithMany(bc => bc.BookCategories)
                .HasForeignKey(c => c.CategoryId);

            modelBuilder.Entity<BookGenre>()
                .HasKey(bg => new { bg.BookId, bg.GenreId});
            modelBuilder.Entity<BookGenre>()
                .HasOne(b => b.Book)
                .WithMany(bg => bg.BookGenres)
                .HasForeignKey(b => b.BookId);
            modelBuilder.Entity<BookGenre>()
                .HasOne(g => g.Genre)
                .WithMany(bg => bg.BookGenres)
                .HasForeignKey(g => g.GenreId);
                

        }

    }
}
