namespace WebApplication1.Models
{
    public class TeamIcon
    {
        public int Id { get; set; }
        public int TeamId { get; set; }
        public string Icon { get; set; }
        public Team Team { get; set; }
    }
}
