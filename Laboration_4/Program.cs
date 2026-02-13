using System.Globalization;

namespace Laboration_4;

class Program
{
    static void Main(string[] args)
    {
        List<Person> peopleList = new List<Person>();

        Person examplePerson = new Person(new Hair("svart","långt"), Gender.Female, DateTime.ParseExact("19990329", "yyyymmdd", CultureInfo.InvariantCulture), "Ellen", "Lindström");
        //peopleList.Add(examplePerson); Kommenterade ut detta för att visa att programmet reagerar när det saknas personer på listan
        
        bool runProgram = true;
        bool loopAddPeople = true;
        while (runProgram)
        {
            Console.Clear();
            Console.WriteLine("**********************************");
            Console.WriteLine("Välj alternativ:\n \n1: Lägg till ny person \n \n2: Se tillagda personer \n \n3: Avsluta programmet");
            Console.WriteLine("**********************************");
            string choice =  Console.ReadLine();
            switch (choice)
            {
                case "1":
                    while (loopAddPeople)
                    {
                        object newPerson = PeopleFunctions.AddPerson();
                        peopleList.Add(newPerson as Person);
                        
                        Console.WriteLine("Vill du lägga till en till person? \n1: ja\n2: nej");
                        try
                        {

                            int chooseLoopAddPeople = int.Parse(Console.ReadLine());

                            switch (chooseLoopAddPeople)
                            {
                                case 1:
                                    loopAddPeople = true;
                                    Console.Clear();
                                    break;
                                case 2:
                                    loopAddPeople = false;
                                    break;
                                default:
                                    loopAddPeople = false;
                                    continue;
                            }
                        }
                        catch (FormatException)
                        {
                            loopAddPeople = false;
                        }
                    }
                    
                    break;  
                case "2":
                    PeopleFunctions.ListPersons(peopleList);
                    Console.ReadKey();
                    break;
                case "3":
                    Console.WriteLine("Tack för att du har använt detta program");
                    runProgram = false;
                    break;
            }   
        }
    }
}