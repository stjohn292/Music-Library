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
        public DbSet<Song> Songs { get; set; }


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
                    
                },


                new Album()
                {
                    AlbumID = 2,
                    AlbumName = "Apologies to the Queen Mary",
                    ImgPath = "",
                    ArtistName = "Wolf Parade",
                    ReleaseYear = 2007,
                    
                },

                new Album()
                {
                    AlbumID = 3,
                    AlbumName = "Dragonslayer",
                    ImgPath = "",
                    ArtistName = "Sunset Rubdown",
                    ReleaseYear = 2011,
                   
                });

            modelBuilder.Entity<Song>().HasData(

               new Song() { SongID = 1, AlbumID = 1, SongName = "Like A Rolling Stone" },
               new Song() { SongID = 2, AlbumID = 1, SongName = "Tombstone Blues" },
               new Song() { SongID = 3, AlbumID = 1, SongName = "It Takes A Lot To Laugh, It Takes A Train To Cry" },
               new Song() { SongID = 4, AlbumID = 1, SongName = "From A Buick 6" },
               new Song() { SongID = 5, AlbumID = 1, SongName = "Ballad Of A Thin Man" },
               new Song() { SongID = 6, AlbumID = 1, SongName = "Queen Jane Approximately" },
               new Song() { SongID = 7, AlbumID = 1, SongName = "Highway 61 Revisited" },
               new Song() { SongID = 8, AlbumID = 1, SongName = "Just Like Tom Thumb's Blues" },
               new Song() { SongID = 9, AlbumID = 1, SongName = "Desolation Row" },

               new Song() { SongID = 10, AlbumID = 2, SongName = "You Are A Runner" },
               new Song() { SongID = 11, AlbumID = 2, SongName = "Modern World" },
               new Song() { SongID = 12, AlbumID = 2, SongName = "Grounds For Divorce" },
               new Song() { SongID = 13, AlbumID = 2, SongName = "We Built Another World" },
               new Song() { SongID = 14, AlbumID = 2, SongName = "Fancy Claps" },
               new Song() { SongID = 15, AlbumID = 2, SongName = "Same Ghost Every Night" },
               new Song() { SongID = 16, AlbumID = 2, SongName = "Shine A Light" },
               new Song() { SongID = 17, AlbumID = 2, SongName = "Dear Sons And Daughters Of Hungry Ghosts" },
               new Song() { SongID = 18, AlbumID = 2, SongName = "I'll Believe In Anything" },
               new Song() { SongID = 19, AlbumID = 2, SongName = "It's A Curse" },
               new Song() { SongID = 20, AlbumID = 2, SongName = "Dinner Bells" },
               new Song() { SongID = 21, AlbumID = 2, SongName = "This Heart's On Fire" },

               new Song() { SongID = 22, AlbumID = 3, SongName = "Silver Moons" },
               new Song() { SongID = 23, AlbumID = 3, SongName = "Idiot Heart" },
               new Song() { SongID = 24, AlbumID = 3, SongName = "Apollo And The Buffalo And Anna" },
               new Song() { SongID = 25, AlbumID = 3, SongName = "Black Swan" },
               new Song() { SongID = 26, AlbumID = 3, SongName = "Paper Lace" },
               new Song() { SongID = 27, AlbumID = 3, SongName = "You Go On Ahead" },
               new Song() { SongID = 28, AlbumID = 3, SongName = "Nightengale" },
               new Song() { SongID = 29, AlbumID = 3, SongName = "Dragon's Layor" }


              );

              base.OnModelCreating(modelBuilder);
        }
    }

}
