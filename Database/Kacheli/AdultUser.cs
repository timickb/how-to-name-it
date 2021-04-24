using System.Collections.Generic;

namespace Database.Kacheli
{
    public class AdultUser : User
    {
        public List<ChildUser> Children { get; set; }
    }
}