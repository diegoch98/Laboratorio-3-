using Laboratorio3.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;

namespace Laboratorio3.Controllers
{
    public class SongController : Controller
    {
        public IActionResult Index()
        {
            var songs = GetListOfSongs();
            ViewBag.MainTitle = "List of my favorite songs";
            return View(songs);
        }

        private List<SongModel> GetListOfSongs()
        {
            List<SongModel> songs = new List<SongModel>();
            songs.Add(new SongModel{ Id = 1, SongName = "Clavel", Genre = "Alternative", 
                ReleasedDate = new DateTime(2016, 08, 01), Singer = "Javier Arce", Length = "4:55 min"});
            songs.Add(new SongModel{ Id = 2, SongName = "Self Care", Genre = "Rap", 
                ReleasedDate = new DateTime(2018, 07, 12), Singer = "Mac Miller", Length = "5:47 min"});
            songs.Add(new SongModel{ Id = 3, SongName = "N1tro", Genre = "Rap", 
                ReleasedDate = new DateTime(2021, 08, 12), Singer = "Fufu", Length = "2:53 min"});
            return songs;
        }
    }
}
