try
{
    var result = GetFirstElement(Array.Empty<int>());
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}


int GetFirstElement(IEnumerable<int> numbers)
{
    foreach (var number in numbers)
    {
        return number;
    }

    throw new Exception("The collection cannot be empty");
}