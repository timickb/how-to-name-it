using System.Collections.Generic;

namespace Database.Kacheli
{
    public class ChildUser : User
    {
        public AdultUser Father { get; set; }
        
        public AdultUser Mother { get; set; }
        
        public virtual List<Skill> SkillsToImprove { get; set; }
        
        public virtual List<Activity> CompletedActivities { get; set; }
    }
}