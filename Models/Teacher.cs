using System;


namespace WestCoastEducation.Models;

public class Teacher: Person //Ärver från Person...
{
    public string? KnowledgeArea {get; set;}
    public List<Course> Courses{get; set;} = new List<Course>();
    
    public Teacher(string firstName, string lastName, string personIdentityNumber, string phoneNumber, string postalCode, string address, string city, string knowledgeArea)
    
    :base(firstName, lastName, personIdentityNumber, phoneNumber, postalCode, address, city)
    {
        KnowledgeArea = knowledgeArea;
    }

        

}
