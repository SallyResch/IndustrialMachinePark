namespace IndustrialMachinePark.Models
{
    public class Machine
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public string? Name { get; set; }
        public string? LatestData { get; set; }
        public bool? IsOnline { get; set; }
    }
}
