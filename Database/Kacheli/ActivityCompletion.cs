using System;

namespace Database.Kacheli
{
    /// <summary>
    /// Сущность, обозначающая факт
    /// выполнения ребенком задания.
    /// </summary>
    public class ActivityCompletion
    {
        public virtual ChildUser Child { get; set; }
        
        public virtual Activity Activity { get; set; }
        
        public DateTime DateTime { get; set; }
    }
}