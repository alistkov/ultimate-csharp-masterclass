bool flag = true;
Person person = new Person();

if (flag)
{
    string textInsideIf = "asdasf";
    person.Name = "John";
}

string text = "bbb";

Console.ReadKey();


class Person
{
    public string Name { get; set; }
    public int Age { get; set; }
}