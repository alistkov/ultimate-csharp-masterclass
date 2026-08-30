var employees = new List<Employee>
{
    new Employee("Piter Parker", "Space navigation", 25000),
    new Employee("Steve Rodgers", "Space navigation", 29800),
    new Employee("Toni Stark", "Xenobiology", 21500),
    new Employee("Bruce Banner", "Xenobiology", 22000),
    new Employee("Natasha Romanov", "Mechanics", 21000),
    new Employee("Thor", "Mechanics", 20000),
};

var result = CalculateAverageSalaryPerDepartment(employees);
Console.WriteLine(result);

Dictionary<string, decimal> CalculateAverageSalaryPerDepartment(IEnumerable<Employee> employees)
{
    var employeesPerDepartments = new Dictionary<string, List<Employee>>();

    foreach (var employee in employees)
    {
        var employeeDepartment = employee.Department;
        if (!employeesPerDepartments.ContainsKey(employeeDepartment))
        {
            employeesPerDepartments[employeeDepartment] = new List<Employee>();
        }

        employeesPerDepartments[employeeDepartment].Add(employee);
    }

    var averageSalaryByDepartment = new Dictionary<string, decimal>();

    foreach (var employeesPerDepartment in employeesPerDepartments)
    {
        decimal sumOfDepartment = 0;

        foreach (var employee in employeesPerDepartment.Value)
        {
            sumOfDepartment += employee.MonthlySalary;
        }

        var average = sumOfDepartment / employeesPerDepartment.Value.Count;

        averageSalaryByDepartment[employeesPerDepartment.Key] = average;
    }

    return averageSalaryByDepartment;
}

public class Employee(string name, string department, decimal monthlySalary)
{
    public string Name { get; init; } = name;
    public string Department { get; init; } = department;
    public decimal MonthlySalary { get; init; } = monthlySalary;
}