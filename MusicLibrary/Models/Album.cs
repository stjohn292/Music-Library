using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MusicLibrary.Models
{
    public class Album
    {
            public int AlbumID { get; set; }
            public string AlbumName { get; set; }
            public string ArtistName { get; set; }
            public string ImgPath { get; set; }
            public int ReleaseYear { get; set; }
           public virtual List<Song> Songs { get; set; }
    }
}
