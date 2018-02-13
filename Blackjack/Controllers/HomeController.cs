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
            Table newTable = new Table();
            newTable.SetupFunction();
            return View(newTable);
        }
    }
}
