
using ConceptsPOO;

Console.WriteLine("POO Conpcepts");
Console.WriteLine("==============");
Employee employee1 = new SalaryEmployee()
{
    Id = 1010,
    FirstName = "Sandra",
    LastName = "Morales",
    BirthDate = new Date(1990, 5, 23),
    HiringDate = new Date(2022, 1, 15),
    IsActive = true,
    Salary = 1815453.45m
};

Console.WriteLine(employee1);


Employee employee2 = new CommissionEmployee()
{
    Id = 2020,
    FirstName = "Patricia",
    LastName = "Gutierrez",
    BirthDate = new Date(1990, 5, 23),
    HiringDate = new Date(2022, 2, 5),
    IsActive = true,
    CommssionPercentaje = 0.03F,
    Sales = 65000000
};
Console.WriteLine(employee2);