using System.Globalization;

namespace Laboration_4;

public static class PeopleFunctions
{
    public static object AddPerson()
    {
        bool validChoice = false;
        bool loopAddPeople = false;
        DateTime birthDate = DateTime.MinValue;
        bool validDate = false;
        string firstName = string.Empty;
        string lastName = string.Empty;
        Gender gender = Gender.Other;
        Hair hair = new Hair();
        
        Console.Clear();
        
        Console.Write("Ange personens förnamn: ");
        firstName = Console.ReadLine();

        Console.Write("Ange personens efternamn: ");
        lastName = Console.ReadLine();
        
        Console.Clear();

        while (!validChoice)
        {
            Console.Write("Ange personens Kön; \n1: Man \n2: Kvinna \n3: Icke-binär \n4: Annat ");
            Console.WriteLine();
            
            try
            {
                int choiceOfGender = Convert.ToInt32(Console.ReadLine());
                switch (choiceOfGender)
                {
                    case 1:
                        gender = Gender.Male;
                        validChoice = true;
                        break;
                    case 2:
                        gender = Gender.Female;
                        validChoice = true;
                        break;
                    case 3:
                        gender = Gender.NonBinary;
                        validChoice = true;
                        break;
                    case 4:
                        gender = Gender.Other;
                        validChoice = true;
                        break;
                    default:
                        validChoice = false;
                        Console.Clear();
                        Console.WriteLine("Ange ett nummer 1-4 tack!");
                        continue;
                }
            }
            catch (FormatException)
            {
                Console.Clear();
                Console.WriteLine("Ange ett nummer 1-4 tack!");
            }
        }
        
        Console.Clear();
        validChoice = false;
        
        while (!validChoice)
        {
            Console.Write("Ange personens hårfärg; \n1: Svart \n2: Brunt \n3: Blont \n4: Rött \n5: Vitt/grått \n6: Annat ");
            Console.WriteLine();
            
            try
            {
                int choiceOfHairColor = Convert.ToInt32(Console.ReadLine());
                switch (choiceOfHairColor)
                {
                    case 1:
                        hair.Color = "Svart";
                        validChoice = true;
                        break;
                    case 2:
                        hair.Color = "Brunt";
                        validChoice = true;
                        break;
                    case 3:
                        hair.Color = "Blont";
                        validChoice = true;
                        break;
                    case 4:
                        hair.Color = "Rött";
                        validChoice = true;
                        break;
                    case 5:
                        hair.Color = "Vitt/grått";
                        validChoice = true;
                        break;
                    case 6:
                        hair.Color = "Annat";
                        validChoice = true;
                        break;
                    default:
                        validChoice = false;
                        Console.Clear();
                        Console.WriteLine("Ange ett nummer 1-6 tack!");
                        continue;
                }
            }
            catch (FormatException)
            {
                Console.Clear();
                Console.WriteLine("Ange ett nummer 1-6 tack!");
            }
        }
        
        Console.Clear();
        validChoice = false;
        
        while (!validChoice)
        {
            Console.Write("Ange personens hårlängd; \n1: Kort \n2: Medium \n3: Långt");
            Console.WriteLine();
            
            try
            {
                int choiceOfHairLenght = Convert.ToInt32(Console.ReadLine());
                switch (choiceOfHairLenght)
                {
                    case 1:
                        hair.Lenght = "Kort";
                        validChoice = true;
                        break;
                    case 2:
                        hair.Lenght = "Medium";
                        validChoice = true;
                        break;
                    case 3:
                        hair.Lenght = "Långt";
                        validChoice = true;
                        break;
                    default:
                        validChoice = false;
                        Console.Clear();
                        Console.WriteLine("Ange ett nummer 1-3 tack!");
                        continue;
                }
            }
            catch (FormatException)
            {
                Console.Clear();
                Console.WriteLine("Ange ett nummer 1-3 tack!");
            }
        }
        
        Console.Clear();
        
        while (!validDate)
        {
            Console.Write("Ange personen födelsedatum (ÅÅÅÅMMDD):");
            string input = Console.ReadLine();
            
            validDate = DateTime.TryParseExact
            (
                input,
                "yyyyMMdd",
                CultureInfo.InvariantCulture,
                DateTimeStyles.None,
                out birthDate
            );
            if (!validDate)
            {
                Console.Clear();
                Console.WriteLine("Fel format, ange ett födelsedatum i formatet: ÅÅÅÅMMDD");
            }
            else
            {
                validDate = true;
                
            }
        }
        
        Console.Clear();
        
        Person person = new Person(hair, gender, birthDate, firstName, lastName);
        
        Console.Clear();
        Console.WriteLine("Personen tillagd: {0} {1} \nKön: {2} \nHår: {3}, {4}\nFödelsedatum: {5}\n", person.FirstName, person.LastName, person.Gender, person.Hair.Color, person.Hair.Lenght, person.DateOfBirth);
        Console.WriteLine("Tryck på enter för att gå vidare");
        Console.ReadLine();

        return person;
    }
    public static void ListPersons(List<Person> peopleList)
    {
        Console.Clear();
        
        if (peopleList.Count == 0)
        {
            Console.Clear();
            Console.WriteLine("Inget på listan");
        }
        else
        {
            Console.WriteLine("Dessa personer finns med på listan:");
            foreach (Person person in peopleList)
            {
                Console.WriteLine(person.FirstName + " " + person.LastName + " | Kön: " + person.Gender + " | Född: " + person.DateOfBirth + " | Hår: " + person.Hair.Lenght + ", " + person.Hair.Color);
                Console.WriteLine();
            }
        }
    }
}

    