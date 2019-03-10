﻿using MusicLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MusicLibrary.Repositories
{
    public interface IAlbumRepository
    {
        IEnumerable<Album> GetAll();
        Album GetByID(int id);
        void Create(Album album);
        void Delete(Album album);
        void Edit(Album album);
    }
}
