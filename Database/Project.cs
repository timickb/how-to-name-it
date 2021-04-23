namespace Database
{
    public class Project : Entity
    {
        public string Title { get; set; }

        public string Description { get; set; }

        public User Author { get; set; }
    }
}