using System;

namespace Database.CompleteGraph
{
    public class Visit : Entity
    {
        public DateTime EnterTime => CreationTime;
        
        public DateTime LeaveTime { get; set; }
        
        public User Visitor { get; set; }
    }
}