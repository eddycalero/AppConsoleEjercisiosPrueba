

namespace Services
{
    public class CalculoOrdenNumerosServices
    {
        public CalculoOrdenNumerosServices() { }

        double[] Numeros = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15 };

        public void ImprimirOrden()
        {
            Console.WriteLine(string.Join(", ", Numeros));
            Array.Sort(Numeros);
            Array.Reverse(Numeros);
            Console.WriteLine(string.Join(", ", Numeros));

        }
    }
}
