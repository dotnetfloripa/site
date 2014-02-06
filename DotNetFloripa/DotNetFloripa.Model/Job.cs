using System;
namespace DotNetFloripa.Model
{
    public class Job : Entity
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime Opened { get; set; }
        public DateTime? Closed { get; set; }
        public string AnnouncedBy { get; set; }
        public Company Company{ get; set; }
    }
}
