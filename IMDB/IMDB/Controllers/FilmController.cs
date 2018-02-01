﻿using System.Linq;
using System.Net;
using System.Web.Mvc;
using IMDB.Models;

namespace IMDB.Controllers
{
    [ValidateInput(false)]
    public class FilmController : Controller
    {
        private IMDBDbContext db = new IMDBDbContext();
        [HttpGet]
        [Route("")]
        public ActionResult Index()
        {
            var films = db.Films.ToList();
            return View(films);
        }

        [HttpGet]
        [Route("create")]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [Route("create")]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Film film)
        {
            db.Films.Add(film);
            db.SaveChanges();
            return Redirect("/");
        }

        [HttpGet]
        [Route("edit/{id}")]
        public ActionResult Edit(int? id)
        {
            var film = db.Films.Find(id);
            // if (film == null) return HttpNotFound();
            return View(film);
        }

        [HttpPost]
        [Route("edit/{id}")]
        [ValidateAntiForgeryToken]
        public ActionResult EditConfirm(int? id, Film filmModel)
        {
            var film = db.Films.Find(id);
            film.Name = filmModel.Name;
            film.Genre = filmModel.Genre;
            film.Director = filmModel.Director;
            film.Year = filmModel.Year;
            db.SaveChanges();
            return Redirect( "/");
        }

        [HttpGet]
        [Route("delete/{id}")]
        public ActionResult Delete(int? id)
        {
            var film = db.Films.Find(id);
            return View(film);
        }

        [HttpPost]
        [Route("delete/{id}")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirm(int? id, Film filmModel)
        {
            var film = db.Films.Find(id);
            db.Films.Remove(film);
            db.SaveChanges();
            return Redirect("/");
        }
    }
}