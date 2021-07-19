using GanjinehStore.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace GanjinehStore.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        public DbSet<Genre> Genres { get; set; }
        public DbSet<BookGenre> BookGenres { get; set; }
        public DbSet<Book> Books { get; set; }
        public DbSet<Author> Authors { get; set; }
        public DbSet<Publication> Publications { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Genre>().HasData(
                new Genre() { Id = 1, Title = "Fantasy Fiction" },
                new Genre() { Id = 2, Title = "Drama" },
                new Genre() { Id = 3, Title = "Young adult fiction" },
                new Genre() { Id = 4, Title = "Mystery" },
                new Genre() { Id = 5, Title = "Thriller" },
                new Genre() { Id = 6, Title = "Bildungsroman" }
            );

            modelBuilder.Entity<Author>().HasData(
                new Author() { AuthorId = 1, FullName = "J. K. Rowling", Mobile = "09222222222" }
            );

            modelBuilder.Entity<Publication>().HasData(
                new Publication() { Id = 1, Name = " Bloomsbury Publishing (UK)", Mobile = "09222222222", RegisterDate = new System.DateTime(2012, 10, 11), PhoneNumber = "091111111111" }
            );

            modelBuilder.Entity<Book>().HasData(
                new Book() { BookId = 1, AuthorId = 1, PublicationId = 1, Title = "Harry Potter", Abstraction = "Harry Potter is a series of seven fantasy novels written by British author J. K. Rowling. The novels chronicle the lives of a young wizard, Harry Potter, and his friends Hermione Granger and Ron Weasley, all of whom are students at Hogwarts School of Witchcraft and Wizardry.", ISBN = "9780747532743", PagesCount = 250, Cover = "harry-potter.jpg"
                }
            );

            modelBuilder.Entity<BookGenre>().HasData(
                new BookGenre() { Id = 1, BookId = 1, GenreId = 1 },
                new BookGenre() { Id = 2, BookId = 1, GenreId = 2 },
                new BookGenre() { Id = 3, BookId = 1, GenreId = 3 },
                new BookGenre() { Id = 4, BookId = 1, GenreId = 4 },
                new BookGenre() { Id = 5, BookId = 1, GenreId = 5 },
                new BookGenre() { Id = 6, BookId = 1, GenreId = 6 }
            );
        }

    }
}
