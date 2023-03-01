using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cnEmpleado2
{
    /// <summary>
    /// Nombre:Paola Ruiz Osorio
    /// Fecha: 25/02/2023
    /// Descripción: Verificar si la persona debe pagar impuestos 
    /// </summary>
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Por favor ingrese su nombre");
            String Nombre = Console.ReadLine();
            Console.WriteLine("Por favor ingrese su saldo");
            int Sueldo = Convert.ToInt32(Console.ReadLine());
            //Llamar el metodo 
            CargarDatosEmpleado(Nombre, Sueldo);

            Console.ReadKey();
        }
        //Creacion del metodo 
        static void CargarDatosEmpleado(string Nombre, int Sueldo)
        {
            if (Sueldo < 3000)
            {
                Console.WriteLine("Hola " + Nombre + " por la cantidad de tu sueldo $" + Sueldo + " no debes pagar impuestos");
            }
            else
            {
                Console.WriteLine("Hola "+ Nombre + " por la cantidad de tu sueldo $" + Sueldo + " debes pagar impuestos");
            }
        }
    }
}
