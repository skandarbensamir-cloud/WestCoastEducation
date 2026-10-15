namespace WestCoastEducation;

class Program
{
    static void Main()
    {
        Console.WriteLine("Welcome to WestCoastEducation");
        Course course = new Course("C# Basics");
        Console.WriteLine(course.CourseTitle);
    }
}
