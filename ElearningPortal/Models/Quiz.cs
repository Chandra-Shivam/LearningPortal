using System.ComponentModel.DataAnnotations.Schema;

namespace ElearningPortal.Models;

public class Quiz
{
    public int Id { get; set; }
    public required string Question { get; set; }
    public required string Answer { get; set; }
    [NotMapped]
    public string? SubmittedAnswer { get; set; }
    public required int CourseId { get; set; }
    public Course? Course { get; set; }
}
