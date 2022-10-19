using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IParcial_Progra2_Jose_Chan
{
    class Motocicleta : Tipo
    {
        //Métodos
        public Motocicleta() { }
        public new virtual void tipoVehiculos() { Console.WriteLine("Vehículo de dos ruedas"); }
    }
}
