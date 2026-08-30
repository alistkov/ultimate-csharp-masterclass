ProcessString process1 = TrimTo5Letters;
ProcessString process2 = ToUpper;
Console.WriteLine(process1("helloooooo!"));
Console.WriteLine(process2("helloooooo!"));

string TrimTo5Letters(string input)
{
    return input.Substring(0, 5);
}

string ToUpper(string input)
{
    return input.ToUpper();
}

delegate string ProcessString(string input);