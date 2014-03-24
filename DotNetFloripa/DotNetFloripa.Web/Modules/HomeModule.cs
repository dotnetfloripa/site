using DotNetFloripa.Model;
using Nancy;
using System;
using System.Linq;
using System.Collections.Generic;
using DotNetFloripa.Model.Interfaces;

namespace DotNetFloripa.Web.Modules
{
    public class HomeModule : NancyModule
    {
        IAppRepository _repository;
        public HomeModule(IAppRepository repository)
        {
            _repository = repository;

            Get["/"] = _ => GetIndex();
            Get["/sobre"] = _ => View["About"];
            Get["/eventos"] = _ => GetEvents();
            Get["/evento/{slug}"] = _ => GetEvent((string)_.slug);
            Get["/vagas"] = _ => View["Jobs"];
            Get["/empresas"] = _ => GetCompanies();
        }

        private dynamic GetIndex()
        {
            var proximoEvento = _repository.GetEvents().OrderByDescending(e => e.Id).FirstOrDefault();
            return View["Index", proximoEvento];
        }

        private dynamic GetEvent(string slug)
        {
            var @event = _repository.GetEventBySlug(slug);
            if (@event == null)
            {
                return HttpStatusCode.NotFound;
            }
            ViewBag.SafeDescription = System.Text.RegularExpressions.Regex.Replace(@event.Description, @"<[^>]+>|&nbsp;", "").Trim();
            return View["Event", @event];
        }

        private dynamic GetEvents()
        {
            var events = _repository.GetEvents().OrderByDescending(e => e.Start).ToArray();
            return View["Events", events];
        }

        private dynamic GetCompanies()
        {
            var companies = _repository.GetCompanies().ToArray();
            return View["Companies", companies];
        }
    }
}
