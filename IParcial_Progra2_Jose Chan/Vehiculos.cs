using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace IParcial_Progra2_Jose_Chan
{
    public class Vehiculos
    {
        //Variables
        protected string codigo { get; set; }
        protected string marca { get; set; }
        protected int costo { get; set; }
        protected string modelo { get; set; }

        //Constructor
        public Vehiculos(string codigo, string marca, int costo, string modelo)
        {
            this.codigo = codigo;
            this.marca = marca;
            this.costo = costo;
            this.modelo = modelo;
        }

        //Constructor en blanco
        public Vehiculos() { }

        //Métodos
        string[] cod = new string[5];
        string[] mar = new string[5];
        int[] cost = new int[5];
        string[] mod = new string[5];
        int i = 0;

        public static void agregarVehiculo()
        {
            if (i < 5)
            {
                Console.WriteLine("Digite código del vehículo: "); codigo[i] = Console.ReadLine();
                Console.WriteLine("Digite marca del vehículo: "); mar[i] = Console.ReadLine();
                Console.WriteLine("Digite costo del vehículo: "); cost[i] = int.Parse(Console.ReadLine());
                Console.WriteLine("Digite modelo del vehículo: "); mod[i] = Console.ReadLine();

                Console.WriteLine($"Usted ha ingresado el vehículo: \n Código: {cod} \n Marca: {mar}  \n" +
                $"Costo: {cost}  \n modelo: {mod} ");
            }
            Console.ReadLine();
            i++;
        }

        public static void modificarVehiculo()
        {
            Console.WriteLine("ATENCIÓN - Debe realizar las búsquedas con el número de código!");
            if(i < 5)
            {
                cod[i] = Console.ReadLine();
                if (cod.Length == 0)
                {
                    Console.WriteLine($"Se encontró el vehículo: \n Código: {cod} \n Marca: {mar}  \n" +
                    $"Costo: {cost}  \n modelo: {mod} ");

                    Console.WriteLine("Digite código del vehículo: "); cod[i] = Console.ReadLine();
                    Console.WriteLine("Digite marca del vehículo: "); mar[i] = Console.ReadLine();
                    Console.WriteLine("Digite costo del vehículo: "); cost[i] = int.Parse(Console.ReadLine());
                    Console.WriteLine("Digite modelo del vehículo: "); mod[i] = Console.ReadLine();

                    Console.WriteLine($"Usted ha ingresado el vehículo: \n Código: {cod} \n Marca: {mar}  \n" +
                    $"Costo: {cost}  \n modelo: {mod} ");
                }
                else
                {
                    Console.WriteLine($"El Vehículo no ha sido encontrado, código incorrecto, por favor verifique su código");
                }
            }
            Console.ReadLine();
            i++;
        }

        public static void consultarVehiculo()
        {
            Console.WriteLine("ATENCIÓN - Debe realizar las búsquedas con el número de código!");
            if (i < 5)
            {
                cod[i] = Console.ReadLine();
                if (cod.Length == 0)
                {
                    Console.WriteLine($"Usted ha encontrado el vehículo: \n Código: {cod} \n Marca: {mar}  \n" +
                    $"Costo: {cost}  \n modelo: {mod} ");
                }
                else
                {
                    Console.WriteLine($"El Vehículo no ha sido encontrado, código incorrecto, por favor verifique su código");
                }
            }
            Console.ReadLine();
            i++;
        }

        public static void facturacion()
        {
            Console.WriteLine("ATENCIÓN - Debe realizar las búsquedas con el número de código!");
            if (i < 5)
            {
                cod[i] = Console.ReadLine();
                if (cod.Length == 0)
                {
                    Console.WriteLine($"Usted ha encontrado el vehículo: \n Código: {cod} \n Marca: {mar}  \n" +
                    $"Costo: {cost}  \n modelo: {mod} ");
                }
                else
                {
                    Console.WriteLine($"El Vehículo no ha sido encontrado, código incorrecto, por favor verifique su código");
                }
            }
            Console.ReadLine();
            i++;
        }

        public static void reportes()
        {
            Console.WriteLine("ATENCIÓN - Debe realizar las búsquedas con el número de código!");
            if (i < 5)
            {
                cod[i] = Console.ReadLine();
                if (cod.Length == 0)
                {
                    Console.WriteLine($"Usted ha encontrado el vehículo: \n Código: {cod} \n Marca: {mar}  \n" +
                    $"Costo: {cost}  \n modelo: {mod} ");
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
