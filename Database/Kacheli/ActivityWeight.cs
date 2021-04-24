namespace Database.Kacheli
{
    /// <summary>
    /// Данная сущность устанавливает связь между
    /// тем, какое задание какой скилл прокачивает
    /// и сколько конкретно очков прибавляет к этому скиллу.
    /// </summary>
    public class ActivityWeight
    {
        public virtual Activity Activity { get; set; }
        
        public virtual Skill Skill { get; set; }
        
        public int Points { get; set; }
    }
}