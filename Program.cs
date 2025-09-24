using GestiorEmpleados.Models;

var empleado = new Empleado
{
    Id = Guid.NewGuid(),
    Nombre = "Juan",
    Apellido = "Pérez",
    NumeroDeIdentificacion = "123456789",
    Edad = 30,
    Posicion = "Desarrollador",
    Salario = 50000
};

var empleado2 = new Empleado
{
    Id = Guid.NewGuid(),
    Nombre = "María",
    Apellido = "Gómez",
    NumeroDeIdentificacion = "987654321",
    Edad = 28,
    Posicion = "Diseñadora",
    Salario = 45000
};