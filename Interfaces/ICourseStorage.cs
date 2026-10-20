using WestCoastEducation.Models;

namespace WestCoastEducation.Interfaces;

public interface ICourseStorage
{
    void SaveCourses(List<Course> courses);
    List<Course> LoadCourses();

}
