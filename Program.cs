using System.ComponentModel.DataAnnotations;
using WestCoastEducation.Enums;
using WestCoastEducation.Models;
namespace WestCoastEducation;

class Program
{
    static void Main()
    {
        Console.WriteLine("===============================");
        Console.WriteLine("Welcome to WestCoastEducation");
        Console.WriteLine("===============================");
        
        DateTime startDate = new DateTime(2026, 8, 24);
        DateTime endDate = new DateTime(2028,6,17 );
        int length = 10;
        CourseType courseType = CourseType.Classroom;
        string courseNumber = ("NCD26");
        string courseTitle = ("C# Basics");
        var course = new Course(courseTitle, length, startDate, endDate, courseType, courseNumber);
        Console.WriteLine(course);

        
        Console.WriteLine(course.CourseTitle);
        Console.WriteLine(course.StartDate);
        Console.WriteLine(course.EndDate);
        Console.WriteLine(course.Length);
        Console.WriteLine(course.CourseType);
        Console.WriteLine(course.CourseNumber);
    }
}
