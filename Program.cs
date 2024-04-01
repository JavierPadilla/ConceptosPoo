// See https://aka.ms/new-console-template for more information
using ConceptosPoo;

Console.WriteLine("Hello, World!");
Console.WriteLine("Poo Concepts");
Console.WriteLine("=============");

//  Prueba de la Clase Date
try
{
    Console.WriteLine(new Date(2019, 12, 23));
    Console.WriteLine(new Date(2024, 2, 29));
}
catch (Exception error)
{

    Console.WriteLine(error.Message);
}

Console.WriteLine("\n");
// prueba da la clase Empleado-Asalariado
Empleado emp1 = new EmpleadoAsalariado()
{
    Id = 1010,
    FirstName = "Juan Javier",
    LastName = "Padilla Gonzalez",
    BirthDate = new Date(1989, 03, 04),
    HiringDate = new Date(2022, 03, 01),
    IsActive = true,
    Salario = 35000.0M
};
Console.WriteLine(emp1);
Empleado emp2 = new EmpleadoComission()
{
    Id = 1012,
    FirstName = "Karen Yuseth",
    LastName = "Plascencia Garcia",
    BirthDate = new Date(1990, 11, 29),
    HiringDate = new Date(2006, 03, 26),
    IsActive = true,
    ComissionPorcentaje = 0.03f,
    Sales = 3450123M
};
 Console.WriteLine(emp2);   


