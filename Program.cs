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

        var student = new Student("Anders", "Svensson", "20070918", "0784563476", "41832", "Höstvädersgatan", "Göteborg");
        Console.WriteLine(student);
        
        
        course.AddStudent(student);
        course.AddStudent(student);
        Console.WriteLine(course.Students.Count);

        course.ListStudents();
        


        
       
    }
}
