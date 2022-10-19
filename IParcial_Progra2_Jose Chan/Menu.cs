using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace IParcial_Progra2_Jose_Chan
{
    public static class Menu
    {
        static Menu() { }

        public static void menuPrincipal()
        {
            int seleccion = 0;
            do
            {
                Console.WriteLine("****Menú Principal****");
                Console.WriteLine("1 --> Vehículos");
                Console.WriteLine("2 --> Ventas");
                Console.WriteLine("3 --> Reportes");
                Console.WriteLine("4 --> Salir");
                Console.WriteLine("Digite una opción");
                seleccion = int.Parse(Console.ReadLine());

                switch (seleccion)
                {
                    case 1: subMenuVehiculos(); break;
                    case 2: Vehiculos.facturacion(); break;
                    case 3: Vehiculos.reportes(); break;
                    case 4: break;

                    default:
                        Console.WriteLine("No digitó una opción valida, vuelva a ingresar una opción");
                        Console.WriteLine("Presione cualquier tecla para continuar");
                        Console.Read();
                        break;

                }
            } while (seleccion != 4);
        }

        public static void subMenuVehiculos()
        {
            int seleccion = 0;
            do
            {
                Console.WriteLine("****Menú Vehículos****");
                Console.WriteLine("1 --> Agregar");
                Console.WriteLine("2 --> Modificar");
                Console.WriteLine("3 --> Consultar");
                Console.WriteLine("4 --> Salir");
                Console.WriteLine("Digite una opción");
                seleccion = int.Parse(Console.ReadLine());

                switch (seleccion)
                {
                    case 1: Vehiculos.agregarVehiculo(); break;
                    case 2: Vehiculos.modificarVehiculo(); break;
                    case 3: Vehiculos.consultarVehiculo(); break;
                    case 4: break;

                    default:
                        Console.WriteLine("No digitó una opción valida, vuelva a ingresar una opción");
                        Console.WriteLine("Presione cualquier tecla para continuar");
                        Console.Read();
                        break;

                }
            } while (seleccion != 4);
        }
    }
}
