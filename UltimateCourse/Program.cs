using UltimateCourse;

try
{
    var result = IsFirstPositive(null);
}
catch (NullReferenceException ex)
{
    
}

int GetFirstElement(IEnumerable<int> numbers)
{
    foreach (var number in numbers)
    {
        return number;
    }

    throw new InvalidOperationException("The collection cannot be empty");
}

bool IsFirstPositive(IEnumerable<int> numbers)
{
    try
    {
        var first = GetFirstElement(numbers);
        return first > 0;
    }
    catch (InvalidOperationException ex)
    {
        Console.WriteLine("The collection is empty!");
        return true;
    }
    catch (NullReferenceException ex)
    {
        Console.WriteLine("Sorry! The application experienced an unexpected error");
        // throw;
        throw new ArgumentNullException("The collection is null.", ex);
    }
}