namespace Database.Kacheli
{
    /// <summary>
    /// Сущность описывает начальное количество
    /// баллов прокачки определенного скилла
    /// у определенного ребенка.
    /// </summary>
    public class ChildStartSkills
    {
        public virtual ChildUser Child { get; set; }
        
        public virtual Skill Skill { get; set; }
        
        public int Points { get; set; }
    }
}