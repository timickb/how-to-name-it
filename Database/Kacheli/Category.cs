using System.Collections.Generic;

namespace Database.Kacheli
{
    /// <summary>
    /// Сфера, которую прокачивает
    /// ребенок.
    /// </summary>
    public class Category : Entity
    {
        public string Name { get; set; }
        
        /// <summary>
        /// Дети, для которых выбрана прокачка данной категории.
        /// </summary>
        public virtual List<ChildUser> Children { get; set; }
    }
}