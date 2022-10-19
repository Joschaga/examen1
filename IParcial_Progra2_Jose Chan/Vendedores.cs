using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IParcial_Progra2_Jose_Chan
{
    public class Vendedores
    {
        //Diccionario
        Dictionary<int, string> vendedor = new Dictionary<int, string>()
        {
          {1, "Jose Chan"},
          {2, "Alexander Curling"}
        };
        
        //Constructor en blanco
        public Vendedores() { }

        //Métodos
        public void listadoVendedores()
        {
            foreach (var item in vendedor)
            {
                Console.WriteLine($"Llave: {item.Key} Nombre: {item.Value}");
            }
        }

        //Función String
        /*string resultado = "";
        if (vendedor.TryGetValue(1, out resultado))
        {
            Console.WriteLine(resultado);
        }
        else
        {
            Console.WriteLine(resultado);
        }
        Console.Read();*/
    }
}
