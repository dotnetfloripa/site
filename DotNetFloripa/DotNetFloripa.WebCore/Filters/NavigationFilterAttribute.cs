using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DotNetFloripa.WebCore.Filters
{
    public class NavigationFilterAttribute : ActionFilterAttribute
    {
        public enum Pages
        {
            Home,
            Sobre,
            Eventos,
            Vagas,
            Empresas
        }

        public Pages CurrentPage { get; set; }

        public NavigationFilterAttribute(Pages currentPage)
        {
            CurrentPage = currentPage;
        }

        public override void OnActionExecuted(ActionExecutedContext context)
        {
            ((Controller)context.Controller).ViewBag.CurrentPage = CurrentPage.ToString();
        }
    }
}