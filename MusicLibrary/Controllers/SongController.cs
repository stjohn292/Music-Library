using MusicLibrary.Models;
using MusicLibrary.Repositories;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;


namespace MusicLibrary.Controllers
{
    public class SongController : Controller
    {
        ISongRepository songRepo;
        public SongController(ISongRepository songRepo)
        {
            this.songRepo = songRepo;
        }

        public ViewResult Index()
        {
            IEnumerable<Song> model = songRepo.GetAll();
            return View(model);
        }
        public ViewResult Details(int id)
        {
            var model = songRepo.GetByID(id);
            return View(model);
        }

        [HttpGet]
        public ViewResult Add(int id)
        {
            var newSong = new Song()
            {
                SongID = id
            };

            return View(newSong);
        }

        [HttpPost]
        public ActionResult Add(Song song)
        {
            songRepo.Add(song);
            return RedirectToAction("../Album/Details/" + song.AlbumID);
        }

        
    }
}

