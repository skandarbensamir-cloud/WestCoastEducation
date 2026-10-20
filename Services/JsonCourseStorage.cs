using System.Text.Json;
using WestCoastEducation.Interfaces;
using WestCoastEducation.Models;

namespace WestCoastEducation.Services;

public class JsonCourseStorage : ICourseStorage
{
    private string _filepath = "courses.json";
    public List<Course> LoadCourses()
    {
        if (!File.Exists(_filepath))
        {
            return new List<Course>();
        }
        
        
        
        string json = File.ReadAllText(_filepath);
        return JsonSerializer.Deserialize<List<Course>>(json) ?? new List<Course>();
        

    }

    public void SaveCourses(List<Course> courses)
    {
       var options = new JsonSerializerOptions {WriteIndented = true};
       string json = JsonSerializer.Serialize(courses, options);
       File.WriteAllText(_filepath, json);
    }
}
