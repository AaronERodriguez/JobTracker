namespace JobTracker.Data;

public class JobApplication
{
    public int ID { get; set; }
    public string Company { get; set; } = "";
    public string Role { get; set; } = "";
    public string Status { get; set; } = "";
    public string? JobPostingUrl { get; set; }
    public string? Notes { get; set; }
    public DateTime DateApplied { get; set; } = DateTime.Today;
}