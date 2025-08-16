namespace ElearningPortal.Models;

public class Enrollment
{
    public int Id { get; set; }
    public required string UserId { get; set; }
    public ApplicationUser? User { get; set; }
    public required int CourseId { get; set; }
    public Course? Course { get; set; }
}
