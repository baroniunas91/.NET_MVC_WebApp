using Microsoft.AspNetCore.Mvc;
using RegistrationHomework.WebApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegistrationHomework.WebApp.Controllers
{
    public class RegistrationController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Post(RegistrationModel model)
        {
            if (ModelState.IsValid)
            {
                return View("Index", model);
            } else
            {
                return View("Index");
            }
        }
    }
}
