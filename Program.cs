using WestCoastEducation.Enums;
using WestCoastEducation.Models;
namespace WestCoastEducation;

using Microsoft.VisualBasic;
using WestCoastEducation.Interfaces;
using WestCoastEducation.Services;

class Program
{
    static void Main()
    {
        DateTime startDate = new DateTime(2026, 8, 24);
        DateTime endDate = new DateTime(2028,6,17 );
        int length = 10;
        CourseType courseType = CourseType.Classroom;
        string courseNumber = ("NCD26");
        string courseTitle = ("C# Basics");
        var course = new Course(courseTitle, length, startDate, endDate, courseType, courseNumber);
        

        var student = new Student("Anders", "Svensson", "20070918", "0784563476", "41832", "Storvadersgatan", "Goteborg");
        course.AddStudent(student);

        var student2 = new Student("Lisa", "Persson", "20070817", "0798765467", "41105", "Tuvegatan", "Goteborg");
        course.AddStudent(student2);
        
        var student3 = new Student("Lucas", "Gomes", "20000212", "0704686967", "44230", "StoraTorget", "Kungalv");
        course.AddStudent(student3);
        
        var teacher = new Teacher("Hjalmar", "Nilsson", "19770436", "0704686977", "42355", "Regnstamsgatan", "Goteborg", "Programming");
        teacher.AddCourse(course);
        
        ICourseStorage storage = new JsonCourseStorage();
        
        while (true)
        {
        Console.WriteLine("===============================");
        Console.WriteLine("Welcome to WestCoastEducation");
        Console.WriteLine("===============================");
           
        Console.WriteLine("Press x to show courses");
        Console.WriteLine("Press s to show students");
        Console.WriteLine("Press v to save courses");
        Console.WriteLine("Press l to load courses");
        Console.WriteLine("Press Enter to exit the program");

        
       
        var choice = Console.ReadLine();

        switch (choice)
        {
            case "x":
            teacher.ListCourses();
            break;

            case "s":
            course.ListStudents();
            break;

            case "v":
            storage.SaveCourses(teacher.Courses);
            Console.WriteLine("Course saved");
            break;


            case "l":
            var LoadCourses1 = storage.LoadCourses();
            Console.WriteLine($"Loaded {LoadCourses1.Count} courses");
            break;

            case "":
            return;

        }

            

        }
       
       


       
        


        
       
    }
}
