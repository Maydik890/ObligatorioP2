﻿using Microsoft.AspNetCore.Mvc;

namespace WebApp.Controllers
{
    public class VacunaController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
