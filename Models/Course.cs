using WestCoastEducation.Enums;
namespace WestCoastEducation.Models;

public class Course
{
//Properties...
public string? CourseNumber{get; set;}
public int Length {get; set;}
public string? CourseTitle{get; set;}
public DateTime StartDate {get; set;}
public DateTime EndDate {get; set;}
public CourseType CourseType{get; set;}
 
//Constructor ...
public Course(string courseTitle)
    {
        CourseTitle = courseTitle;
    }
    
}

