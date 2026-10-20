using System.Text.Json;
using WestCoastEducation.Interfaces;
using WestCoastEducation.Models;

namespace WestCoastEducation.Services;

public class JsonCourseStorage : ICourseStorage
{
    private string _filepath = "coruse.json";
    public List<Course> LoadCourses()
    {
        throw new NotImplementedException();
    }

    public void SaveCourses(List<Course> courses)
    {
       string json = JsonSerializer.Serialize(courses);
       File.WriteAllText(_filepath, json);
    }
}
