Console.WriteLine("Hello!");

bool shouldExit = false;
var todos = new List<string>();

while (!shouldExit)
{
    Console.WriteLine("What do you want to do?");
    Console.WriteLine("[S]ee all TODOs");
    Console.WriteLine("[A]dd a TODO");
    Console.WriteLine("[R]emove a TODO");
    Console.WriteLine("[E]xit");

    var userChoice = Console.ReadLine();

    switch (userChoice)
    {
        case "S":
        case "s":
            Console.WriteLine("See all TODOs");
            break;
        case "A":
        case "a":
            AddTodo();
            break;
        case "R":
        case "r":
            Console.WriteLine("Remove a TODO");
            break;
        case "E":
        case "e":
            Console.WriteLine("Exit");
            shouldExit = true;
            break;
        default:
            Console.WriteLine("Invalid choice");
            break;
    }
}

void AddTodo()
{
    bool isValidDescription = false;

    while (!isValidDescription)
    {
        Console.WriteLine("Enter the TODO description");
        var description = Console.ReadLine();

        if (description == "")
        {
            Console.WriteLine("The description cannot be empty");
        }
        else if (todos.Contains(description))
        {
            Console.WriteLine("The description must be unique");
        }
        else
        {
            todos.Add(description);
            isValidDescription = true;
        }
    }
}