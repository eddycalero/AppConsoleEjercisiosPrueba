
using Commons;

namespace Services
{
    public class CalculoAlumnoService
    {

        public static void CalcularAsignaturas(double calif1, double calif2, double calif3, double calif4, double calif5)
        {

            double porcentajeAprobacion = CalcularPorcentajeAprobacion(calif1, calif2, calif3, calif4, calif5);

            // Determinar si el alumno está aprobado o suspenso
            if (porcentajeAprobacion >= 60.0)
            {
                Console.WriteLine($"El alumno está APROBADO. {porcentajeAprobacion}");
            }
            else
            {
                Console.WriteLine($"El alumno está SUSPENDIDO.{porcentajeAprobacion}");
            }
        }

        // Función para calcular el porcentaje de aprobación
        static double CalcularPorcentajeAprobacion(double calif1, double calif2, double calif3, double calif4, double calif5)
        {
            // Calcular el porcentaje contando las tres primeras materias al 100%, y las dos últimas al 50%
            double porcentajeAprobacion = (calif1 + calif2 + calif3 + calif4 + calif5 * 0.5) / 5.0;

            return porcentajeAprobacion; // Retorna el porcentaje promedio
        }

    
    }
}

