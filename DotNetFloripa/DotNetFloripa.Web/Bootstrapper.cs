using DotNetFloripa.Data;
using DotNetFloripa.Model.Interfaces;
using Nancy;
using Owin;

namespace DotNetFloripa.Web
{
    public class Bootstrapper : DefaultNancyBootstrapper
    {
        protected override void RegisterInstances(Nancy.TinyIoc.TinyIoCContainer container, System.Collections.Generic.IEnumerable<Nancy.Bootstrapper.InstanceRegistration> instanceRegistrations)
        {
            base.RegisterInstances(container, instanceRegistrations);

            container.Register<IAppRepository, AppRepository>();
        }
    }
}