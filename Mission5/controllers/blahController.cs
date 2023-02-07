using Microsoft.AspNetCore.Mvc;
using Mission5.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mission4_twilso48.controllers
{
    //controller class that has actions for index and from html pages
    public class blahController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        
        [HttpGet]
        public IActionResult Form()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Form(FormModel model)
        {
            return View();
        }
    }
}
