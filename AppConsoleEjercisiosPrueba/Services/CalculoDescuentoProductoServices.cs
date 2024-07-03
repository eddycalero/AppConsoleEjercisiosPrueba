

namespace Services
{
    public class CalculoDescuentoProductoServices
    {
        double PrecioProducto = 0;
        double DescuentoProducto = 0;
        public CalculoDescuentoProductoServices(double precioProducto, double descuentoProducto)
        {

            this.PrecioProducto = precioProducto;
            this.DescuentoProducto = descuentoProducto;

        }
        public void CalcularDescuento()
        {
            double Respuesta =  (DescuentoProducto / 100) * PrecioProducto;
            double NuevoPrecio = PrecioProducto - DescuentoProducto;
            ConsolePrint.Print($"Precio con descuento:{NuevoPrecio}");

        }
    }
}
