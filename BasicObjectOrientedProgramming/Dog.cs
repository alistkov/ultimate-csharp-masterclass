namespace BasicObjectOrientedProgramming;

public class Dog
{
    private readonly string _name;
    private readonly string _breed;
    private readonly int _weight;

    public Dog(string name, string breed, int weight)
    {
        _name = name;
        _breed = breed;
        _weight = weight;
    }

    public Dog(string name, int weight)
    {
        _name = name;
        _breed = "mixed-breed";
        _weight = weight;
    }

    public string Describe() =>
        $"This dog is named {_name}, it's a {_breed}, and it weighs {_weight} kilograms, so it's a {CalculateWidthDescription()} dog.";


    private string CalculateWidthDescription()
    {
        return _weight switch
        {
            < 5 => "tiny",
            < 30 => "medium",
            _ => "large"
        };
    }
}