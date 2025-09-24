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




empleado.MostrarInformacion();


