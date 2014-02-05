using System.Linq;
using Nancy;

namespace DotNetFloripa.Web.Extensions
{
    public static class NancyExtensions
    {
        public static bool IsPjaxRequest(this NancyContext context)
        {
            return context.Request.Headers.Keys.Contains("X-PJAX");
        }
    }
}