using System.Collections.Generic;

namespace Database
{
    public class Complaint : Entity
    {
        public User Author { get; set; }

        public ComplaintType Type { get; set; }

        public EducationalInstitution EducationalInstitution { get; set; }

        public string Text { get; set; }
        
        public virtual List<ComplaintFeedback> Feedback { get; set; }
    }
}