using UltimateCourse;

var f1 = new FullName
{
    FirstName = "John",
    LastName = "Smith"
};
var f2 = new FullName
{
    FirstName = "Anna",
    LastName = "Smith"
};

var f3 = new FullName
{
    FirstName = "Kenji",
    LastName = "Narasaki"
};

var f4 = new FullName
{
    FirstName = "John",
    LastName = "Watson"
};


var fList = new List<FullName> { f1, f2, f3, f4 };
var sorted = new SortedList<FullName>(fList);

Console.ReadKey();

// var anna = new Person { Name = "Anna", YearOfBirth = 1980 };
// var john = new Person { Name = "John", YearOfBirth = 1915 };
//
// PrintInOrder(10, 5);
// PrintInOrder("aa", "bb");
// PrintInOrder(anna, john);
//

//
// void PrintInOrder<T>(T first, T second) where T: IComparable<T>
// {
//     if (first.CompareTo(second) > 0)
//     {
//         Console.WriteLine($"{second} {first}");
//     }
//     else
//     {
//         Console.WriteLine($"{first} {second}");
//     }
// }
//
// public class Person : IComparable<Person>
// {
//     public string Name { get; init; }
//     public int YearOfBirth { get; init; }
//
//     public override string ToString() => $"{Name} born in {YearOfBirth}";
//
//     public int CompareTo(Person other)
//     {
//         if (YearOfBirth < other.YearOfBirth)
//         {
//             return 1;
//         }
//
//         if (YearOfBirth > other.YearOfBirth)
//         {
//             return -1;
//         }
//
//         return 0;
//     }
// }