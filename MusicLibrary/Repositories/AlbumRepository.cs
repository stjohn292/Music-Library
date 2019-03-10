using MusicLibrary.Models;
using MusicLibrary.wwwroot;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MusicLibrary.Repositories
{
    public class AlbumRepository : IAlbumRepository
    {
        AlbumContext db;
        public AlbumRepository(AlbumContext db)
        {
            this.db = db;
        }


        public Album GetByID(int id)
        {
            return db.Albums.Single(album => album.AlbumID == id);
        }

        public IEnumerable<Album> GetAll()
        {
            return db.Albums.ToList();
        }

        public void Create(Album album)
        {
            db.Albums.Add(album);
            db.SaveChanges();
        }
        public void Delete(Album album)
        {
            db.Albums.Remove(album);
            db.SaveChanges();
        }

        public void Edit(Album album)
        {
            db.Update(album);
            db.SaveChanges();
        }

        public Album GetById(int id)
        {
            throw new NotImplementedException();
        }
    }
}
