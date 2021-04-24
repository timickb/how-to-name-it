using System;

namespace Database.Kacheli
{
    public class User : Entity
    {
        public string Email { get; set; }
        
        public string Name { get; set; }
        
        public DateTime BirthDate { get; set; }
        
        public bool Sex { get; set; }
    }
}