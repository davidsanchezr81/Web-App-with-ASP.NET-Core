using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DutchTreat.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace DutchTreat.Controllers
{
    public class AppController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet("contact")]
        public IActionResult Contact()
        {
            ViewBag.Title = "Contact Us";

            //throw new InvalidOperationException("Bad things happen");

            return View();
            
        }

        [HttpPost("contact")]
        public IActionResult Contact(ContactViewModel model)
        {

            if (ModelState.IsValid)
            {
                _mailService.SendMail("sanchez_david_geofisica@hotmail.com",model.Subject, $"From: {model.Name} - {model.Email}, Message: {model.Message}");
            }
           
        }

        public IActionResult About()
        {
            ViewBag.Title = "About Us";

            return View();


        }
    }
}
