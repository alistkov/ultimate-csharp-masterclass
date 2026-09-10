var nums = new List<int> { 2, 3, 4, 5, 6 };

AddOneToList(ref nums);

// foreach (var num in nums)
// {
//     Console.WriteLine(num);
// }

Console.ReadKey();

void AddOneToList(ref List<int> numbers)
{
    // numbers.Add(1);
    numbers = null;
}