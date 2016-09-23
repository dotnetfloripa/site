using System;
namespace DotNetFloripa.ModelCore
{
    public class Event : Entity
    {
        public string Slug { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime Start { get; set; }
        public DateTime End { get; set; }
        public string ExternalUrl { get; set; }
        public string[] Organizers { get; set; }
        public string ImageUrl { get; set; }
        public Talk[] Talks { get; set; }
    }
}
