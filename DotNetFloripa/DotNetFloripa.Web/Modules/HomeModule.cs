using Nancy;

namespace DotNetFloripa.Web.Modules
{
    public class HomeModule : NancyModule
    {
        public HomeModule()
        {
            Get["/"] = _ => View["Index"];
            Get["/sobre"] = _ => View["About"];
            Get["/eventos"] = _ => View["Events"];
            Get["/vagas"] = _ => View["Jobs"];
            Get["/empresas"] = _ => View["Companies"];
            Get["/contato"] = _ => View["Contact"];
        }
    }
}