namespace Database
{
    /// <summary>
    /// 
    /// </summary>
    public class ProjectUpdate : Entity
    {
        public virtual Project Project { get; set; }
        
        public string Changelog { get; set; }
        
        public string Version { get; set; }
        
    }
}