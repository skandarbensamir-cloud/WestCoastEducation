using WestCoastEducation.Enums;
using WestCoastEducation.Models;
namespace WestCoastEducation;
using WestCoastEducation.Interfaces;
using WestCoastEducation.Services;

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
        

        var student = new Student("Anders", "Svensson", "20070918", "0784563476", "41832", "Storvadersgatan", "Goteborg");
        course.AddStudent(student);

        var student2 = new Student("Lisa", "Persson", "20070817", "0798765467", "41105", "Tuvegatan", "Goteborg");
        course.AddStudent(student2);
        
        var student3 = new Student("Lucas", "Gomes", "20000212", "0704686967", "44230", "StoraTorget", "Kungalv");
        course.AddStudent(student3);
        
        var teacher = new Teacher("Hjalmar", "Nilsson", "19770436", "0704686977", "42355", "Regnstamsgatan", "Goteborg", "Programming");
        teacher.AddCourse(course);
        
        ICourseStorage storage = new JsonCourseStorage();

        // Shows staff - each class buuilds on it's parent's ToString 
        Console.WriteLine("\n---staff---");
        Console.WriteLine(teacher);

        var manager = new EducationManager("Maria", "fredriksson", "19800512", "0709876543", "41309", "Drottningsgatan", "Goteborg", "Education", new DateTime(2020, 3 , 1));
        Console.WriteLine(manager);

        var admin = new Administrator("Erik", "Larsson", "19740116", "0786334576", "41799", "Hisingsgatan", "Goteborg", "Administration", new DateTime(2018, 7 , 2));
        Console.WriteLine(admin);
        
        // Show all courses the teacher is responsible for
        Console.WriteLine("\n---Courses---");
        teacher.ListCourses();
        
        // Lists every student registered in the course
        Console.WriteLine("\n---Students---");
        course.ListStudents();
        
        // Tries to add the same student again
        Console.WriteLine("\n---Duplicate test---");
        course.AddStudent(student);
        
        // Saves the teacher's courses to a JSON file and loads them back through the ICourseStorage interFace
        Console.WriteLine("\n---Save & Load JSon");
        storage.SaveCourses(teacher.Courses);
        Console.WriteLine("Course saved");

        var Loadcourse1 = storage.LoadCourses();
        Console.WriteLine($"Loaded {Loadcourse1.Count} courses");
    
        
        
        
     }
}
