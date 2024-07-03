

namespace Services
{
    public class FibonacciServices
    {
        public static void SerieFibonacci()
        {
            int n = 20; // numeros de terminos de la serie fibonacci a imprimir
            for (int i = 0; i <= n; i++) //se coloca la condicion que solo se repita n veces
            {
                Console.Write(FibonacciRecursivo(i) + " "); // se le asigna el valor de i al metodo FibonacciRecursivo
            }
            Console.WriteLine();
        }

        public static int FibonacciRecursivo(int a)
        {
            if (a <= 1)
            {
                return a;//mientas el valor de de a que recibe en el parametro sea menor o igual a uno se retornara
            }
            else// cuando el valor de a amente a despues de 1 se realisara una resta 
            {
                return FibonacciRecursivo(a - 1) + FibonacciRecursivo(a - 2); // se resta el primer valor y el segundo, retornando el valor de esa suma
            }
        }
    }
}
