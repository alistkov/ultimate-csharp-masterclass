using UltimateCourse;

var invalidPerson = new Person("", -100);

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

    throw new Exception("The collection cannot be empty");
}