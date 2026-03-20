namespace Laboration_4;

public class Person
{
    public Hair Hair { get; set; }
    public Gender Gender { get; set; }
    public DateTime DateOfBirth { get; set; } 
    public string FirstName { get; set; } 
    public string LastName { get; set; } 
    public string EyeColor { get; set; }

    public Person(Hair hair, Gender gender, DateTime dateOfBirth, string firstName, string lastName, string eyeColor)
    {
        Hair = hair;
        Gender = gender;
        DateOfBirth = dateOfBirth;
        FirstName = firstName;
        LastName = lastName;
        EyeColor = eyeColor;
    }

    public override string ToString()
    {
        return $"Namn: {FirstName} {LastName} | Kön: {Gender} | Född: {DateOfBirth} | Hår: {Hair.Lenght}, {Hair.Color} | Ögonfärg: {EyeColor}";
    }
}