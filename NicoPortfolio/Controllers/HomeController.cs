using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using NicoPortfolio.Models;
using NicoPortfolio.ViewModels;


namespace NicoPortfolio.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";
            var threeRepos = Repo.GetRepos();
 
            return View(threeRepos);
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult SendMessage()
        {
            return View();
        }

        [HttpPost]
        public IActionResult SendMessage(MessageViewModel model)
        {
            Message newMessage = new Message("message from: " + model.Name + "// email: " + model.Email + "//" + model.Body );
            newMessage.Send();
            return RedirectToAction("Index");
        }


    }
}
