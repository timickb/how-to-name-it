using System.Collections.Generic;

namespace Database.Kacheli
{
    public class Skill : Entity
    {
        public string Name { get; set; }
        
        public string Description { get; set; }
        
        /// <summary>
        /// Активности, относящиеся к прокачке
        /// данного скилла.
        /// </summary>
        public virtual List<Activity> Activities { get; set; }
        
        /// <summary>
        /// Дети, для которых выбрана прокачка
        /// данного скилла.
        /// </summary>
        public virtual List<ChildUser> Children { get; set; }
    }
}