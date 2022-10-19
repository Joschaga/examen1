using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IParcial_Progra2_Jose_Chan
{
    internal class Tipo : Vehiculos
    {
        //Lista
        List<string> tipoVehiculo_list = new List<string>()
        {
            "Motocicleta", "Automóvil", "Dron"
        };

        //Métodos
        public void tipoVehiculos()
        {
            Console.WriteLine("Existen diferentes tipos de vehículos");
            Console.ReadLine();
        }

        public static void listadoVehiculos()
        {
            int i = 0;
            Console.WriteLine("ATENCIÓN - Debe realizar las búsquedas con el número de código!");
            if (i < 5)
            {
                cod[i] = Console.ReadLine();
                if (cod.Length == 0)
                {
                    Console.WriteLine($"El vehículo existe");
                }
                else
                {
                    Console.WriteLine($"El Vehículo no ha sido encontrado, código incorrecto, por favor verifique su código");
                }
            }
            Console.ReadLine();
            i++;
        }
    }
}
