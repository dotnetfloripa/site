using DotNetFloripa.ModelCore;
using DotNetFloripa.ModelCore.Interfaces;
using DotNetFloripa.WebCore.Filters;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Linq;
using static DotNetFloripa.WebCore.Filters.NavigationFilterAttribute;

namespace DotNetFloripa.WebCore.Controllers
{
    public class HomeController : Controller
    {
        IAppRepository _repository;

        public HomeController(IAppRepository repository)
        {
            _repository = repository;
        }

        [HttpGet]
        [NavigationFilter(Pages.Home)]
        public IActionResult Index()
        {
            var proximoEvento = _repository.GetEvents().Where(e => e.Start.Date >= DateTime.Now.Date).OrderByDescending(e => e.Id).FirstOrDefault();
            if (proximoEvento == null)
            {
                proximoEvento = new Event();
            }
            return View(proximoEvento);
        }

        [HttpGet]
        [NavigationFilter(Pages.Sobre)]
        public IActionResult Sobre()
        {
            ViewData["Message"] = "Your application description page.";

            return View("About");
        }

        [HttpGet]
        [NavigationFilter(Pages.Eventos)]
        public IActionResult Evento(string slug)
        {
            var @event = _repository.GetEventBySlug(slug);
            
            if (@event == null)
                return NotFound();

            ViewBag.SafeDescription = System.Text.RegularExpressions.Regex.Replace(@event.Description, @"<[^>]+>|&nbsp;", "").Trim();

            return View("Event", @event);
        }

        [HttpGet]
        [NavigationFilter(Pages.Eventos)]
        public IActionResult Eventos()
        {
            var events = _repository.GetEvents().OrderByDescending(e => e.Start).ToArray();
            return View("Events", events);
        }

        [HttpGet]
        [NavigationFilter(Pages.Vagas)]
        public IActionResult Vagas()
        {
            return View("Jobs");
        }

        [HttpGet]
        [NavigationFilter(Pages.Empresas)]
        public IActionResult Empresas()
        {
            var companies = _repository.GetCompanies().ToArray();
            return View("Companies", companies);
        }
    }
}
