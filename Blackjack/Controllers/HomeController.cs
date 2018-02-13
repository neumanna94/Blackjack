using Microsoft.AspNetCore.Mvc;
using Blackjack.Models;
using System.Collections.Generic;

namespace Blackjack.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet("/")]
        public ActionResult Index()
        {

            return View();
        }
        [HttpGet("/clear")]
        public ActionResult NewGame()
        {

        }
        [HttpGet("/HitPlayerOne")]
        public ActionResult HitPlayerOne()
        {

        }
        [HttpGet("/HitPlayerTwo")]
        public ActionResult HitPlayerTwo()
        {

        }
        [HttpGet("/HoldPlayerOne")]
        public ActionResult HoldPlayerOne()
        {

        }
        [HttpGet("/HoldPlayerTwo")]
        public ActionResult HoldPlayerTwo()
        {

        }
        [HttpPost("/Result")]
        public ActionResult Result()
        {

        }

    }
}
