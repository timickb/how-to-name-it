using System.Collections.Generic;

namespace Database.Kacheli
{
    public class AdultUser : User
    {
        public virtual List<ChildUser> Children { get; set; }
    }
}