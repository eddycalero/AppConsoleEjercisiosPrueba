

namespace Services
{
    public class CalculoSalarioServices : DatosSalarioModels
    {
       
        public  double CalculoSueldoBasico(double horasTrabajadas, double tarifaHoraria)
        {
           return horasTrabajadas * tarifaHoraria;
        }  

        public  double CalculoSueldoBruto( double sueldoBasico)
        {
            return sueldoBasico * this.BONIFICACION;
        }

        public double CalculoSueldoNeto(double sueldoBruto)
        {
            return sueldoBruto * this.DESCUENTO;
        }

    }
}
