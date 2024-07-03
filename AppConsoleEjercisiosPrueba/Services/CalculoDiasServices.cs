
namespace Services
{
    public static class CalculoDiasServices
    {
        public static void CalculoDias(string fechaNacimientoInput)
        {
         

            // Convertir la cadena de fecha de nacimiento en un objeto DateTime
            DateTime fechaNacimiento;
            if (DateTime.TryParseExact(fechaNacimientoInput, "dd/MM/yyyy", null, System.Globalization.DateTimeStyles.None, out fechaNacimiento))
            {
                // Obtener la fecha actual
                DateTime fechaActual = DateTime.Now;

                // Calcular la diferencia en días
                TimeSpan diferencia = fechaActual - fechaNacimiento;
                int diasVividos = (int)diferencia.TotalDays;

                ConsolePrint.Print($"Has vivido {diasVividos} días.");
            }
            else
            {
                ConsolePrint.Print("Formato de fecha no válido. Por favor, usa el formato dd/MM/yyyy.");
            }
        }
    }
}
