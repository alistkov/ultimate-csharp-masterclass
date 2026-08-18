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
            SeeAllTodos();
            break;
        case "A":
        case "a":
            AddTodo();
            break;
        case "R":
        case "r":
            RemoveTodo();
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

void SeeAllTodos()
{
    if (todos.Count == 0)
    {
        Console.WriteLine("No TODOs have been added yet.");
        return;
    }
    for (var i = 0; i < todos.Count; i++)
    {
        Console.WriteLine($"{i + 1}. {todos[i]}");
    }
}

void RemoveTodo()
{
    if (todos.Count == 0)
    {
        Console.WriteLine("No TODOs have been added yet.");
        return;
    }

    bool isIndexValid = false;
    
    Console.WriteLine("Select the index of the TODO you want to remove");
    SeeAllTodos();

    while (!isIndexValid)
    {
        var userInput = Console.ReadLine();

        if (userInput == "")
        {
            Console.WriteLine("Selected index cannot be empty");
        }

        if (int.TryParse(userInput, out int index) && index >= 1 && index <= todos.Count)
        {
            var indexOfTodo = index - 1;
            var todoToBeRemoved = todos[indexOfTodo];
            todos.RemoveAt(indexOfTodo);
            isIndexValid = true;
            Console.WriteLine($"TODO removed: {todoToBeRemoved}");
        }
        else
        {
            Console.WriteLine("The given index is not valid");
        }
    }
    
}