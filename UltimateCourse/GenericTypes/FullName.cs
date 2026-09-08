namespace UltimateCourse.GenericTypes;

public class FullName : IComparable<FullName>
{
    public string FirstName { get; init; }
    public string LastName { get; init; }

    public int CompareTo(FullName other)
    {
        if (LastName == other.LastName)
        {
            if (FirstName.CompareTo(other.FirstName) > 0)
            {
                return 1;
            }

            if (FirstName.CompareTo(other.FirstName) < 0)
            {
                return -1;
            }

            return 0;
        }

        if (LastName.CompareTo(other.LastName) > 0)
        {
            return 1;
        }

        if (LastName.CompareTo(other.LastName) < 0)
        {
            return -1;
        }

        return 0;
    }

    public override string ToString() => $"{FirstName} {LastName}";
    
    //your code hoes here
}