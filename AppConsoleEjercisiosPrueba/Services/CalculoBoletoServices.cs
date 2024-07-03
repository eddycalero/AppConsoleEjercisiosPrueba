

namespace Services
{
    public static class CalculoBoletoServices
    {
        const double PORCENTAJE = 0.25;
        const double PRECIOBOLETO = 3.50;
       
        
        public static void AplicarDescuento(double kilometros, double dias)
        {
            double BoletoFinal = 0;

            if (kilometros <= 800 && dias >= 7)
            { double boleto = kilometros * PRECIOBOLETO;
               double descuento = PORCENTAJE * boleto;
                BoletoFinal = boleto - descuento ;
                ConsolePrint.Print($"Precio del Boleto: {boleto} Precio con Descuento: {BoletoFinal}");
            }
            else
            {
                BoletoFinal = kilometros * PRECIOBOLETO;
                ConsolePrint.Print($"Precio del Boleto: {BoletoFinal}");
            }

           

        }
    }
}
