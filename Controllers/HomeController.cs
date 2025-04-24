using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MeetingApp.Models;


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
    
    var meetingInfo = new MeetingInfo
    {
        Id = 1, Location = "İstanbul",
        Date = new DateTime(2024, 01, 20, 20, 0, 0), 
        numberOfPeople = 100 ,
        };
    return View(meetingInfo);
}

    }
}
