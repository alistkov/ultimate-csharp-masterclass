using UltimateCourse;

var invalidPerson = new Person("Sam", -100);

var emptyCollection = new List<int>();
var firstElement = GetFirstElement(Array.Empty<int>());
var firstUsingLinq = emptyCollection.First();

var numbers = new int[] { 1, 2, 4 };

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
        throw new ArgumentNullException("The collection is null.", ex);
    }
}