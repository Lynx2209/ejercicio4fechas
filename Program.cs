

class Program
{
    public static void Main()
    {
        // Solicitar la fecha de nacimiento al usuario
        Console.Write("Ingrese su fecha de nacimiento (formato YYYY-MM-DD): ");
        string fechaNacimientoStr = Console.ReadLine();

        // Convertir la cadena de fecha a un objeto DateTime
        DateTime fechaNacimiento = DateTime.ParseExact(fechaNacimientoStr, "yyyy-MM-dd", null);

        // Calcular la edad
        (int años, int meses, int dias) = CalcularEdad(fechaNacimiento);

        // Mostrar la edad
        Console.WriteLine("Su edad es: {años} años, {meses} meses y {dias} días.");
    }

    static (int años, int meses, int dias) CalcularEdad(DateTime fechaNacimiento)
    {
        // Obtener la fecha actual
        DateTime fechaActual = DateTime.Now;

        // Calcular la diferencia entre la fecha actual y la fecha de nacimiento
        TimeSpan edad = fechaActual - fechaNacimiento;

        // Obtener los años, meses y días de la diferencia de tiempo
        int años = edad.Days / 365;
        int meses = (edad.Days % 365) / 30;
        int dias = (edad.Days % 365) % 30;

        return (años, meses, dias);
    }
}
