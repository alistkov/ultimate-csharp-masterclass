bool someCondition = false;

if (someCondition)
{
    var someClass = new SomeClass();
}

Console.WriteLine($"Count of all instances is now {SomeClass.CountOfInstances}");

Console.ReadKey();


public class SomeClass
{
    private static List<SomeClass> _allExistingInstanses = new List<SomeClass>();

    public SomeClass()
    {
        _allExistingInstanses.Add(this);
    }

    public static int CountOfInstances => _allExistingInstanses.Count;
}