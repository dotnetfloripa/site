using System;
namespace DotNetFloripa.ModelCore
{
    public class Talk : Entity
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime Start { get; set; }
        public DateTime End { get; set; }
        public string Speaker { get; set; }
        public string SlideUrl { get; set; }
    }
}
