using WestCoastEducation.Enums;
namespace WestCoastEducation.Models;

public class Course
{
//Properties...
public string CourseNumber{get; set;}
public int Length {get; set;}
public string CourseTitle{get; set;}
public DateTime StartDate {get; set;}
public DateTime EndDate {get; set;}
public CourseType CourseType{get; set;} //Denna property refererar till vår enum...
 
//Constructor ...
public Course(string courseTitle, int length, DateTime startDate, DateTime endDate, CourseType courseType, string courseNumber)
    {
        CourseTitle = courseTitle;
        Length = length;
        StartDate = startDate;
        EndDate = endDate;
        CourseType = courseType; 
        CourseNumber = courseNumber;
    }
    
}

