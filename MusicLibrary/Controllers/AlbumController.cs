using Microsoft.AspNetCore.Mvc;
using MusicLibrary.Repositories;
using MusicLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MusicLibrary.Controllers
{
    
    public class AlbumController : Controller
    {
        IAlbumRepository albumRepo;

        public AlbumController(IAlbumRepository albumRepo)
        {
            this.albumRepo = albumRepo;
        }

        public ViewResult Index()
        {
            var model = albumRepo.GetAll();
            return View(model);
        }

        public ViewResult Details(int id)
        {
            var model = albumRepo.GetByID(id);
            return View(model);
        }

        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Album album)
        {
            albumRepo.Create(album);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ViewResult Delete(int id)
        {
            var model = albumRepo.GetByID(id);
            return View(model);
        }

        [HttpPost]
        public ActionResult Delete(Album album)
        {

            albumRepo.Delete(album);
            return RedirectToAction("Index");
        }


        [HttpGet]
        public ViewResult Edit(int id)
        {
            var model = albumRepo.GetByID(id);
            return View(model);
        }

        [HttpPost]
        public ActionResult Edit(Album album)
        {
            albumRepo.Edit(album);
            return RedirectToAction("Details/" + album.AlbumID);
        }
    }
}
