
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

 //Console.WriteLine(employee1);


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
//Console.WriteLine(employee2);


Employee employee3 = new HourlyEmployee()
{
    Id = 3030,
    FirstName = "Gonzalo",
    LastName = "Cardona",
    BirthDate = new Date(1980, 5, 23),
    HiringDate = new Date(2022, 2, 5),
    IsActive = true,
    Hours = 123.5F,
    HourValue = 12356.56M
};

//Console.WriteLine(employee3);


Employee employee4 = new BaseCommissionEmployee()
{
    Id = 4040,
    FirstName = "Jazmin",
    LastName = "Salazar",
    BirthDate = new Date(1955, 5, 30),
    HiringDate = new Date(2021, 8, 9),
    IsActive = true,
    Base = 860678.45M,
    Sales = 58000000M,
    CommssionPercentaje = 0.015F
};


//Console.WriteLine(employee4);

ICollection<Employee> employees = new List<Employee>() 
{ 
   employee1, employee2, employee3, employee4 
};

decimal payroll = 0;

foreach (Employee employee in employees)
{
    Console.WriteLine(employee);
    payroll += employee.GetValueToPay();
}


Console.WriteLine("                               ===============");
Console.WriteLine($"TOTAL                          {$"{payroll:C2}",15}");


Invoice invoice = new Invoice()
{
    Id = 1,
    Description = "Iphone 13",
    Price = 5300000M,
    Quantity = 6
};

Invoice invoice2 = new Invoice()
{
    Id = 2,
    Description = "Posta Premium",
    Price = 32000M,
    Quantity = 17.5F
};

Console.WriteLine(invoice);
Console.WriteLine(invoice2);