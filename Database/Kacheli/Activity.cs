using System.Collections.Generic;

namespace Database.Kacheli
{
    /// <summary>
    /// Активность, которую бот будет
    /// отправлять пользователю на ежедневной основе.
    /// </summary>
    public class Activity
    {
        public string Name { get; set; }
        
        public string Description { get; set; }

        public int MinutesToHaveDone { get; set; }
        
        public ActivityComplexity Complexity { get; set; }
        
        public virtual List<Skill> Skills { get; set; }
    }
}