namespace Database
{
    public class ComplaintFeedback : Entity
    {
        public User Author { get; set; }

        public string Text { get; set; }
        
        public virtual Complaint Complaint { get; set; }
    }
}