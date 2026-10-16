using System;


namespace WestCoastEducation.Models;

public class Teacher: Person //Ärver från Person...
{
    public string? KnowledgeArea {get; set;}
    public List<Course> Courses{get; set;} = new List<Course>();

}
