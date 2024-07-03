
namespace Services
{
    public class SecuenciaService
    {
        public static void SecuenciaLetras()
        {
            string[] abecedario = {// se crea un arreglo para poder almacenar el abecedario
                "a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m",
                "n", "ñ", "o", "p", "q", "r", "s", "t", "u", "v", "w", "x", "y","z"
            };

            // Generar la secuencia
            for (int i = 0; i < abecedario.Length; i++)
            {
                Console.Write(abecedario[i] + " "); // Imprimir a-z

            }
            Console.WriteLine();
            for (int i = 0; i < abecedario.Length; i++)
            {

                for (int j = 0; j < abecedario.Length; j++)
                {
                    Console.Write($"{abecedario[i]}{abecedario[j]}" + " "); // Imprimir aa-zz 
                }
            }
            Console.WriteLine();
        }
    }
}
