using Microsoft.AspNetCore.Mvc;
using ASP_NET.Models;
using System;

namespace ASP_NET.Controllers
{
    public class EscuelaController : Controller
    {

        public IActionResult Index()
        {
            var escuela = new Escuela("Nabux", 2014);

            ViewBag.CosaDinamica = "Holaaaaaa";
            return  View(escuela);
        }
        
    }
}