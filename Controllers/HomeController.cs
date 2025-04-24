using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace MeetingApp.Controllers 
{
    public class HomeController : Controller
    {
        public IActionResult Index()
{
    int saat = DateTime.Now.Hour;
    string selamlama;

    if (saat < 12)
    {
        selamlama = "Günaydın";
    }
    else if (saat < 18)
    {
        selamlama = "İyi Günler";
    }
    else
    {
        selamlama = "İyi Akşamlar";
    }
    ViewBag.Selamlama = selamlama;
    ViewBag.Username="Furkan";
    return View();
}

    }
}
