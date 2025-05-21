namespace ScholarProject.DAL.Models;

public class Course : BaseModel
{
    public double Price { get; set; }
    public string ImgUrl { get; set; }
    public string Field { get; set; }

    public string TeacherName { get; set; }
    public string CourseName { get; set; }
}
