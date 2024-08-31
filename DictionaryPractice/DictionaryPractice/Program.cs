var employees = new List<Employee>
{
    new Employee("Jacke Smith", "Space Navigation", 25000),
    new Employee("Anna Blake", "Space Navigation", 29000),
    new Employee("Barbara Oak", "Xenobiology", 21500),
    new Employee("Damien Parker", "Xenobiology", 22000),
    new Employee("Nisha Patel", "Machanics", 21000),
    new Employee("Gustavo Sanchez", "Machanics", 20000),
};

var result = CalculateAverageSalaryPerDepartment(employees);

Console.ReadKey();

Dictionary<string, decimal> CalculateAverageSalaryPerDepartment(IEnumerable<Employee> employees)
{
    var employeesPerDepartments = new Dictionary<string, List<Employee>>();

    foreach (var employee in employees)
    {
        if(!employeesPerDepartments.ContainsKey(employee.Department))
        {
            employeesPerDepartments[employee.Department] = new List<Employee>();
        }

        employeesPerDepartments[employee.Department].Add(employee);
    }

    var result = new Dictionary<string, decimal>();

    foreach (var employeesPerDepartment in employeesPerDepartments)
    {
        decimal sumOfSalaries = 0;

        foreach (var employee in employeesPerDepartment.Value)
        {
            sumOfSalaries += employee.MonthlySalary;
        }

        var average = sumOfSalaries / employeesPerDepartment.Value.Count;

        result[employeesPerDepartment.Key] = average;
    }

     return result;
}

public class Employee(string name, string department, decimal monthlySalary)
{
    public string Name { get; set; } = name;
    public string Department { get; set; } = department;
    public decimal MonthlySalary { get; set; } = monthlySalary;
}