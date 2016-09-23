using System.Linq;
namespace DotNetFloripa.ModelCore.Interfaces
{
    public interface IAppRepository
    {
        IQueryable<Event> GetEvents();
        Event GetEventBySlug(string slug);
        IQueryable<Company> GetCompanies();
    }
}
