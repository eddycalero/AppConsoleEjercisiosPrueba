

using Commons;

namespace Services
{
    public class MenuServicioServices
    {
        public static void MenudeOpciones()
        {
            bool salir = false;

            while (!salir)
            {
                try
                {

                    Console.WriteLine("***Binevenido**");
                    Console.WriteLine("1.Serie Fibonacci");
                    Console.WriteLine("2.Secuencia del abecedario");
                    Console.WriteLine("3.Descuento del boleto");
                    Console.WriteLine("4.Calculo del pago mensual");
                    Console.WriteLine("5.Aplicar Descuento a un Producto");
                    Console.WriteLine("6.Ordenar Numeros < a >");
                    Console.WriteLine("7.Calcular Dias vividos");
                    Console.WriteLine("8.Calcular calificacion de estudiante");
                    Console.WriteLine("9.Salir");
                    Console.WriteLine("Elige una de las opciones");
                    int opcion = Convert.ToInt32(Console.ReadLine());

                    switch (opcion)
                    {
                        case 1:
                            FibonacciServices.SerieFibonacci();
                            break;
                        case 2:
                            SecuenciaService.SecuenciaLetras();
                            break;
                        case 3:
                            try
                            {
                                Console.WriteLine("ingrese el numero de kilometraje");
                                int kilometro = Convert.ToInt32(Console.ReadLine());
                                Console.WriteLine("ingrese el numero de dias");
                                int dia = Convert.ToInt32(Console.ReadLine());
                                CalculoBoletoServices.AplicarDescuento(kilometro, dia);
                            }
                            catch (Exception e)
                            {
                                Console.WriteLine(e.Message);
                            }

                            break;
                        case 4:
                            CalculoSalarioServices d = new CalculoSalarioServices();
                            try
                            {
                                Console.WriteLine("ingrese Horas Laboradas");
                                double horasTrabajadas = Convert.ToInt32(Console.ReadLine());
                                Console.WriteLine("ingrese la Tarifa Horaria");
                                double tarifaHoraria = Convert.ToInt32(Console.ReadLine());
                                ConsolePrint.Print($"Calculo Sueldo Basico: {d.CalculoSueldoBasico(horasTrabajadas, tarifaHoraria)}");
                                ConsolePrint.Print($"Calculo Sueldo Bruto: {d.CalculoSueldoBruto(d.CalculoSueldoBasico(horasTrabajadas, tarifaHoraria))}");
                                ConsolePrint.Print($"Calculo Sueldo Neto: {d.CalculoSueldoNeto(d.CalculoSueldoBruto(d.CalculoSueldoBasico(horasTrabajadas, tarifaHoraria)))}");
                            }
                            catch (Exception e)
                            {
                                Console.WriteLine(e.Message);
                            }

                            break;
                        case 5:

                            try
                            {
                                Console.WriteLine("ingrese el precio del producto");
                                double PrecioProducto = Convert.ToInt32(Console.ReadLine());
                                Console.WriteLine("ingrese el descuento");
                                double Descuento = Convert.ToInt32(Console.ReadLine());
                                CalculoDescuentoProductoServices s = new CalculoDescuentoProductoServices(PrecioProducto, Descuento);
                                s.CalcularDescuento();
                            }
                            catch (Exception e)
                            {
                                Console.WriteLine(e.Message);
                            }

                            break;
                        case 6:
                            CalculoOrdenNumerosServices l = new CalculoOrdenNumerosServices();
                            l.ImprimirOrden();

                            break;
                        case 7:
                            ConsolePrint.Print("Introduce tu fecha de nacimiento (dd/MM/yyyy): ");
                            string date = Console.ReadLine();
                            CalculoDiasServices.CalculoDias(date); 

                            break;
                        case 8:
                            ConsolePrint.Print("ingrese Primera Calisificacion");
                            double nota1= Convert.ToInt32(Console.ReadLine());
                            ConsolePrint.Print("ingrese Segunda Calisificacion");
                            double nota2 = Convert.ToInt32(Console.ReadLine());
                            ConsolePrint.Print("ingrese Tercera Calisificacion");
                            double nota3 = Convert.ToInt32(Console.ReadLine());
                            ConsolePrint.Print("ingrese Cuarta Calisificacion");
                            double nota4 = Convert.ToInt32(Console.ReadLine());
                            ConsolePrint.Print("ingrese Quinta Calisificacion");
                            double nota5 = Convert.ToInt32(Console.ReadLine());


                            CalculoAlumnoService.CalcularAsignaturas(nota1,nota2,nota3,nota4,nota5);

                            break;
                        case 9:
                            Console.WriteLine("Has elegido la opción 9");
                            salir = true;

                            break;
                        default:
                            Console.WriteLine("Elige una opcion entre 1 y 9");
                            break;
                    }

                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }

            }
        }
    }
}

