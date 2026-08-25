namespace UltimateCourse;

public class Person
{
    public string Name { get; }
    public int YearOfBirth { get; }


    public Person(string name, int yearOfBirth)
    {
        switch (name)
        {
            case null:
                throw new ArgumentNullException(nameof(name));
            case "":
                throw new ArgumentException("The name cannot be empty");
        }

        if (yearOfBirth < 1900 || yearOfBirth > DateTime.Now.Year)
        {
            throw new ArgumentOutOfRangeException(nameof(yearOfBirth));
        }

        Name = name;
        YearOfBirth = yearOfBirth;
    }
}