using MusicLibrary.Models;
using System.Collections.Generic;
using System.Linq;

namespace MusicLibrary.Repositories
{
    public class SongRepository : ISongRepository
    {
        AlbumContext db;
        public SongRepository(AlbumContext db)
        {
            this.db = db;
        }

        public int Count()
        {
            return db.Songs.Count();
        }

        public void Add(Song song)
        {
            db.Songs.Add(song);
            db.SaveChanges();
        }
        public Song GetByID(int id)
        {
            return db.Songs.Single(song => song.SongID == id);
        }
       
        public void Save()
        {
            db.SaveChanges();
        }
        public IEnumerable<Song> GetAll()
        {
            return db.Songs.ToList();
        }
    
    }
}
