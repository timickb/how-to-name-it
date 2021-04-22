using System;

namespace Database
{
    public class User : Entity
    {
        public UserStatus Status { get; set; }
        
        public string Name { get; set; }
        
        public string Surname { get; set; }
        
        public DateTime BirthDate { get; set; }
        
        public string Password { get; set; }
        
        public bool Blocked { get; set; }
        
        
    }
}