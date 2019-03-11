using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MusicLibrary.Models;
using Microsoft.EntityFrameworkCore;

namespace MusicLibrary
{
    public class AlbumContext : DbContext
    {
        public DbSet<Album> Albums { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var connectionString = "Server=(localdb)\\mssqllocaldb;Database=MusicTesting;Trusted_Connection=True;";

            optionsBuilder.UseSqlServer(connectionString)
                          .UseLazyLoadingProxies();

            base.OnConfiguring(optionsBuilder);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Album>().HasData(

                new Album()
                {
                    AlbumID = 1,
                    AlbumName = "Highway 61 Revisited",
                    ImgPath = "",
                    ArtistName = "Bob Dylan.",
                    ReleaseYear = 1965,
                    GenreID = 1,
                    RunTime = 85,
                },


                new Album()
                {
                    AlbumID = 2,
                    AlbumName = "Apologies to the Queen Mary",
                    ImgPath = "",
                    ArtistName = "Wolf Parade",
                    ReleaseYear = 2007,
                    GenreID = 1,
                    RunTime = 91,
                },

                new Album()
                {
                    AlbumID = 3,
                    AlbumName = "Dragonslayer",
                    ImgPath = "",
                    ArtistName = "Sunset Rubdown",
                    ReleaseYear = 2011,
                    GenreID = 1,
                    RunTime = 89,
                });

        }
    }

}
