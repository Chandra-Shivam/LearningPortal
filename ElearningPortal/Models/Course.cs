namespace ElearningPortal.Models;

public class Course
{
    public int Id { get; set; }
    public required string Title { get; set; }
    public required string Description { get; set; }
    public string? VideoUrl { get; set; }
    public required int CategoryId { get; set; }
    public Category? Category { get; set; }
    public ICollection<Enrollment>? Enrollments { get; set; }
    public ICollection<Quiz>? Quizzes { get; set; }
}
