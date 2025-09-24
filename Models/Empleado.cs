namespace GestiorEmpleados.Models;

public class Empleado
{
    public Guid Id { get; set; }
    public string Nombre { get; set; }
    public string Apellido { get; set; }
    public string NumeroDeIdentificacion { get; set; }
    public byte Edad { get; set; }
    public string Posicion { get; set; }
    public double Salario { get; set; }


    private void CalcularBonificacion()
    {
        var bono = Salario * 0.10;
        Salario += bono;
    }

    public void MostrarInformacion()
    {
        Console.WriteLine($"ID: {Id}");
        Console.WriteLine($"Nombre: {Nombre} {Apellido}");
        Console.WriteLine($"Número de Identificación: {NumeroDeIdentificacion}");
        Console.WriteLine($"Edad: {Edad}");
        Console.WriteLine($"Posición: {Posicion}");
        Console.WriteLine($"Salario: {CalcularBonificacion:C}");
    }
}
