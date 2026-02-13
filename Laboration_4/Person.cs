namespace Laboration_4;

public class Person
{
    public Hair Hair { get; set; }
    public Gender Gender { get; set; }
    public DateTime DateOfBirth { get; set; } 
    public string FirstName { get; set; } 
    public string LastName { get; set; } 

    public Person(Hair hair, Gender gender, DateTime dateOfBirth, string firstName, string lastName)
    {
        Hair = hair;
        Gender = gender;
        DateOfBirth = dateOfBirth;
        FirstName = firstName;
        LastName = lastName;
    }
}