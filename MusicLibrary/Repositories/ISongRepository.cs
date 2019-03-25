using MusicLibrary.Models;
using System.Collections.Generic;

namespace MusicLibrary.Repositories
{
    public interface ISongRepository
    {
        IEnumerable<Song> GetAll();
        Song GetByID(int id);
        void Add(Song song);
     }
}
