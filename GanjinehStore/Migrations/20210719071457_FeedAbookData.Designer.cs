// <auto-generated />
using System;
using GanjinehStore.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace GanjinehStore.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20210719071457_FeedAbookData")]
    partial class FeedAbookData
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.6")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("GanjinehStore.Models.Author", b =>
                {
                    b.Property<int>("AuthorId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Email")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("FullName")
                        .IsRequired()
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("Mobile")
                        .IsRequired()
                        .HasMaxLength(11)
                        .HasColumnType("nvarchar(11)");

                    b.HasKey("AuthorId");

                    b.ToTable("Authors");

                    b.HasData(
                        new
                        {
                            AuthorId = 1,
                            FullName = "J. K. Rowling",
                            Mobile = "09222222222"
                        });
                });

            modelBuilder.Entity("GanjinehStore.Models.Book", b =>
                {
                    b.Property<int>("BookId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Abstraction")
                        .IsRequired()
                        .HasMaxLength(1500)
                        .HasColumnType("nvarchar(1500)");

                    b.Property<int>("AuthorId")
                        .HasColumnType("int");

                    b.Property<string>("Cover")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("ISBN")
                        .IsRequired()
                        .HasMaxLength(32)
                        .HasColumnType("nvarchar(32)");

                    b.Property<int>("PagesCount")
                        .HasColumnType("int");

                    b.Property<int>("PublicationId")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("BookId");

                    b.HasIndex("AuthorId");

                    b.HasIndex("PublicationId");

                    b.ToTable("Books");

                    b.HasData(
                        new
                        {
                            BookId = 1,
                            Abstraction = "Harry Potter is a series of seven fantasy novels written by British author J. K. Rowling. The novels chronicle the lives of a young wizard, Harry Potter, and his friends Hermione Granger and Ron Weasley, all of whom are students at Hogwarts School of Witchcraft and Wizardry.",
                            AuthorId = 1,
                            Cover = "harry-potter.jpg",
                            ISBN = "9780747532743",
                            PagesCount = 250,
                            PublicationId = 1,
                            Title = "Harry Potter"
                        });
                });

            modelBuilder.Entity("GanjinehStore.Models.BookGenre", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("BookId")
                        .HasColumnType("int");

                    b.Property<int>("GenreId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("BookId");

                    b.HasIndex("GenreId");

                    b.ToTable("BookGenres");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            BookId = 1,
                            GenreId = 1
                        },
                        new
                        {
                            Id = 2,
                            BookId = 1,
                            GenreId = 2
                        },
                        new
                        {
                            Id = 3,
                            BookId = 1,
                            GenreId = 3
                        },
                        new
                        {
                            Id = 4,
                            BookId = 1,
                            GenreId = 4
                        },
                        new
                        {
                            Id = 5,
                            BookId = 1,
                            GenreId = 5
                        },
                        new
                        {
                            Id = 6,
                            BookId = 1,
                            GenreId = 6
                        });
                });

            modelBuilder.Entity("GanjinehStore.Models.Genre", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.ToTable("Genres");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Title = "Fantasy Fiction"
                        },
                        new
                        {
                            Id = 2,
                            Title = "Drama"
                        },
                        new
                        {
                            Id = 3,
                            Title = "Young adult fiction"
                        },
                        new
                        {
                            Id = 4,
                            Title = "Mystery"
                        },
                        new
                        {
                            Id = 5,
                            Title = "Thriller"
                        },
                        new
                        {
                            Id = 6,
                            Title = "Bildungsroman"
                        });
                });

            modelBuilder.Entity("GanjinehStore.Models.Publication", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Fax")
                        .HasMaxLength(32)
                        .HasColumnType("nvarchar(32)");

                    b.Property<string>("Mobile")
                        .HasMaxLength(32)
                        .HasColumnType("nvarchar(32)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasMaxLength(64)
                        .HasColumnType("nvarchar(64)");

                    b.Property<DateTime>("RegisterDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Publications");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Mobile = "09222222222",
                            Name = " Bloomsbury Publishing (UK)",
                            PhoneNumber = "091111111111",
                            RegisterDate = new DateTime(2012, 10, 11, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        });
                });

            modelBuilder.Entity("GanjinehStore.Models.Book", b =>
                {
                    b.HasOne("GanjinehStore.Models.Author", "Author")
                        .WithMany("Books")
                        .HasForeignKey("AuthorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("GanjinehStore.Models.Publication", "Publication")
                        .WithMany("Books")
                        .HasForeignKey("PublicationId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Author");

                    b.Navigation("Publication");
                });

            modelBuilder.Entity("GanjinehStore.Models.BookGenre", b =>
                {
                    b.HasOne("GanjinehStore.Models.Book", "Book")
                        .WithMany("BookGenres")
                        .HasForeignKey("BookId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("GanjinehStore.Models.Genre", "Genre")
                        .WithMany("BookGenres")
                        .HasForeignKey("GenreId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Book");

                    b.Navigation("Genre");
                });

            modelBuilder.Entity("GanjinehStore.Models.Author", b =>
                {
                    b.Navigation("Books");
                });

            modelBuilder.Entity("GanjinehStore.Models.Book", b =>
                {
                    b.Navigation("BookGenres");
                });

            modelBuilder.Entity("GanjinehStore.Models.Genre", b =>
                {
                    b.Navigation("BookGenres");
                });

            modelBuilder.Entity("GanjinehStore.Models.Publication", b =>
                {
                    b.Navigation("Books");
                });
#pragma warning restore 612, 618
        }
    }
}
