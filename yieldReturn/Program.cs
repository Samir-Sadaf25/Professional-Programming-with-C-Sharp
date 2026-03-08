using YeildReturn;

class Program
{
    static void Main(string[] args)
    {
        ProcessPeople();
    }
    public static void ProcessPeople()
    {
        var people = GetPeople(10000000);
        foreach(var person in people)
        {
            if (person.Id < 100000)
            {
                Console.WriteLine($"Id : {person.Id} Name: {person.Name}");
            }
            else
                break;
        }

    }
    static IEnumerable<Person> GetPeople(int count)
    {
       
        for (int i = 0; i < count; i++)
        {
            yield return new Person() { Id = i, Name = $"Name {i}" };
        }
        
    }
}



