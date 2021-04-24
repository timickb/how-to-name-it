using System.Collections.Generic;

namespace Database
{
    public class Project : Entity
    {
        public string Title { get; set; }

        public string Description { get; set; }
        
        public List<string> Links { get; set; }

        public virtual List<Article> News { get; set; }
        
        public virtual List<ProjectUpdate> Updates { get; set; }
    }
}